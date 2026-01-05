using DesafioPOO.Models;

class Program
{
    static void Main()
    {
        // decimal limite = decimal.Parse(Console.ReadLine());
        // int quantidade = int.Parse(Console.ReadLine());

        // var analisador = new AnalisadorDeTransacoes(limite);

        // for (int i = 0; i < quantidade; i++)
        // {
        //     decimal valor = decimal.Parse(Console.ReadLine());

        //     analisador.AdicionarTransacao(valor);

        // }

        // analisador.ExibirRelatorio();

        #region Polimorfismo
        Smartphone nokia = new Nokia("3310", "Nokia", "123456", 2);
        Smartphone iphone = new Iphone("14 Pro", "Apple", "654321", 64);

        nokia.Ligar();
        nokia.InstalarAplicativo("Snake");
        Console.WriteLine();
        iphone.Ligar();
        iphone.InstalarAplicativo("Instagram");

        Console.ReadLine();

        #endregion
    }
}