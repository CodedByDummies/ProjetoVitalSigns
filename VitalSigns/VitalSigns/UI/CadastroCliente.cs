using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using VitalSignsDLL.BLL;
using VitalSignsDLL.DAL;

namespace VitalSigns.UI
{
    public partial class frmCadastroCliente : Form
    {
        private List<Cidades> cidades;

        public frmCadastroCliente()
        {
            InitializeComponent();
        }

        private void frmCadastroCliente_Load(object sender, EventArgs e)
        {
            ListarEstados();
        }

        private void btnSalvarCadastroCliente_Click(object sender, EventArgs e)
        {
            IConexao conexao = new ConexaoMySQL();
            if (conexao.AbrirConexao() == ConnectionState.Open)
            {
                string cep = TxtCepCadastro.Text;
                string bairro = txtBairroCadastro.Text;
                string logradouro = txtLougradouroCadastro.Text;
                int num = int.Parse(txtNumeroCadastro.Text);
                string complemento = txtComplementoCadastro.Text;
                long idCidade = this.cidades[cbCidadeCadastro.SelectedIndex].IdCidades;

                string insertEndereco = string.Format("insert into Enderecos values ('{0}', '{1}', '{2}', {3}, '{4}', {5})",
                    cep, bairro, logradouro, num, complemento, idCidade);

                int insertEnderecoRowsAffected = conexao.ExecutarSemConsulta(insertEndereco);

                if (insertEnderecoRowsAffected > 0)
                {
                    string cpf_cnpj = txtCpfCadastro.Text;
                    string nome = txtNomeCadastro.Text;
                    string tel = mtxtTelefoneCadastro.Text;
                    string e_mail = txtEmailCadastro.Text;
                    string insertCliente = string.Format("insert into Clientes values ('{0}', '{1}', '{2}', '{3}', '{4}')", cpf_cnpj, nome, tel, e_mail, cep);

                    int insertClienteRowsAffected = conexao.ExecutarSemConsulta(insertCliente);

                    if (insertClienteRowsAffected > 0)
                    {
                        MessageBox.Show("Cliente cadastrado!", "Cliente Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Cliente não cadastrado", "Cadastrar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Endereço não cadastrado", "Cadastrar Endereço", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                conexao.FecharConexao();
            }
            else
            {
                MessageBox.Show("Não foi possível conectar-se ao Banco de Dados", "Falha na Conexão", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ListarEstados()
        {
            IConexao conexao = new ConexaoMySQL();

            if (conexao.AbrirConexao() == ConnectionState.Open)
            {
                string selectEstados = "SELECT nome FROM estados";

                MySqlDataReader dataReader = (MySqlDataReader)conexao.ExecutarConsulta(selectEstados);

                List<string> estados = new List<string>();

                while (dataReader.HasRows && dataReader.Read())
                {
                    estados.Add(dataReader["nome"].ToString());
                }

                cbEstadoCadastro.DataSource = estados;

                dataReader.Close();
                conexao.FecharConexao();
            }
            else
            {
                MessageBox.Show("Não foi possível conectar-se ao Banco de Dados", "Falha na Conexão", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbEstadoCadastro_SelectionChangeCommitted(object sender, EventArgs e)
        {
            IConexao conexao = new ConexaoMySQL();

            if (conexao.AbrirConexao() == ConnectionState.Open)
            {
                string selectCidades = string.Format("SELECT idCidades, nome, estados_idEstados FROM cidades where estados_idEstados = {0}",
                    cbEstadoCadastro.SelectedIndex + 1);

                MySqlDataReader dataReader = (MySqlDataReader)conexao.ExecutarConsulta(selectCidades);

                if (this.cidades != null)
                {
                    this.cidades.Clear();
                }
                else
                {
                    this.cidades = new List<Cidades>();
                }

                List<string> cidadesNomes = new List<string>();

                while (dataReader.HasRows && dataReader.Read())
                {
                    Cidades cidade = new Cidades();
                    cidade.IdCidades = long.Parse(dataReader["idCidades"].ToString());
                    cidade.Nome = dataReader["nome"].ToString();
                    cidade.IdEstados = long.Parse(dataReader["estados_idEstados"].ToString());

                    cidades.Add(cidade);

                    cidadesNomes.Add(dataReader["nome"].ToString());
                }

                cbCidadeCadastro.DataSource = cidadesNomes;

                dataReader.Close();
                conexao.FecharConexao();
            }
            else
            {
                MessageBox.Show("Não foi possível conectar-se ao Banco de Dados", "Falha na Conexão", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cbEstadoCadastro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
