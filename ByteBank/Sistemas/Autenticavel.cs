﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Sistemas
{
    public class Autenticavel
    {
        public string Senha { get; set; }

        public bool Autenticar(string senha)
        {
           return Senha = senha;
        }
    }
}
