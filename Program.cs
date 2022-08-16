using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioEnterprise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Exercícios da Aula de Enterprise\n");

            //Console.WriteLine("1 - a) Area do triangulo retângulo\n");

            //Console.WriteLine("Informe o valor da base do triângulo");
            //float a = float.Parse(Console.ReadLine()); 

            //Console.WriteLine("Informe o valor da altura do triângulo");
            //float c = float.Parse(Console.ReadLine());

            //Console.WriteLine($"A área do triângulo retângulo é : {(a * c) / 2}");

            //Console.WriteLine("1 - b) Area do circulo\n");

            //Console.WriteLine("Informe o valor do raio: ");
            //float raio = float.Parse(Console.ReadLine());

            //Console.WriteLine($"A área do círculo é : {(raio * raio) * 3.14}");
            //Console.ReadLine();

            //Console.WriteLine("1 - c) Area do trapézio: \n");
            //Console.WriteLine("Informe o valor da base maior: ");
            //float base1 = float.Parse(Console.ReadLine());

            //Console.WriteLine("Informe o valor da base menor: ");
            //float base2 = float.Parse(Console.ReadLine());

            //Console.WriteLine("Informe o valor da altura: ");
            //float alturaTrapezio = float.Parse(Console.ReadLine());

            //Console.WriteLine($"A área do trapézio é : {(base1 * base2) * alturaTrapezio / 2}");

            //Console.WriteLine("1 - d) Area do quadrado: \n");
            //Console.WriteLine("Informe o valor da base do quadrado: ");
            //float baseQuadrado = float.Parse(Console.ReadLine());

            //Console.WriteLine($"A área do quadrado é : {baseQuadrado * baseQuadrado}");

            //Console.WriteLine("1 - d) Area do retângulo: \n");

            //Console.WriteLine("Informe o valor da base do retângulo: ");
            //float baseRetangulo = float.Parse(Console.ReadLine());

            //Console.WriteLine("Informe o valor da altura do retângulo: ");
            //float alturaRetangulo = float.Parse(Console.ReadLine());

            //Console.WriteLine($"A área do quadrado é : {baseRetangulo * alturaRetangulo}");

            Console.WriteLine("------------------------------------------------------------------");

            //Console.WriteLine("2 - Informe dois valores inteiros para descobrir se são múltiplos");

            //Console.WriteLine("Informe o primeiro valor para saber se é multiplo: ");
            //int val1 = int.Parse(Console.ReadLine());

            //Console.Write("Informe o segundo valor: ");
            //int val2 = int.Parse(Console.ReadLine());

            //if(val1 % val2 == 0)
            //{
            //    Console.WriteLine($"Os números {val1} e {val2} são múltiplos");
            //} else
            //{
            //    Console.WriteLine($"Os números {val1} e {val2} não são múltiplos");
            //}

            //Console.ReadLine();

            //Console.WriteLine("3 - Estimativa de três pontos: ");

            //Console.WriteLine("Informe (em horas) a estimativa mais otimista");
            //float otimista =  float.Parse(Console.ReadLine()); 

            //Console.WriteLine("Informe (em horas) a estimativa mais pessimista");
            //float pessimista = float.Parse(Console.ReadLine());

            //Console.WriteLine("Informe (em horas) a estimativa mais provável");
            //float provavel = float.Parse(Console.ReadLine());

            //float estimativa = (otimista + pessimista + (4 * provavel)) / 6;

            //Console.WriteLine($"Valor da estimativa de tres pontos : {Math.Round(estimativa, 2)}");

            //Console.ReadLine();



            //Console.WriteLine("4 - Insira a nota do aluno: ");
            //float nota = float.Parse(Console.ReadLine());

            //if (nota >= 7)
            //{
            //    Console.WriteLine("Aluno aprovado!!");
            //} else if (nota < 7 && nota >= 4) {
            //    Console.WriteLine("Em recuperacao");
            //} else if (nota < 4)
            //{
            //    Console.WriteLine("Reprovado");
            //}

            //Console.ReadLine();

            //Console.WriteLine("5 - Programa melhor que a Alexa pra dar bom dia: ");
            //Console.WriteLine("Digite : 1 - Bom dia;\n" +
            //                           "2 - Boa tarde;\n " +
            //                           "3 - Boa noite;\n");
            //int choice = int.Parse(Console.ReadLine());

            //switch(choice)
            //{
            //    case 1:
            //        Console.WriteLine("Bom dia");
            //        break;
            //    case 2:
            //        Console.WriteLine("Boa tarde");
            //        break ;
            //    case 3:
            //        Console.WriteLine("Boa noite");
            //        break;
            //    default: 
            //        Console.WriteLine("Opcao invalida");
            //        break;
            //}

            //Console.ReadLine();

            //Console.WriteLine("6 - Informe um numero para descobrir seu fatorial");
            //int fatorial = int.Parse(Console.ReadLine());

            //for (int i = fatorial - 1; i > 0 ; i--)
            //{
            //    fatorial *= i ;
            //    Console.WriteLine("fatorial: " + fatorial);
            //}


            //Console.ReadLine();

            //Console.WriteLine("7 - Informe um numero para imprimir o valor do seu quadrado e do seu cubo: ");
            //int valor = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= valor; i++)
            //{
            //    Console.WriteLine($"{i} {i*i} {i*i*i}");
            //}

            //Console.ReadLine(); 

            Console.WriteLine("8 - urna eletronica\n");

            int voto = 0;
            int chaves = 0;
            int chiquinha = 0;
            int quico = 0;
            int nulo = 0;
            
            do
            {
                Console.WriteLine("Entre com seu voto: ");
                Console.WriteLine("1. Candidato Chaves\n" +
                              "2.Candidata Chiquinha\n" +
                              " 3.Candidato Quico\n" +
                              " 4.Nulo / Branco\n" +
                              "5.Encerrar a votação\n");
                voto = int.Parse(Console.ReadLine());

                switch(voto)
                {
                    case 1:
                        chaves++;
                        break;
                    case 2: 
                        chiquinha++;
                        break;
                    case 3:
                        quico++;
                        break;
                    case 4:
                        nulo++;
                        break;
                    case 5:
                        Console.WriteLine("Número de votos de cada candidato: \n");
                        Console.WriteLine("Candidato Chaves: " + chaves + "\n");
                        Console.WriteLine("Candidata Chiquinha: " + chiquinha + "\n");
                        Console.WriteLine("Candidato Quico: " + quico + "\n");
                        Console.WriteLine("Votos Nulo/Branco: " + nulo + "\n");

                        int totalVotos = chaves + chiquinha + quico + nulo;
                        double percentualNulo = (nulo * 100) / totalVotos;

                        Console.WriteLine($"Porcentagem de votos Nulo/Branco: {percentualNulo}%\n");

                        if (chaves > chiquinha && chaves > quico)
                        {
                            Console.WriteLine("Chaves Vencedor!");
                            Console.ReadLine();
                        }
                        else if (chiquinha > chaves && chiquinha > quico)
                        {
                            Console.WriteLine("Chiquinha Vencedora!");
                            Console.ReadLine();
                        }
                        else if (quico > chaves && quico > chiquinha)
                        {
                            Console.WriteLine("Quico Vencedor!");
                            Console.ReadLine();
                        }
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
                    
            } while (voto != 5);
        }
    }
}
