using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EstudandoOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aprendendo OOP!\n");

            //Criando instância da conta
            Conta conta = new Conta();

            conta.AdicionarLimite(1500);

            conta.Depositar(1500);
            conta.Depositar(2500);
            conta.Depositar(4500);

            conta.ImprimirSaldo();
            //É passado o valor a Sacar() onde seu retorno Bool é atribuido a variavel 'sacar' Booleana 
            bool sacar = conta.Sacar(7000);

            //Se o retorno for True chama o método ImprimirSaldo() e mostrar o limite da conta ao usuario
            if (sacar)
            {
                conta.ImprimirSaldo();
                Console.WriteLine("Seu limite atual é: R$" + conta.Limite + "\n");
            }
            
            conta.ImprimirSaldo();
            bool sacar1 = conta.Sacar(1738);

            if (sacar1)
            {
                conta.ImprimirSaldo();
                Console.WriteLine("Seu limite atual é: R$" + conta.Limite + "\n");
            }

            Console.ReadLine();
        }
    }
}
