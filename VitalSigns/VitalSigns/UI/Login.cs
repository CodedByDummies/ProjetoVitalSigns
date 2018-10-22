using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using VitalSignsDLL.BLL;
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
                string login = txtLogin.Text;
                string senha = txtSenha.Text;

                string sql = string.Format("SELECT idPerfil FROM usuarios where login = '{0}' and senha = '{1}'", login, senha);

                MySqlDataReader dataReader = (MySqlDataReader)conexao.ExecutarConsulta(sql);

                while (dataReader.Read())
                {
                    switch (dataReader[0])
                    {
                        case (int)Perfis.Administrador:
                            dataReader.Close();
                            conexao.FecharConexao();
                            this.Hide();
                            new frmLocalizarCliente(Perfis.Administrador).Show();
                            return;

                        case (int)Perfis.Gerente:
                            dataReader.Close();
                            conexao.FecharConexao();
                            this.Hide();
                            new frmLocalizarCliente(Perfis.Gerente).Show();
                            return;

                        case (int)Perfis.Atendente:
                            dataReader.Close();
                            conexao.FecharConexao();
                            this.Hide();
                            new frmLocalizarCliente(Perfis.Atendente).Show();
                            return;

                        case (int)Perfis.Tecnico_Alocado:
                            dataReader.Close();
                            conexao.FecharConexao();
                            this.Hide();
                            new frmLocalizarCliente(Perfis.Tecnico_Alocado).Show();
                            return;

                        case (int)Perfis.Técnico_Campo:
                            dataReader.Close();
                            conexao.FecharConexao();
                            this.Hide();
                            new frmLocalizarCliente(Perfis.Técnico_Campo).Show();
                            return;
                    }
                }

                dataReader.Close();
                conexao.FecharConexao();
                MessageBox.Show("Usuário não identificado", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
