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

        private void cbPesquisa_SelectionChangeCommitted(object sender, EventArgs e)
        {
            switch (cbPesquisa.SelectedItem.ToString())
            {
                case "CPF": return;
                case "CNPJ": return;
                case "Chamado": return;
            }


        }
    }
}
