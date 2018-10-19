using System.Data;
using System.Data.Common;
using MySql.Data.MySqlClient;

namespace VitalSignsDLL.DAL
{
    public class ConexaoMySQL : IConexao
    {
        private string connString = "server=localhost;user id=root;database=testepim;persistsecurityinfo=True;password=;SslMode=None";
        private MySqlConnection connection;

        public ConnectionState AbrirConexao()
        {
            this.connection = new MySqlConnection(this.connString);
            this.connection.Open();
            return this.connection.State;
        }

        public DbDataReader ExecutarConsulta(string cmd)
        {
            MySqlCommand command = new MySqlCommand(cmd, this.connection);
            return command.ExecuteReader();
        }

        public int ExecutarSemConsulta(string cmd)
        {
            MySqlCommand command = new MySqlCommand(cmd, this.connection);
            return command.ExecuteNonQuery();
        }

        public ConnectionState FecharConecao()
        {
            this.connection.Close();
            return this.connection.State;
        }
    }
}
