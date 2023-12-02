namespace at_cs
{
    abstract class Conta
    {
        public virtual double SaldoAtual { get; set; }

        public Conta(double saldo)
        {
            SaldoAtual = saldo;
        }


    }
}