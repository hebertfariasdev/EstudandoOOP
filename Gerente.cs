﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudandoOOP
{
    public class Gerente : Funcionario
    {
        public override void Reajustar()
        {
            this.Salario += 1000;
            Console.WriteLine("Salario reajustado do gerente é: R$" + Salario);
        }
    }
}
