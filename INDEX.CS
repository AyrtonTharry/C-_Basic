using System;

namespace consoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 10;
            int numero_2 = 5;
            Console.WriteLine("Quanto é " + numero + " + " + numero_2 + "?");

            int resposta = Convert.ToInt32(Console.ReadLine());

            if(resposta == 15)
            {
                Console.WriteLine("Parabens, você acertou!");
            } else
            {
                Console.WriteLine("Ops,Tente novamente!");
            }

            //!int resposta = Console.ReadLine();
            //!String nome = "Moisés";
        }
    }
}