﻿using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)

        {

            Menu();
        }
        static void Menu()
        {

            Console.Clear();
            Console.WriteLine("Escolha uma das opçções abaixo:");
            Console.WriteLine("");
            Console.WriteLine("1- Soma");
            Console.WriteLine("2- Subtração");
            Console.WriteLine("3- Divisão");
            Console.WriteLine("4- Multiplicação");
            Console.WriteLine("5- Sair");
            Console.WriteLine("____________________");


            int opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {

                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;

            }

        }
        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 + v2;
            Console.WriteLine($"O resultado da soma é:  { resultado}");

            Console.ReadKey();
            Menu();
        }
        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 - v2;
            Console.WriteLine($"O resultado da subtração é:  { resultado}");

            Console.ReadKey();
            Menu();
        }
        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 / v2;
            Console.WriteLine($"O resultado da Divisão é:  { resultado}");

            Console.ReadKey();
            Menu();
        }
        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 * v2;
            Console.WriteLine($"O resultado da Multiplicação é:  { resultado}");

            Console.ReadKey();
            Menu();
        }
    }


}
