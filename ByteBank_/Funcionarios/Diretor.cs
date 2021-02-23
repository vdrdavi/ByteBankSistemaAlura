using ByteBank_.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_.Funcionarios
{
    class Diretor : FuncionarioAutenticavel
    {
        public override double GetBonificacao()
        {
            return 0.5 * Salario;
        }

        public Diretor(string cpf) : base(5000, cpf)
        {
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }
    }
}
