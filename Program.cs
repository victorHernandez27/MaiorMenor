using System;

namespace MaiorMenor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float numero, maior, menor;

            Console.WriteLine("Digite o 1 ºnumero: ");
            numero = float.Parse(Console.ReadLine());

            maior = numero;
            menor = numero;

            for(int i = 1; i <= 14; i++)
            {
                Console.WriteLine("Digite o {0}º numero: ",i+1);  
                numero = float.Parse(Console.ReadLine());

                if(numero > maior)
                {
                    maior = numero;
                }
                else
                {
                    if(numero < menor)
                    {
                        menor = numero;
                    }
                }
            }

            Console.WriteLine("Maior: {0}\nMenor: {1}", maior, menor);
            Console.ReadKey(); 

        }
    }
}
