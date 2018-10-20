namespace VitalSignsDLL.BLL
{
    public class Cidades
    {
        private long idCidades;
        private string nome;
        private long idEstados;

        public long IdCidades
        {
            get { return this.idCidades; }
            set { this.idCidades = value; }
        }

        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }

        public long IdEstados
        {
            get { return this.idEstados; }
            set { this.idEstados = value; }
        }
    }
}
