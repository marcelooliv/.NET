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
    public partial class Form_prod_comp : Form
    {
        private double custoTotal = 0.00;
        public Form_prod_comp()
        {
            InitializeComponent();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Banco.RemoverComposto(tb_nomeComposto.Text);
            tb_nomeComposto.Clear();
            MessageBox.Show("Produto composto removido com sucesso");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            string prodNome = listView1.SelectedItems[0].SubItems[0].Text;
            int qntdeItem = Convert.ToInt32(listView1.SelectedItems[0].SubItems[1].Text);
            custoTotal = Banco.DecresceTotalComposto(prodNome, custoTotal, qntdeItem);
            label9.Text = "R$" + custoTotal.ToString("F2");
            listView1.Items.RemoveAt(listView1.SelectedIndices[0]);
        }

        private void btn_adiciona_Click(object sender, EventArgs e)
        {
            if (tb_nomeComposto.Text == "")
            {
                MessageBox.Show("Insira o nome do produto.");
                tb_nomeComposto.Focus();
                return;
            }
            if (tb_precoVendaComposto.Text == "")
            {
                MessageBox.Show("Insira o preço de venda.");
                tb_precoVendaComposto.Focus();
                return;

            }
            if (tb_prodSimples.Text == "")
            {
                MessageBox.Show("Insira o produto simples a ser adicionado.");
                tb_prodSimples.Focus();
                return;

            }
            if (tb_qntd.Text == "")
            {
                MessageBox.Show("Digite a quantidade.");
                tb_qntd.Focus();
                return;

            }
            if (!Banco.VerificarProduto(tb_prodSimples.Text))
            {
                MessageBox.Show("Esse produto simples não existe no banco de dados.");
                tb_prodSimples.Focus();
                return;
            }
            string[] listaItens = new string[2];
            listaItens[0] = tb_prodSimples.Text;
            listaItens[1] = tb_qntd.Text;
            ListViewItem novoItem = new ListViewItem(listaItens);
            listView1.Items.Add(novoItem);
            int qntd = Convert.ToInt32(tb_qntd.Text);
            custoTotal = Banco.CalculaTotalComposto(tb_prodSimples.Text, custoTotal, qntd);
            label9.Text = "R$"+custoTotal.ToString("F2");
            tb_prodSimples.Clear();
            qntd = 0;
            tb_qntd.Clear();
            
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            string nomeProdutoComposto = tb_nomeComposto.Text;
            double precoVendaComposto = double.Parse(tb_precoVendaComposto.Text);
            try
            {
                Banco.AdicionarComposto(nomeProdutoComposto, precoVendaComposto);
            }
            catch (Exception)
            {
                MessageBox.Show("Produto composto já existente.");
            }
            
            string[] nomeProdutoSimples = new string[listView1.Items.Count];
            int[] quantProdutoSimples = new int[listView1.Items.Count];


            try
            {
                for (int i = 0; i < listView1.Items.Count; i++)
                {

                    nomeProdutoSimples[i] = listView1.Items[i].SubItems[0].Text;
                    quantProdutoSimples[i] = int.Parse(listView1.Items[i].SubItems[1].Text);
                    Banco.InsereComponenteComposto(nomeProdutoSimples[i], nomeProdutoComposto, quantProdutoSimples[i]);
                }
                tb_nomeComposto.Clear();
                tb_precoVendaComposto.Clear();
                listView1.Clear();
                MessageBox.Show("Produto cadastrado com sucesso");
            }
            catch(Exception)
            {
                throw;
            }
            custoTotal = 0;
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            double preco = double.Parse(tb_precoVendaComposto.Text);
            Banco.AtualizarComposto(tb_nomeComposto.Text, preco);
            MessageBox.Show("Preço de venda atualizado com sucesso.");
        }

        private void Form_prod_comp_Load(object sender, EventArgs e)
        {
            tb_nomeComposto.Focus();
            
            label9.Text = "R$"+custoTotal.ToString("F2");

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
