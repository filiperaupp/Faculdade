using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int ope=0;
            float num_um=0, num_dois=0;
            do {
                Console.WriteLine("--- Menu Calculadora ---");
                Console.WriteLine("1 - Somar");
                Console.WriteLine("2- Substracao");
                Console.WriteLine("3- Divisao");
                Console.WriteLine("4- Multiplicacao");
                Console.WriteLine("5- Sair");
                ope = Convert.ToInt32(Console.ReadLine());
                if (ope >=1 && ope<=4) {
                    Console.WriteLine("Primeiro numero:");
                    num_um = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Segundo numero:");
                    num_dois = Convert.ToInt32(Console.ReadLine());
                }
                else {
                    ope = 5;
                }
                switch (ope)
                {
                    case 1: {
                        Console.WriteLine("O resultado eh: " + (num_um+num_dois));
                        Console.WriteLine("");
                        break;
                    }
                    case 2: {
                        Console.WriteLine("O resultado eh: " + (num_um-num_dois));
                        Console.WriteLine("");
                        break;
                    }
                    case 3: {
                        Console.WriteLine("O resultado eh: " + (num_um/num_dois));
                        Console.WriteLine("");
                        break;
                    }
                    case 4:{
                        Console.WriteLine("O resultado eh: " + (num_um*num_dois));
                        Console.WriteLine("");
                        break;
                    }
                    case 5:{
                        Console.WriteLine("Programa encerrado.");
                        break;
                    }
                    default:
                        Console.WriteLine("Numero invalido. Encerrando programa. ");
                        break;
                }
            } while (ope >=1 && ope <5);
           
        }
    }
}
