using System;
using System.IO;

namespace P2.Functions
{
    internal class CsvUtils
    {
        public static void VerificarOuCriarArquivosCsv()
        {
            string diretorioExecucao = AppDomain.CurrentDomain.BaseDirectory;

            string pastaDatabase = Path.Combine(diretorioExecucao, "Database");

            if (!Directory.Exists(pastaDatabase))
            {
                Directory.CreateDirectory(pastaDatabase);
            }

            string[] arquivos = {
                "usuarios.csv",
                "clientes.csv",
                "produtos.csv",
                "pedidos.csv",
                "itens_pedido.csv"
            };

            foreach (string nomeArquivo in arquivos)
            {
                string caminho = Path.Combine(pastaDatabase, nomeArquivo);

                if (!File.Exists(caminho))
                {
                    using (StreamWriter sw = new StreamWriter(caminho))
                    {
                        switch (nomeArquivo)
                        {
                            case "usuarios.csv":
                                sw.WriteLine("Usuario;Senha");
                                sw.WriteLine("ADMIN;123");
                                break;
                            case "clientes.csv":
                                sw.WriteLine("Nome;CPF;Email;CEP;Logradouro;Numero;Bairro;Cidade;Estado;Telefone;WhatsApp");
                                break;
                            case "produtos.csv":
                                sw.WriteLine("Codigo;Nome;Preco;Descricao");
                                break;
                            case "pedidos.csv":
                                sw.WriteLine("CodigoPedido;CpfCliente;Data;Total");
                                break;
                            case "itens_pedido.csv":
                                sw.WriteLine("CodigoPedido;CodigoProduto;Quantidade;PrecoUnitario;Subtotal");
                                break;
                        }
                    }
                }
            }
        }
    }
}

