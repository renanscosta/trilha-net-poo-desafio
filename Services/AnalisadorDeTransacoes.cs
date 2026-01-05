using System;

namespace DesafioPOO.Services;

public class AnalisadorDeTransacoes
{
    public decimal Limite { get; set; }
    public List<decimal> Transacoes { get; set; }
    public AnalisadorDeTransacoes(decimal limite)
    {
        Limite = limite;
        Transacoes = new List<decimal>();
    }

    public void AdicionarTransacao(decimal valor)
    {
        Transacoes.Add(valor);
    }

    public List<decimal> ObterTransacoesSuspeitas()
    {

        List<decimal> suspeitas = new List<decimal>();
        Transacoes.ForEach(transacao =>
        {
            if (transacao > Limite)
            {
                suspeitas.Add(transacao);
            }
        });
        return suspeitas;
    }

    public void ExibirRelatorio()
    {
        var suspeitas = ObterTransacoesSuspeitas();

        if (suspeitas.Count == 0)
        {
            Console.WriteLine("Nenhuma transacao suspeita");
        }
        else
        {
            decimal totalSuspeitas = suspeitas.Sum();
            int numeroSuspeitas = suspeitas.Count();

            string transacaoTexto = numeroSuspeitas == 1 ? "transacao suspeita" : "transacoes suspeitas";

            Console.WriteLine($"Transacoes suspeitas: {totalSuspeitas:F2}");
            Console.WriteLine($"{numeroSuspeitas} {transacaoTexto}");
        }
    }

}
