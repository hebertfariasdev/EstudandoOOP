using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudandoOOP
{
    public class GerenteDeTI : Funcionario
    {
        public override void Reajustar()
        {
            this.Salario += 2000;
            Console.WriteLine("Salario reajustado do Gerente de TI é: R$" + Salario);
        }
    }
}
