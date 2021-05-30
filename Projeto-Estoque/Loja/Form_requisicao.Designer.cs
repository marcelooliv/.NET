
namespace Loja
{
    partial class Form_requisicao
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_nomeProduto = new System.Windows.Forms.ComboBox();
            this.tb_quantidade = new System.Windows.Forms.TextBox();
            this.tb_funcionario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.tb_custoTotal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.prod_nome = new System.Windows.Forms.ColumnHeader();
            this.prod_quant = new System.Windows.Forms.ColumnHeader();
            this.preco_custo_und = new System.Windows.Forms.ColumnHeader();
            this.prod_subtotal = new System.Windows.Forms.ColumnHeader();
            this.tb_data = new System.Windows.Forms.TextBox();
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Produto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Quantidade:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Data de Requisição:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Funcionário Responsável:";
            // 
            // cb_nomeProduto
            // 
            this.cb_nomeProduto.FormattingEnabled = true;
            this.cb_nomeProduto.Location = new System.Drawing.Point(169, 23);
            this.cb_nomeProduto.Name = "cb_nomeProduto";
            this.cb_nomeProduto.Size = new System.Drawing.Size(161, 26);
            this.cb_nomeProduto.TabIndex = 1;
            this.cb_nomeProduto.SelectedIndexChanged += new System.EventHandler(this.cb_nomeProduto_SelectedIndexChanged);
            // 
            // tb_quantidade
            // 
            this.tb_quantidade.Location = new System.Drawing.Point(124, 90);
            this.tb_quantidade.Name = "tb_quantidade";
            this.tb_quantidade.Size = new System.Drawing.Size(63, 26);
            this.tb_quantidade.TabIndex = 2;
            // 
            // tb_funcionario
            // 
            this.tb_funcionario.Location = new System.Drawing.Point(234, 216);
            this.tb_funcionario.Name = "tb_funcionario";
            this.tb_funcionario.Size = new System.Drawing.Size(155, 26);
            this.tb_funcionario.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(145, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 18);
            this.label7.TabIndex = 4;
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.BackColor = System.Drawing.Color.LightSlateGray;
            this.btn_adicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adicionar.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_adicionar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_adicionar.Location = new System.Drawing.Point(294, 261);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(95, 34);
            this.btn_adicionar.TabIndex = 6;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = false;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_salvar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_salvar.Location = new System.Drawing.Point(690, 355);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(115, 32);
            this.btn_salvar.TabIndex = 8;
            this.btn_salvar.Text = "Enviar Pedido";
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_excluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_excluir.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_excluir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_excluir.Location = new System.Drawing.Point(852, 355);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(93, 32);
            this.btn_excluir.TabIndex = 8;
            this.btn_excluir.Text = "Excluir Item";
            this.btn_excluir.UseVisualStyleBackColor = false;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // tb_custoTotal
            // 
            this.tb_custoTotal.Location = new System.Drawing.Point(551, 359);
            this.tb_custoTotal.Name = "tb_custoTotal";
            this.tb_custoTotal.ReadOnly = true;
            this.tb_custoTotal.Size = new System.Drawing.Size(96, 26);
            this.tb_custoTotal.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(456, 362);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 18);
            this.label11.TabIndex = 12;
            this.label11.Text = "Custo Total:";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.prod_nome,
            this.prod_quant,
            this.preco_custo_und,
            this.prod_subtotal});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(395, 11);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(550, 284);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // prod_nome
            // 
            this.prod_nome.Tag = "";
            this.prod_nome.Text = "PRODUTO";
            this.prod_nome.Width = 185;
            // 
            // prod_quant
            // 
            this.prod_quant.Text = "QNTD";
            // 
            // preco_custo_und
            // 
            this.preco_custo_und.Text = "PREÇO CUSTO UND";
            this.preco_custo_und.Width = 200;
            // 
            // prod_subtotal
            // 
            this.prod_subtotal.Text = "SUBTOTAL";
            this.prod_subtotal.Width = 100;
            // 
            // tb_data
            // 
            this.tb_data.Location = new System.Drawing.Point(186, 146);
            this.tb_data.Name = "tb_data";
            this.tb_data.ReadOnly = true;
            this.tb_data.Size = new System.Drawing.Size(83, 26);
            this.tb_data.TabIndex = 2;
            this.tb_data.Text = "Hoje";
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.BackColor = System.Drawing.Color.Firebrick;
            this.btn_Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Fechar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Fechar.ForeColor = System.Drawing.Color.White;
            this.btn_Fechar.Location = new System.Drawing.Point(880, 403);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(64, 35);
            this.btn_Fechar.TabIndex = 14;
            this.btn_Fechar.Text = "Fechar";
            this.btn_Fechar.UseVisualStyleBackColor = false;
            this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
            // 
            // Form_requisicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(956, 450);
            this.Controls.Add(this.btn_Fechar);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tb_custoTotal);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_funcionario);
            this.Controls.Add(this.tb_data);
            this.Controls.Add(this.tb_quantidade);
            this.Controls.Add(this.cb_nomeProduto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form_requisicao";
            this.Text = "Requisição de Retirada";
            this.Load += new System.EventHandler(this.Form_requisicao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_nomeProduto;
        private System.Windows.Forms.TextBox tb_quantidade;
        private System.Windows.Forms.TextBox tb_funcionario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.TextBox tb_custoTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader prod_nome;
        private System.Windows.Forms.ColumnHeader prod_quant;
        private System.Windows.Forms.ColumnHeader preco_custo_und;
        private System.Windows.Forms.ColumnHeader prod_subtotal;
        private System.Windows.Forms.TextBox tb_data;
        private System.Windows.Forms.Button btn_Fechar;
    }
}