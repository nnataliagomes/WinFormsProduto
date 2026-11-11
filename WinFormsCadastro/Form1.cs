using System;
using System.Windows.Forms;

namespace WinFormsCadastro
{
    public partial class Form1 : Form
    {
        private int proximoCodigo = 1;
        private bool produtoCadastrado = false;

        public Form1()
        {
            InitializeComponent();

            // Eventos dos preços
            nudPrecoCusto.ValueChanged += nudPrecoCusto_ValueChanged;
            nudPrecoVenda.ValueChanged += nudPrecoVenda_ValueChanged;

            // Eventos dos botões
            btnNovo.Click += btnNovo_Click;
            btnSalvar.Click += btnSalvar_Click;
            btnLimpar.Click += btnLimpar_Click;
            btnExcluir.Click += btnExcluir_Click;

          
        }

        // CARREGAR FORMULÁRIO
        private void Form1_Load(object sender, EventArgs e)
        {
            // Categorias
            cmbCategoria.Items.Clear();
            cmbCategoria.Items.Add("Eletrônicos");
            cmbCategoria.Items.Add("Informática");
            cmbCategoria.Items.Add("Móveis");
            cmbCategoria.Items.Add("Alimentos");
            cmbCategoria.Items.Add("Vestuário");
            cmbCategoria.Items.Add("Outros");

            // Fornecedores
            cmbFornecedor.Items.Clear();
            cmbFornecedor.Items.Add("Fornecedor A");
            cmbFornecedor.Items.Add("Fornecedor B");
            cmbFornecedor.Items.Add("Fornecedor C");

            ConfigurarCampos();

            LimparCampos();
        }

        // CONFIGURAR CAMPOS
        private void ConfigurarCampos()
        {
           
            txtMargem.ReadOnly = true;

            nudPrecoCusto.DecimalPlaces = 2;
            nudPrecoVenda.DecimalPlaces = 2;

            nudPrecoCusto.Maximum = 9999;
            nudPrecoVenda.Maximum = 9999;

           
            nudStockInicial.Minimum = 0;
            nudStockMinimo.Minimum = 0;

            nudStockInicial.Maximum = 9999;
            nudStockMinimo.Maximum = 9999;

            
            chkProdutoAtivo.Checked = true;
        }


        // CALCULAR MARGEM DE LUCRO
        private void CalcularMargem()
        {
            decimal custo = nudPrecoCusto.Value;
            decimal venda = nudPrecoVenda.Value;

            decimal margem = venda - custo;

            txtMargem.Text = margem.ToString("N2");
        }

        // EVENTO DO PREÇO DE CUSTO
        private void nudPrecoCusto_ValueChanged(object sender, EventArgs e)
        {
            CalcularMargem();
        }

        // EVENTO DO PREÇO DE VENDA
        private void nudPrecoVenda_ValueChanged(object sender, EventArgs e)
        {
            CalcularMargem();
        }

        // BOTÃO NOVO
        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimparCampos();

            produtoCadastrado = false;

            MessageBox.Show(
                "Novo cadastro!",
                "Novo Produto",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        // BOTÃO SALVAR
        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtNomeProduto.Text))
            {
                MessageBox.Show("Informe o nome do produto!");
                txtNomeProduto.Focus();
                return;
            }

            if (cmbCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma categoria!");
                cmbCategoria.Focus();
                return;
            }

            if (cmbFornecedor.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um fornecedor!");
                cmbFornecedor.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDescricao.Text))
            {
                MessageBox.Show("Informe a descrição do produto!");
                txtDescricao.Focus();
                return;
            }


            if (nudPrecoCusto.Value <= 0)
            {
                MessageBox.Show("O preço de custo deve ser maior que zero!");
                nudPrecoCusto.Focus();
                return;
            }

            if (nudPrecoVenda.Value <= 0)
            {
                MessageBox.Show("O preço de venda deve ser maior que zero!");
                nudPrecoVenda.Focus();
                return;
            }

            if (nudPrecoVenda.Value <= nudPrecoCusto.Value)
            {
                MessageBox.Show(
                    "O preço de venda deve ser maior que o preço de custo!",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                nudPrecoVenda.Focus();
                return;
            }

            // SIMULAÇÃO DO SALVAMENTO
            string mensagem =
                "PRODUTO CADASTRADO COM SUCESSO!\n\n" +
                "Código: " + txtCodigo.Text + "\n" +
                "Nome: " + txtNomeProduto.Text + "\n" +
                "Categoria: " + cmbCategoria.Text + "\n" +
                "Fornecedor: " + cmbFornecedor.Text + "\n" +
                "Descrição: " + txtDescricao.Text + "\n\n" +
                "Preço de Custo: R$ " + nudPrecoCusto.Value.ToString("N2") + "\n" +
                "Preço de Venda: R$ " + nudPrecoVenda.Value.ToString("N2") + "\n" +
                "Margem: R$ " + txtMargem.Text + "\n\n" +
                "Estoque Inicial: " + nudStockInicial.Value + "\n" +
                "Estoque Mínimo: " + nudStockMinimo.Value + "\n\n" +
                "Produto Ativo: " + (chkProdutoAtivo.Checked ? "Sim" : "Não");

            MessageBox.Show(
                mensagem,
                "Cadastro realizado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            produtoCadastrado = true;
            proximoCodigo++;

        }

        // BOTÃO LIMPAR
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        // MÉTODO PARA LIMPAR TODOS OS CAMPOS
        private void LimparCampos()
        {
            txtCodigo.Clear();
            txtNomeProduto.Clear();

            cmbCategoria.SelectedIndex = -1;
            cmbFornecedor.SelectedIndex = -1;

            txtDescricao.Clear();

            nudPrecoCusto.Value = 0;
            nudPrecoVenda.Value = 0;

            txtMargem.Text = "0,00";

            nudStockInicial.Value = 0;
            nudStockMinimo.Value = 0;

            chkProdutoAtivo.Checked = true;

            dtpDataCadastro.Value = DateTime.Today;

        }

        // BOTÃO EXCLUIR
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show(
                "Deseja realmente excluir este produto?",
                "Excluir Produto",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resposta == DialogResult.Yes)
            {
                LimparCampos();

                produtoCadastrado = false;

                MessageBox.Show(
                    "Produto excluído com sucesso!",
                    "Exclusão",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }
    }
}
