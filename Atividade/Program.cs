using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade
{
    class Program
    {
        static void Main(string[] args)
        {

            int opcao;

            Console.WriteLine("Informe a atividade que deseja consultar:\n ");
            Console.WriteLine("Atividade 01 - calculo do IMC");
            Console.WriteLine("Atividade 02 - Salario");
            Console.WriteLine("Atividade 03 - Volume de um raio");
            Console.WriteLine("Atividade 04 - Media de uma aluno");
            Console.WriteLine("Atividade 05 - Nome e tipo dos animais \n");

            opcao = int.Parse(Console.ReadLine());


            switch (opcao)
            {
                case 01:
                    Imc();
                    break;
                case 02:
                    Salario();
                    break;
                case 03:
                    Raio();
                    break;
                case 04:
                    Media();
                    break;
                case 05:
                    Animais();
                    break;
                default:
                    Console.WriteLine("Opcao inválida!");
                    break;
            }
            Console.ReadLine();
        }

        static void Imc()
        {
            double peso;
            double altura;

            Console.WriteLine("Vamos consultar o seu IMC?");

            Console.WriteLine("Qual o seu peso?");
            peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual sua altura?");
            altura = double.Parse(Console.ReadLine());

            double imc = peso / (Math.Pow(altura, 2));

            Console.WriteLine("seu imc é de: " + imc);

            if (imc < 20)
            {
                Console.WriteLine("Abaixo do peso");
            }

            else if (imc >= 20 && imc < 25)
            {
                Console.WriteLine("Peso ideal");
            }
            if (imc >= 25)
            {
                Console.WriteLine("Acima do peso");
            }


            Console.ReadLine();

        }
        static void Salario()
        {
            Console.WriteLine("Vamos descobrir quantos salarios você recebe!\n");

            double salario;
            double salarioMinimo = 1100;


            Console.WriteLine("Informe o seu salário");
            salario = double.Parse(Console.ReadLine());

            double salarioTotal = salario / salarioMinimo;

            Console.WriteLine("O funcionario recebe " + Math.Round(salarioTotal, 2) + " salario minimo");
            Console.ReadLine();

        }

        static void Raio()
        {
            Console.WriteLine("Vamos descobrir o volume de uma esfera de raio! \n");

            double pi = 3.14;
            double raio;
            double volume;


            Console.WriteLine("Informe o raio");
            raio = double.Parse(Console.ReadLine());


            volume = (4 * pi * Math.Pow(raio, 3)) / 3;
            Console.WriteLine("O volume da esfera do raio é de: " + Math.Round(volume, 2));

            Console.ReadLine();
        }

        static void Media()
        {
            Console.WriteLine("Vamos calcular a media aritmética de um aluno e descobrir se ele foi aprovado! \n");

            double nota1, nota2, nota3;
            double media;

            Console.Write("Informe sua primeira nota: ");
            nota1 = double.Parse(Console.ReadLine());

            Console.Write("Informe sua segunda nota: ");
            nota2 = double.Parse(Console.ReadLine());

            Console.Write("Informe sua terceira nota: ");
            nota3 = double.Parse(Console.ReadLine());

            media = (nota1 + nota2 + nota3) / 3;

            Console.WriteLine("\n");

            Console.WriteLine("Sua média foi: " + Math.Round(media, 2));

            Console.WriteLine("\n");



            if (media >= 7)
            {
                Console.WriteLine("Parabéns, você foi aprovado!");
            }
            else if (media < 7)
            {
                double notaExame;
                double novaMedia;

                Console.WriteLine("Você não atingiu a média, informe a nota do seu novo exame:\n");
                notaExame = double.Parse(Console.ReadLine());

                novaMedia = (media + notaExame) / 2;

                if (novaMedia >= 5)
                {
                    Console.WriteLine("Parabéns, aprovado!!\n");
                }
                else
                {

                    Console.WriteLine("\n");
                    Console.WriteLine("Infelizmente você reprovou!");
                }

            }

            Console.ReadLine();
        }

        static void Animais()
        {
            List<Animal> animais = new List<Animal>();
            int op;
            do
            {
                Console.WriteLine("\nMenu de opções\n");
                Console.WriteLine("1 - Adicionar animal.\n");
                Console.WriteLine("2 - Quantidade de animais.\n");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 01:
                        Console.Write("Qual o nome do animal?\n");
                        String nome = Console.ReadLine();

                        Console.Write("Qual o tipo do animal?\n");
                        String tipo = Console.ReadLine();

                        Animal animal = new Animal();
                        animal.Nome = nome;
                        animal.Tipo = tipo;
                        animais.Add(animal);


                        break;

                    case 02:
                        int contadorCachorro = 0;
                        int contadorGato = 0;
                        int contadorPeixe = 0;


                        foreach (Animal a in animais)
                        {
                            if (a.Tipo == "Cachorro") contadorCachorro++;
                            else if (a.Tipo == "Gato") contadorGato++;
                            if (a.Tipo == "Peixe") contadorPeixe++;
                        }
                        Console.WriteLine("\nQuantidade de cachorro: " + contadorCachorro);
                        Console.WriteLine("Quantidade de gato: " + contadorGato);
                        Console.WriteLine("Quantidade de peixe: " + contadorPeixe);
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;

                }

            } while (op != -1);

        }

    }
}
