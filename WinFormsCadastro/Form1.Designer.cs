namespace WinFormsCadastro
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
            grpDados = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            cmbFornecedor = new ComboBox();
            cmbCategoria = new ComboBox();
            txtDescricao = new TextBox();
            txtNomeProduto = new TextBox();
            lblDescricao = new Label();
            lblFornecedor = new Label();
            lblCategoria = new Label();
            lblNome = new Label();
            txtCodigo = new TextBox();
            lblCodigo = new Label();
            groupBox1 = new GroupBox();
            button1 = new Button();
            txtMargem = new TextBox();
            nudStockInicial = new NumericUpDown();
            nudStockMinimo = new NumericUpDown();
            nudPrecoVenda = new NumericUpDown();
            nudPrecoCusto = new NumericUpDown();
            lblMargem = new Label();
            lblStockInicial = new Label();
            lblVenda = new Label();
            lblStockMinimo = new Label();
            lblCusto = new Label();
            lblData = new GroupBox();
            dtpDataCadastro = new DateTimePicker();
            label1 = new Label();
            chkProdutoAtivo = new CheckBox();
            btnNovo = new Button();
            btnExcluir = new Button();
            btnLimpar = new Button();
            btnSalvar = new Button();
            grpDados.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudStockInicial).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudStockMinimo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrecoVenda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrecoCusto).BeginInit();
            lblData.SuspendLayout();
            SuspendLayout();
            // 
            // grpDados
            // 
            grpDados.Controls.Add(label3);
            grpDados.Controls.Add(label2);
            grpDados.Controls.Add(label4);
            grpDados.Controls.Add(cmbFornecedor);
            grpDados.Controls.Add(cmbCategoria);
            grpDados.Controls.Add(txtDescricao);
            grpDados.Controls.Add(txtNomeProduto);
            grpDados.Controls.Add(lblDescricao);
            grpDados.Controls.Add(lblFornecedor);
            grpDados.Controls.Add(lblCategoria);
            grpDados.Controls.Add(lblNome);
            grpDados.Controls.Add(txtCodigo);
            grpDados.Controls.Add(lblCodigo);
            grpDados.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpDados.Location = new Point(10, 9);
            grpDados.Margin = new Padding(3, 2, 3, 2);
            grpDados.Name = "grpDados";
            grpDados.Padding = new Padding(3, 2, 3, 2);
            grpDados.Size = new Size(710, 208);
            grpDados.TabIndex = 1;
            grpDados.TabStop = false;
            grpDados.Text = "Dados principais";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(84, 96);
            label3.Name = "label3";
            label3.Size = new Size(12, 15);
            label3.TabIndex = 17;
            label3.Text = "*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(306, 96);
            label2.Name = "label2";
            label2.Size = new Size(12, 15);
            label2.TabIndex = 16;
            label2.Text = "*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(593, 25);
            label4.Name = "label4";
            label4.Size = new Size(12, 15);
            label4.TabIndex = 15;
            label4.Text = "*";
            // 
            // cmbFornecedor
            // 
            cmbFornecedor.Font = new Font("Segoe UI", 9F);
            cmbFornecedor.FormattingEnabled = true;
            cmbFornecedor.Items.AddRange(new object[] { "Selecione...", "", "", "", "", "Fornecedor A", "", "", "", "", "Fornecedor B", "", "", "", "", "Fornecedor C", "", "", "", "", "Fornecedor D" });
            cmbFornecedor.Location = new Point(14, 116);
            cmbFornecedor.Margin = new Padding(3, 2, 3, 2);
            cmbFornecedor.Name = "cmbFornecedor";
            cmbFornecedor.Size = new Size(171, 23);
            cmbFornecedor.TabIndex = 12;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Items.AddRange(new object[] { "Selecione...", "", "", "", "", "Alimentos", "", "", "", "", "Bebidas", "", "", "", "", "Eletrônicos", "", "", "", "", "Informática", "", "", "", "", "Limpeza", "", "", "", "", "Vestuário", "", "", "", "", "Outros" });
            cmbCategoria.Location = new Point(534, 49);
            cmbCategoria.Margin = new Padding(3, 2, 3, 2);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(171, 29);
            cmbCategoria.TabIndex = 11;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(246, 116);
            txtDescricao.Margin = new Padding(3, 2, 3, 2);
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(459, 79);
            txtDescricao.TabIndex = 10;
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.Font = new Font("Segoe UI", 9F);
            txtNomeProduto.Location = new Point(182, 49);
            txtNomeProduto.Margin = new Padding(3, 2, 3, 2);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(347, 23);
            txtNomeProduto.TabIndex = 9;
            txtNomeProduto.Text = "000000";
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Font = new Font("Segoe UI", 9F);
            lblDescricao.Location = new Point(246, 97);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(58, 15);
            lblDescricao.TabIndex = 8;
            lblDescricao.Text = "Descrição";
            // 
            // lblFornecedor
            // 
            lblFornecedor.AutoSize = true;
            lblFornecedor.Font = new Font("Segoe UI", 9F);
            lblFornecedor.Location = new Point(14, 97);
            lblFornecedor.Name = "lblFornecedor";
            lblFornecedor.Size = new Size(67, 15);
            lblFornecedor.TabIndex = 7;
            lblFornecedor.Text = "Fornecedor";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 9F);
            lblCategoria.Location = new Point(534, 26);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(58, 15);
            lblCategoria.TabIndex = 6;
            lblCategoria.Text = "Categoria";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 9F);
            lblNome.Location = new Point(182, 26);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(103, 15);
            lblNome.TabIndex = 4;
            lblNome.Text = "Nome do Produto";
            // 
            // txtCodigo
            // 
            txtCodigo.Font = new Font("Segoe UI", 9F);
            txtCodigo.Location = new Point(14, 49);
            txtCodigo.Margin = new Padding(3, 2, 3, 2);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(163, 23);
            txtCodigo.TabIndex = 3;
            txtCodigo.Text = "000000";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Segoe UI", 9F);
            lblCodigo.Location = new Point(14, 26);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 2;
            lblCodigo.Text = "Código";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txtMargem);
            groupBox1.Controls.Add(nudStockInicial);
            groupBox1.Controls.Add(nudStockMinimo);
            groupBox1.Controls.Add(nudPrecoVenda);
            groupBox1.Controls.Add(nudPrecoCusto);
            groupBox1.Controls.Add(lblMargem);
            groupBox1.Controls.Add(lblStockInicial);
            groupBox1.Controls.Add(lblVenda);
            groupBox1.Controls.Add(lblStockMinimo);
            groupBox1.Controls.Add(lblCusto);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(10, 221);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(384, 168);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Precificação e Estoque";
            // 
            // button1
            // 
            button1.Location = new Point(181, 166);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 10;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtMargem
            // 
            txtMargem.Font = new Font("Segoe UI", 9F);
            txtMargem.Location = new Point(133, 66);
            txtMargem.Margin = new Padding(3, 2, 3, 2);
            txtMargem.Name = "txtMargem";
            txtMargem.ReadOnly = true;
            txtMargem.ScrollBars = ScrollBars.Horizontal;
            txtMargem.Size = new Size(68, 23);
            txtMargem.TabIndex = 9;
            txtMargem.Text = "0,00";
            // 
            // nudStockInicial
            // 
            nudStockInicial.Font = new Font("Segoe UI", 9F);
            nudStockInicial.Location = new Point(133, 99);
            nudStockInicial.Margin = new Padding(3, 2, 3, 2);
            nudStockInicial.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nudStockInicial.Name = "nudStockInicial";
            nudStockInicial.Size = new Size(67, 23);
            nudStockInicial.TabIndex = 8;
            // 
            // nudStockMinimo
            // 
            nudStockMinimo.Font = new Font("Segoe UI", 9F);
            nudStockMinimo.Location = new Point(312, 100);
            nudStockMinimo.Margin = new Padding(3, 2, 3, 2);
            nudStockMinimo.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nudStockMinimo.Name = "nudStockMinimo";
            nudStockMinimo.Size = new Size(64, 23);
            nudStockMinimo.TabIndex = 7;
            // 
            // nudPrecoVenda
            // 
            nudPrecoVenda.DecimalPlaces = 2;
            nudPrecoVenda.Font = new Font("Segoe UI", 9F);
            nudPrecoVenda.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nudPrecoVenda.Location = new Point(326, 38);
            nudPrecoVenda.Margin = new Padding(3, 2, 3, 2);
            nudPrecoVenda.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            nudPrecoVenda.Name = "nudPrecoVenda";
            nudPrecoVenda.Size = new Size(50, 23);
            nudPrecoVenda.TabIndex = 6;
            // 
            // nudPrecoCusto
            // 
            nudPrecoCusto.DecimalPlaces = 2;
            nudPrecoCusto.Font = new Font("Segoe UI", 9F);
            nudPrecoCusto.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nudPrecoCusto.Location = new Point(133, 36);
            nudPrecoCusto.Margin = new Padding(3, 2, 3, 2);
            nudPrecoCusto.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            nudPrecoCusto.Name = "nudPrecoCusto";
            nudPrecoCusto.Size = new Size(67, 23);
            nudPrecoCusto.TabIndex = 5;
            // 
            // lblMargem
            // 
            lblMargem.AutoSize = true;
            lblMargem.Font = new Font("Segoe UI", 9F);
            lblMargem.Location = new Point(5, 66);
            lblMargem.Name = "lblMargem";
            lblMargem.Size = new Size(76, 15);
            lblMargem.TabIndex = 4;
            lblMargem.Text = "Margem (R$)";
            // 
            // lblStockInicial
            // 
            lblStockInicial.AutoSize = true;
            lblStockInicial.Font = new Font("Segoe UI", 9F);
            lblStockInicial.Location = new Point(5, 99);
            lblStockInicial.Name = "lblStockInicial";
            lblStockInicial.Size = new Size(70, 15);
            lblStockInicial.TabIndex = 3;
            lblStockInicial.Text = "Stock Inicial";
            // 
            // lblVenda
            // 
            lblVenda.AutoSize = true;
            lblVenda.Font = new Font("Segoe UI", 9F);
            lblVenda.Location = new Point(220, 39);
            lblVenda.Name = "lblVenda";
            lblVenda.Size = new Size(88, 15);
            lblVenda.TabIndex = 2;
            lblVenda.Text = "Preço de Venda";
            // 
            // lblStockMinimo
            // 
            lblStockMinimo.AutoSize = true;
            lblStockMinimo.Font = new Font("Segoe UI", 9F);
            lblStockMinimo.Location = new Point(217, 102);
            lblStockMinimo.Name = "lblStockMinimo";
            lblStockMinimo.Size = new Size(81, 15);
            lblStockMinimo.TabIndex = 1;
            lblStockMinimo.Text = "Stock Mínimo";
            // 
            // lblCusto
            // 
            lblCusto.AutoSize = true;
            lblCusto.Font = new Font("Segoe UI", 9F);
            lblCusto.Location = new Point(5, 38);
            lblCusto.Name = "lblCusto";
            lblCusto.Size = new Size(111, 15);
            lblCusto.TabIndex = 0;
            lblCusto.Text = "Preço de Custo (R$)";
            // 
            // lblData
            // 
            lblData.Controls.Add(dtpDataCadastro);
            lblData.Controls.Add(label1);
            lblData.Controls.Add(chkProdutoAtivo);
            lblData.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblData.Location = new Point(400, 221);
            lblData.Margin = new Padding(3, 2, 3, 2);
            lblData.Name = "lblData";
            lblData.Padding = new Padding(3, 2, 3, 2);
            lblData.Size = new Size(315, 168);
            lblData.TabIndex = 3;
            lblData.TabStop = false;
            lblData.Text = "Situação / Detalhes";
            // 
            // dtpDataCadastro
            // 
            dtpDataCadastro.CalendarMonthBackground = SystemColors.Highlight;
            dtpDataCadastro.CalendarTitleBackColor = SystemColors.ButtonShadow;
            dtpDataCadastro.Font = new Font("Segoe UI", 9F);
            dtpDataCadastro.Format = DateTimePickerFormat.Short;
            dtpDataCadastro.Location = new Point(32, 124);
            dtpDataCadastro.Margin = new Padding(3, 2, 3, 2);
            dtpDataCadastro.Name = "dtpDataCadastro";
            dtpDataCadastro.RightToLeft = RightToLeft.No;
            dtpDataCadastro.Size = new Size(219, 23);
            dtpDataCadastro.TabIndex = 2;
            dtpDataCadastro.UseWaitCursor = true;
            dtpDataCadastro.Value = new DateTime(2026, 11, 10, 20, 58, 10, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(30, 99);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 1;
            label1.Text = "Data de Cadastro";
            // 
            // chkProdutoAtivo
            // 
            chkProdutoAtivo.AutoSize = true;
            chkProdutoAtivo.Checked = true;
            chkProdutoAtivo.CheckState = CheckState.Checked;
            chkProdutoAtivo.Font = new Font("Segoe UI", 9F);
            chkProdutoAtivo.Location = new Point(32, 50);
            chkProdutoAtivo.Margin = new Padding(3, 2, 3, 2);
            chkProdutoAtivo.Name = "chkProdutoAtivo";
            chkProdutoAtivo.Size = new Size(100, 19);
            chkProdutoAtivo.TabIndex = 0;
            chkProdutoAtivo.Text = "Produto Ativo";
            chkProdutoAtivo.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            btnNovo.BackColor = SystemColors.ButtonShadow;
            btnNovo.FlatStyle = FlatStyle.System;
            btnNovo.ForeColor = SystemColors.ActiveCaptionText;
            btnNovo.Location = new Point(153, 407);
            btnNovo.Margin = new Padding(3, 2, 3, 2);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(98, 30);
            btnNovo.TabIndex = 4;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = false;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = SystemColors.ButtonShadow;
            btnExcluir.FlatStyle = FlatStyle.System;
            btnExcluir.ForeColor = SystemColors.ActiveCaptionText;
            btnExcluir.Location = new Point(449, 407);
            btnExcluir.Margin = new Padding(3, 2, 3, 2);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(99, 29);
            btnExcluir.TabIndex = 5;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = SystemColors.ButtonShadow;
            btnLimpar.FlatStyle = FlatStyle.System;
            btnLimpar.ForeColor = SystemColors.ActiveCaptionText;
            btnLimpar.Location = new Point(354, 407);
            btnLimpar.Margin = new Padding(3, 2, 3, 2);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(90, 29);
            btnLimpar.TabIndex = 6;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = SystemColors.ButtonShadow;
            btnSalvar.FlatStyle = FlatStyle.System;
            btnSalvar.ForeColor = SystemColors.ActiveCaptionText;
            btnSalvar.Location = new Point(256, 407);
            btnSalvar.Margin = new Padding(3, 2, 3, 2);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(92, 29);
            btnSalvar.TabIndex = 7;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 446);
            Controls.Add(btnSalvar);
            Controls.Add(btnLimpar);
            Controls.Add(btnExcluir);
            Controls.Add(btnNovo);
            Controls.Add(lblData);
            Controls.Add(groupBox1);
            Controls.Add(grpDados);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            grpDados.ResumeLayout(false);
            grpDados.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudStockInicial).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudStockMinimo).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPrecoVenda).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPrecoCusto).EndInit();
            lblData.ResumeLayout(false);
            lblData.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox grpDados;
        private Label lblCodigo;
        private TextBox txtCodigo;
        private Label lblDescricao;
        private Label lblFornecedor;
        private Label lblCategoria;
        private Label lblNome;
        private TextBox txtDescricao;
        private TextBox txtNomeProduto;
        private ComboBox cmbCategoria;
        private ComboBox cmbFornecedor;
        private GroupBox groupBox1;
        private Label lblMargem;
        private Label lblStockInicial;
        private Label lblVenda;
        private Label lblStockMinimo;
        private Label lblCusto;
        private NumericUpDown nudStockInicial;
        private NumericUpDown nudStockMinimo;
        private NumericUpDown nudPrecoVenda;
        private NumericUpDown nudPrecoCusto;
        private TextBox txtMargem;
        private GroupBox lblData;
        private DateTimePicker dtpDataCadastro;
        private Label label1;
        private CheckBox chkProdutoAtivo;
        private Button btnNovo;
        private Button btnExcluir;
        private Button btnLimpar;
        private Button btnSalvar;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button1;
    }
}
