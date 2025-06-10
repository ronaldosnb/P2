using System;
using System.IO;

namespace P2.Functions
{
    internal class LoginUtils
    {
        private static string pastaDatabase = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Database");
        private static string caminhoUsuarios = Path.Combine(pastaDatabase, "usuarios.csv");

        public static bool VerificarCredenciais(string usuario, string senha)
        {
            if (!File.Exists(caminhoUsuarios))
                return false;

            var linhas = File.ReadAllLines(caminhoUsuarios);

            foreach (var linha in linhas)
            {
                if (linha.StartsWith("Usuario"))
                    continue;

                var partes = linha.Split(';');
                if (partes.Length < 2)
                    continue;

                string usuarioArq = partes[0];
                string senhaArq = partes[1];

                if (usuarioArq.Equals(usuario, StringComparison.OrdinalIgnoreCase) && senhaArq == senha)
                    return true;
            }

            return false;
        }
    }
}
