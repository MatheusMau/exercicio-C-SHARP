using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matheus
{
    internal class Sequencial
        
    { public void exe22()
        {
            // Criar um algoritmo que leia três valores inteiros e apresente na tela o valor da soma dos quadrados dos
            // três valores lidos.

            double num1, num2, num3, soma;

            Console.WriteLine("Digite o primeiro número :");
            num1 = Math.Pow(double.Parse(Console.ReadLine()), 2);
            Console.WriteLine("Digite o segundo número :");
            num2 = Math.Pow(double.Parse(Console.ReadLine()), 2);
            Console.WriteLine("Digite o terceiro número :");
            num3 = Math.Pow(double.Parse(Console.ReadLine()), 2);

            soma = num1 + num2 + num3;
            Console.WriteLine("a soma dos quadrados é {0}", soma);
            Console.ReadLine();

        }
        public void exe28()
        {
            // O custo ao consumidor, de um carro novo, é a soma do custo de fábrica com a porcentagem do distribuidor e dos
            // impostos (aplicados ao custo de fábrica). Supondo que a porcentagem do distribuidor seja de 28% e os
            // impostos de 45%, criar um algoritmo que leia o custo de fábrica de um carro e apresenta na tela o custo final
            // ao consumidor. 

            double valor;

            Console.WriteLine("Informe o valor de custo carro: ");
            valor = double.Parse(Console.ReadLine());

            valor = valor + ((valor * 0.28) + (valor * 0.45));
            Console.WriteLine("{0}", valor);
            Console.ReadLine();

        }
        public void exe29()
        {
            // Uma revendedora de carros usados paga a seus funcionários vendedores, um salário fixo por mês,
            // mais uma comissão em reais também fixa para cada carro vendido e mais 5% do valor das vendas por ele efetuadas.
            // Criar um algoritmo que leia o número de carros por ele vendidos, o valor total de suas vendas,
            // o salário fixo e o valor que recebe por carro vendido, calcule e apresente na tela o salário mensal do vendedor.

            double salario, comissao, qtdecarro, valordocarro;

            Console.WriteLine("Informe o sálario do vendendor:");
            salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade de carro vendidos ");
            comissao = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a comissao:");
            qtdecarro = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor do carro:");
            valordocarro = double.Parse(Console.ReadLine());

            salario = salario + (((qtdecarro * valordocarro) * 0.05) + (qtdecarro * comissao));
            Console.WriteLine("{0}", salario);
            Console.ReadLine();


        }
        public void exe31()
        {

            double distancia, tempo, velocidade, litros, minutos, horas;

            Console.WriteLine("Informe o as horas gasta na viagem: ");
            horas = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe os minutos da viagem: ");
            minutos = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a velocidade média da viagem: ");
            velocidade = double.Parse(Console.ReadLine());

            tempo = (horas * 60) + minutos;
            distancia = tempo * velocidade;
            litros = distancia / 12;

            Console.WriteLine("O tempo gasto foi de : {0} {1}", tempo, minutos);
            Console.WriteLine("A velocidade foi de {0}", velocidade);
            Console.WriteLine("A Distancia foi de {0}", distancia);
            Console.WriteLine("Os litros gasto foi de {0:N2}", litros); 
            Console.ReadLine();
        }
        public void exe32()
        {
            // Criar um algoritmo que leia um valor L e calcula a área de um quadrado de lado L.

            int l, area;
            Console.WriteLine("informe o lado do quadrado");
            l = int.Parse(Console.ReadLine());

            area = l * l;
            Console.WriteLine("a area do quadrado é {0}", area);
            Console.ReadLine();
        }
        public void exe33()
        {
            double a, b, c, triangulo, circulo, trapezio, quadrado, retanguloA, retanguloP;

            Console.WriteLine("Informe o valor de A");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor de B");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor de C");
            c = double.Parse(Console.ReadLine());

            triangulo = (a * c) / 2;
            Console.WriteLine("A area do triangulo é {0}", triangulo);

            circulo = Math.PI * Math.Pow((c*Math.PI), 2);
            Console.WriteLine("O raio do ciruclo é {0}", circulo);

            trapezio = ((a + b) * c) / 2;
            Console.WriteLine("A Area do trapazio é de {0}", trapezio);

            quadrado = (b * b);
            Console.WriteLine("A area do quadrado é de {0}", quadrado);

            retanguloA = a * b;
            Console.WriteLine("A area do retangulo é de {0}", retanguloA);

            retanguloP = (a + b) * 2;
            Console.WriteLine("O perimetro é de {0}", retanguloP);







        }


    }
}
