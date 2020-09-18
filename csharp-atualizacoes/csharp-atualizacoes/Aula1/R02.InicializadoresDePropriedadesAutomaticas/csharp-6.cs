using System;

namespace CSharp6.R02
{
    class Programa
    {
        public void Main()
        {
            Console.WriteLine("2. Inicializadores de Propriedade Automática");

            Aluno aluno = new Aluno("Marty", "McFly", new DateTime(1968, 6, 12));

            Console.WriteLine(aluno.Nome);
            Console.WriteLine(aluno.Sobrenome);
        }
    }

    class Aluno
    {
        public string Nome { get; }
        public string Sobrenome { get; }
        public DateTime DataNascimento { get; } = new DateTime(1990, 1, 1);

        public Aluno(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        public Aluno(string nome, string sobrenome, DateTime dataNascimento) : this(nome, sobrenome)
        {
            DataNascimento = dataNascimento;
        }

    }
}
