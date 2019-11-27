using System;

namespace ExampleOCP.src.Correct.Model
{
    public class ContaCorrente : Conta
    {
        public ContaCorrente() : base ()
        {

        }

        public ContaCorrente(string banco, int agencia, string numConta, decimal saldo) 
            : base (banco, agencia, numConta, saldo)
        {

        }

        public override void Debitar(decimal valor)
        {
            try
            {
                if(this.Saldo > valor)
                    this.Saldo -= valor;
                    
            }catch(Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public override void Depositar(decimal valor)
        {
            try
            {
                this.Saldo += valor;
            }catch(Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public override decimal SaldoTotal()
        {
            try
            {
                return this.Saldo;
            }catch(Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public override void Transferir(decimal valor, Conta contaDestino)
        {
            try
            {

                this.Debitar(valor);
                contaDestino.Depositar(valor);

            }catch(Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}