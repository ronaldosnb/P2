using System;
using System.Data;
using System.Windows.Forms;
using P2.Functions;

namespace P2
{
    public partial class FormUsuarios : Form
    {
        public FormUsuarios()
        {
            InitializeComponent();
            CarregarUsuarios();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string usuario = txtNovoUsuario.Text.Trim();
            string senha = txtNovaSenha.Text.Trim();

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Por favor, preencha usuário e senha.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool sucesso = CrudUtils.SalvarUsuario(usuario, senha);

            if (sucesso)
            {
                MessageBox.Show("Usuário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNovoUsuario.Clear();
                txtNovaSenha.Clear();
                CarregarUsuarios();
            }
            else
            {
                MessageBox.Show("Usuário já existe ou ocorreu um erro ao salvar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarUsuarios()
        {
            string caminho = System.IO.Path.Combine("Database", "usuarios.csv");
            DataTable tabela = CrudUtils.CarregarCsvComoDataTable(caminho);

            dataUsuarios.DataSource = tabela;
            dataUsuarios.ClearSelection();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string termoBusca = txtBuscar.Text.Trim();

            if (string.IsNullOrEmpty(termoBusca))
            {
                MessageBox.Show("Digite um nome de usuário para buscar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string caminhoArquivo = Path.Combine("Database", "usuarios.csv");
            int indiceEncontrado = CrudUtils.BuscarIndiceRegistro(caminhoArquivo, termoBusca, 0);

            if (indiceEncontrado >= 0 && indiceEncontrado < dataUsuarios.Rows.Count)
            {
                dataUsuarios.ClearSelection();
                dataUsuarios.Rows[indiceEncontrado].Selected = true;
                dataUsuarios.FirstDisplayedScrollingRowIndex = indiceEncontrado;
            }
            else
            {
                MessageBox.Show("Usuário não encontrado.", "Resultado da Busca", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataUsuarios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um usuário para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var linhaSelecionada = dataUsuarios.SelectedRows[0];
            string usuarioSelecionado = linhaSelecionada.Cells[0].Value.ToString();

            if (usuarioSelecionado.Equals("ADMIN", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("O usuário ADMIN não pode ser excluído.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmar = MessageBox.Show($"Deseja realmente excluir o usuário '{usuarioSelecionado}'?", "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmar == DialogResult.Yes)
            {
                string caminhoArquivo = Path.Combine("Database", "usuarios.csv");
                bool sucesso = CrudUtils.ExcluirRegistroPorIdentificador(caminhoArquivo, usuarioSelecionado, 0); // Coluna 0 = usuário

                if (sucesso)
                {
                    MessageBox.Show("Usuário excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarUsuarios(); // Atualiza o DataGridView (crie essa função se ainda não tiver)
                }
                else
                {
                    MessageBox.Show("Erro ao excluir o usuário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
