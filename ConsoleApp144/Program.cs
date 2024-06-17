using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp153
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos funicionarios gostaria de registrar: ");
            int N = int.Parse(Console.ReadLine());
            Funcionario[] Func = new Funcionario[N];
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Funcionario #{0}", i);
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Func[i] = new Funcionario(id, nome, salario);
            }
            Console.WriteLine("Digite Id funcionario que gostaria de alterar salario: ");
            int novoId = int.Parse(Console.ReadLine());
            Funcionario Func2 = Array.Find(Func, f => f?.ID == novoId);
            if (Func2 != null)
            {
                Console.WriteLine("Qual porcentagem de aumento no salario: ");
                double porcentagem = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Func2.AumentoSalario(porcentagem);
                Console.WriteLine("Lista funcionarios atualizada: ");
                foreach (var obj in Func)
                {
                    Console.WriteLine(obj);
                }
            }
            else
            {
                Console.WriteLine("Id funcionario não encontrado, tente novamente!!");
            }
            Console.ReadLine();
        }
    }
}
