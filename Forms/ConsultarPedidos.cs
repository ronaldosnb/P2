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
            lblTotal.Text = "R$ 0,00";
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
                    item.Tag = pedido.CodigoPedido; // Salva o código no Tag
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
            lblTotal.Text = "R$ 0,00";

            if (listPedidos.SelectedItems.Count > 0)
            {
                var selectedItem = listPedidos.SelectedItems[0];

                if (selectedItem.Tag is int codigo)
                {
                    var itens = PedidoUtils.BuscarItensDoPedido(codigo);
                    decimal total = 0;

                    foreach (var item in itens)
                    {
                        total += item.Subtotal;

                        var linha = new ListViewItem(item.NomeProduto);
                        linha.SubItems.Add(item.Quantidade.ToString());
                        linha.SubItems.Add(item.Subtotal.ToString("C2", CultureInfo.CurrentCulture));
                        listItens.Items.Add(linha);
                    }

                    lblTotal.Text = total.ToString("C2", CultureInfo.CurrentCulture);
                }
            }
        }
    }
}

