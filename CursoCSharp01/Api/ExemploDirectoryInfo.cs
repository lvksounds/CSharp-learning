using System;
using System.IO;

namespace CursoCSharp01.Api
{
    internal class ExemploDirectoryInfo
    {
        public static void Executar()
        {
            var dirProjeto = @"C:\Users\lucas.freitas\Documents\Cursos\Udemy\C#\CSharp-learning";
            var dirInfo =  new DirectoryInfo(dirProjeto);

            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
            Console.WriteLine("Arquivos ------------------------- ");
            var arquivos = dirInfo.GetFiles();

            foreach(var arquivo in arquivos) { Console.WriteLine(arquivo); }

            Console.WriteLine("\nPastas --------------------- ");

            var pastas = dirInfo.GetDirectories();

            foreach(var pasta in pastas) { Console.WriteLine(pasta); }

            Console.WriteLine(dirInfo.CreationTime);
            Console.WriteLine(dirInfo.LastAccessTime);
        }
    }
}
