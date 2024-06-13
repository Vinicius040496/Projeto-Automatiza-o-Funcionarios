using System;
using System.Globalization;

namespace ConsoleApp143
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos funcionários gostaria de registrar: ");
            int N = int.Parse(Console.ReadLine());
            Funcionarios[] F = new Funcionarios[N];

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Funcionário #{0}",i);
                Console.Write("ID Funcionario: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário Funcionario: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                F[i] = new Funcionarios(id, nome, salario);
            };
  
            Console.WriteLine("Digite o ID do funcionário que gostaria de alterar o salário: ");
            int idat = int.Parse(Console.ReadLine());

            Funcionarios funcionario = Array.Find(F, f => f?.Id == idat);

            if (funcionario != null)
            {
                Console.WriteLine("Qual porcentagem de aumento salarial: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                funcionario.AplicarAumento(porcentagem);

                Console.WriteLine("Lista de funcionários atualizada:");
                foreach (var f in F)
                {
                    Console.WriteLine(f);
                }
            }
            else
            {
                Console.WriteLine("ID funcionário não encontrado,Tente novamente!");
            }
            Console.ReadLine();
        }
    }
}
