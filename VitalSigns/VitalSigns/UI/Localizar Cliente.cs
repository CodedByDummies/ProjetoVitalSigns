using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VitalSignsDLL.BLL;
using VitalSignsDLL.DAL;

namespace VitalSigns.UI
{
    public partial class frmLocalizarCliente : Form
    {
        public frmLocalizarCliente(Perfis perfil)
        {
            InitializeComponent();

            switch (perfil)
            {
                case Perfis.Administrador:
                    btnCriarPerfil.Visible = true;
                    break;
            }
        }

        private void frmLocalizarCliente_Load(object sender, EventArgs e)
        {

        }

        private void frmLocalizarCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void frmLocalizarCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            // DialogResult dr = MessageBox.Show("Deseja sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            IConexao conexao = new ConexaoMySQL();

            if (conexao.AbrirConexao() == ConnectionState.Open)
            {
                string cpf_cnpj = txtLocalizadorCliente.Text;
                string sql = string.Format("SELECT cpf_cnpj,nome,telefone,e_mail,endereco_cep FROM clientes where cpf_cnpj = '{0}'", cpf_cnpj);
                MySqlDataReader dataReader = (MySqlDataReader)conexao.ExecutarConsulta(sql);

                while (dataReader.Read())
                {
                    Console.WriteLine(dataReader[0] + " | "+ dataReader[1] + " | "+ dataReader[2] + " | " + dataReader [3] + " | " + dataReader[4]);
                }
                dataReader.Close();
                conexao.FecharConecao();
               // MessageBox.Show("Cliente não localizado", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
