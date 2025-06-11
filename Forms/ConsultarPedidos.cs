using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using P2.Functions; // Importa as classes Pedido, ItemPedido e PedidoUtils

namespace P2
{
    public partial class ConsultarPedidos : Form
    {
        private List<Pedido> pedidosCliente = new List<Pedido>();

        public ConsultarPedidos()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string cpf = mskCpf.Text.Trim();

            // Limpa os campos
            lblNome.Text = "";
            listPedidos.Items.Clear();
            listItens.Items.Clear();

            // Busca pedidos pelo CPF
            pedidosCliente = PedidoUtils.BuscarPedidosPorCpf(cpf);

            if (pedidosCliente.Count > 0)
            {
                // Exibe nome do cliente (assumindo que todos os pedidos têm o mesmo nome)
                lblNome.Text = pedidosCliente[0].NomeCliente;

                // Exibe pedidos no ListView
                foreach (var pedido in pedidosCliente)
                {
                    var item = new ListViewItem(pedido.CodigoPedido.ToString());
                    item.SubItems.Add(pedido.ValorTotal.ToString("C2", CultureInfo.CurrentCulture));
                    listPedidos.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("Nenhum pedido encontrado para este CPF.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void listPedidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            listItens.Items.Clear();

            if (listPedidos.SelectedItems.Count > 0)
            {
                int codigo = int.Parse(listPedidos.SelectedItems[0].Text);

                var itens = PedidoUtils.BuscarItensDoPedido(codigo);

                foreach (var item in itens)
                {
                    var linha = new ListViewItem(item.NomeProduto);
                    linha.SubItems.Add(item.Quantidade.ToString());
                    linha.SubItems.Add(item.Subtotal.ToString("C2", CultureInfo.CurrentCulture));
                    listItens.Items.Add(linha);
                }
            }
        }
    }
}

