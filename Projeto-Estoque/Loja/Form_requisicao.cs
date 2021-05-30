using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Loja
{
    public partial class Form_requisicao : Form
    {
        private List<string> Nomes = new List<string>();
        private List<string> Composto = new List<string>();
        private double CustoTotal = 0.00;
        public Form_requisicao()
        {
            InitializeComponent();
             
       
        }

        private void limparTB()
        {
            tb_quantidade.Clear();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
   
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            if(cb_nomeProduto.Text == "")
            {
                MessageBox.Show("Selecione um produto.");
                cb_nomeProduto.Focus();
                return;
            }
            if (tb_quantidade.Text == "")
            {
                MessageBox.Show("Selecione a quantidade.");
                tb_quantidade.Focus();
                return;

            }
            if (tb_funcionario.Text == "")
            {
                MessageBox.Show("Digite o nome do funcionário.");
                tb_funcionario.Focus();
                return;

            }
            mudaValores(Composto);
            limparTB();
            

        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            string nome = listView1.SelectedItems[0].SubItems[0].Text;
            int quantity = Convert.ToInt32(listView1.SelectedItems[0].SubItems[1].Text);
            double custoUND = Convert.ToDouble(listView1.SelectedItems[0].SubItems[2].Text);
            double subtotal = Convert.ToDouble(listView1.SelectedItems[0].SubItems[3].Text);
            foreach(string c in Composto)
            {
                if(nome == c)
                {
                    Banco.RemoveRetiradaCompostaEstoque(nome, quantity);
                }
                else
                {
                    Banco.RemoveRetiradaSimplesEstoque(nome);
                }
            }
            CustoTotal = CustoTotal - subtotal;
            tb_custoTotal.Text = "R$" + CustoTotal.ToString("F2");
            listView1.Items.RemoveAt(listView1.SelectedIndices[0]);

        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            tb_quantidade.Clear();
            tb_funcionario.Clear();
            tb_custoTotal.Clear();
            listView1.Items.Clear();
            MessageBox.Show("Requisição salva com sucesso.");
        }

        private void Form_requisicao_Load(object sender, EventArgs e)
        {
            
            cb_nomeProduto.Items.Clear();
            try
            {
                using (var cmd = Banco.Conectar().CreateCommand())
                {
                    cmd.CommandText = "SELECT prod_nome FROM tb_estoque";
                    SQLiteDataReader dread = cmd.ExecuteReader();
                    while (dread.Read())
                    {
                        Nomes.Add(dread.GetString("prod_nome"));
                    }
                    cmd.Reset();
                    cmd.CommandText = "SELECT nome_prod_composto FROM tb_produtos_compostos";
                    dread = cmd.ExecuteReader();
                    while (dread.Read())
                    {
                        Nomes.Add(dread.GetString("nome_prod_composto"));
                        Composto.Add(dread.GetString("nome_prod_composto"));
                    }
                    Banco.Conectar().Close();
                }
            }
            catch (Exception)
            {
                throw;
            }
            cb_nomeProduto.DataSource = Nomes;
            tb_custoTotal.Text = "R$"+CustoTotal.ToString("F2");


        }
        private void mudaValores(List<string> composto)
        {
            foreach(string c in composto)
            {
                if (cb_nomeProduto.Text == c)
                {
                    SQLiteDataAdapter adpter = null;
                    DataTable dtable = new DataTable();
                    using (var cmd = Banco.Conectar().CreateCommand())
                    {
                        cmd.CommandText = "SELECT sum(tcc.quantidade*te.prod_preco_custo) as somatorio FROM tb_componentes_compostos as tcc INNER JOIN tb_estoque as te ON tcc.id_componentes = te.prod_id WHERE tcc.nome_prod_composto = '" + cb_nomeProduto.Text + "'";
                        adpter = new SQLiteDataAdapter(cmd.CommandText, Banco.Conectar());
                        adpter.Fill(dtable);
                        double preco_unidade = Convert.ToDouble(dtable.Rows[0][0]);
                        int quant = Convert.ToInt32(tb_quantidade.Text);
                        double subtotal = quant * preco_unidade;
                        string[] listaItens = new string[4];
                        listaItens[0] = cb_nomeProduto.Text;
                        listaItens[1] = tb_quantidade.Text;
                        listaItens[2] = preco_unidade.ToString("F2");
                        listaItens[3] = subtotal.ToString("F2");

                        ListViewItem novoItem = new ListViewItem(listaItens);
                        listView1.Items.Add(novoItem);
                        CustoTotal = CustoTotal + subtotal;
                        tb_custoTotal.Text = "R$" + CustoTotal.ToString("F2");
                        Banco.InserirRequisicaoComposta(cb_nomeProduto.Text,tb_funcionario.Text, quant, subtotal);
                        Banco.InserirRetiradaCompostaEstoque(quant, cb_nomeProduto.Text);
                        Banco.Conectar().Close();
                        
                    }
                }
                else
                {
                    SQLiteDataAdapter adpter = null;
                    DataTable dtable = new DataTable();
                    using (var cmd = Banco.Conectar().CreateCommand())
                    {
                        cmd.CommandText = "SELECT prod_preco_custo FROM tb_estoque WHERE prod_nome= '" + cb_nomeProduto.Text + "'";
                        adpter = new SQLiteDataAdapter(cmd.CommandText, Banco.Conectar());
                        adpter.Fill(dtable);
                        double preco_custo = Convert.ToDouble(dtable.Rows[0][0]);
                        int quant = Convert.ToInt32(tb_quantidade.Text);
                        double subtotal = quant * preco_custo;
                        string[] listaItens = new string[4];
                        listaItens[0] = cb_nomeProduto.Text;
                        listaItens[1] = tb_quantidade.Text;
                        listaItens[2] = preco_custo.ToString("F2");
                        listaItens[3] = subtotal.ToString("F2");

                        ListViewItem novoItem = new ListViewItem(listaItens);
                        listView1.Items.Add(novoItem);
                        CustoTotal = CustoTotal + subtotal;
                        tb_custoTotal.Text = "R$" + CustoTotal.ToString("F2");
                        Banco.InserirRequisicaoSimples(cb_nomeProduto.Text, tb_funcionario.Text, quant, subtotal);
                        Banco.InserirRetiradaSimplesEstoque(quant, cb_nomeProduto.Text);
                        Banco.Conectar().Close();
                    }
                }
            }
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_nomeProduto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
