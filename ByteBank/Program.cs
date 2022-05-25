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
            Funcionario carlos = new Funcionario("1231322132", 2000);

            carlos.Nome = "Carlos";

            carlos.AumentarSalario();
            Console.WriteLine("Novo salário do carlos: " + carlos.Salario);

            gerenciador.Registrar(carlos);

            Diretor roberta = new Diretor("13214546", 5000);
            roberta.Nome = "Roberta";

            roberta.AumentarSalario();
            Console.WriteLine("Novo salário da roberta: " + roberta.Salario);


            gerenciador.Registrar(roberta);

            Funcionario pedro = new Diretor("1312544", 5000);

            Console.WriteLine("Funcionário comum: " + carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());

            Console.WriteLine("Diretora: " + roberta.Nome);
            Console.WriteLine(roberta.GetBonificacao());

            Console.WriteLine(gerenciador.GetTotalBonificacao());

            Console.ReadLine();
        }
    }
}
