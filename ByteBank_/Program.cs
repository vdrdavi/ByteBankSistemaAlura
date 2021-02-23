using ByteBank_.Funcionarios;
using ByteBank_.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_
{
    class Program
    {
        static void Main(string[] args)
        {
            // CalcularBonificação();
            UsarSistema();
            Console.ReadLine();
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor davi = new Diretor("454.658.148-30");
            davi.Nome = "Davi";
            davi.Senha = "abc123";

            GerenteDeConta joao = new GerenteDeConta("987.573.987-55");
            joao.Nome = "João";
            joao.Senha = "123abc";

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "senha123";
             

            sistemaInterno.Logar(parceiro, "senha123");
            sistemaInterno.Logar(davi, "abc123");
            sistemaInterno.Logar(joao, "123abc");
        }


        public static void CalcularBonificação()
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario gabriel = new Designer("263.549.139-01");
            gabriel.Nome = "Gabriel";
            Console.WriteLine(gabriel.GetBonificacao());

            Funcionario felipe = new Auxiliar("546.879.157-20");
            felipe.Nome = "Felipe";
            Console.WriteLine(felipe.GetBonificacao());

            Funcionario carlos = new Desenvolvedor("283.182.455-45");
            carlos.Nome = "Carlos";
            Console.WriteLine(carlos.GetBonificacao());

            Funcionario joao = new GerenteDeConta("987.573.987-55");
            joao.Nome = "João";
            Console.WriteLine(joao.GetBonificacao());

            Funcionario davi = new Diretor("454.658.148-30");
            davi.Nome = "Davi";
            Console.WriteLine(davi.GetBonificacao());


            gerenciador.Registrar(gabriel);
            gerenciador.Registrar(felipe);
            gerenciador.Registrar(carlos);
            gerenciador.Registrar(joao);
            gerenciador.Registrar(davi);

            Console.WriteLine("Total de bonificações: " + gerenciador.GetTotalBonificacao());
        }
    }
}
