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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_RelatorioDeRequisicoes relatorio1 = new Form_RelatorioDeRequisicoes();
            relatorio1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form_requisicao formulario = new Form_requisicao();
            formulario.ShowDialog();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_prod_simples_Click(object sender, EventArgs e)
        {
            Form_prod_smp form_smp = new Form_prod_smp();
            form_smp.ShowDialog();
        }

        private void btn_prod_composto_Click(object sender, EventArgs e)
        {
            Form_prod_comp form_comp = new Form_prod_comp();
            form_comp.ShowDialog();
        }

        private void btn_relat_saida_Click(object sender, EventArgs e)
        {
            Form_RelatorioDeRetirada relatorio2 = new Form_RelatorioDeRetirada();
            relatorio2.ShowDialog();
        }
    }
}
