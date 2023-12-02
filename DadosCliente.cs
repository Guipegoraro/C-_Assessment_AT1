namespace at_cs
{
    class DadosCliente
    {
        private string cpf;
        private string nome;
        private ContaCorrente contaCorrente;
        private ContaInternacional contaInternacional;
        private ContaCripto contaCripto;

        public DadosCliente(string cpf, string nome, double contaCorrente, double contaInternacional, double contaCripto)
        {
            Cpf = cpf;
            Nome = nome;
            this.contaCorrente = new ContaCorrente(contaCorrente);
            this.contaInternacional = new ContaInternacional(contaInternacional);
            this.contaCripto = new ContaCripto(contaCripto);
        }

        public string Cpf { get => cpf; set => cpf = value; }
        public string Nome { get => nome; set => nome = value; }
        public ContaCorrente ContaCorrente { get => contaCorrente; set => contaCorrente = value; }
        public ContaInternacional ContaInternacional { get => contaInternacional; set => contaInternacional = value; }
        public ContaCripto ContaCripto { get => contaCripto; set => contaCripto = value; }

    }
}