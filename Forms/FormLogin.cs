using System.Text;

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
            
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            string basePath = AppDomain.CurrentDomain.BaseDirectory;

            string usuariosPath = Path.Combine(basePath, "usuarios.csv");
            if (!File.Exists(usuariosPath))
            {
                File.WriteAllText(usuariosPath, "usuario,senha\nADMIN,123", Encoding.UTF8);
            }

            string clientesPath = Path.Combine(basePath, "clientes.csv");
            if (!File.Exists(clientesPath))
            {
                File.WriteAllText(clientesPath, "cpf,nome,email,cep,logradouro,numero,bairro,cidade,estado,telefone,whatsapp\n", Encoding.UTF8);
            }

            string produtosPath = Path.Combine(basePath, "produtos.csv");
            if (!File.Exists(produtosPath))
            {
                File.WriteAllText(produtosPath, "codigo,nome,preco,descricao\n", Encoding.UTF8);
            }

            string pedidosPath = Path.Combine(basePath, "pedidos.csv");
            if (!File.Exists(pedidosPath))
            {
                File.WriteAllText(pedidosPath, "codigo_pedido,cpf_cliente,total\n", Encoding.UTF8);
            }
        }
    }
}
