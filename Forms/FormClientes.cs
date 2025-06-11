using System;
using System.Windows.Forms;
using ViaCep;
using System.Threading;
using P2.Functions;
using System.Data;

namespace P2
{
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
        }

        // Função modular para carregar os clientes no DataGridView
        private void AtualizarGridClientes()
        {
            try
            {
                DataTable clientes = CrudUtils.ListarClientes();
                dataClientes.DataSource = clientes;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar clientes: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = txtNome.Text.Trim();
                string cpf = mskCpf.Text.Trim();
                string email = txtEmail.Text.Trim();
                string whatsapp = mskWhatsapp.Text.Trim();
                string telefone = mskTelefone.Text.Trim();
                string cep = mskCep.Text.Trim();
                string logradouro = txtLogradouro.Text.Trim();
                string numero = txtNumero.Text.Trim();
                string bairro = txtBairro.Text.Trim();
                string cidade = txtCidade.Text.Trim();
                string estado = txtEstado.Text.Trim();

                // Verifica se algum campo está vazio
                if (string.IsNullOrWhiteSpace(nome) ||
                    string.IsNullOrWhiteSpace(cpf) ||
                    string.IsNullOrWhiteSpace(email) ||
                    string.IsNullOrWhiteSpace(whatsapp) ||
                    string.IsNullOrWhiteSpace(telefone) ||
                    string.IsNullOrWhiteSpace(cep) ||
                    string.IsNullOrWhiteSpace(logradouro) ||
                    string.IsNullOrWhiteSpace(numero) ||
                    string.IsNullOrWhiteSpace(bairro) ||
                    string.IsNullOrWhiteSpace(cidade) ||
                    string.IsNullOrWhiteSpace(estado))
                {
                    MessageBox.Show("Preencha todos os campos obrigatórios antes de cadastrar.", "Campos obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Cadastra o cliente
                CrudUtils.CadastrarCliente(
                    nome, cpf, email, whatsapp, telefone,
                    cep, logradouro, numero, bairro, cidade, estado);

                MessageBox.Show("Cliente cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpa os campos
                txtNome.Clear();
                mskCpf.Clear();
                txtEmail.Clear();
                mskWhatsapp.Clear();
                mskTelefone.Clear();
                mskCep.Clear();
                txtLogradouro.Clear();
                txtNumero.Clear();
                txtBairro.Clear();
                txtCidade.Clear();
                txtEstado.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            AtualizarGridClientes();
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string cep = mskCep.Text.Replace("-", "").Trim();

                if (!string.IsNullOrWhiteSpace(cep))
                {
                    var viaCepClient = new ViaCepClient();

                    var resultado = await viaCepClient.SearchAsync(cep, CancellationToken.None);

                    if (resultado != null && resultado.ZipCode != null)
                    {
                        txtLogradouro.Text = resultado.Street;
                        txtBairro.Text = resultado.Neighborhood;
                        txtCidade.Text = resultado.City;
                        txtEstado.Text = resultado.StateInitials;
                    }
                    else
                    {
                        MessageBox.Show("CEP não encontrado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, informe um CEP válido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao buscar o CEP: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            // Atualiza o DataGridView ao carregar o formulário
            AtualizarGridClientes();
        }
    }
}
