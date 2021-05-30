using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja
{
    public partial class Form_prod_smp : Form
    {
        public Form_prod_smp()
        {
            InitializeComponent();
        }

        private void Form_prod_smp_Load(object sender, EventArgs e)
        {
            tb_NomeProduto.Focus();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(tb_NomeProduto.Text == "" || tb_custoVenda.Text == "" || tb_precoVenda.Text == "")
            {
                MessageBox.Show("Preencha todos os campos.");
                return;
            }
            if (Banco.VerificarProduto(tb_NomeProduto.Text))
            {
                MessageBox.Show("Produto já existe.");
                LimparTextos();
                return;
            }
            try
            {
                double pre_custo = double.Parse(tb_custoVenda.Text);
                double pre_venda = double.Parse(tb_precoVenda.Text);
                Banco.Adicionar(tb_NomeProduto.Text, pre_custo, pre_venda);
                MessageBox.Show("Produto adicionado com sucesso.");
                    
            }catch(Exception)
            {
                    MessageBox.Show("Erro ao adicionar produto :(");
            }
            
            LimparTextos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tb_NomeProduto.Text == "")
            {
                MessageBox.Show("Preencha o nome do produto.");
                tb_NomeProduto.Focus();
                return;
            }
            if (!Banco.VerificarProduto(tb_NomeProduto.Text))
            {
                MessageBox.Show("Produto não existe.");
                tb_NomeProduto.Focus();
                return;
            }  
            try
            {
                Banco.RemoverProduto(tb_NomeProduto.Text);
                MessageBox.Show("Produto removido com sucesso.");
                    

            }catch (Exception)
             {
                    MessageBox.Show("Erro ao remover produto :(");
             }
            
            LimparTextos();
        }
        private void LimparTextos()
        {
            tb_NomeProduto.Clear();
            tb_custoVenda.Clear();
            tb_precoVenda.Clear();
            tb_NomeProduto.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tb_NomeProduto.Text == "")
            {
                MessageBox.Show("Preencha o nome do produto.");
                tb_NomeProduto.Focus();
                return;
            }
            if (!Banco.VerificarProduto(tb_NomeProduto.Text))
            {
                MessageBox.Show("Produto não existe.");
                tb_NomeProduto.Focus();
                return;
            }
            try
            {
                double pre_c = double.Parse(tb_custoVenda.Text);
                double pre_v = double.Parse(tb_precoVenda.Text);
                Banco.AtualizarProduto(pre_c, pre_v, tb_NomeProduto.Text);
                MessageBox.Show("Produto atualizado com sucesso.");

            }catch (Exception)
             {
                MessageBox.Show("Erro ao atualizar o produto :(");
             }
            LimparTextos();
        }
    }
}
