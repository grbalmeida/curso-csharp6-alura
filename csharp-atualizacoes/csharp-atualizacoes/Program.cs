﻿using System;

namespace csharp_atualizacoes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] menus = new string[] {
                "1. Propriedades Automáticas Somente-Leitura",
                "2. Inicializadores De Propriedade Automática",
                "3. Membros Com Corpo De Expressão"
            };

            Console.WriteLine("ÍNDICE DE PROGRAMAS");
            Console.WriteLine("===================");


            int programa = 0;
            string line;
            do
            {
                foreach (var menu in menus)
                {
                    Console.WriteLine(menu);
                }

                Console.WriteLine();
                Console.WriteLine("Escolha um programa:");

                line = Console.ReadLine();
                int.TryParse(line, out programa);
                switch (programa)
                {
                    case 1:
                        new CSharp6.R01.Programa().Main();
                        break;
                    default:
                        break;
                }

                Console.WriteLine();
                Console.WriteLine("PRESSIONE UMA TECLA PARA CONTINUAR...");
                Console.ReadKey();
                Console.Clear();
            } while (line.Length > 0);
        }
    }
}