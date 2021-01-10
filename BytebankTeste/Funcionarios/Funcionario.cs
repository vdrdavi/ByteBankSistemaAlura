using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_.Funcionarios
{
    public abstract class  Funcionario
    {
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }
        public static int TotalDeFuncionarios { get; private set; }

        public Funcionario(double salario, string cpf)
        {
            Salario = salario;
            cpf = CPF;

            TotalDeFuncionarios++;
            // Construtores da classe base sempre são invocados primeiro
            Console.WriteLine("Construtor de FUNCIONARIO");
        }

        public abstract void AumentarSalario();

        public abstract double GetBonificacao();
    }
}
