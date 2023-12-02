namespace at_cs;

class ContaCripto : Conta, ITarifa
{
    public override double SaldoAtual { get => base.SaldoAtual; set => base.SaldoAtual = value * 4d; }
    public ContaCripto(double saldo) : base(saldo)
    {
    }
    public double Calcular()
    {
        return SaldoAtual * 0.025d;
    }
}