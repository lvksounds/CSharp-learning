using System;
using System.IO;

namespace CursoCSharp01.Api
{
    internal class Diretorios
    {
        public static void Executar()
        {
            var novoDir = @"C:\Users\lucas.freitas\Documents\Cursos\Udemy\C#\CSharp-learning\PastaCSharp";
            var novoDirDestino = @"C:\Users\lucas.freitas\Documents\Cursos\Udemy\C#\CSharp-learning\PastaCSharpDestino";
            var dirProjeto = @"C:\Users\lucas.freitas\Documents\Cursos\Udemy\C#\CSharp-learning\CursoCSharp01";

            if (Directory.Exists(novoDir))
            {
                Directory.Delete(novoDir, true);
            }

            if (Directory.Exists(novoDirDestino))
            {
                Directory.Delete(novoDirDestino, true);
            }

            Directory.CreateDirectory(novoDir);
            Console.WriteLine(Directory.GetCreationTime(novoDir));

            Console.WriteLine("== Pastas ============");

            var pastas = Directory.GetDirectories(dirProjeto);
            
            foreach(var pasta in pastas)
            {
                Console.WriteLine(pasta);
            }

            Console.WriteLine("\n\n == Arquivos =========");

            var arquivos = Directory.GetFiles(dirProjeto);

            foreach(string arquivo in arquivos)
            {
                Console.WriteLine(arquivo);
            }

            Directory.Move(novoDir, novoDirDestino);
        }
    }
}
