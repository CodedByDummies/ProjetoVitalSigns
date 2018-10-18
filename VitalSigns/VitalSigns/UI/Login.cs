using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.Common;
using System.Windows.Forms;
using VitalSignsDLL.DAL;

namespace VitalSigns.UI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            IConexao conexao = new ConexaoMySQL();
            if (conexao.AbrirConexao() == ConnectionState.Open)
            {

                Console.WriteLine("Conectou!!!");

                MySqlDataReader dataReader = (MySqlDataReader) conexao.ExecutarConsulta("select login from usuarios");

                while(dataReader.Read())
                {
                    Console.WriteLine(dataReader.GetString(0));
                }

                dataReader.Close();
                Console.WriteLine("Data Reader Closed!!!");
            }

            conexao.FecharConecao();
            Console.WriteLine("Conexão fechada!!!");
        }
    }
}
