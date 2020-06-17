using Microsoft.VisualBasic;
using System;
using System.Globalization;

namespace ConsoleAula2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("SOMA DE DOIS NUMEROS");
            //int n1, n2, soma;

            //Console.WriteLine("Favor indicar primeiro número: ");
            //n1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Favor indicar segundo número: ");
            //n2 = int.Parse(Console.ReadLine());

            //soma = n1 + n2;

            //Console.WriteLine("La suma de n1 = " + n1 + " n2 = " + n2 + " é: " + soma);
            //Console.ReadLine();

            // _____________________________________________________________________________________________

            //Console.WriteLine("AREA DE UM CIRCULO");

            //int raio;
            //double area, pi = 3.14159;

            //Console.WriteLine("Indique o valor do raio:");

            //raio = int.Parse(Console.ReadLine());

            //area =  pi* (raio * raio);

            //Console.WriteLine("Raio = " + raio + " Area = " + area.ToString("f4", CultureInfo.InvariantCulture));

            // _____________________________________________________________________________-

            //Console.WriteLine("SALARIO DE UM FUNCIONÁRIO");

            //byte numFunc, horasTrab;
            //double valor, salario;

            //Console.WriteLine("Indique el Número del Funcionario:");

            //numFunc = byte.Parse(Console.ReadLine());

            //Console.WriteLine("Quantas horas trabalhou?");
            //horasTrab = byte.Parse(Console.ReadLine());

            //Console.WriteLine("Valor que recebe por hora?");
            //valor = double.Parse(Console.ReadLine());

            //salario = horasTrab * valor;

            //Console.WriteLine("O funcionário número " + numFunc + " recebeu um salario de R$ " + salario.ToString("f2", CultureInfo.InvariantCulture));

            //// ________________________________________________________________________________________

            //Console.WriteLine("VALIDACAO SENHA");

            //int senha;
            //Boolean errado = true;

            //Console.WriteLine("Indique a Senha:");
            //senha = int.Parse(Console.ReadLine());

            //while (errado)
            //{
            //    Console.WriteLine("Indique a Senha:");
            //    senha = int.Parse(Console.ReadLine());

            //    // conferir que seja numérica

            //    if (senha == 2002)
            //    {
            //        errado = false;
            //        Console.WriteLine("Acesso Permitido");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Senha Inválida");
            //    }

            //}

            // _______________________________________________________________________________________________________________

            Console.WriteLine("NÚMERO IMPARES");

            int numero;
            bool impreso = false;
            string entrada;

            Console.WriteLine("Indicar um número");

            // conferir se é um número inteiro

            // conferir que seja maior que 0 e menor que 1000

            numero = int.Parse(Console.ReadLine());
            if (0 <= numero && numero <= 1000)
            {

                for (int i = 0; i <= numero; i++)
                {
                    if (!impreso)
                    {
                        entrada = "Entrada: " + numero;   // nao consigo que imprima a palavra "Entrada"
                        impreso = true;
                        Console.WriteLine(entrada);

                    }
                    else
                    {
                        entrada = null;
                    }
                    if (i % 2 != 0)
                    {
                      //  entrada = entrada + Convert.ToString(i);
                        Console.WriteLine(entrada + Convert.ToString(i));
                    }
                }
            }


            // MOSTRAR DADOS DA PESSOA MAIS VELHA

            string nome1, nome2, pessoaMaior;
            byte idade1, idade2, idadeMaior;
            string[] nome;
            int n = 2;
            int[] idade;
            bool primeiro = false;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Favor indicar nome");
                nome[i] = Console.ReadLine();

                Console.WriteLine("Favor indicar idade de " + nome[i]);
                idade1 = byte.Parse(Console.ReadLine());

                if (!primeiro)
                {
                    nome1 = nome[i];
                    primeiro = true;
                }
                else
                {
                    if (nome[i] > nome1)
                    {

                    }
                }
            }
        }

    }
}
