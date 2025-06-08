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
            FormPrincipal tela = new FormPrincipal();
            tela.Show();
        }

    }
}
