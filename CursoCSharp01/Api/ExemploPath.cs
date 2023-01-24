using System;
using System.IO;


namespace CursoCSharp01.Api
{
    internal class ExemploPath
    {
        public static void Executar()
        {
            var arquivo = "C:\\Users\\lvkso\\OneDrive\\Documentos\\programação\\Cursos\\Udemy\\C#_Curso_Completo\\CSharp-learning\\CSharp-learning\\Arquivos\\ExemploPath.txt";
            var pasta = "C:\\Users\\lvkso\\OneDrive\\Documentos\\programação\\Cursos\\Udemy\\C#_Curso_Completo\\CSharp-learning\\CSharp-learning\\Arquivos\\";

            if (!File.Exists(arquivo))
            {
                using (StreamWriter sw = File.CreateText(arquivo))
                {
                    sw.WriteLine("Um arquivo novo criado");
                };
            }

            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            Console.WriteLine(Path.GetFullPath(arquivo)) ;
            Console.WriteLine(Path.VolumeSeparatorChar);
        }
    }
}
