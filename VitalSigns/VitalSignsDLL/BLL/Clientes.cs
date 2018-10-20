namespace VitalSignsDLL.BLL
{
    public class Clientes
    {
        private string cpf_cnpj;
        private string nome;
        private string telefone;
        private string e_mail;
        private string cep;

        public string CPF_CNPJ
        {
            get { return this.cpf_cnpj; }
            set { this.cpf_cnpj = value; }
        }

        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }

        public string Telefone
        {
            get { return this.telefone; }
            set { this.telefone = value; }
        }

        public string E_mail
        {
            get { return this.e_mail; }
            set { this.e_mail = value; }
        }

        public string CEP
        {
            get { return this.cep; }
            set { this.cep = value; }
        }
    }
}
