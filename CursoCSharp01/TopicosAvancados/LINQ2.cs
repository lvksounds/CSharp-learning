using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp01.TopicosAvancados
{
    class LINQ2
    {
        public static void Executar()
        {
            var alunos = new List<Aluno>()
            {
                new Aluno(){Nome = "Pedro", Idade = 12, Nota = 10.0},
                new Aluno(){Nome = "Lucas", Idade = 24, Nota = 9.5},
                new Aluno(){Nome = "Julia", Idade = 23, Nota = 4.8},
                new Aluno(){Nome = "João", Idade = 20, Nota = 7},
                new Aluno(){Nome = "João", Idade = 22, Nota = 5.7},
                new Aluno(){Nome = "Fabio", Idade = 25, Nota = 2.6},
                new Aluno(){Nome = "Rafaela", Idade = 17, Nota = 9.8},
            };

            var lucas = alunos.Single(a => a.Nome.Equals("Lucas"));
            Console.WriteLine($"Nome: {lucas.Nome}. Idade: {lucas.Idade}");

            var fulano = alunos.SingleOrDefault(a => a.Nome.Equals("Fulano"));

            if(fulano == null)
            {
                Console.WriteLine("Não há ocorrência com este nome.");
            }

            var exemploSkip = alunos.Skip(1).Take(3);
            foreach(var item in exemploSkip)
            {
                Console.WriteLine(item.Nome);
            }

            var maiorNota = alunos.Max(aluno => aluno.Nota);
            Console.WriteLine(maiorNota);

            var menorNota = alunos.Min(aluno => aluno.Nota);

            var somatorioNotas = alunos.Sum(aluno => aluno.Nota);
            Console.WriteLine(somatorioNotas);

            var media = alunos.Average(aluno => aluno.Nota);
            Console.WriteLine(media);

        }
    }
}
