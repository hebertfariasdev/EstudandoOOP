using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudandoOOP
{
    public class AnalistaDeTI : Funcionario
    {
        public override void Reajustar()
        {
            this.Salario += 700;
            Console.WriteLine("Salario reajustado do analista de TI é: R$" + Salario);
        }
    }
}
