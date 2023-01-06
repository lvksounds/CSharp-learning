using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp01.Api
{
    class ExemploFileInfo
    {
        public static void ExcluirSeExistir(params string[] caminhos)
        {
            foreach(var caminho in caminhos)
            {
                FileInfo arquivo = new FileInfo(caminho);

                if (arquivo.Exists)
                {
                    arquivo.Delete();
                }
            }
        }
        public static void Executar()
        {
            var caminhoOrigem = @"C:\Users\lucas.freitas\Documents\Cursos\Udemy\C#\CSharp-learning\Arquivos\arq_origem.txt";
            var caminhoDestino = @"C:\Users\lucas.freitas\Documents\Cursos\Udemy\C#\CSharp-learning\Arquivos\arq_destino.txt";
            var caminhoCopia = @"C:\Users\lucas.freitas\Documents\Cursos\Udemy\C#\CSharp-learning\Arquivos\arq_copia.txt";

            ExcluirSeExistir(caminhoOrigem, caminhoDestino, caminhoCopia);
            
            using(StreamWriter sw = File.CreateText(caminhoOrigem))
            {
                sw.WriteLine("Arquivo Original!");
            } 

            FileInfo origem = new FileInfo(caminhoOrigem);
            Console.WriteLine(origem.Name);
            Console.WriteLine(origem.DirectoryName);
            Console.WriteLine(origem.Attributes);
            Console.WriteLine(origem.Extension);

            origem.CopyTo(caminhoCopia);
            origem.MoveTo(caminhoDestino);
        }
    }
}
