using System;
using System.Data;
using System.Data.Common;
using MySql.Data.Common;
using MySql.Data.MySqlClient;

namespace VitalSignsDLL.DAL
{
    class ConexaoMySQL : IConexao
    {
        private string connString = "";
        private MySqlConnection connection;

        public ConnectionState AbrirConexao()
        {
            this.connection = new MySqlConnection(this.connString);
            this.connection.Open();
            return this.connection.State;
        }

        public DbDataReader ExecutarConsulta(string cmd)
        {
            throw new NotImplementedException();
        }

        public int ExecutarSemConsulta(string cmd)
        {
            throw new NotImplementedException();
        }

        public ConnectionState FecharConecao()
        {
            this.connection.Close();
            return this.connection.State;
        }
    }
}
