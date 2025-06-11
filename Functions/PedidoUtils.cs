using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace P2.Functions
{
    public static class PedidoUtils
    {
        private static string pedidosPath = @"Database\pedidos.csv";
        private static string itensPath = @"Database\itens_pedido.csv";

        public static void SalvarPedido(string codigoPedido, string cpf, string nomeCliente, List<ItemPedido> itens)
        {
            decimal valorTotal = itens.Sum(i => i.Subtotal);

            // Grava pedido
            using (StreamWriter sw = File.AppendText(pedidosPath))
                sw.WriteLine($"{codigoPedido};{cpf};{nomeCliente};{valorTotal}");

            // Grava itens
            using (StreamWriter sw = File.AppendText(itensPath))
            {
                foreach (var item in itens)
                {
                    sw.WriteLine($"{codigoPedido};{item.CodigoProduto};{item.NomeProduto};{item.Preco};{item.Quantidade};{item.Subtotal}");
                }
            }
        }
    }

    public class ItemPedido
    {
        public string CodigoProduto { get; set; }
        public string NomeProduto { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
        public decimal Subtotal => Preco * Quantidade;
    }
}
