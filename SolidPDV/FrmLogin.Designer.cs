namespace SolidPDV
{
    partial class FrmLogin
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
            this.txb_senha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_okLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txb_senha
            // 
            this.txb_senha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_senha.Location = new System.Drawing.Point(12, 80);
            this.txb_senha.Name = "txb_senha";
            this.txb_senha.PasswordChar = '*';
            this.txb_senha.Size = new System.Drawing.Size(440, 26);
            this.txb_senha.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 35;
            this.label3.Text = "Senha:";
            // 
            // txb_email
            // 
            this.txb_email.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_email.Location = new System.Drawing.Point(12, 30);
            this.txb_email.Name = "txb_email";
            this.txb_email.Size = new System.Drawing.Size(440, 26);
            this.txb_email.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 33;
            this.label2.Text = "Email:";
            // 
            // btn_okLogin
            // 
            this.btn_okLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_okLogin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_okLogin.ForeColor = System.Drawing.Color.Navy;
            this.btn_okLogin.Location = new System.Drawing.Point(184, 112);
            this.btn_okLogin.Name = "btn_okLogin";
            this.btn_okLogin.Size = new System.Drawing.Size(109, 38);
            this.btn_okLogin.TabIndex = 37;
            this.btn_okLogin.Text = "OK";
            this.btn_okLogin.UseVisualStyleBackColor = false;
            this.btn_okLogin.Click += new System.EventHandler(this.btn_okLogin_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 155);
            this.Controls.Add(this.btn_okLogin);
            this.Controls.Add(this.txb_senha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txb_email);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_senha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_okLogin;
    }
}