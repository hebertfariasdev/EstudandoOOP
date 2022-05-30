using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudandoOOP
{
    public class GerenteDeAgencia : Funcionario
    {
        public override void Reajustar()
        {
            this.Salario += 1200;
            Console.WriteLine("Salario reajustado do Gerente de Agencia é: R$" + Salario);
        }
    }
}
