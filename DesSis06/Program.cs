using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesSis06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro numero: ");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            double n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Escreva o tipo de equação: (+,-,*,/)");
            String operacao = Console.ReadLine().ToUpper();
            double resultado;
            switch (operacao)
            {
                case "+":
                    resultado = n1 + n2;
                    Console.WriteLine("O seu resultado é: " + resultado);
                    break;


                case "-":
                    resultado = n1 - n2;
                    Console.WriteLine("O seu resultado é: " + resultado);
                    break;

                case "/":
                    resultado = n1 / n2;
                    Console.WriteLine("O seu resultado é: " + resultado);
                    break;


                case "*":
                    resultado = n1 * n2;
                    Console.WriteLine("O seu resultado é: " + resultado);
                    break;

                default:

                    Console.WriteLine("Opção inválida");
                    Console.ReadKey();
                    break;
            }
            //inicio da segunda atividade
            Console.WriteLine("Digite a forma geométrica que deseja calcular a área:{Quadrado - 1, Triângulo - 2, Trapézio - 3, Retângulo - 4, Losângulo - 5} ");
            double forma = double.Parse(Console.ReadLine());
            double area;

            switch (forma)
            {
                case 1 :
                    Console.WriteLine("Digite a o valor da base: ");
                    double medida = double.Parse(Console.ReadLine());
                    area = medida * medida;
                    Console.WriteLine("o Valor da sua área é de : " + area);
                break;

                case 2:
                    Console.WriteLine("Digite a o valor da base: ");
                    double medidaB = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a o valor da altura: ");
                    double medidaAlt = double.Parse(Console.ReadLine());
                    area = (medidaB * medidaAlt) / 2;
                    Console.WriteLine("o Valor da sua área é de : " + area);
                break;

                case 3:
                    Console.WriteLine("Digite a o valor da base : ");
                    double base1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a o valor da base 2 : ");
                    double base2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o valor da altura: ");
                    double Altura = double.Parse(Console.ReadLine());
                    area = ( base1 + base2 )* Altura / 2 ;
                    Console.WriteLine("o Valor da sua área é de : " + area);
                break;

                case 4:
                    Console.WriteLine("Digite a o valor da base: ");
                    double  baseRetan = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a o valor da Altura: ");
                    double  AlturaRetan= double.Parse(Console.ReadLine());
                    area = baseRetan * AlturaRetan ;
                    Console.WriteLine("o Valor da sua área é de : " + area);
                break;

                case 5:
                    Console.WriteLine("Digite a o valor da Diagonal Maior: ");
                    double DiagoMai = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a o valor da Diagonal menor: ");
                    double DiagoMeno = double.Parse(Console.ReadLine());
                    area = (DiagoMai * DiagoMeno) / 2;
                    Console.WriteLine("o Valor da sua área é de : " + area);
                break;
                default:

                    Console.WriteLine("Opção inválida");
                    Console.ReadKey();
                    break;

            }
        }
    }
}
