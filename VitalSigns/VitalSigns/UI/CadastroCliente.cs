using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VitalSignsDLL.DAL;

namespace VitalSigns.UI
{
    public partial class frmCadastroCliente : Form
    {

        public frmCadastroCliente()
        {
            InitializeComponent();
            
        }

        private void btnSalvarCadastroCliente_Click(object sender, EventArgs e)
        {
            IConexao conexao = new ConexaoMySQL();
            if (conexao.AbrirConexao() == ConnectionState.Open)
            {
                string cpf_cnpj = txtCpfCadastro.Text;
                string nome = txtNomeCadastro.Text;
                string tel = txtTelefoneCadastro.Text;
                string e_mail = txtEmailCadastro.Text;
                string cep = TxtCepCadastro.Text;

                string bairro = txtBairroCadastro.Text;
                string logradouro = txtLougradouroCadastro.Text;
                int num = int.Parse(txtNumeroCadastro.Text);
                string complemento = txtComplementoCadastro.Text;

                int idCidade = cbCidadeCadastro.SelectedIndex;

                string sql = string.Format("insert into Clientes values ('{0}', '{1}', '{2}', '{3}', '{4}')", cpf_cnpj, nome, tel, e_mail, cep);
                int rowsAffected = conexao.ExecutarSemConsulta(sql);

            }
        }
    }
}
