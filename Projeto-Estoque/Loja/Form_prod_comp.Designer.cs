
namespace Loja
{
    partial class Form_prod_comp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_adiciona = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_nomeComposto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_precoVendaComposto = new System.Windows.Forms.TextBox();
            this.lb_CalculoCusto = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.cl_name = new System.Windows.Forms.ColumnHeader();
            this.cl_quant = new System.Windows.Forms.ColumnHeader();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_prodSimples = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_qntd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_adiciona
            // 
            this.btn_adiciona.BackColor = System.Drawing.Color.LightCyan;
            this.btn_adiciona.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_adiciona.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_adiciona.Location = new System.Drawing.Point(8, 457);
            this.btn_adiciona.Name = "btn_adiciona";
            this.btn_adiciona.Size = new System.Drawing.Size(75, 31);
            this.btn_adiciona.TabIndex = 0;
            this.btn_adiciona.Text = "Adicionar";
            this.btn_adiciona.UseVisualStyleBackColor = false;
            this.btn_adiciona.Click += new System.EventHandler(this.btn_adiciona_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome do Produto:";
            // 
            // tb_nomeComposto
            // 
            this.tb_nomeComposto.Location = new System.Drawing.Point(135, 26);
            this.tb_nomeComposto.Name = "tb_nomeComposto";
            this.tb_nomeComposto.Size = new System.Drawing.Size(192, 26);
            this.tb_nomeComposto.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(356, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(284, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "*Salvar: adastra o produto composto no sistema.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(356, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(288, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "*Remover: remove da lista o produto selecionado.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(356, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(306, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "*Adicionar: adiciona um novo produto simples à lista.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(8, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Preço de Venda:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tb_precoVendaComposto
            // 
            this.tb_precoVendaComposto.Location = new System.Drawing.Point(135, 80);
            this.tb_precoVendaComposto.Name = "tb_precoVendaComposto";
            this.tb_precoVendaComposto.Size = new System.Drawing.Size(101, 26);
            this.tb_precoVendaComposto.TabIndex = 2;
            // 
            // lb_CalculoCusto
            // 
            this.lb_CalculoCusto.AutoSize = true;
            this.lb_CalculoCusto.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_CalculoCusto.Location = new System.Drawing.Point(8, 503);
            this.lb_CalculoCusto.Name = "lb_CalculoCusto";
            this.lb_CalculoCusto.Size = new System.Drawing.Size(143, 20);
            this.lb_CalculoCusto.TabIndex = 1;
            this.lb_CalculoCusto.Text = "Preço de Custo Total:";
            this.lb_CalculoCusto.Click += new System.EventHandler(this.label2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(356, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(304, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "*Excluir: deleta um produto composto já cadastrado.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(356, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(423, 15);
            this.label8.TabIndex = 4;
            this.label8.Text = "*Alterar: modifica o preço de venda de um produto composto já existente.";
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.Indigo;
            this.btn_salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_salvar.ForeColor = System.Drawing.Color.White;
            this.btn_salvar.Location = new System.Drawing.Point(365, 281);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(75, 38);
            this.btn_salvar.TabIndex = 8;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Indigo;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(391, 325);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 38);
            this.button3.TabIndex = 9;
            this.button3.Text = "Excluir";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.BackColor = System.Drawing.Color.Indigo;
            this.btn_alterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_alterar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_alterar.ForeColor = System.Drawing.Color.White;
            this.btn_alterar.Location = new System.Drawing.Point(417, 369);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(75, 38);
            this.btn_alterar.TabIndex = 10;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = false;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.BackColor = System.Drawing.Color.LightCyan;
            this.btn_remove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_remove.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_remove.Location = new System.Drawing.Point(116, 457);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(75, 31);
            this.btn_remove.TabIndex = 0;
            this.btn_remove.Text = "Remover";
            this.btn_remove.UseVisualStyleBackColor = false;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Firebrick;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(726, 491);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(62, 32);
            this.button6.TabIndex = 11;
            this.button6.Text = "Fechar";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(157, 503);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "label9";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cl_name,
            this.cl_quant});
            this.listView1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(8, 251);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(340, 200);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // cl_name
            // 
            this.cl_name.Text = "CONTÉM";
            this.cl_name.Width = 255;
            // 
            // cl_quant
            // 
            this.cl_quant.Text = "QNTD";
            this.cl_quant.Width = 80;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(8, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Produto simples contido:";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // tb_prodSimples
            // 
            this.tb_prodSimples.Location = new System.Drawing.Point(181, 163);
            this.tb_prodSimples.Name = "tb_prodSimples";
            this.tb_prodSimples.Size = new System.Drawing.Size(146, 26);
            this.tb_prodSimples.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(8, 215);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Quantidade:";
            this.label10.Click += new System.EventHandler(this.label2_Click);
            // 
            // tb_qntd
            // 
            this.tb_qntd.Location = new System.Drawing.Point(98, 212);
            this.tb_qntd.Name = "tb_qntd";
            this.tb_qntd.Size = new System.Drawing.Size(55, 26);
            this.tb_qntd.TabIndex = 2;
            // 
            // Form_prod_comp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_qntd);
            this.Controls.Add(this.tb_prodSimples);
            this.Controls.Add(this.tb_precoVendaComposto);
            this.Controls.Add(this.tb_nomeComposto);
            this.Controls.Add(this.lb_CalculoCusto);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_adiciona);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form_prod_comp";
            this.Text = "Cadastro de Produto Composto";
            this.Load += new System.EventHandler(this.Form_prod_comp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_adiciona;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_nomeComposto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_precoVendaComposto;
        private System.Windows.Forms.Label lb_CalculoCusto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader cl_name;
        private System.Windows.Forms.ColumnHeader cl_quant;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_prodSimples;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_qntd;
        private System.Windows.Forms.Button btn_alterar;
    }
}