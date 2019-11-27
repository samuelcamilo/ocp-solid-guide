using System;
using ExampleOCP.src.Correct.Model;

namespace ExampleOCP
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario user1 = new Usuario();
            Usuario user2 = new Usuario();

            user1.Nome = "xxxxx";
            user1.CPF = "xxxxx";
            user1.Idade = 23;
            user1.TipoUsuario = TipoUsuario.PessoaFisica;
            user1.Conta = new ContaPoupanca("Nu Pagamentos NE", 0001, "54221851", 2500);
            user1.DataCadastro = DateTime.Now;

            user2.Nome = "xxxxx";
            user2.CPF = "xxxxx";
            user2.Idade = 19;
            user2.TipoUsuario = TipoUsuario.PessoaFisica;
            user2.Conta = new ContaCorrente("Nu Pagamentos NE", 0001, "5632788", 2500);
            user2.DataCadastro = DateTime.Now;

            user1.Conta.Transferir(100, user2.Conta);

            Console.WriteLine("Usuario 1");
            Console.WriteLine("Tipo de Conta: " + user1.Conta.GetType());
            Console.WriteLine("Saldo na Conta: " + user1.Conta.SaldoTotal());

            Console.WriteLine("Usuario 2");
            Console.WriteLine("Tipo de Conta: " + user2.Conta.GetType());
            Console.WriteLine("Saldo na Conta: " + user2.Conta.SaldoTotal());
        }
    }
}
