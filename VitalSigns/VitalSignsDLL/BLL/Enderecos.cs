namespace VitalSignsDLL.BLL
{
    class Enderecos
    {
        private string cep;
        private string bairro;
        private string logradouro;
        private int numero;
        private string complemento;
        private long idCidades;

        public string CEP
        {
            get { return this.cep; }
            set { this.cep = value; }
        }

        public string Bairro
        {
            get { return this.bairro; }
            set { this.bairro = value; }
        }

        public string Logradouro
        {
            get { return this.logradouro; }
            set { this.logradouro = value; }
        }

        public int Numero
        {
            get { return this.numero; }
            set { this.numero = value; }
        }

        public string Complemento
        {
            get { return this.complemento; }
            set { this.complemento = value; }
        }

        public long IdCidades
        {
            get { return this.idCidades; }
            set { this.idCidades = value; }
        }
    }
}
