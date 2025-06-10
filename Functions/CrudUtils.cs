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

            for (int i = 1; i < linhas.Count; i++) // Assume que há cabeçalho
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

        // ✅ Salva novo usuário no CSV
        public static bool SalvarUsuario(string usuario, string senha)
        {
            string caminhoArquivo = Path.Combine("Database", "usuarios.csv");

            try
            {
                // Cria o arquivo com cabeçalho se não existir
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
                        return false; // Usuário já existe
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

        // ✅ Carrega qualquer .csv em um DataTable
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
                    return i - linhaInicial; // Retorna o índice da linha no DataGridView (sem cabeçalho)
                }
            }

            return -1; // Não encontrado
        }

    }
}
