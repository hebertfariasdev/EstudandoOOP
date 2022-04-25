using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EstudandoOOP
{
    public class Conta
    {
        private double Saldo { get; set; }

        public double Limite { get; private set; }

        public int Numero { get; set; }

        public void Depositar(double valor)
        {
            this.Saldo += valor;
            Console.WriteLine("Foi depositado R$" + valor + " em sua conta!!");
        }
        public bool Sacar(double valor)
        {
            double saldoDisponivel = this.ConsultarSaldo();

            //Se NÂO for possivel sacar o valor, é informado ao usuario e retornado False
            if (valor > saldoDisponivel)
            {
                Console.WriteLine("Saque e saldo indisponivel!!");
                return false;
            }
            //Se for possivel sacar o valor, é informado o valor a ser sacado ao usuario
            Console.WriteLine("Foi sacado R$" + valor + " da sua conta!!");
            this.Saldo -= valor;    //Logo em seguida é descontado o valor do saldo total e retornado True
            return true;            
        }        

        //ConsultarSaldo apenas retorna o valor do saldo para Sacar() e ImprimirSaldo()
        public double ConsultarSaldo()
        {
            double saldo = this.Saldo + this.Limite;
            return saldo;
        }

        //ImprimirSaldo() responsavel por imprimir na tela para usuario o valor do saldo da conta
        public void ImprimirSaldo()
        {
            Console.WriteLine("\nSeu saldo atual é R$" + this.ConsultarSaldo());
        }
        public void AdicionarLimite(double valor)
        {
            this.Limite = valor;
        }
    }
}
