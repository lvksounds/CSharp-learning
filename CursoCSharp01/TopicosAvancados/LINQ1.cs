using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp01.TopicosAvancados
{
    public class Aluno
    {
        public string Nome;
        public int Idade;
        public double Nota;
    }

    class LINQ1
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

            Console.WriteLine("Aprovados -------------------------");

            var aprovados = alunos.Where(aluno => aluno.Nota >= 7)
                .OrderBy(a => a.Nota);
            foreach (var aluno in aprovados)
            {
                Console.WriteLine(aluno.Nome);
            }

            Console.WriteLine("\nChamada -------------------------");

            var chamada = alunos.OrderBy(aluno => aluno.Nome)
                .Select(aluno => aluno.Nome);

            foreach(var aluno in chamada)
            {
                Console.WriteLine(aluno);
            }

            Console.WriteLine("\nAprovados (por idade) --------------------");

            var alunosAprovados =
                from aluno in alunos
                where aluno.Nota >= 7
                orderby aluno.Nome
                select aluno.Nome;
            
            foreach(var aluno in alunosAprovados)
            {
                Console.WriteLine(aluno);
            }
        }
    }
}
