using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using P2.Functions;

namespace P2
{
    public partial class FormPedidos : Form
    {
        private List<ItemPedido> itens = new List<ItemPedido>();
        private string nomeCliente = "";

        public FormPedidos()
        {
            InitializeComponent();
        }

        private void AtualizarGridProdutos()
        {
            try
            {
                dataProdutos.DataSource = CrudUtils.CarregarProdutos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar produtos: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void FormPedidos_Load(object sender, EventArgs e)
        {
            AtualizarGridProdutos();
            CarregarDadosPedidos();

        }
        private void CarregarDadosPedidos()
        {
            dataPedidos.AutoGenerateColumns = true;
            dataPedidos.DataSource = PedidoUtils.CarregarPedidos();
        }
        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            string cpf = mskCpf.Text.Trim();
            string path = @"Database\clientes.csv";

            var linhas = File.ReadAllLines(path);
            foreach (var linha in linhas)
            {
                var dados = linha.Split(';');
                if (dados[1] == cpf)
                {
                    nomeCliente = dados[0];
                    lblNomeCliente.Text = nomeCliente;
                    return;
                }
            } 

            MessageBox.Show("Cliente não encontrado.");
        }

        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            string codigoProduto = txtCodigoProduto.Text.Trim();
            string path = @"Database\produtos.csv";
            int quantidade;

            if (!int.TryParse(txtQuantidade.Text.Trim(), out quantidade) || quantidade <= 0)
            {
                MessageBox.Show("Quantidade inválida.");
                return;
            }

            var linhas = File.ReadAllLines(path);
            foreach (var linha in linhas)
            {
                var dados = linha.Split(';');
                if (dados[0] == codigoProduto)
                {
                    string nome = dados[1];
                    decimal preco;

                    if (!decimal.TryParse(dados[2], out preco))
                    {
                        MessageBox.Show("Preço inválido no produto.");
                        return;
                    }

                    if (itens.Any(i => i.CodigoProduto == codigoProduto))
                    {
                        MessageBox.Show("Produto já adicionado ao pedido.");
                        return;
                    }

                    var item = new ItemPedido
                    {
                        CodigoProduto = codigoProduto,
                        NomeProduto = nome,
                        Preco = preco,
                        Quantidade = quantidade
                    };

                    itens.Add(item);
                    AtualizarGrid();
                    txtCodigoProduto.Clear();
                    txtQuantidade.Clear();
                    return;
                }
            }

            MessageBox.Show("Produto não encontrado.");
        }

        private void AtualizarGrid()
        {
            dataGridItens.DataSource = null;
            dataGridItens.DataSource = itens.Select(i => new
            {
                i.CodigoProduto,
                i.NomeProduto,
                i.Preco,
                i.Quantidade,
                Subtotal = i.Subtotal
            }).ToList();

            lblTotalPedido.Text = $"Total: R$ {itens.Sum(i => i.Subtotal):0.00}";
        }

        private void btnGravarPedido_Click(object sender, EventArgs e)
        {
            string codigoPedido = txtCodigoPedido.Text.Trim();
            string cpf = mskCpf.Text.Trim();

            if (string.IsNullOrWhiteSpace(codigoPedido) || string.IsNullOrWhiteSpace(cpf) || itens.Count == 0)
            {
                MessageBox.Show("Preencha todos os campos e adicione ao menos um produto.");
                return;
            }

            if (File.Exists("Database/pedidos.csv"))
            {
                var jaExiste = File.ReadLines("Database/pedidos.csv")
                                   .Any(l => l.Split(';')[0] == codigoPedido);
                if (jaExiste)
                {
                    MessageBox.Show("Código do pedido já existente.");
                    return;
                }
            }

            PedidoUtils.SalvarPedido(codigoPedido, cpf, nomeCliente, itens);
            MessageBox.Show("Pedido salvo com sucesso!");
            LimparCampos();
            CarregarDadosPedidos();

        }

        private void LimparCampos()
        {
            txtCodigoPedido.Clear();
            mskCpf.Clear();
            txtCodigoProduto.Clear();
            txtQuantidade.Clear();
            lblNomeCliente.Text = "";
            lblTotalPedido.Text = "Total: R$ 0,00";
            itens.Clear();
            dataGridItens.DataSource = null;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataPedidos.CurrentRow != null)
            {
                int codigoPedido = Convert.ToInt32(dataPedidos.CurrentRow.Cells["CodigoPedido"].Value);

                var confirmar = MessageBox.Show($"Deseja realmente excluir o pedido {codigoPedido}?", "Confirmação", MessageBoxButtons.YesNo);
                if (confirmar == DialogResult.Yes)
                {
                    PedidoUtils.ExcluirPedido(codigoPedido);
                    CarregarDadosPedidos();
                    MessageBox.Show("Pedido excluído com sucesso!");
                }
            }
            else
            {
                MessageBox.Show("Selecione um pedido para excluir.");
            }
        }

        private void lblNomeCliente_Click(object sender, EventArgs e)
        {

        }

        private void pedido_Click(object sender, EventArgs e)
        {

        }
    }
}
