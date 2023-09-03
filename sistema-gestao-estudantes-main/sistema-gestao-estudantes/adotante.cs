using MySql.Data.MySqlClient;
using System;
using System.IO;

namespace sistema_gestao_estudantes
{
    internal class Adotante
    {
        public Adotante()
        {
        }

        internal static bool inserirAdotante(string nome, string sobrenome, DateTime nascimento, string telefone, string genero, string endereco, MemoryStream foto)
        {
            throw new NotImplementedException();
        }

        internal object pegarAdotante(MySqlCommand comando)
        {
            throw new NotImplementedException();
        }
    }
}