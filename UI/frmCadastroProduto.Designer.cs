﻿namespace UI
{
    partial class frmCadastroProduto
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblCodProduto = new System.Windows.Forms.Label();
            this.lblNomeProduto = new System.Windows.Forms.Label();
            this.txtCodProduto = new System.Windows.Forms.TextBox();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.lblDescricaoProduto = new System.Windows.Forms.Label();
            this.txtDescricaoProduto = new System.Windows.Forms.TextBox();
            this.lblQtdeProduto = new System.Windows.Forms.Label();
            this.lblValorPago = new System.Windows.Forms.Label();
            this.lblValorVenda = new System.Windows.Forms.Label();
            this.txtQtdeProduto = new System.Windows.Forms.TextBox();
            this.txtValorPago = new System.Windows.Forms.TextBox();
            this.txtValorVenda = new System.Windows.Forms.TextBox();
            this.lblUniMedida = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblSubCategoria = new System.Windows.Forms.Label();
            this.cmbUnMedida = new System.Windows.Forms.ComboBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.cmbSubCategoria = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.lblFoto = new System.Windows.Forms.Label();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.toolTipCarrega = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipRemove = new System.Windows.Forms.ToolTip(this.components);
            this.btnAddCat = new System.Windows.Forms.Button();
            this.btnAddUMed = new System.Windows.Forms.Button();
            this.btnAddSubCat = new System.Windows.Forms.Button();
            this.pnDados.SuspendLayout();
            this.pnButton.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.btnAddSubCat);
            this.pnDados.Controls.Add(this.btnAddUMed);
            this.pnDados.Controls.Add(this.btnAddCat);
            this.pnDados.Controls.Add(this.btnRemover);
            this.pnDados.Controls.Add(this.btnCarregar);
            this.pnDados.Controls.Add(this.lblFoto);
            this.pnDados.Controls.Add(this.panel1);
            this.pnDados.Controls.Add(this.cmbSubCategoria);
            this.pnDados.Controls.Add(this.cmbCategoria);
            this.pnDados.Controls.Add(this.cmbUnMedida);
            this.pnDados.Controls.Add(this.lblSubCategoria);
            this.pnDados.Controls.Add(this.lblCategoria);
            this.pnDados.Controls.Add(this.lblUniMedida);
            this.pnDados.Controls.Add(this.txtValorVenda);
            this.pnDados.Controls.Add(this.txtValorPago);
            this.pnDados.Controls.Add(this.txtQtdeProduto);
            this.pnDados.Controls.Add(this.lblValorVenda);
            this.pnDados.Controls.Add(this.lblValorPago);
            this.pnDados.Controls.Add(this.lblQtdeProduto);
            this.pnDados.Controls.Add(this.txtDescricaoProduto);
            this.pnDados.Controls.Add(this.lblDescricaoProduto);
            this.pnDados.Controls.Add(this.txtNomeProduto);
            this.pnDados.Controls.Add(this.txtCodProduto);
            this.pnDados.Controls.Add(this.lblNomeProduto);
            this.pnDados.Controls.Add(this.lblCodProduto);
            this.pnDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnCalcelar
            // 
            this.btnCalcelar.Click += new System.EventHandler(this.btnCalcelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // lblCodProduto
            // 
            this.lblCodProduto.AutoSize = true;
            this.lblCodProduto.Location = new System.Drawing.Point(18, 11);
            this.lblCodProduto.Name = "lblCodProduto";
            this.lblCodProduto.Size = new System.Drawing.Size(40, 13);
            this.lblCodProduto.TabIndex = 0;
            this.lblCodProduto.Text = "Código";
            // 
            // lblNomeProduto
            // 
            this.lblNomeProduto.AutoSize = true;
            this.lblNomeProduto.Location = new System.Drawing.Point(18, 49);
            this.lblNomeProduto.Name = "lblNomeProduto";
            this.lblNomeProduto.Size = new System.Drawing.Size(35, 13);
            this.lblNomeProduto.TabIndex = 1;
            this.lblNomeProduto.Text = "Nome";
            // 
            // txtCodProduto
            // 
            this.txtCodProduto.Enabled = false;
            this.txtCodProduto.Location = new System.Drawing.Point(21, 27);
            this.txtCodProduto.Name = "txtCodProduto";
            this.txtCodProduto.Size = new System.Drawing.Size(100, 20);
            this.txtCodProduto.TabIndex = 2;
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(21, 65);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(342, 20);
            this.txtNomeProduto.TabIndex = 3;
            // 
            // lblDescricaoProduto
            // 
            this.lblDescricaoProduto.AutoSize = true;
            this.lblDescricaoProduto.Location = new System.Drawing.Point(18, 88);
            this.lblDescricaoProduto.Name = "lblDescricaoProduto";
            this.lblDescricaoProduto.Size = new System.Drawing.Size(55, 13);
            this.lblDescricaoProduto.TabIndex = 4;
            this.lblDescricaoProduto.Text = "Descrição";
            // 
            // txtDescricaoProduto
            // 
            this.txtDescricaoProduto.Location = new System.Drawing.Point(21, 104);
            this.txtDescricaoProduto.Multiline = true;
            this.txtDescricaoProduto.Name = "txtDescricaoProduto";
            this.txtDescricaoProduto.Size = new System.Drawing.Size(342, 54);
            this.txtDescricaoProduto.TabIndex = 5;
            // 
            // lblQtdeProduto
            // 
            this.lblQtdeProduto.AutoSize = true;
            this.lblQtdeProduto.Location = new System.Drawing.Point(21, 200);
            this.lblQtdeProduto.Name = "lblQtdeProduto";
            this.lblQtdeProduto.Size = new System.Drawing.Size(62, 13);
            this.lblQtdeProduto.TabIndex = 6;
            this.lblQtdeProduto.Text = "Quantidade";
            // 
            // lblValorPago
            // 
            this.lblValorPago.AutoSize = true;
            this.lblValorPago.Location = new System.Drawing.Point(21, 161);
            this.lblValorPago.Name = "lblValorPago";
            this.lblValorPago.Size = new System.Drawing.Size(59, 13);
            this.lblValorPago.TabIndex = 7;
            this.lblValorPago.Text = "Valor Pago";
            // 
            // lblValorVenda
            // 
            this.lblValorVenda.AutoSize = true;
            this.lblValorVenda.Location = new System.Drawing.Point(217, 161);
            this.lblValorVenda.Name = "lblValorVenda";
            this.lblValorVenda.Size = new System.Drawing.Size(80, 13);
            this.lblValorVenda.TabIndex = 8;
            this.lblValorVenda.Text = "Valor de Venda";
            // 
            // txtQtdeProduto
            // 
            this.txtQtdeProduto.Location = new System.Drawing.Point(24, 216);
            this.txtQtdeProduto.Name = "txtQtdeProduto";
            this.txtQtdeProduto.Size = new System.Drawing.Size(134, 20);
            this.txtQtdeProduto.TabIndex = 12;
            this.txtQtdeProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtdeProduto_KeyPress);
            this.txtQtdeProduto.Leave += new System.EventHandler(this.txtQtdeProduto_Leave);
            // 
            // txtValorPago
            // 
            this.txtValorPago.Location = new System.Drawing.Point(24, 177);
            this.txtValorPago.Name = "txtValorPago";
            this.txtValorPago.Size = new System.Drawing.Size(134, 20);
            this.txtValorPago.TabIndex = 10;
            this.txtValorPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorPago_KeyPress);
            this.txtValorPago.Leave += new System.EventHandler(this.txtValorPago_Leave);
            // 
            // txtValorVenda
            // 
            this.txtValorVenda.Location = new System.Drawing.Point(220, 177);
            this.txtValorVenda.Name = "txtValorVenda";
            this.txtValorVenda.Size = new System.Drawing.Size(143, 20);
            this.txtValorVenda.TabIndex = 11;
            this.txtValorVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorVenda_KeyPress);
            this.txtValorVenda.Leave += new System.EventHandler(this.txtValorVenda_Leave);
            // 
            // lblUniMedida
            // 
            this.lblUniMedida.AutoSize = true;
            this.lblUniMedida.Location = new System.Drawing.Point(217, 200);
            this.lblUniMedida.Name = "lblUniMedida";
            this.lblUniMedida.Size = new System.Drawing.Size(100, 13);
            this.lblUniMedida.TabIndex = 12;
            this.lblUniMedida.Text = "Unidade de Medida";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(21, 241);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 13;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblSubCategoria
            // 
            this.lblSubCategoria.AutoSize = true;
            this.lblSubCategoria.Location = new System.Drawing.Point(217, 239);
            this.lblSubCategoria.Name = "lblSubCategoria";
            this.lblSubCategoria.Size = new System.Drawing.Size(71, 13);
            this.lblSubCategoria.TabIndex = 14;
            this.lblSubCategoria.Text = "SubCategoria";
            // 
            // cmbUnMedida
            // 
            this.cmbUnMedida.FormattingEnabled = true;
            this.cmbUnMedida.Location = new System.Drawing.Point(220, 216);
            this.cmbUnMedida.Name = "cmbUnMedida";
            this.cmbUnMedida.Size = new System.Drawing.Size(143, 21);
            this.cmbUnMedida.TabIndex = 13;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbCategoria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(21, 255);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(137, 21);
            this.cmbCategoria.TabIndex = 16;
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbCategoria_SelectedIndexChanged);
            // 
            // cmbSubCategoria
            // 
            this.cmbSubCategoria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbSubCategoria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSubCategoria.FormattingEnabled = true;
            this.cmbSubCategoria.Location = new System.Drawing.Point(220, 255);
            this.cmbSubCategoria.Name = "cmbSubCategoria";
            this.cmbSubCategoria.Size = new System.Drawing.Size(143, 21);
            this.cmbSubCategoria.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pbFoto);
            this.panel1.Location = new System.Drawing.Point(406, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 173);
            this.panel1.TabIndex = 18;
            // 
            // pbFoto
            // 
            this.pbFoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbFoto.Location = new System.Drawing.Point(0, 0);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(196, 171);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 0;
            this.pbFoto.TabStop = false;
            // 
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.Location = new System.Drawing.Point(403, 11);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(28, 13);
            this.lblFoto.TabIndex = 19;
            this.lblFoto.Text = "Foto";
            // 
            // btnCarregar
            // 
            this.btnCarregar.Image = global::UI.Properties.Resources.folderimage_9658;
            this.btnCarregar.Location = new System.Drawing.Point(406, 207);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(95, 60);
            this.btnCarregar.TabIndex = 20;
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Image = global::UI.Properties.Resources.remove;
            this.btnRemover.Location = new System.Drawing.Point(507, 207);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(97, 60);
            this.btnRemover.TabIndex = 21;
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnAddCat
            // 
            this.btnAddCat.Location = new System.Drawing.Point(164, 253);
            this.btnAddCat.Name = "btnAddCat";
            this.btnAddCat.Size = new System.Drawing.Size(22, 23);
            this.btnAddCat.TabIndex = 22;
            this.btnAddCat.Text = "+";
            this.btnAddCat.UseVisualStyleBackColor = true;
            this.btnAddCat.Click += new System.EventHandler(this.btnAddCat_Click);
            // 
            // btnAddUMed
            // 
            this.btnAddUMed.Location = new System.Drawing.Point(369, 214);
            this.btnAddUMed.Name = "btnAddUMed";
            this.btnAddUMed.Size = new System.Drawing.Size(22, 23);
            this.btnAddUMed.TabIndex = 23;
            this.btnAddUMed.Text = "+";
            this.btnAddUMed.UseVisualStyleBackColor = true;
            this.btnAddUMed.Click += new System.EventHandler(this.btnAddUMed_Click);
            // 
            // btnAddSubCat
            // 
            this.btnAddSubCat.Location = new System.Drawing.Point(369, 253);
            this.btnAddSubCat.Name = "btnAddSubCat";
            this.btnAddSubCat.Size = new System.Drawing.Size(22, 23);
            this.btnAddSubCat.TabIndex = 24;
            this.btnAddSubCat.Text = "+";
            this.btnAddSubCat.UseVisualStyleBackColor = true;
            this.btnAddSubCat.Click += new System.EventHandler(this.btnAddSubCat_Click);
            // 
            // frmCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(640, 412);
            this.Name = "frmCadastroProduto";
            this.Load += new System.EventHandler(this.frmCadastroProduto_Load);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.pnButton.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFoto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbSubCategoria;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.ComboBox cmbUnMedida;
        private System.Windows.Forms.Label lblSubCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblUniMedida;
        private System.Windows.Forms.TextBox txtValorVenda;
        private System.Windows.Forms.TextBox txtValorPago;
        private System.Windows.Forms.TextBox txtQtdeProduto;
        private System.Windows.Forms.Label lblValorVenda;
        private System.Windows.Forms.Label lblValorPago;
        private System.Windows.Forms.Label lblQtdeProduto;
        private System.Windows.Forms.TextBox txtDescricaoProduto;
        private System.Windows.Forms.Label lblDescricaoProduto;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.TextBox txtCodProduto;
        private System.Windows.Forms.Label lblNomeProduto;
        private System.Windows.Forms.Label lblCodProduto;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.ToolTip toolTipCarrega;
        private System.Windows.Forms.ToolTip toolTipRemove;
        private System.Windows.Forms.Button btnAddSubCat;
        private System.Windows.Forms.Button btnAddUMed;
        private System.Windows.Forms.Button btnAddCat;
    }
}
