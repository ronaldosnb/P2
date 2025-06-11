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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataClientes.SelectedRows.Count > 0)
            {
                DialogResult confirmacao = MessageBox.Show(
                    "Tem certeza que deseja excluir o cliente selecionado?",
                    "Confirmar exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacao == DialogResult.Yes)
                {
                    try
                    {
                        // Pega o CPF da linha selecionada (coluna 1)
                        string cpf = dataClientes.SelectedRows[0].Cells[1].Value.ToString();

                        CrudUtils.ExcluirCliente(cpf);
                        MessageBox.Show("Cliente excluído com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AtualizarGridClientes(); // Atualiza o grid
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir cliente: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um cliente para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
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

                // Verifica campos obrigatórios
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
                    MessageBox.Show("Preencha todos os campos para atualizar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                CrudUtils.AtualizarCliente(cpf, nome, email, whatsapp, telefone,
                                            cep, logradouro, numero, bairro, cidade, estado);

                MessageBox.Show("Cliente atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                AtualizarGridClientes(); // Atualiza a tabela
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar cliente: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void dataClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataClientes.Rows[e.RowIndex];

                txtNome.Text = row.Cells[0].Value?.ToString();
                mskCpf.Text = row.Cells[1].Value?.ToString();
                txtEmail.Text = row.Cells[2].Value?.ToString();
                mskWhatsapp.Text = row.Cells[3].Value?.ToString();
                mskTelefone.Text = row.Cells[4].Value?.ToString();
                mskCep.Text = row.Cells[5].Value?.ToString();
                txtLogradouro.Text = row.Cells[6].Value?.ToString();
                txtNumero.Text = row.Cells[7].Value?.ToString();
                txtBairro.Text = row.Cells[8].Value?.ToString();
                txtCidade.Text = row.Cells[9].Value?.ToString();
                txtEstado.Text = row.Cells[10].Value?.ToString();
            }
        }
    }
}
