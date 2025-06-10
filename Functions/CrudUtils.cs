using System;
using System.Collections.Generic;
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
    }
}
