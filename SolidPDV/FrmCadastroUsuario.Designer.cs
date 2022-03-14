namespace SolidPDV
{
    partial class FrmCadastroUsuario
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
            this.txb_nome = new System.Windows.Forms.TextBox();
            this.txb_email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_senha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.txb_confirmaSenha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_todosUsuarios = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_todosUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 18);
            this.label1.TabIndex = 27;
            this.label1.Text = "Nome:";
            // 
            // txb_nome
            // 
            this.txb_nome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_nome.Location = new System.Drawing.Point(12, 30);
            this.txb_nome.Name = "txb_nome";
            this.txb_nome.Size = new System.Drawing.Size(440, 26);
            this.txb_nome.TabIndex = 28;
            // 
            // txb_email
            // 
            this.txb_email.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_email.Location = new System.Drawing.Point(12, 80);
            this.txb_email.Name = "txb_email";
            this.txb_email.Size = new System.Drawing.Size(440, 26);
            this.txb_email.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 29;
            this.label2.Text = "Email:";
            // 
            // txb_senha
            // 
            this.txb_senha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_senha.Location = new System.Drawing.Point(12, 130);
            this.txb_senha.Name = "txb_senha";
            this.txb_senha.PasswordChar = '*';
            this.txb_senha.Size = new System.Drawing.Size(440, 26);
            this.txb_senha.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 31;
            this.label3.Text = "Senha:";
            // 
            // btn_consultar
            // 
            this.btn_consultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_consultar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consultar.ForeColor = System.Drawing.Color.Navy;
            this.btn_consultar.Location = new System.Drawing.Point(229, 373);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(109, 38);
            this.btn_consultar.TabIndex = 37;
            this.btn_consultar.Text = "Sair";
            this.btn_consultar.UseVisualStyleBackColor = false;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_salvar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvar.ForeColor = System.Drawing.Color.Navy;
            this.btn_salvar.Location = new System.Drawing.Point(114, 373);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(109, 38);
            this.btn_salvar.TabIndex = 36;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // txb_confirmaSenha
            // 
            this.txb_confirmaSenha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_confirmaSenha.Location = new System.Drawing.Point(12, 185);
            this.txb_confirmaSenha.Name = "txb_confirmaSenha";
            this.txb_confirmaSenha.PasswordChar = '*';
            this.txb_confirmaSenha.Size = new System.Drawing.Size(440, 26);
            this.txb_confirmaSenha.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 18);
            this.label4.TabIndex = 38;
            this.label4.Text = "Confirma Senha:";
            // 
            // dgv_todosUsuarios
            // 
            this.dgv_todosUsuarios.AllowUserToAddRows = false;
            this.dgv_todosUsuarios.AllowUserToDeleteRows = false;
            this.dgv_todosUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_todosUsuarios.Location = new System.Drawing.Point(12, 217);
            this.dgv_todosUsuarios.Name = "dgv_todosUsuarios";
            this.dgv_todosUsuarios.ReadOnly = true;
            this.dgv_todosUsuarios.Size = new System.Drawing.Size(440, 150);
            this.dgv_todosUsuarios.TabIndex = 35;
            // 
            // FrmCadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 423);
            this.Controls.Add(this.txb_confirmaSenha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.dgv_todosUsuarios);
            this.Controls.Add(this.txb_senha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txb_email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb_nome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmCadastroUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Usuário";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_todosUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_nome;
        private System.Windows.Forms.TextBox txb_email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_senha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.TextBox txb_confirmaSenha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_todosUsuarios;
    }
}