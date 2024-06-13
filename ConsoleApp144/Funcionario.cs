using System;
using System.Globalization;

namespace ConsoleApp143
{
    class Funcionarios
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public double Salario { get; private set; }

        public Funcionarios(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void AplicarAumento(double porcentagem)
        {
            Salario += Salario * porcentagem / 100.0;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Nome: {Nome}, Salário: {Salario.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}