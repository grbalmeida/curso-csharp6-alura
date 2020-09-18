using System;

namespace CSharp6.R01
{
    class Programa
    {
        public void Main()
        {
            Console.WriteLine("1. Propriedades Automáticas Somente-Leitura");

            Aluno aluno = new Aluno("Marty", "McFly", new DateTime(1968, 6, 12));

            Console.WriteLine(aluno.Nome);
            Console.WriteLine(aluno.Sobrenome);

            //aluno.Nome = "Biff";
            //aluno.Sobrenome = "Tannen";
            //Console.WriteLine(aluno.Nome);
            //Console.WriteLine(aluno.Sobrenome);
        }
    }

    class Aluno
    {
        readonly string nome;
        public string Nome { get { return nome; } }

        readonly string sobrenome;
        public string Sobrenome { get { return sobrenome; } }

        readonly DateTime dataNascimento;
        public DateTime DataNascimento { get { return dataNascimento; } }

        public Aluno(string nome, string sobrenome, DateTime dataNascimento)
        {
            this.nome = nome;
            this.sobrenome = sobrenome;
            this.dataNascimento = dataNascimento;
        }
    }
}
