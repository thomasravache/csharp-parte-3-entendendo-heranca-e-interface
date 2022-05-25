using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();
            Funcionario carlos = new Funcionario();

            carlos.Nome = "Carlos";
            carlos.CPF = "12313113";
            carlos.Salario = 2000;

            gerenciador.Registrar(carlos);

            Diretor roberta = new Diretor();
            roberta.Nome = "Roberta";
            roberta.CPF = "121131231";
            roberta.Salario = 5000;

            gerenciador.Registrar(roberta);

            Funcionario pedro = new Diretor();

            Console.WriteLine("Funcionário comum: " + carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());

            Console.WriteLine("Diretora: " + roberta.Nome);
            Console.WriteLine(roberta.GetBonificacao());

            Console.WriteLine(gerenciador.GetTotalBonificacao());

            Console.ReadLine();
        }
    }
}
