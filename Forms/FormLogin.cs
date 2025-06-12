using System.Text;
using P2.Functions;
using static P2.FormPrincipal;

namespace P2
{
    public partial class FormLogin : System.Windows.Forms.Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string senha = txtSenha.Text;

            bool acessoLiberado = LoginUtils.VerificarCredenciais(usuario, senha);

            if (acessoLiberado)
            {
                MessageBox.Show("Login realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Sessao.UsuarioLogado = txtUsuario.Text.Trim();

                FormPrincipal formPrincipal = new FormPrincipal(usuario);
                formPrincipal.Show();
                
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            CsvUtils.VerificarOuCriarArquivosCsv();
        }
    }
}
