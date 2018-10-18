
using MySql.Data.MySqlClient;
using System;
using System.Data;
using VitalSignsDLL.DAL;

namespace VitalSignsDLL.BLL
{
    class TestDataBase
    {
        public static void Main(string[] args)
        {
            IConexao conexao = new ConexaoMySQL();
            if (conexao.AbrirConexao() == ConnectionState.Open)
            {
                MySqlDataReader dataReader = (MySqlDataReader)conexao.ExecutarConsulta("select cpf_cnpj, nome, telefone, e_mail, endereco_cep from clientes");


                while (dataReader.Read())
                {
                    Console.WriteLine(dataReader.GetString(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4));
                }

                dataReader.Close();

            }

            conexao.FecharConecao();
        }
    }
}
