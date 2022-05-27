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

            //Aula 07 - Herança
            ContaPoupanca contaPoupanca = new ContaPoupanca(112, 0);

            contaPoupanca.Depositar(100);
            contaPoupanca.Sacar(10);

            double saldo = contaPoupanca.ConsultarSaldo();

            contaPoupanca.MostrarNumeroConta();
            Console.WriteLine("Saldo da conta poupança é: " + saldo);

            Console.WriteLine();

            Conta conta = new Conta(113, 100);

            conta.Depositar(500);
            conta.Sacar(140);

            double saldoContaCorrente = conta.ConsultarSaldo();
            Console.WriteLine("Saldo da conta corrente é: " + saldoContaCorrente);



            /*
            //AULA 06 - Métodos e Atributos Estáticos

            Conta conta1 = new Conta(253, 500);
            Conta conta2 = new Conta(456, 600);
            Conta conta3 = new Conta(654, 750);
            Conta conta4 = new Conta(789, 900);
            Conta conta5 = new Conta(915, 1000);

            //Um Atribuito/Método estático sempre é chamado atraves de sua classe
            //Exemplo: " Conta.TotalContasCriadas "
            int proximoTotal = Conta.ProximoTotalContasCriadas();

            Console.WriteLine("Total de contas: " + Conta.TotalContasCriadas);
            Console.WriteLine("Proximo total de contas: " + proximoTotal);
            */


            /*
             * 
             * //AULA 05 - AGREGAÇÃO

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
            */

            /*
             *          ATÉ A AULA 04:
             * 
             * 

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
