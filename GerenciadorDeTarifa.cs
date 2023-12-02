namespace at_cs;
using System.Collections.Generic;
public delegate void CalculoCompletoDelegate(string cpf, double saldo, double tarifa);
class GerenciadorDeTarifa
{
    private double valorTotalSaldo;
    private double valorTotalTarifa;
    public double ValorTotalSaldo { get => valorTotalSaldo; set => valorTotalSaldo = value; }
    public double ValorTotalTarifa { get => valorTotalTarifa; set => valorTotalTarifa = value; }

    public GerenciadorDeTarifa(List<DadosCliente> dados, CalculoCompletoDelegate callback)
    {
        this.CalcularTotais(dados, callback);
    }
    public void CalcularTotais(List<DadosCliente> clientes, CalculoCompletoDelegate callback)
    {
        foreach (var cliente in clientes)
        {
            ValorTotalSaldo = cliente.ContaCorrente.SaldoAtual + cliente.ContaInternacional.SaldoAtual + cliente.ContaCripto.SaldoAtual;
            ValorTotalTarifa = cliente.ContaCorrente.Calcular() + cliente.ContaInternacional.Calcular() + cliente.ContaCripto.Calcular();

            callback(cliente.Cpf, ValorTotalSaldo, ValorTotalTarifa);
        }
    }
}