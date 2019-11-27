using System;

namespace ExampleOCP.src.Correct.Model
{
    public class Usuario
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public int Idade { get; set; }
        public TipoUsuario TipoUsuario {get; set;}
        public Conta Conta { get; set; }
        public DateTime DataCadastro { get; set; }

        public Usuario() { }

        public Usuario(string nome, string cpf, int idade, TipoUsuario tipo, Conta conta)
        {
            this.Nome = nome;
            this.CPF = cpf;
            this.Idade = idade;
            this.TipoUsuario = tipo;
            this.Conta = conta;
        }

    }
}