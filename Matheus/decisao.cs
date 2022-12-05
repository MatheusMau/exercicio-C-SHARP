using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matheus
{
    internal class Decisao
    {
        public void decisao1()
        {
            // Criar um algoritmo que lê um número e verifica se ele é negativo.
            // Se for negativo, imprimir na tela a mensagem "Numero negativo".

            string controle = ("sim");

            while (controle.Equals("sim"))
            {
                Console.WriteLine("Digite um número");
                int num = int.Parse(Console.ReadLine());

                if (num < 0)
                {
                    Console.WriteLine("Número negativo");
                }
                else if (num == 0)
                {
                    Console.WriteLine("número neutro");
                }
                else
                {
                    Console.WriteLine("número positivo");
                }
                Console.WriteLine("Deseja continuar?[sim] ou [nao]");
                controle = Console.ReadLine();
            }
            Console.WriteLine("fim do programa");

        }
        public void decisao2()
        {
            // Criar um algoritmo que leia dois números L e R.
            // O programa deve verificar a maior área entre um quadrado de lado L e um círculo de raio R.
            // Imprimir na tela qual o maior: "Quadrado" ou "Circulo".


            Console.WriteLine("Informe o lado do quadrado: ");
            double quadrado = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o raio do circulo");
            double circulo = double.Parse(Console.ReadLine());

            quadrado = Math.Pow(quadrado, 2);
            circulo = Math.PI * Math.Pow(circulo, 2);

            if (quadrado > circulo)
            {
                Console.WriteLine("A área do quadrado é de {0}", quadrado + "o quadrado é maior!");
            }
            else if (circulo > quadrado)
            {
                Console.WriteLine("A área do ciruclo é de {0}", circulo + "o circulo é maior!");
            }
            Console.ReadLine();

        }
        public void decisao3()
        {
            // Criar um algoritmo que leia três números e imprime o maior deles.

            Console.WriteLine("Digite um número");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite um número");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite um número");
            double num3 = double.Parse(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("O número {0}", num1 + " é maior");
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("O número {0}", num2 + " é maior");
            }
            else if (num3 > num1 && num3 > num2)
            {
                Console.WriteLine("O número {0}", num3 + " é maior");
            }
            else if (num1 == num2 && num2 == num3)
            {
                Console.WriteLine("Números iguais");
            }
            Console.ReadLine();
        }
        public void decisao4()
        {

            // Criar um algoritmo que leia um valor e apresente na tela se esse valor é positivo ou negativo
            // (considere o valor zero como positivo).

            string repeticao = ("sim");           

            while (repeticao.Equals("sim",StringComparison.CurrentCultureIgnoreCase)) { 
            Console.WriteLine("Digite um número");
            double num = double.Parse(Console.ReadLine());
                Console.Clear();
            if ( num < 0)
            {
                    Console.WriteLine("O número {0}", num + " é negativo");
                }
            else if ( num >= 0)
            {
                    Console.WriteLine("O número {0}", num + " é positivo");
            }
                Console.WriteLine("deseja continuar?");
                Console.WriteLine("[sim] ou [não]");
                repeticao = Console.ReadLine();
                
            }
            Console.WriteLine("fim do programa");
            Console.ReadLine();

        }
    }
}
