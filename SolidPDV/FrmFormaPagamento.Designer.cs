namespace SolidPDV
{
    partial class FrmFormaPagamento
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_precoTotalPagamento = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_concluir = new System.Windows.Forms.Button();
            this.cb_dinheiro = new System.Windows.Forms.CheckBox();
            this.cb_cartaoCredito = new System.Windows.Forms.CheckBox();
            this.cb_cartaoDebito = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total a pagar ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(281, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "R$";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbl_precoTotalPagamento);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 47);
            this.panel1.TabIndex = 2;
            // 
            // lbl_precoTotalPagamento
            // 
            this.lbl_precoTotalPagamento.AutoSize = true;
            this.lbl_precoTotalPagamento.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_precoTotalPagamento.Location = new System.Drawing.Point(341, 9);
            this.lbl_precoTotalPagamento.Name = "lbl_precoTotalPagamento";
            this.lbl_precoTotalPagamento.Size = new System.Drawing.Size(58, 26);
            this.lbl_precoTotalPagamento.TabIndex = 3;
            this.lbl_precoTotalPagamento.Text = "0.00";
            this.lbl_precoTotalPagamento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cb_dinheiro);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(0, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(412, 47);
            this.panel2.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Dinheiro";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.cb_cartaoDebito);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(0, 133);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(412, 47);
            this.panel3.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Cartão Debito";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.cb_cartaoCredito);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Location = new System.Drawing.Point(0, 198);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(412, 47);
            this.panel4.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "Cartão Crédito";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_concluir
            // 
            this.btn_concluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_concluir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_concluir.ForeColor = System.Drawing.Color.Navy;
            this.btn_concluir.Location = new System.Drawing.Point(287, 254);
            this.btn_concluir.Name = "btn_concluir";
            this.btn_concluir.Size = new System.Drawing.Size(119, 50);
            this.btn_concluir.TabIndex = 6;
            this.btn_concluir.Text = "Salvar";
            this.btn_concluir.UseVisualStyleBackColor = false;
            this.btn_concluir.Click += new System.EventHandler(this.btn_concluir_Click);
            // 
            // cb_dinheiro
            // 
            this.cb_dinheiro.AutoSize = true;
            this.cb_dinheiro.Location = new System.Drawing.Point(370, 15);
            this.cb_dinheiro.Name = "cb_dinheiro";
            this.cb_dinheiro.Size = new System.Drawing.Size(15, 14);
            this.cb_dinheiro.TabIndex = 1;
            this.cb_dinheiro.UseVisualStyleBackColor = true;
            // 
            // cb_cartaoCredito
            // 
            this.cb_cartaoCredito.AutoSize = true;
            this.cb_cartaoCredito.Location = new System.Drawing.Point(370, 15);
            this.cb_cartaoCredito.Name = "cb_cartaoCredito";
            this.cb_cartaoCredito.Size = new System.Drawing.Size(15, 14);
            this.cb_cartaoCredito.TabIndex = 2;
            this.cb_cartaoCredito.UseVisualStyleBackColor = true;
            // 
            // cb_cartaoDebito
            // 
            this.cb_cartaoDebito.AutoSize = true;
            this.cb_cartaoDebito.Location = new System.Drawing.Point(370, 19);
            this.cb_cartaoDebito.Name = "cb_cartaoDebito";
            this.cb_cartaoDebito.Size = new System.Drawing.Size(15, 14);
            this.cb_cartaoDebito.TabIndex = 3;
            this.cb_cartaoDebito.UseVisualStyleBackColor = true;
            // 
            // FrmFormaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 313);
            this.Controls.Add(this.btn_concluir);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmFormaPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forma de Pagamento";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_concluir;
        public System.Windows.Forms.Label lbl_precoTotalPagamento;
        private System.Windows.Forms.CheckBox cb_dinheiro;
        private System.Windows.Forms.CheckBox cb_cartaoDebito;
        private System.Windows.Forms.CheckBox cb_cartaoCredito;
    }
}