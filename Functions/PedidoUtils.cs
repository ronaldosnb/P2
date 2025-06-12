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
                sw.WriteLine($"{codigoPedido};{cpf};{nomeCliente};{valorTotal.ToString(CultureInfo.InvariantCulture)}");

            using (StreamWriter sw = File.AppendText(itensPath))
            {
                foreach (var item in itens)
                {
                    sw.WriteLine($"{codigoPedido};{item.CodigoProduto};{item.NomeProduto};{item.Preco.ToString(CultureInfo.InvariantCulture)};{item.Quantidade};{item.Subtotal.ToString(CultureInfo.InvariantCulture)}");
                }
            }
        }

        public static List<Pedido> CarregarPedidos()
        {
            var listaPedidos = new List<Pedido>();

            if (!File.Exists(pedidosPath))
                return listaPedidos;

            var linhas = File.ReadAllLines(pedidosPath).Skip(1); 

            foreach (var linha in linhas)
            {
                var colunas = linha.Split(';');

                if (colunas.Length >= 4 &&
                    int.TryParse(colunas[0], out int codigo) &&
                    decimal.TryParse(colunas[3], NumberStyles.Any, CultureInfo.InvariantCulture, out decimal total))
                {
                    listaPedidos.Add(new Pedido
                    {
                        CodigoPedido = codigo,
                        CPFCliente = colunas[1],
                        NomeCliente = colunas[2],
                        ValorTotal = total
                    });
                }
            }

            return listaPedidos;
        }

        public static void ExcluirPedido(int codigoPedido)
        {
            // Remove do pedidos.csv (preserva cabeçalho)
            var linhasPedidos = File.ReadAllLines(pedidosPath).ToList();
            var cabecalho = linhasPedidos.First();
            var novasLinhas = linhasPedidos
                .Skip(1)
                .Where(l => !l.StartsWith(codigoPedido + ";"))
                .ToList();
            novasLinhas.Insert(0, cabecalho);
            File.WriteAllLines(pedidosPath, novasLinhas);

            // Remove os itens do itens_pedido.csv (não tem cabeçalho)
            var linhasItens = File.ReadAllLines(itensPath).ToList();
            linhasItens = linhasItens
                .Where(l => !l.StartsWith(codigoPedido + ";"))
                .ToList();
            File.WriteAllLines(itensPath, linhasItens);
        }

        public static List<Pedido> BuscarPedidosPorCpf(string cpf)
        {
            var pedidos = new List<Pedido>();

            if (!File.Exists(pedidosPath))
                return pedidos;

            var linhas = File.ReadAllLines(pedidosPath).Skip(1); // pular cabeçalho

            foreach (var linha in linhas)
            {
                var col = linha.Split(';');
                if (col.Length >= 4 && col[1] == cpf)
                {
                    pedidos.Add(new Pedido
                    {
                        CodigoPedido = int.Parse(col[0]),
                        CPFCliente = col[1],
                        NomeCliente = col[2],
                        ValorTotal = decimal.Parse(col[3], CultureInfo.InvariantCulture)
                    });
                }
            }

            return pedidos;
        }

        public static List<ItemPedido> BuscarItensDoPedido(int codigoPedido)
        {
            var itens = new List<ItemPedido>();

            if (!File.Exists(itensPath))
                return itens;

            var linhas = File.ReadAllLines(itensPath);

            foreach (var linha in linhas)
            {
                var col = linha.Split(';');
                if (col.Length >= 6 && int.TryParse(col[0], out int codigo) && codigo == codigoPedido)
                {
                    if (decimal.TryParse(col[3], NumberStyles.Any, CultureInfo.InvariantCulture, out decimal preco) &&
                        int.TryParse(col[4], out int qtd))
                    {
                        itens.Add(new ItemPedido
                        {
                            CodigoProduto = col[1],
                            NomeProduto = col[2],
                            Preco = preco,
                            Quantidade = qtd
                        });
                    }
                }
            }

            return itens;
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
