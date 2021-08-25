using System;

namespace MetodoNota
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o valor do ingresso escolhido?");
            double x = double.Parse(Console.ReadLine());

            Ingresso i = new Ingresso(x);

            Console.WriteLine(i);

            Console.ReadLine();
        }
    }
}
