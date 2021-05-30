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
    public partial class Form_RelatorioDeRequisicoes : Form
    {
        public Form_RelatorioDeRequisicoes()
        {
            InitializeComponent();
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT data as 'Data', nome_produto as 'Produto', nome_funcionario as 'Funcionário', quantidade as 'Quantidade', custo_total as 'Custo Total', preco_venda_total as 'Preço de Venda' FROM tb_requisicoes WHERE data BETWEEN '" + mb_DataInicial.Text + "' AND '" + mb_DataFinal.Text + "'";
                dataGridView1.DataSource = Banco.Consultar(sql);
                sql = "SELECT sum(custo_total) FROM tb_requisicoes WHERE data BETWEEN '" + mb_DataInicial.Text + "' AND '" + mb_DataFinal.Text + "'";
                DataTable dtable = Banco.Consultar(sql);
                if (dtable.Rows.Count > 0 && dtable.Rows[0][0] != null)
                {
                    double custoTotal = Convert.ToDouble(dtable.Rows[0][0]);
                    tb_custoTotal.Text = "R$" + custoTotal.ToString("F2");
                }
                else
                {
                    MessageBox.Show("Não existe regristro.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Produtos contidos nas requisições foram removidos do estoque.");
            }
        }
    }
}
