using System;

namespace Atv_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] numeros = new int [10];

            for (var contador = 0; contador < 10; contador++)
            {
                Console.WriteLine($"Digite o {contador+1} numero");
                numeros[contador] = int.Parse(Console.ReadLine());
            }
                Console.WriteLine("Numeros que voce cadastrou");


                for (var contador = 0; contador < 10; contador++)
                {
                    Console.WriteLine(+numeros[contador]);
                }
        }
    }
}
