namespace WinFormsCadastro
{
    partial class grpPrecificacao
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
            lblCodigo = new Label();
            txtCodigo = new TextBox();
            lblNome = new Label();
            lblCategoria = new Label();
            lblFornecedor = new Label();
            lblDescricao = new Label();
            txtNomeProduto = new TextBox();
            txtDescricao = new TextBox();
            cmbCategoria = new ComboBox();
            cmbFornecedor = new ComboBox();
            groupBox1 = new GroupBox();
            lblCusto = new Label();
            lblStockMinimo = new Label();
            lblVenda = new Label();
            lblStockInicial = new Label();
            lblMargem = new Label();
            nudPrecoCusto = new NumericUpDown();
            nudPrecoVenda = new NumericUpDown();
            nudEstoqueMinimo = new NumericUpDown();
            nudStocknicial = new NumericUpDown();
            txtMargem = new TextBox();
            lblData = new GroupBox();
            chkProdutoAtivo = new CheckBox();
            label1 = new Label();
            dtpDataCadastro = new DateTimePicker();
            btnNovo = new Button();
            btnExcluir = new Button();
            btnLimpar = new Button();
            btnSalvar = new Button();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            grpDados.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrecoCusto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrecoVenda).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudEstoqueMinimo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudStocknicial).BeginInit();
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
            grpDados.Location = new Point(12, 12);
            grpDados.Name = "grpDados";
            grpDados.Size = new Size(812, 277);
            grpDados.TabIndex = 1;
            grpDados.TabStop = false;
            grpDados.Text = "Dados principais";
            grpDados.Enter += grpDados_Enter;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Segoe UI", 9F);
            lblCodigo.Location = new Point(16, 34);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(58, 20);
            lblCodigo.TabIndex = 2;
            lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            txtCodigo.Font = new Font("Segoe UI", 9F);
            txtCodigo.Location = new Point(16, 65);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(186, 27);
            txtCodigo.TabIndex = 3;
            txtCodigo.Text = "000000";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 9F);
            lblNome.Location = new Point(208, 34);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(129, 20);
            lblNome.TabIndex = 4;
            lblNome.Text = "Nome do Produto";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 9F);
            lblCategoria.Location = new Point(610, 34);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(74, 20);
            lblCategoria.TabIndex = 6;
            lblCategoria.Text = "Categoria";
            lblCategoria.Click += lblCategoria_Click;
            // 
            // lblFornecedor
            // 
            lblFornecedor.AutoSize = true;
            lblFornecedor.Font = new Font("Segoe UI", 9F);
            lblFornecedor.Location = new Point(16, 129);
            lblFornecedor.Name = "lblFornecedor";
            lblFornecedor.Size = new Size(84, 20);
            lblFornecedor.TabIndex = 7;
            lblFornecedor.Text = "Fornecedor";
            lblFornecedor.Click += label1_Click;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Font = new Font("Segoe UI", 9F);
            lblDescricao.Location = new Point(281, 129);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(74, 20);
            lblDescricao.TabIndex = 8;
            lblDescricao.Text = "Descrição";
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.Font = new Font("Segoe UI", 9F);
            txtNomeProduto.Location = new Point(208, 65);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(396, 27);
            txtNomeProduto.TabIndex = 9;
            txtNomeProduto.Text = "000000";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(281, 155);
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(524, 104);
            txtDescricao.TabIndex = 10;
            txtDescricao.TextChanged += textBox2_TextChanged;
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Items.AddRange(new object[] { "Selecione...", "", "", "", "", "Alimentos", "", "", "", "", "Bebidas", "", "", "", "", "Eletrônicos", "", "", "", "", "Informática", "", "", "", "", "Limpeza", "", "", "", "", "Vestuário", "", "", "", "", "Outros" });
            cmbCategoria.Location = new Point(610, 65);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(195, 36);
            cmbCategoria.TabIndex = 11;
            cmbCategoria.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // cmbFornecedor
            // 
            cmbFornecedor.Font = new Font("Segoe UI", 9F);
            cmbFornecedor.FormattingEnabled = true;
            cmbFornecedor.Items.AddRange(new object[] { "Selecione...", "", "", "", "", "Fornecedor A", "", "", "", "", "Fornecedor B", "", "", "", "", "Fornecedor C", "", "", "", "", "Fornecedor D" });
            cmbFornecedor.Location = new Point(16, 155);
            cmbFornecedor.Name = "cmbFornecedor";
            cmbFornecedor.Size = new Size(195, 28);
            cmbFornecedor.TabIndex = 12;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txtMargem);
            groupBox1.Controls.Add(nudStocknicial);
            groupBox1.Controls.Add(nudEstoqueMinimo);
            groupBox1.Controls.Add(nudPrecoVenda);
            groupBox1.Controls.Add(nudPrecoCusto);
            groupBox1.Controls.Add(lblMargem);
            groupBox1.Controls.Add(lblStockInicial);
            groupBox1.Controls.Add(lblVenda);
            groupBox1.Controls.Add(lblStockMinimo);
            groupBox1.Controls.Add(lblCusto);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 295);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(439, 224);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Precificação e Estoque";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // lblCusto
            // 
            lblCusto.AutoSize = true;
            lblCusto.Font = new Font("Segoe UI", 9F);
            lblCusto.Location = new Point(6, 50);
            lblCusto.Name = "lblCusto";
            lblCusto.Size = new Size(139, 20);
            lblCusto.TabIndex = 0;
            lblCusto.Text = "Preço de Custo (R$)";
            lblCusto.Click += label1_Click_1;
            // 
            // lblStockMinimo
            // 
            lblStockMinimo.AutoSize = true;
            lblStockMinimo.Font = new Font("Segoe UI", 9F);
            lblStockMinimo.Location = new Point(248, 136);
            lblStockMinimo.Name = "lblStockMinimo";
            lblStockMinimo.Size = new Size(100, 20);
            lblStockMinimo.TabIndex = 1;
            lblStockMinimo.Text = "Stock Mínimo";
            // 
            // lblVenda
            // 
            lblVenda.AutoSize = true;
            lblVenda.Font = new Font("Segoe UI", 9F);
            lblVenda.Location = new Point(251, 52);
            lblVenda.Name = "lblVenda";
            lblVenda.Size = new Size(112, 20);
            lblVenda.TabIndex = 2;
            lblVenda.Text = "Preço de Venda";
            lblVenda.Click += label3_Click;
            // 
            // lblStockInicial
            // 
            lblStockInicial.AutoSize = true;
            lblStockInicial.Font = new Font("Segoe UI", 9F);
            lblStockInicial.Location = new Point(6, 132);
            lblStockInicial.Name = "lblStockInicial";
            lblStockInicial.Size = new Size(88, 20);
            lblStockInicial.TabIndex = 3;
            lblStockInicial.Text = "Stock Inicial";
            lblStockInicial.Click += label4_Click;
            // 
            // lblMargem
            // 
            lblMargem.AutoSize = true;
            lblMargem.Font = new Font("Segoe UI", 9F);
            lblMargem.Location = new Point(6, 88);
            lblMargem.Name = "lblMargem";
            lblMargem.Size = new Size(96, 20);
            lblMargem.TabIndex = 4;
            lblMargem.Text = "Margem (R$)";
            lblMargem.Click += label5_Click;
            // 
            // nudPrecoCusto
            // 
            nudPrecoCusto.DecimalPlaces = 2;
            nudPrecoCusto.Font = new Font("Segoe UI", 9F);
            nudPrecoCusto.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nudPrecoCusto.Location = new Point(152, 48);
            nudPrecoCusto.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            nudPrecoCusto.Name = "nudPrecoCusto";
            nudPrecoCusto.Size = new Size(77, 27);
            nudPrecoCusto.TabIndex = 5;
            // 
            // nudPrecoVenda
            // 
            nudPrecoVenda.DecimalPlaces = 2;
            nudPrecoVenda.Font = new Font("Segoe UI", 9F);
            nudPrecoVenda.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nudPrecoVenda.Location = new Point(372, 50);
            nudPrecoVenda.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            nudPrecoVenda.Name = "nudPrecoVenda";
            nudPrecoVenda.Size = new Size(57, 27);
            nudPrecoVenda.TabIndex = 6;
            nudPrecoVenda.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // nudEstoqueMinimo
            // 
            nudEstoqueMinimo.Font = new Font("Segoe UI", 9F);
            nudEstoqueMinimo.Location = new Point(356, 134);
            nudEstoqueMinimo.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nudEstoqueMinimo.Name = "nudEstoqueMinimo";
            nudEstoqueMinimo.Size = new Size(73, 27);
            nudEstoqueMinimo.TabIndex = 7;
            nudEstoqueMinimo.ValueChanged += numericUpDown3_ValueChanged;
            // 
            // nudStocknicial
            // 
            nudStocknicial.Font = new Font("Segoe UI", 9F);
            nudStocknicial.Location = new Point(152, 132);
            nudStocknicial.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nudStocknicial.Name = "nudStocknicial";
            nudStocknicial.Size = new Size(77, 27);
            nudStocknicial.TabIndex = 8;
            // 
            // txtMargem
            // 
            txtMargem.Font = new Font("Segoe UI", 9F);
            txtMargem.Location = new Point(152, 88);
            txtMargem.Name = "txtMargem";
            txtMargem.ReadOnly = true;
            txtMargem.ScrollBars = ScrollBars.Horizontal;
            txtMargem.Size = new Size(77, 27);
            txtMargem.TabIndex = 9;
            txtMargem.Text = "0,00";
            // 
            // lblData
            // 
            lblData.Controls.Add(dtpDataCadastro);
            lblData.Controls.Add(label1);
            lblData.Controls.Add(chkProdutoAtivo);
            lblData.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblData.Location = new Point(457, 295);
            lblData.Name = "lblData";
            lblData.Size = new Size(360, 224);
            lblData.TabIndex = 3;
            lblData.TabStop = false;
            lblData.Text = "Situação / Detalhes";
            lblData.Enter += groupBox2_Enter;
            // 
            // chkProdutoAtivo
            // 
            chkProdutoAtivo.AutoSize = true;
            chkProdutoAtivo.Checked = true;
            chkProdutoAtivo.CheckState = CheckState.Checked;
            chkProdutoAtivo.Font = new Font("Segoe UI", 9F);
            chkProdutoAtivo.Location = new Point(36, 67);
            chkProdutoAtivo.Name = "chkProdutoAtivo";
            chkProdutoAtivo.Size = new Size(123, 24);
            chkProdutoAtivo.TabIndex = 0;
            chkProdutoAtivo.Text = "Produto Ativo";
            chkProdutoAtivo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(34, 132);
            label1.Name = "label1";
            label1.Size = new Size(125, 20);
            label1.TabIndex = 1;
            label1.Text = "Data de Cadastro";
            // 
            // dtpDataCadastro
            // 
            dtpDataCadastro.CalendarMonthBackground = SystemColors.Highlight;
            dtpDataCadastro.CalendarTitleBackColor = SystemColors.ButtonShadow;
            dtpDataCadastro.Font = new Font("Segoe UI", 9F);
            dtpDataCadastro.Format = DateTimePickerFormat.Short;
            dtpDataCadastro.Location = new Point(37, 166);
            dtpDataCadastro.Name = "dtpDataCadastro";
            dtpDataCadastro.RightToLeft = RightToLeft.No;
            dtpDataCadastro.Size = new Size(250, 27);
            dtpDataCadastro.TabIndex = 2;
            dtpDataCadastro.UseWaitCursor = true;
            dtpDataCadastro.Value = new DateTime(2026, 11, 10, 20, 58, 10, 0);
            // 
            // btnNovo
            // 
            btnNovo.BackColor = SystemColors.ButtonShadow;
            btnNovo.FlatStyle = FlatStyle.System;
            btnNovo.ForeColor = SystemColors.ActiveCaptionText;
            btnNovo.Location = new Point(175, 543);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(112, 40);
            btnNovo.TabIndex = 4;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = false;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = SystemColors.ButtonShadow;
            btnExcluir.FlatStyle = FlatStyle.System;
            btnExcluir.ForeColor = SystemColors.ActiveCaptionText;
            btnExcluir.Location = new Point(513, 543);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(113, 39);
            btnExcluir.TabIndex = 5;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = SystemColors.ButtonShadow;
            btnLimpar.FlatStyle = FlatStyle.System;
            btnLimpar.ForeColor = SystemColors.ActiveCaptionText;
            btnLimpar.Location = new Point(404, 543);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(103, 39);
            btnLimpar.TabIndex = 6;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = SystemColors.ButtonShadow;
            btnSalvar.FlatStyle = FlatStyle.System;
            btnSalvar.ForeColor = SystemColors.ActiveCaptionText;
            btnSalvar.Location = new Point(293, 543);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(105, 39);
            btnSalvar.TabIndex = 7;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(678, 33);
            label4.Name = "label4";
            label4.Size = new Size(16, 20);
            label4.TabIndex = 15;
            label4.Text = "*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(350, 128);
            label2.Name = "label2";
            label2.Size = new Size(16, 20);
            label2.TabIndex = 16;
            label2.Text = "*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(96, 128);
            label3.Name = "label3";
            label3.Size = new Size(16, 20);
            label3.TabIndex = 17;
            label3.Text = "*";
            // 
            // button1
            // 
            button1.Location = new Point(207, 222);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 10;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // grpPrecificacao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 595);
            Controls.Add(btnSalvar);
            Controls.Add(btnLimpar);
            Controls.Add(btnExcluir);
            Controls.Add(btnNovo);
            Controls.Add(lblData);
            Controls.Add(groupBox1);
            Controls.Add(grpDados);
            Name = "grpPrecificacao";
            Text = "Form1";
            Load += Form1_Load;
            grpDados.ResumeLayout(false);
            grpDados.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPrecoCusto).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPrecoVenda).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudEstoqueMinimo).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudStocknicial).EndInit();
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
        private NumericUpDown nudStocknicial;
        private NumericUpDown nudEstoqueMinimo;
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
