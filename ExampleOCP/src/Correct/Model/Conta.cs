using System;

namespace ExampleOCP.src.Correct.Model
{
    public abstract class Conta
    {
        public string Banco { get; protected set; }
        public int Agencia { get; protected set; }
        public string NumConta { get; protected set; }
        public decimal Saldo { get; protected set; }
        public DateTime DataAbertura { get; protected set; }

        public Conta() {  }
        public Conta(string banco, int agencia, string nunConta, decimal saldo)
        {
            this.Banco = banco;
            this.Agencia = agencia;
            this.NumConta = NumConta;
            this.Saldo = saldo;
            this.DataAbertura = DateTime.Now;
        }

        public abstract decimal SaldoTotal();
        public abstract void Depositar(decimal valor);
        public abstract void Debitar(decimal valor);
        public abstract void Transferir(decimal valor, Conta contaDestino);
    }
}