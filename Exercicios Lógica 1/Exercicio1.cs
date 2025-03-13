using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o código da peça 1: ");
        int codigoPeca1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o numero da Peça 1: ");
        int numeroPeca1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor unitário da peça 1: ");
        double valorUnitatioPeca1 = double.Parse(Console.ReadLine());


        Console.WriteLine("Digite o código da peça 2: ");
        int codigoPeca2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o numero da Peça 2: ");
        int numeroPeca2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o valor unitário da peça 2: ");
        double valorUnitatioPeca2 = double.Parse(Console.ReadLine());

        double total = (numeroPeca1 * valorUnitatioPeca1) + (numeroPeca2 * valorUnitatioPeca2);

        Console.WriteLine("VALOR A PAGAR: R$" + total.ToString("F2"));
    
    
    }
}
