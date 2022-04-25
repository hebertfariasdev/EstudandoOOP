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
            //AULA 05 - AGREGAÇÃO

            CartaoDeCredito cdc = new CartaoDeCredito();
            Cliente cliente1 = new Cliente();

            //Adicionado nome do cliente
            cliente1.Nome = "Jão das Neves";

            //Adicionando o numero e data de validade do cartao
            cdc.Numero = "123456789987";
            cdc.DataDeValidade = "08/2025";
            cdc.Cliente = cliente1;

            Console.WriteLine("O nome do cliente é: " + cliente1.Nome);
            Console.WriteLine("O numero do cartao é: " + cdc.Numero);
            Console.WriteLine("O data de validade do cartao é: " + cdc.DataDeValidade);
            Console.WriteLine("O nome do cliente agregado do cartao é: " + cdc.Cliente.Nome);


            /*
             *          ATÉ A AULA 04:
             * 
             * 
            Console.WriteLine("Aprendendo OOP!\n");

            //Criando instância da conta
            Conta conta = new Conta(123, 300);

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
                Console.WriteLine("Seu limite atual é: R$" + conta.Limite);
                Console.WriteLine("O numero da sua conta é: " + conta.Numero + "\n");
            }
            */


            Console.ReadLine();
        }
    }
}
