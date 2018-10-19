using MySql.Data.MySqlClient;
using System;
using System.Data;
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
            LimparGridView();

            IConexao conexao = new ConexaoMySQL();

            if (conexao.AbrirConexao() == ConnectionState.Open)
            {
                string cpf_cnpj = txtLocalizadorCliente.Text;
                string sql = string.Format("SELECT cpf_cnpj,nome,telefone,e_mail,endereco_cep FROM clientes where cpf_cnpj = '{0}'", cpf_cnpj);
                MySqlDataReader dataReader = (MySqlDataReader)conexao.ExecutarConsulta(sql);

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Clientes cliente = new Clientes();
                        cliente.CPF_CNPJ = dataReader[0].ToString();
                        cliente.Nome = dataReader[1].ToString();
                        cliente.Telefone = dataReader[2].ToString();
                        cliente.E_mail = dataReader[3].ToString();
                        cliente.CEP = dataReader[4].ToString();
                        dgwViewChamados.Rows.Add(new object[] {cliente.CPF_CNPJ, cliente.Nome, cliente.Telefone, cliente.E_mail, cliente.CEP });
                    }
                    dataReader.Close();
                    conexao.FecharConecao();
                    return;
                }
                dataReader.Close();
                conexao.FecharConecao();
                MessageBox.Show("Cliente não localizado", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
        }

        private void LimparGridView()
        {
            dgwViewChamados.Rows.Clear();
        }
    }
}
