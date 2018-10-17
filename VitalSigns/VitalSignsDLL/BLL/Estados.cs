namespace VitalSignsDLL.BLL
{
    class Estados
    {
        private long idEstados;
        private string nome;

        public long IdEstados
        {
            get { return this.idEstados; }
            set { this.idEstados = value; }
        }

        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }
    }
}
