using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class ContaCorrente
    {
        // propriedades da classe
        private int numeroAgencia;

        public string conta { get; set; }  //propriedade autoimplementada
        private double saldo;
        public Cliente titular { get; set; }
        public static int TotalDeContasCriadas { get; private set; }

        // Criando metodos para fazer operações com a conta.
        public int NumeroAgencia 
        {
            get { return this.numeroAgencia; } 
            private set
            {
                if(value > 0)
                {
                    this.numeroAgencia = value; 
                }
            }
        }

        
        // metodos para operar com as propriedades
        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (saldo >= valor)
            {
                this.saldo -= valor;
                return true;
            } else
            {
                return false;
            }
            
            
        }

        public bool Transferir(double valor, ContaCorrente contaDestino) 
        {
            if (saldo >= valor)
            {
                // usando os metodos sacar e depositar direto em outro metodo
                this.Sacar(valor);
                contaDestino.Depositar(valor);
                    return true;
            }
            else
            {
                return false;
            }
        }
        // metodo para definir o saldo da conta que está privada.
        public void SetSaldo(double valor)
        {
            if (valor < 0)
            {
                return;
            } else
            {
                this.saldo = saldo + valor;
            }
        }

        public double GetSaldo()
        {
            return this.saldo;
        }

        // metodo construtor

        public ContaCorrente(int numeroAgencia, string conta)
        {
            this.NumeroAgencia = numeroAgencia;
            this.conta = conta;
            TotalDeContasCriadas++;
    
        }

    }
}
