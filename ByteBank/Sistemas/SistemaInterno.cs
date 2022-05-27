using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Sistemas
{
    public class SistemaInterno
    {
        public void Logar(IAutenticavel colaborador, string senha)
        {
            bool usuarioAutenticado = colaborador.Autenticar(senha);

            if (usuarioAutenticado)
            {
                Console.WriteLine("Bem vindo ao sistema!");
            }
            else
            {
                Console.WriteLine("Senha incorreta");
            }
        }
    }
}
