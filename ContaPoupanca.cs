using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudandoOOP
{
    public class ContaPoupanca : Conta
    {
        public ContaPoupanca(int numero, double limite) : base(numero, limite)
        {

        }

        public void MostrarNumeroConta()
        {
            Console.WriteLine("Número da conta poupanca é: " + this.Numero);
        }
    }
}
