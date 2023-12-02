namespace at_cs;

class ContaCorrente : Conta, ITarifa
{
    public ContaCorrente(double saldo) : base(saldo)
    {
    }
    public double Calcular()
    {
        return SaldoAtual * 0.015d;
    }

}