using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Globalization;

namespace P2.Functions
{
    public static class PedidoUtils
    {
        private static string pedidosPath = @"Database\pedidos.csv";
        private static string itensPath = @"Database\itens_pedido.csv";

        public static void SalvarPedido(string codigoPedido, string cpf, string nomeCliente, List<ItemPedido> itens)
        {
            decimal valorTotal = itens.Sum(i => i.Subtotal);

            using (StreamWriter sw = File.AppendText(pedidosPath))
                sw.WriteLine($"{codigoPedido};{cpf};{nomeCliente};{valorTotal}");

            using (StreamWriter sw = File.AppendText(itensPath))
            {
                foreach (var item in itens)
                {
                    sw.WriteLine($"{codigoPedido};{item.CodigoProduto};{item.NomeProduto};{item.Preco};{item.Quantidade};{item.Subtotal}");
                }
            }
        }

        public static List<Pedido> CarregarPedidos()
        {
            var listaPedidos = new List<Pedido>();

            if (!File.Exists(pedidosPath))
                return listaPedidos;

            var linhas = File.ReadAllLines(pedidosPath);

            for (int i = 1; i < linhas.Length; i++) // pula cabeçalho
            {
                var colunas = linhas[i].Split(';');

                if (colunas.Length >= 4 &&
                    int.TryParse(colunas[0], out int codigo) &&
                    decimal.TryParse(colunas[3], NumberStyles.Any, CultureInfo.InvariantCulture, out decimal total))
                {
                    var pedido = new Pedido
                    {
                        CodigoPedido = codigo,
                        CPFCliente = colunas[1],
                        NomeCliente = colunas[2],
                        ValorTotal = total
                    };

                    listaPedidos.Add(pedido);
                }
            }

            return listaPedidos;
        }
        public static void ExcluirPedido(int codigoPedido)
        {
            // Remove do pedidos.csv
            var linhasPedidos = File.ReadAllLines(pedidosPath).ToList();
            linhasPedidos = linhasPedidos
                .Where(l => !l.StartsWith(codigoPedido + ";"))
                .ToList();
            File.WriteAllLines(pedidosPath, linhasPedidos);

            // Remove os itens do itens_pedido.csv
            var linhasItens = File.ReadAllLines(itensPath).ToList();
            linhasItens = linhasItens
                .Where(l => !l.StartsWith(codigoPedido + ";"))
                .ToList();
            File.WriteAllLines(itensPath, linhasItens);
        }



    }
    public class Pedido
    {
        public int CodigoPedido { get; set; }
        public string CPFCliente { get; set; }
        public string NomeCliente { get; set; }
        public decimal ValorTotal { get; set; }
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
