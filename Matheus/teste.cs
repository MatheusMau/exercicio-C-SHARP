using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Matheus
{
    internal class Teste

    {
        public void arroz()
        {
            // Criar um algoritmo que leia três números e imprime o maior deles.

            Console.WriteLine("Digite o primeiro número");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro número");
            double num3 = double.Parse(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine(" o número maior é o {0}", num1);
            }
            else if (num2 > num1 && num2 > num3) 
            {
                Console.WriteLine(" o número maior é o {0}", num2);
            }
            if (num3 > num1 && num3 > num2)
            {
                Console.WriteLine(" o número maior é o {0}", num3);
            }
            else if ( num1 == num2 && num2 == num3 && num1 == num3)
            {
                Console.WriteLine("números iguais!");
            }
            
            
           Console.ReadLine();


        }
    }
}
