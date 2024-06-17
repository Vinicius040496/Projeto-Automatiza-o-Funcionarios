using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp153
{
    internal class Funcionario
    {
        public int ID {  get; private set; }
        public string Nome { get;private set; }
        public double Salario { get;private set; }

        public Funcionario(int id, string nome, double salario)
        {
            ID = id;
            Nome = nome;
            Salario = salario;
        }
        public void AumentoSalario (double porcentagem)
        {
            Salario += (Salario * porcentagem) / 100;
        }
        public override string ToString()
        {
            return ID + ", " + Nome + ", " + Salario.ToString("f2",CultureInfo.InvariantCulture);
        }
    }
}
