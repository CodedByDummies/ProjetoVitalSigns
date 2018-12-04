using System.Data;
using System.Data.Common;
using System.Windows.Forms;
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
            try
            {
                this.connection = new MySqlConnection(this.connString);
                this.connection.Open();
            }
            catch (MySqlException e)
            {
                // The two most common error numbers when connecting are as follows: 
                // 0: Cannot connect to server. 
                // 1045: Invalid user name, user password, or both.
                // See: https://dev.mysql.com/doc/connector-net/en/connector-net-programming-connecting-errors.html
                switch (e.Number)
                {
                    case 0:
                        MessageBox.Show("Não é possível conectar-se ao servidor. Contate o Administrador", e.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case 1045:
                        MessageBox.Show("Nome de usuário / senha inválidos, por favor, tente novamente", e.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    default:
                        MessageBox.Show(e.Message, e.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }

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
