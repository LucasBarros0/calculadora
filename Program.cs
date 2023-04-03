using System;

namespace calculator2
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
            Console.WriteLine("Qual dessas opração deseja usar?");
            Console.WriteLine("1 - soma");
            Console.WriteLine("2 - subtração");
            Console.WriteLine("3 - divisão");
            Console.WriteLine("4 - multiplicação");
            Console.WriteLine("5 - sair");

            Console.WriteLine("Selecione uma opção:");
            Console.WriteLine("--------------------");
            short res = short.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: soma(); break;
                case 2: subtracao(); break;
                case 3: divisao(); break;
                case 4: multiplicacao(); break;
                default: System.Environment.Exit(0); break;
            }


        }
        static void soma()
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro valor");
            double valor1 = double.Parse(Console.ReadLine());

            Console.WriteLine("DIgite o segundo valor");
            double valor2 = double.Parse(Console.ReadLine());

            double resultado = valor1 + valor2;

            Console.WriteLine($"O resultado da soma é {resultado}");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Se deseja deseja continuar digite 1 se não digite 0");
            double continuar = double.Parse(Console.ReadLine());


            if (continuar == 1)
            {
                soma();
            }
            else
            {
                Menu();
            }

        }
        static void divisao()
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro valor");
            double valor1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o seundo valor");
            double valor2 = double.Parse(Console.ReadLine());

            double resultado = valor1 / valor2;

            Console.WriteLine($"O resultado da soma é {resultado}");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Se deseja deseja continuar digite 1 se não digite 0");
            double continuar = double.Parse(Console.ReadLine());

            if (continuar == 1)
            {
                divisao();
            }
            else
            {
                Menu();
            }
        }
        static void subtracao()
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro valor");
            double valor1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor");
            double valor2 = double.Parse(Console.ReadLine());

            double resultado = valor1 - valor2;

            Console.WriteLine($"O resultado da divisão é {resultado}");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Se deseja deseja continuar digite 1 se não digite 0");
            double continuar = double.Parse(Console.ReadLine());

            if (continuar == 1)
            {
                subtracao();
            }
            else
            {
                Menu();
            }
        }
        static void multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Digite o primeiro valor");
            double valor1 = double.Parse(Console.ReadLine());

            Console.WriteLine("DIgite o segundo valor");
            double valor2 = double.Parse(Console.ReadLine());

            double resultado = valor1 * valor2;

            Console.WriteLine($"O resultado da multiplicação é {resultado}");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Se deseja deseja continuar digite 1 se não digite 0");
            double continuar = double.Parse(Console.ReadLine());

            if (continuar == 1)
            {
                multiplicacao();
            }
            else
            {
                Menu();
            }
        }
    }
}
