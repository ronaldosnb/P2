using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;

namespace P2.Functions
{
    internal class CrudUtils
    {
        public static bool AtualizarRegistroCsv(string caminhoArquivo, string chave, string novaLinha, int indiceChave, bool temCabecalho = true)
        {
            if (!File.Exists(caminhoArquivo))
                return false;

            List<string> linhas = File.ReadAllLines(caminhoArquivo).ToList();
            bool atualizado = false;

            int linhaInicial = temCabecalho ? 1 : 0;

            for (int i = linhaInicial; i < linhas.Count; i++)
            {
                string[] partes = linhas[i].Split(';');

                if (indiceChave < partes.Length && partes[indiceChave].Equals(chave, StringComparison.OrdinalIgnoreCase))
                {
                    linhas[i] = novaLinha;
                    atualizado = true;
                    break;
                }
            }

            if (atualizado)
            {
                File.WriteAllLines(caminhoArquivo, linhas);
                return true;
            }

            return false;
        }

        public static bool AtualizarSenhaDireto(string usuario, string novaSenha)
        {
            string caminhoArquivo = Path.Combine("Database", "usuarios.csv");

            if (!File.Exists(caminhoArquivo))
                return false;

            List<string> linhas = File.ReadAllLines(caminhoArquivo).ToList();
            bool atualizado = false;

            for (int i = 1; i < linhas.Count; i++) 
            {
                string[] partes = linhas[i].Split(';');

                if (partes.Length >= 2 && partes[0].Equals(usuario, StringComparison.OrdinalIgnoreCase))
                {
                    linhas[i] = $"{usuario};{novaSenha}";
                    atualizado = true;
                    break;
                }
            }

            if (atualizado)
            {
                File.WriteAllLines(caminhoArquivo, linhas);
                return true;
            }

            return false;
        }

        public static bool SalvarUsuario(string usuario, string senha)
        {
            string caminhoArquivo = Path.Combine("Database", "usuarios.csv");

            try
            {
                if (!File.Exists(caminhoArquivo))
                {
                    Directory.CreateDirectory("Database");
                    File.WriteAllText(caminhoArquivo, "usuario;senha\n");
                }

                var linhas = File.ReadAllLines(caminhoArquivo);
                foreach (var linha in linhas.Skip(1))
                {
                    var partes = linha.Split(';');
                    if (partes.Length >= 1 && partes[0].Equals(usuario, StringComparison.OrdinalIgnoreCase))
                    {
                        return false; 
                    }
                }

                string novaLinha = $"{usuario};{senha}";
                File.AppendAllText(caminhoArquivo, novaLinha + Environment.NewLine);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao salvar usuário: " + ex.Message);
                return false;
            }
        }

        public static DataTable CarregarCsvComoDataTable(string caminhoArquivo, char separador = ';')
        {
            DataTable tabela = new DataTable();

            if (!File.Exists(caminhoArquivo))
                return tabela;

            string[] linhas = File.ReadAllLines(caminhoArquivo);

            if (linhas.Length == 0)
                return tabela;

            string[] colunas = linhas[0].Split(separador);
            foreach (string coluna in colunas)
            {
                tabela.Columns.Add(coluna.Trim());
            }

            for (int i = 1; i < linhas.Length; i++)
            {
                string[] dados = linhas[i].Split(separador);
                tabela.Rows.Add(dados);
            }

            return tabela;
        }
        public static int BuscarIndiceRegistro(string caminhoArquivo, string termoBusca, int indiceColuna = 0, bool temCabecalho = true)
        {
            if (!File.Exists(caminhoArquivo))
                return -1;

            var linhas = File.ReadAllLines(caminhoArquivo).ToList();
            int linhaInicial = temCabecalho ? 1 : 0;

            for (int i = linhaInicial; i < linhas.Count; i++)
            {
                string[] partes = linhas[i].Split(';');
                if (indiceColuna < partes.Length && partes[indiceColuna].Equals(termoBusca, StringComparison.OrdinalIgnoreCase))
                {
                    return i - linhaInicial;
                }
            }

            return -1;
        }
        public static bool ExcluirRegistroPorIdentificador(string caminhoArquivo, string identificador, int indiceColuna, bool temCabecalho = true)
        {
            if (!File.Exists(caminhoArquivo))
                return false;

            List<string> linhas = File.ReadAllLines(caminhoArquivo).ToList();
            int linhaInicial = temCabecalho ? 1 : 0;
            bool removido = false;

            for (int i = linhaInicial; i < linhas.Count; i++)
            {
                var partes = linhas[i].Split(';');
                if (indiceColuna < partes.Length && partes[indiceColuna].Equals(identificador, StringComparison.OrdinalIgnoreCase))
                {
                    linhas.RemoveAt(i);
                    removido = true;
                    break;
                }
            }

            if (removido)
            {
                File.WriteAllLines(caminhoArquivo, linhas);
                return true;
            }

            return false;
        }
        public static bool AtualizarCampoCsv(string caminhoArquivo, string identificador, int indiceIdentificador, int indiceCampoParaAtualizar, string novoValor, bool temCabecalho = true)
        {
            if (!File.Exists(caminhoArquivo))
                return false;

            List<string> linhas = File.ReadAllLines(caminhoArquivo).ToList();
            int linhaInicial = temCabecalho ? 1 : 0;
            bool atualizado = false;

            for (int i = linhaInicial; i < linhas.Count; i++)
            {
                var partes = linhas[i].Split(';');

                if (indiceIdentificador < partes.Length && partes[indiceIdentificador].Equals(identificador, StringComparison.OrdinalIgnoreCase))
                {
                    if (indiceCampoParaAtualizar < partes.Length)
                    {
                        partes[indiceCampoParaAtualizar] = novoValor;
                        linhas[i] = string.Join(";", partes);
                        atualizado = true;
                        break;
                    }
                }
            }

            if (atualizado)
            {
                File.WriteAllLines(caminhoArquivo, linhas);
                return true;
            }

            return false;
        }

        private static string caminhoPasta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Database");
        private static string caminhoArquivo = Path.Combine(caminhoPasta, "clientes.csv");

        public static void CadastrarCliente(
            string nome, string cpf, string email, string whatsapp, string telefone,
            string cep, string logradouro, string numero, string bairro,
            string cidade, string estado)
        {
            try
            {
                if (!Directory.Exists(caminhoPasta))
                    Directory.CreateDirectory(caminhoPasta);

                if (!File.Exists(caminhoArquivo))
                {
                    using (StreamWriter sw = File.CreateText(caminhoArquivo))
                    {
                        sw.WriteLine("Nome;CPF;Email;WhatsApp;Telefone;CEP;Logradouro;Número;Bairro;Cidade;Estado");
                    }
                }

                using (StreamWriter sw = File.AppendText(caminhoArquivo))
                {
                    sw.WriteLine($"{nome};{cpf};{email};{whatsapp};{telefone};{cep};{logradouro};{numero};{bairro};{cidade};{estado}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao cadastrar cliente: " + ex.Message);
            }
        }

        public static DataTable ListarClientes()
        {
            DataTable tabela = new DataTable();

            try
            {
                string caminhoPasta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Database");
                string caminhoArquivo = Path.Combine(caminhoPasta, "clientes.csv");

                if (!File.Exists(caminhoArquivo))
                    return tabela;

                using (StreamReader sr = new StreamReader(caminhoArquivo))
                {
                    bool primeiraLinha = true;
                    int colunasEsperadas = 0;

                    while (!sr.EndOfStream)
                    {
                        string linha = sr.ReadLine();
                        string[] campos = linha.Split(';');

                        if (primeiraLinha)
                        {
                            foreach (string coluna in campos)
                            {
                                tabela.Columns.Add(coluna);
                            }
                            colunasEsperadas = campos.Length;
                            primeiraLinha = false;
                        }
                        else
                        {
                            if (campos.Length == colunasEsperadas)
                            {
                                tabela.Rows.Add(campos);
                            }
                            else
                            {
                                // pula linha com número incorreto de campos
                                continue;
                            }
                        }
                    }
                }

                return tabela;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao listar clientes: " + ex.Message);
            }
        }

        public static void ExcluirCliente(string cpf)
        {
            string caminhoPasta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Database");
            string caminhoArquivo = Path.Combine(caminhoPasta, "clientes.csv");

            if (!File.Exists(caminhoArquivo))
                throw new FileNotFoundException("Arquivo de clientes não encontrado.");

            var linhas = File.ReadAllLines(caminhoArquivo).ToList();
            if (linhas.Count <= 1)
                return;

            // Cabeçalho
            var cabecalho = linhas[0];
            linhas.RemoveAt(0); // Remove o cabeçalho da lista temporariamente

            // Remove a linha onde o CPF for igual
            var novaLista = linhas.Where(l => !l.Split(';')[1].Equals(cpf)).ToList(); // índice 1 é o CPF

            // Adiciona o cabeçalho de volta e salva
            novaLista.Insert(0, cabecalho);
            File.WriteAllLines(caminhoArquivo, novaLista);
        }
        public static void AtualizarCliente(
        string cpf,
        string nome,
        string email,
        string whatsapp,
        string telefone,
        string cep,
        string logradouro,
        string numero,
        string bairro,
        string cidade,
        string estado)
        {
            string caminhoPasta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Database");
            string caminhoArquivo = Path.Combine(caminhoPasta, "clientes.csv");

            if (!File.Exists(caminhoArquivo))
                throw new FileNotFoundException("Arquivo de clientes não encontrado.");

            var linhas = File.ReadAllLines(caminhoArquivo).ToList();
            if (linhas.Count <= 1)
                throw new Exception("Nenhum cliente encontrado.");

            var cabecalho = linhas[0];
            linhas.RemoveAt(0);

            for (int i = 0; i < linhas.Count; i++)
            {
                string[] campos = linhas[i].Split(';');

                if (campos.Length > 1 && campos[1] == cpf)
                {
                    linhas[i] = string.Join(";", new string[]
                    {
                nome, cpf, email, whatsapp, telefone,
                cep, logradouro, numero, bairro, cidade, estado
                    });
                    break;
                }
            }

            linhas.Insert(0, cabecalho);
            File.WriteAllLines(caminhoArquivo, linhas);
        }
        public static void CadastrarProduto(string codigo, string nome, string preco, string descricao)
        {
            string pasta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Database");
            string caminho = Path.Combine(pasta, "produtos.csv");

            if (!Directory.Exists(pasta))
                Directory.CreateDirectory(pasta);

            bool novoArquivo = !File.Exists(caminho);

            using (StreamWriter writer = new StreamWriter(caminho, true))
            {
                if (novoArquivo)
                {
                    writer.WriteLine("Codigo;Nome;Preco;Descricao");
                }

                writer.WriteLine($"{codigo};{nome};{preco};{descricao}");
            }
        }
        public static bool ProdutoJaExiste(string codigo)
        {
            string caminho = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Database", "produtos.csv");

            if (!File.Exists(caminho))
                return false;

            var linhas = File.ReadAllLines(caminho).Skip(1); // Pula o cabeçalho

            foreach (var linha in linhas)
            {
                var dados = linha.Split(';');
                if (dados.Length > 0 && dados[0] == codigo)
                {
                    return true;
                }
            }

            return false;
        }

        public static DataTable CarregarProdutos()
        {
            string caminho = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Database", "produtos.csv");
            DataTable tabela = new DataTable();

            tabela.Columns.Add("Codigo");
            tabela.Columns.Add("Nome");
            tabela.Columns.Add("Preco");
            tabela.Columns.Add("Descricao");

            if (!File.Exists(caminho))
                return tabela;

            var linhas = File.ReadAllLines(caminho);

            // Pula o cabeçalho
            foreach (var linha in linhas.Skip(1))
            {
                var dados = linha.Split(';');

                if (dados.Length >= 4)
                {
                    tabela.Rows.Add(dados[0], dados[1], dados[2], dados[3]);
                }
            }

            return tabela;
        }

        public static void ExcluirProduto(string codigo)
        {
            string caminho = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Database", "produtos.csv");

            if (!File.Exists(caminho))
                throw new FileNotFoundException("Arquivo de produtos não encontrado.");

            var linhas = File.ReadAllLines(caminho).ToList();
            if (linhas.Count <= 1)
                return; // Só tem cabeçalho

            // Mantém cabeçalho
            var novasLinhas = new List<string> { linhas[0] };

            foreach (var linha in linhas.Skip(1))
            {
                var dados = linha.Split(';');
                if (dados.Length >= 1 && dados[0] != codigo)
                {
                    novasLinhas.Add(linha);
                }
            }

            File.WriteAllLines(caminho, novasLinhas);
        }

        public static void AtualizarProduto(string codigo, string novoNome, string novoPreco, string novaDescricao)
        {
            string caminho = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Database", "produtos.csv");

            if (!File.Exists(caminho))
                throw new FileNotFoundException("Arquivo de produtos não encontrado.");

            var linhas = File.ReadAllLines(caminho).ToList();
            var novasLinhas = new List<string> { linhas[0] };

            foreach (var linha in linhas.Skip(1))
            {
                var dados = linha.Split(';');

                if (dados.Length >= 4 && dados[0] == codigo)
                {
                    // Substitui pelos novos dados
                    string novaLinha = $"{codigo};{novoNome};{novoPreco};{novaDescricao}";
                    novasLinhas.Add(novaLinha);
                }
                else
                {
                    novasLinhas.Add(linha);
                }
            }

            File.WriteAllLines(caminho, novasLinhas);
        }


    }
}
