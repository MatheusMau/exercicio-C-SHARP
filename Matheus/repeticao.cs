using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Matheus
{
    internal class Repeticao
    {
        public void exe1()
        {
            // Criar um algoritmo que apresente o quadrado dos números inteiros de 15 a 200.

            for (int i = 15; i <= 200; i++)
            {
                Console.WriteLine(Math.Pow(i, 2));
            }
            Console.ReadLine();
        }
        public void exe2()
        {
            // Criar um algoritmo que apresente na tela os números de 1 a 50 em ordem decrescente.

            for (int i = 50; i > 0; i--) 
            {
                Console.WriteLine(i);
       
            }
            
        }
        public void exe3()
        {    // Criar um algoritmo que calcule e apresente na tela a tabuada do 8 (1 a 10).

            int tabuada = 8;
            for (int i = 0; i <= 10; i++)
            Console.WriteLine("{0} X {1} = {2} ", tabuada, i, (tabuada * i));
            Console.ReadLine();

        }
        public void exe4()
        {
            // Criar um algoritmo que apresente na tela o total da soma dos
            // cem primeiros números inteiros positivos (1 + 2 + 3 + ... + 98 + 99 + 100).

            int soma = 0;
            for( int i = 1;  i <=100; i ++)
            {
                soma = soma + i;
            }
            Console.WriteLine("A soma dos 100 primeiros números é: {0}", soma);


        }
        public void exe5()
        {
            // Criar um algoritmo que apresente os valores da conversão de polegadas para centímetros, de 3 em 3, iniciando a contagem em 1 polegada e terminando em 13 polegadas.
            // Uma polegada equivale a aproximadamente 2,54 centímetros.

            for ( int i = 1; i <= 13; i+=2 )
            {
                double cm = i * 2.54;
                Console.WriteLine(cm);
            }

           
        }
        public void exe6()
        {
            //Criar um algoritmo que leia um número inteiro e apresente na tela o seu fatorial. (Dica: 5! = 5x4x3x2x1 = 120).
            int num, fatorial = 1;
            Console.WriteLine("Informe o fatorial: ");
            num = int.Parse(Console.ReadLine());

            for (int i= 1; i <= num; i++)
            {
               fatorial*=i;
             
            }
            Console.WriteLine("{0}! = {1} ", num, fatorial);
            Console.ReadLine();

        }
        public void exe7()
        {
            for ( int i = 100; i < 9999; i++)
            {
                int num1 = i / 100;
                int num2 = i % 100;
                int soma = num1 + num2;
                int quad = soma * soma;
                if (i == quad)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();


        }

           public void exe8()
        {

            // Criar um algoritmo que leia um valor N e apresente na tela todos os valores inteiros entre 1 e N.
            // Considere que o valor de N será sempre maior que zero.

            int num;
            Console.WriteLine("Informe um número");
            num = int.Parse(Console.ReadLine());
            for (int i =1; i < num; i++)
            {
                Console.WriteLine(i);
            }


        }
        public void exe9()
        {
            // Criar um algoritmo que efetue a leitura de 10 valores numéricos inteiros e, ao final,
            // apresente na tela a soma e a média dos valores lidos. // autoencremento

            double num, media, soma = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite um número");
                num = double.Parse(Console.ReadLine());
                soma+=num;
            }
            media = soma / 10;
            Console.WriteLine("soma = {0}", soma);
            Console.WriteLine("divisao = {0:N2}", media);
            Console.ReadLine();
        }
        public void exe10()
        {

            // Criar um algoritmo que leia o número de horas trabalhadas diárias (NH) de um funcionário por um período de 20 dias
            // (ele trabalhou todos os 20 dias) e apresente na tela o total de horas trabalhadas por ele nesse período.

            double horas, total = 0;

            for ( int i =1; i <=20; i++)
            {
                Console.WriteLine("Horas trabalho no dia {0}", i);
                horas = double.Parse(Console.ReadLine());
                total += horas;
            }
            Console.WriteLine("Total de horas trabalhadas {0}", total);
            Console.ReadLine();
        }
        public void exe11()
        {
            // Um professor possui 3 turmas, e cada turma possui 5 alunos.
            // Criar um algoritmo que leia a nota dos alunos de cada uma das turmas e apresente a média das notas por turma.

            double media, total = 0, nota;

            for ( int i =1; i<=3; i++)
            {
                Console.WriteLine("Informe as notas da turma {0}", i);
                for (int j = 1; j <= 5; j++)
                {
                    Console.WriteLine("Informe a nota do aluno {0}", j);
                    nota = double.Parse(Console.ReadLine());
                    total += nota;
                }
                media = total/5;
                Console.WriteLine("As média das nota da turma {0} é {1}", i, media);
            }

            Console.ReadLine();


        }
    }

}
