
namespace SolidPDV
{
    partial class FrmVendas
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
            this.btn_concluir = new System.Windows.Forms.Button();
            this.txb_codBarra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cancelarVenda = new System.Windows.Forms.Button();
            this.btn_cliente = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_quantidade = new System.Windows.Forms.TextBox();
            this.txb_preco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_mostrarProduto = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_valorTotal = new System.Windows.Forms.TextBox();
            this.txb_qtdTotalItens = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mostrarProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_concluir
            // 
            this.btn_concluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_concluir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_concluir.ForeColor = System.Drawing.Color.Navy;
            this.btn_concluir.Location = new System.Drawing.Point(12, 12);
            this.btn_concluir.Name = "btn_concluir";
            this.btn_concluir.Size = new System.Drawing.Size(150, 36);
            this.btn_concluir.TabIndex = 4;
            this.btn_concluir.Text = "Concluir! (F3)";
            this.btn_concluir.UseVisualStyleBackColor = false;
            this.btn_concluir.Click += new System.EventHandler(this.btn_concluir_Click);
            // 
            // txb_codBarra
            // 
            this.txb_codBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txb_codBarra.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_codBarra.ForeColor = System.Drawing.Color.Black;
            this.txb_codBarra.Location = new System.Drawing.Point(12, 93);
            this.txb_codBarra.Name = "txb_codBarra";
            this.txb_codBarra.Size = new System.Drawing.Size(513, 48);
            this.txb_codBarra.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(550, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "QTD:";
            // 
            // btn_cancelarVenda
            // 
            this.btn_cancelarVenda.BackColor = System.Drawing.Color.Gold;
            this.btn_cancelarVenda.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelarVenda.ForeColor = System.Drawing.Color.Black;
            this.btn_cancelarVenda.Location = new System.Drawing.Point(369, 12);
            this.btn_cancelarVenda.Name = "btn_cancelarVenda";
            this.btn_cancelarVenda.Size = new System.Drawing.Size(150, 36);
            this.btn_cancelarVenda.TabIndex = 11;
            this.btn_cancelarVenda.Text = "Cancelar Compra";
            this.btn_cancelarVenda.UseVisualStyleBackColor = false;
            this.btn_cancelarVenda.Click += new System.EventHandler(this.btn_cancelarVenda_Click);
            // 
            // btn_cliente
            // 
            this.btn_cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_cliente.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cliente.ForeColor = System.Drawing.Color.Navy;
            this.btn_cliente.Location = new System.Drawing.Point(188, 12);
            this.btn_cliente.Name = "btn_cliente";
            this.btn_cliente.Size = new System.Drawing.Size(150, 36);
            this.btn_cliente.TabIndex = 12;
            this.btn_cliente.Text = "Cliente! (F4)";
            this.btn_cliente.UseVisualStyleBackColor = false;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(851, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 407);
            this.vScrollBar1.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(675, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "PREÇO:";
            // 
            // txb_quantidade
            // 
            this.txb_quantidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txb_quantidade.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_quantidade.Location = new System.Drawing.Point(528, 93);
            this.txb_quantidade.Name = "txb_quantidade";
            this.txb_quantidade.Size = new System.Drawing.Size(112, 48);
            this.txb_quantidade.TabIndex = 16;
            this.txb_quantidade.Text = "0";
            this.txb_quantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txb_preco
            // 
            this.txb_preco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txb_preco.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_preco.Location = new System.Drawing.Point(643, 93);
            this.txb_preco.Name = "txb_preco";
            this.txb_preco.ReadOnly = true;
            this.txb_preco.Size = new System.Drawing.Size(169, 48);
            this.txb_preco.TabIndex = 17;
            this.txb_preco.Text = "0,00";
            this.txb_preco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(455, 470);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 39);
            this.label2.TabIndex = 18;
            this.label2.Text = "Total = R$ ";
            // 
            // dgv_mostrarProduto
            // 
            this.dgv_mostrarProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_mostrarProduto.Location = new System.Drawing.Point(12, 147);
            this.dgv_mostrarProduto.Name = "dgv_mostrarProduto";
            this.dgv_mostrarProduto.Size = new System.Drawing.Size(800, 315);
            this.dgv_mostrarProduto.TabIndex = 22;
            this.dgv_mostrarProduto.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_mostrarProduto_CellEndEdit);
            this.dgv_mostrarProduto.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_mostrarProduto_CellMouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(28, 470);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 39);
            this.label4.TabIndex = 23;
            this.label4.Text = "Qtd Itens:";
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_buscar.BackgroundImage = global::SolidPDV.Properties.Resources.lupa06;
            this.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Location = new System.Drawing.Point(475, 100);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(44, 36);
            this.btn_buscar.TabIndex = 21;
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 24);
            this.label5.TabIndex = 26;
            this.label5.Text = "Código de Barra:";
            // 
            // txb_valorTotal
            // 
            this.txb_valorTotal.BackColor = System.Drawing.SystemColors.Control;
            this.txb_valorTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_valorTotal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_valorTotal.ForeColor = System.Drawing.Color.Navy;
            this.txb_valorTotal.Location = new System.Drawing.Point(664, 468);
            this.txb_valorTotal.Name = "txb_valorTotal";
            this.txb_valorTotal.ReadOnly = true;
            this.txb_valorTotal.Size = new System.Drawing.Size(127, 41);
            this.txb_valorTotal.TabIndex = 27;
            this.txb_valorTotal.Text = "0,00";
            // 
            // txb_qtdTotalItens
            // 
            this.txb_qtdTotalItens.BackColor = System.Drawing.SystemColors.Control;
            this.txb_qtdTotalItens.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_qtdTotalItens.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_qtdTotalItens.ForeColor = System.Drawing.Color.Navy;
            this.txb_qtdTotalItens.Location = new System.Drawing.Point(213, 470);
            this.txb_qtdTotalItens.Name = "txb_qtdTotalItens";
            this.txb_qtdTotalItens.ReadOnly = true;
            this.txb_qtdTotalItens.Size = new System.Drawing.Size(127, 41);
            this.txb_qtdTotalItens.TabIndex = 28;
            this.txb_qtdTotalItens.Text = "0";
            // 
            // FrmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 520);
            this.Controls.Add(this.txb_qtdTotalItens);
            this.Controls.Add(this.txb_valorTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgv_mostrarProduto);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.btn_cliente);
            this.Controls.Add(this.btn_cancelarVenda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_codBarra);
            this.Controls.Add(this.btn_concluir);
            this.Controls.Add(this.txb_quantidade);
            this.Controls.Add(this.txb_preco);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mostrarProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_concluir;
        private System.Windows.Forms.TextBox txb_codBarra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cancelarVenda;
        private System.Windows.Forms.Button btn_cliente;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_quantidade;
        private System.Windows.Forms.TextBox txb_preco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.DataGridView dgv_mostrarProduto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txb_valorTotal;
        private System.Windows.Forms.TextBox txb_qtdTotalItens;
    }
}