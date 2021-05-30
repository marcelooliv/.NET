
namespace Loja
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_prod_simples = new System.Windows.Forms.Button();
            this.btn_relat_saida = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_prod_composto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MidnightBlue;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Azure;
            this.label1.Location = new System.Drawing.Point(21, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Opções Do Sistema:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AliceBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.Navy;
            this.button1.Location = new System.Drawing.Point(424, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 65);
            this.button1.TabIndex = 1;
            this.button1.Text = "RELATÓRIO DE REQUISIÇÕES";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_prod_simples
            // 
            this.btn_prod_simples.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_prod_simples.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_prod_simples.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_prod_simples.ForeColor = System.Drawing.Color.Navy;
            this.btn_prod_simples.Location = new System.Drawing.Point(23, 106);
            this.btn_prod_simples.Name = "btn_prod_simples";
            this.btn_prod_simples.Size = new System.Drawing.Size(220, 65);
            this.btn_prod_simples.TabIndex = 1;
            this.btn_prod_simples.Text = "CADASTRAR PRODUTO SIMPLES";
            this.btn_prod_simples.UseVisualStyleBackColor = false;
            this.btn_prod_simples.Click += new System.EventHandler(this.btn_prod_simples_Click);
            // 
            // btn_relat_saida
            // 
            this.btn_relat_saida.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_relat_saida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_relat_saida.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_relat_saida.ForeColor = System.Drawing.Color.Navy;
            this.btn_relat_saida.Location = new System.Drawing.Point(424, 106);
            this.btn_relat_saida.Name = "btn_relat_saida";
            this.btn_relat_saida.Size = new System.Drawing.Size(220, 65);
            this.btn_relat_saida.TabIndex = 1;
            this.btn_relat_saida.Text = "RELATÓRIO DE SAÍDAS";
            this.btn_relat_saida.UseVisualStyleBackColor = false;
            this.btn_relat_saida.Click += new System.EventHandler(this.btn_relat_saida_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.AliceBlue;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.ForeColor = System.Drawing.Color.Navy;
            this.button4.Location = new System.Drawing.Point(21, 286);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(220, 65);
            this.button4.TabIndex = 1;
            this.button4.Text = "FAZER UMA REQUISIÇÃO";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.Firebrick;
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.ForeColor = System.Drawing.Color.White;
            this.btn_sair.Location = new System.Drawing.Point(734, 414);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(54, 24);
            this.btn_sair.TabIndex = 2;
            this.btn_sair.Text = "SAIR";
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_prod_composto
            // 
            this.btn_prod_composto.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_prod_composto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_prod_composto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_prod_composto.ForeColor = System.Drawing.Color.Navy;
            this.btn_prod_composto.Location = new System.Drawing.Point(21, 196);
            this.btn_prod_composto.Name = "btn_prod_composto";
            this.btn_prod_composto.Size = new System.Drawing.Size(220, 65);
            this.btn_prod_composto.TabIndex = 1;
            this.btn_prod_composto.Text = "CADASTRAR PRODUTO COMPOSTO";
            this.btn_prod_composto.UseVisualStyleBackColor = false;
            this.btn_prod_composto.Click += new System.EventHandler(this.btn_prod_composto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_relat_saida);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_prod_composto);
            this.Controls.Add(this.btn_prod_simples);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.LemonChiffon;
            this.Name = "Form1";
            this.Text = "Menu Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_prod_simples;
        private System.Windows.Forms.Button btn_relat_saida;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_prod_composto;
    }
}

