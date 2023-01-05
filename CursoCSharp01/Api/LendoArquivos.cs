using System;
using System.IO;
// C:\Users\lucas.freitas\Documents\Cursos\Udemy\C#\CSharp-learning\Arquivos\


namespace CursoCSharp01.Api
{
    class LendoArquivos
    {
        public static void Executar()
        {
            var path = @"C:\Users\lucas.freitas\Documents\Cursos\Udemy\C#\CSharp-learning\Arquivos\lendo_arquivos.txt";

            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("Produto;Preco;Qtde");
                    sw.WriteLine("Caneta Bic Preta;3.59;89");
                    sw.WriteLine("Borracha Branca;2.86;30");
                }
            }

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    var texto = sr.ReadToEnd();
                    Console.WriteLine(texto);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
