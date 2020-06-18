using Microsoft.VisualBasic;
using System;
using System.Globalization;

namespace ConsoleAula2
{
    class Program
    {
        private static string nome1;

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

            //    // -->> Falta conferir que seja numérica

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

            //Console.WriteLine("NÚMERO IMPARES");

            //int numero;
            //bool impreso = false;
            //string entrada;

            //Console.WriteLine("Indicar um número");

            //// -->> falta conferir se é um número inteiro

            //// conferir que seja maior que 0 e menor que 1000

            //numero = int.Parse(Console.ReadLine());
            //if (0 <= numero && numero <= 1000)
            //{

            //    for (int i = 0; i <= numero; i++)
            //    {
            //        if (!impreso)
            //        {
            //            entrada = "Entrada: " + numero;  
            //            impreso = true;
            //            Console.WriteLine(entrada);

            //        }
            //        else
            //        {
            //            entrada = null;
            //        }
            //        if (i % 2 != 0)
            //        {
            //          //  entrada = entrada + Convert.ToString(i);
            //            Console.WriteLine(entrada + Convert.ToString(i));
            //        }
            //    }
            //}

            // __________________________________________________________________________________________________________________

            // MOSTRAR DADOS DA PESSOA MAIS VELHA

            //string nome1, pessoaMaior = null;
            //byte idade1, idadeMaior = 0;
            //string[] nome = { null, null };
            //int n = 2;
            //int[] idade = { 0, 0 };
            //bool primeiro = false;

            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine("Favor indicar nome");
            //    nome1 = Console.ReadLine();
            //    nome[i] = nome1; 
            //    Console.WriteLine("Favor indicar idade de " + nome1);

            // Falta verificar que idade seja numerica

            //    idade1 = byte.Parse(Console.ReadLine());
            //    idade[i] = idade1;


            //    if (!primeiro)
            //    {
            //        pessoaMaior = nome1;
            //        idadeMaior = idade1;
            //        primeiro = true;
            //    }
            //    else
            //    {
            //        if (idade1 > idadeMaior) 
            //        {
            //            idadeMaior = idade1;
            //            pessoaMaior = nome1;

            //        }
            //    }


            //}

            //for (int i = 0; i < n; i++)

            //    Console.WriteLine("Pessoa " + (i+1) + " Nome: " + nome[i] + " idade: " + idade[i]);
            //{

            //}

            //Console.WriteLine("Pessoa de mais idade: " + pessoaMaior + " com " + idadeMaior + " anos");


            // __________________________________________________________________________________________________________________

            // SALARIO MEDIO DE DOIS FUNCIONARIOS

            string funcionario1 = null;
            int salario1 = 0;
            double promedio = 0;
            string[] funcionario = { null, null };
            int n = 2;
            int[] salario = { 0, 0 }; // deve ser double
            
            // falta conferir salario numerico
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Favor indicar nome do funcionario");
                funcionario1 = Console.ReadLine();
                funcionario[i] = funcionario1;
                Console.WriteLine("Favor indicar salario de " + nome1);

                // fazer conversao adecuada (para dou=ble com 2 casas decimais
                salario1 = int.Parse(Console.ReadLine());    
                salario[i] = salario1;
                
            promedio += salario[i];
            }

            for (int i = 0; i < n; i++)

                Console.WriteLine("Pessoa " + (i + 1) + " Nome: " + funcionario[i] + " salario: " + salario[i]);
            {

            }

            Console.WriteLine("Salario medio: " + (promedio/n));




        }

    }
}
