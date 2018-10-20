using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VitalSignsDLL.DAL;
using VitalSignsDLL.BLL;
using System.Data;

namespace VitalSignsWeb.UI
{
    public partial class TelaLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEntrar(object sender, EventArgs e)
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
                    /*switch (dataReader[0])
                    {
                        case (int)Perfis.Administrador:*/
                            dataReader.Close();
                            conexao.FecharConecao();
                            this.Hide();
                            Response.Redirect("~/Localizar Cliente.aspx");
                            return;

                        /*case (int)Perfis.Gerente:
                            dataReader.Close();
                            conexao.FecharConecao();
                            this.Hide();
                            Response.Redirect("~/Localizar Cliente.aspx");
                            return;

                        case (int)Perfis.Atendente:
                            dataReader.Close();
                            conexao.FecharConecao();
                            this.Hide();
                            Response.Redirect("~/Localizar Cliente.aspx");
                            return;

                        case (int)Perfis.Tecnico_Alocado:
                            dataReader.Close();
                            conexao.FecharConecao();
                            this.Hide();
                            Response.Redirect("~/Localizar Cliente.aspx");
                            return;

                        case (int)Perfis.Técnico_Campo:
                            dataReader.Close();
                            conexao.FecharConecao();
                            this.Hide();
                            Response.Redirect("~/Localizar Cliente.aspx");
                            return;
                        default:
                            break;
                    }*/
                }

                dataReader.Close();
                conexao.FecharConecao();
                //MessageBox.Show("Usuário não identificado", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Hide()
        {
            throw new NotImplementedException();
        }
    }

}