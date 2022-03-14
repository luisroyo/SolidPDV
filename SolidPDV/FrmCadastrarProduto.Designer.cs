
namespace SolidPDV
{
    partial class FrmCadastrarProduto
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
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txb_codBarra = new System.Windows.Forms.TextBox();
            this.txb_descricao = new System.Windows.Forms.TextBox();
            this.txb_precoCusto = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cb_unidade_medida = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_qtd_minima = new System.Windows.Forms.TextBox();
            this.cb_categoria = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txb_qtd_estoque = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txb_PrecoVenda = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_ListaProdutos = new System.Windows.Forms.DataGridView();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.btn_inserir = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(189, 133);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Preço Venda";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 136);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Preço Custo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(4, 11);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "Código Barra";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(4, 74);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 16);
            this.label11.TabIndex = 10;
            this.label11.Text = "Descrição";
            // 
            // txb_codBarra
            // 
            this.txb_codBarra.Font = new System.Drawing.Font("Arial", 10F);
            this.txb_codBarra.Location = new System.Drawing.Point(7, 37);
            this.txb_codBarra.Margin = new System.Windows.Forms.Padding(4);
            this.txb_codBarra.Name = "txb_codBarra";
            this.txb_codBarra.Size = new System.Drawing.Size(714, 23);
            this.txb_codBarra.TabIndex = 12;
            // 
            // txb_descricao
            // 
            this.txb_descricao.Font = new System.Drawing.Font("Arial", 10F);
            this.txb_descricao.Location = new System.Drawing.Point(7, 94);
            this.txb_descricao.Margin = new System.Windows.Forms.Padding(4);
            this.txb_descricao.Name = "txb_descricao";
            this.txb_descricao.Size = new System.Drawing.Size(714, 23);
            this.txb_descricao.TabIndex = 13;
            // 
            // txb_precoCusto
            // 
            this.txb_precoCusto.Font = new System.Drawing.Font("Arial", 10F);
            this.txb_precoCusto.Location = new System.Drawing.Point(7, 159);
            this.txb_precoCusto.Margin = new System.Windows.Forms.Padding(4);
            this.txb_precoCusto.Name = "txb_precoCusto";
            this.txb_precoCusto.Size = new System.Drawing.Size(158, 23);
            this.txb_precoCusto.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.cb_unidade_medida);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txb_qtd_minima);
            this.panel2.Controls.Add(this.cb_categoria);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Location = new System.Drawing.Point(5, 281);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(735, 78);
            this.panel2.TabIndex = 17;
            // 
            // cb_unidade_medida
            // 
            this.cb_unidade_medida.Font = new System.Drawing.Font("Arial", 10F);
            this.cb_unidade_medida.FormattingEnabled = true;
            this.cb_unidade_medida.Location = new System.Drawing.Point(383, 34);
            this.cb_unidade_medida.Margin = new System.Windows.Forms.Padding(4);
            this.cb_unidade_medida.Name = "cb_unidade_medida";
            this.cb_unidade_medida.Size = new System.Drawing.Size(158, 24);
            this.cb_unidade_medida.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(190, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Quantidade Mínima";
            // 
            // txb_qtd_minima
            // 
            this.txb_qtd_minima.Font = new System.Drawing.Font("Arial", 10F);
            this.txb_qtd_minima.Location = new System.Drawing.Point(193, 35);
            this.txb_qtd_minima.Margin = new System.Windows.Forms.Padding(4);
            this.txb_qtd_minima.Name = "txb_qtd_minima";
            this.txb_qtd_minima.Size = new System.Drawing.Size(158, 23);
            this.txb_qtd_minima.TabIndex = 20;
            // 
            // cb_categoria
            // 
            this.cb_categoria.Font = new System.Drawing.Font("Arial", 10F);
            this.cb_categoria.FormattingEnabled = true;
            this.cb_categoria.Items.AddRange(new object[] {
            "Mercearia"});
            this.cb_categoria.Location = new System.Drawing.Point(8, 34);
            this.cb_categoria.Margin = new System.Windows.Forms.Padding(4);
            this.cb_categoria.Name = "cb_categoria";
            this.cb_categoria.Size = new System.Drawing.Size(158, 24);
            this.cb_categoria.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Categoria";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(380, 14);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 16);
            this.label12.TabIndex = 18;
            this.label12.Text = "UN. Medida";
            // 
            // txb_qtd_estoque
            // 
            this.txb_qtd_estoque.Font = new System.Drawing.Font("Arial", 10F);
            this.txb_qtd_estoque.Location = new System.Drawing.Point(382, 159);
            this.txb_qtd_estoque.Margin = new System.Windows.Forms.Padding(4);
            this.txb_qtd_estoque.Name = "txb_qtd_estoque";
            this.txb_qtd_estoque.Size = new System.Drawing.Size(158, 23);
            this.txb_qtd_estoque.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(379, 139);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 16);
            this.label13.TabIndex = 19;
            this.label13.Text = "QTD Estoque";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txb_PrecoVenda);
            this.panel1.Controls.Add(this.txb_qtd_estoque);
            this.panel1.Controls.Add(this.txb_precoCusto);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txb_descricao);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txb_codBarra);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Font = new System.Drawing.Font("Arial", 10F);
            this.panel1.Location = new System.Drawing.Point(6, 37);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(734, 210);
            this.panel1.TabIndex = 21;
            // 
            // txb_PrecoVenda
            // 
            this.txb_PrecoVenda.Font = new System.Drawing.Font("Arial", 10F);
            this.txb_PrecoVenda.Location = new System.Drawing.Point(192, 159);
            this.txb_PrecoVenda.Margin = new System.Windows.Forms.Padding(4);
            this.txb_PrecoVenda.Name = "txb_PrecoVenda";
            this.txb_PrecoVenda.Size = new System.Drawing.Size(158, 23);
            this.txb_PrecoVenda.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(2, 11);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Propriedades do Produto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(3, 261);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "Categoria / Estoque";
            // 
            // dgv_ListaProdutos
            // 
            this.dgv_ListaProdutos.AllowUserToAddRows = false;
            this.dgv_ListaProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListaProdutos.Location = new System.Drawing.Point(6, 377);
            this.dgv_ListaProdutos.Name = "dgv_ListaProdutos";
            this.dgv_ListaProdutos.Size = new System.Drawing.Size(734, 196);
            this.dgv_ListaProdutos.TabIndex = 29;
            // 
            // btn_excluir
            // 
            this.btn_excluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_excluir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excluir.ForeColor = System.Drawing.Color.Navy;
            this.btn_excluir.Location = new System.Drawing.Point(579, 589);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(150, 36);
            this.btn_excluir.TabIndex = 33;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = false;
            // 
            // btn_editar
            // 
            this.btn_editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_editar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.ForeColor = System.Drawing.Color.Navy;
            this.btn_editar.Location = new System.Drawing.Point(200, 589);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(150, 36);
            this.btn_editar.TabIndex = 32;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = false;
            // 
            // btn_consultar
            // 
            this.btn_consultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_consultar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consultar.ForeColor = System.Drawing.Color.Navy;
            this.btn_consultar.Location = new System.Drawing.Point(390, 589);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(150, 36);
            this.btn_consultar.TabIndex = 31;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = false;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // btn_inserir
            // 
            this.btn_inserir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_inserir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inserir.ForeColor = System.Drawing.Color.Navy;
            this.btn_inserir.Location = new System.Drawing.Point(6, 589);
            this.btn_inserir.Name = "btn_inserir";
            this.btn_inserir.Size = new System.Drawing.Size(150, 36);
            this.btn_inserir.TabIndex = 30;
            this.btn_inserir.Text = "Inserir";
            this.btn_inserir.UseVisualStyleBackColor = false;
            this.btn_inserir.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // FrmCadastrarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 637);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.btn_inserir);
            this.Controls.Add(this.dgv_ListaProdutos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmCadastrarProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Produto";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListaProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txb_codBarra;
        private System.Windows.Forms.TextBox txb_descricao;
        private System.Windows.Forms.TextBox txb_precoCusto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txb_qtd_estoque;
        private System.Windows.Forms.TextBox txb_qtd_minima;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_categoria;
        private System.Windows.Forms.ComboBox cb_unidade_medida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_PrecoVenda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_ListaProdutos;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.Button btn_inserir;
    }
}