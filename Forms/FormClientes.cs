using System;
using System.Windows.Forms;
using ViaCep;
using System.Threading; // Essencial para usar o CancellationToken

namespace P2
{
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Seu código para o button1, se houver.
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                // Assume-se que os seus controles se chamam:
                // mskCep, txtLogradouro, txtBairro, txtCidade, txtEstado

                string cep = mskCep.Text.Replace("-", "").Trim();

                if (!string.IsNullOrWhiteSpace(cep))
                {
                    var viaCepClient = new ViaCepClient();

                    // CORREÇÃO APLICADA AQUI: Adicionado CancellationToken.None
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
    }
}