using System.Data;
using System.Data.Common;
using MySql.Data.MySqlClient;

namespace VitalSignsDLL.DAL
{
    public class ConexaoMySQL : IConexao
    {
        //#Etecia238#
        //deadrifter@85
        
        private string connString = "server=localhost;user id=root;database=testepim;persistsecurityinfo=True;password=#Etecia238#;SslMode=None";
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

        public ConnectionState FecharConexao()
        {
            this.connection.Close();
            return this.connection.State;
        }
    }
}
