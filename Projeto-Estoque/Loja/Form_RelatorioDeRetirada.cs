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
    public partial class Form_RelatorioDeRetirada : Form
    {
        public Form_RelatorioDeRetirada()
        {
            InitializeComponent();
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT tre.data as 'Data', tbe.prod_nome as 'Produto', tre.quantidade as 'Quantidade', tre.preco_custo_total as 'Custo Total' FROM tb_retiradasDoEstoque as tre INNER JOIN tb_estoque as tbe ON tre.id_produto = tbe.prod_id WHERE tre.data BETWEEN '" + mb_DataInicial.Text + "' AND '" + mb_DataFinal.Text + "'";
                dataGridView1.DataSource = Banco.Consultar(sql);
                sql = "SELECT sum(preco_custo_total) FROM tb_retiradasDoEstoque WHERE data BETWEEN '" + mb_DataInicial.Text + "' AND '" + mb_DataFinal.Text + "'";
                DataTable table = Banco.Consultar(sql);
                if (table.Rows.Count > 0)
                {
                    double custoTotal = Convert.ToDouble(table.Rows[0][0]);
                    tb_CustoTotal.Text = "R$" + custoTotal.ToString("F2");
                }
                else
                {
                    MessageBox.Show("Não existe registro.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Produtos contidos nas requisições foram removidos do estoque.");
            }
        }
    }
}
