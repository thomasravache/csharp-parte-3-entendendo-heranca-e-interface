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
            Funcionario carlos = new Funcionario();

            carlos.Nome = "Carlos";
            carlos.CPF = "12313113";
            carlos.Salario = 2000;


            Console.WriteLine(carlos.GetBonificacao());

            Console.ReadLine();
        }
    }
}
