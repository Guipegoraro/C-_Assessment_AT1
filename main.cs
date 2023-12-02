using System;
using System.Collections.Generic;
using System.IO;
namespace at_cs
{  
class Program {
  static void Main(string[] args)
        {
            CalculoCompletoDelegate callback = (cpf, saldo, tarifa) =>
            {
                Console.WriteLine($"Arquivo gerado para o CPF {cpf}");
                // logica criar arquivo
                string nomeArquivo = $"{cpf}.txt";
                string conteudoArquivo = $"Saldo total: {saldo} | Tarifa total: {tarifa}";
                File.WriteAllText($"{Environment.CurrentDirectory}/{nomeArquivo}", conteudoArquivo);
            };

            List<DadosCliente> dados = new List<DadosCliente>();
            string[] linhas = File.ReadAllLines($"{Environment.CurrentDirectory}/input.txt");
            foreach (string linha in linhas)
            {
                string[] info = linha.Split("|");
                string cpf = info[0];
                string nome = info[1];
                double contaCorrente = double.Parse(info[2]);
                double contaInternacional = double.Parse(info[3]);
                double contaCripto = double.Parse(info[4]);

                DadosCliente cliente = new DadosCliente(cpf, nome, contaCorrente, contaInternacional, contaCripto);
                dados.Add(cliente);
            }
            GerenciadorDeTarifa gerenciador = new GerenciadorDeTarifa(dados, callback);


        }
}
  }