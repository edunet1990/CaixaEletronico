using System;
using System.Globalization;

namespace CaixaEletronico
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta x;
            double valorInicial = 0;
            Console.WriteLine("Digite o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome do ditular da conta: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Haverá depósito inicial (s/n): ");
            char ch = char.Parse(Console.ReadLine());
            if(ch == 's')
            {
                Console.WriteLine("Digite o valor de depósito Inicial");
                valorInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                x = new Conta(numero, nome, valorInicial);
            }
            else
            {
                x = new Conta(numero, nome); 
            }

            Console.WriteLine();
            Console.WriteLine("Conta Criada");
            Console.WriteLine(x);


            Console.WriteLine();
            Console.Write("Digite um valor de depósito");
            double dep = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.depositar(dep);
            Console.WriteLine(x);


            Console.WriteLine();
            Console.Write("Digite um valor para saque");
            double saq = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.sacar(saq);
            Console.WriteLine();
            Console.WriteLine("Conta Atualizada");
            Console.WriteLine(x);

            Console.ReadKey();
        }
    }
}
