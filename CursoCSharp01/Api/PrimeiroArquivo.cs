using System;
using System.IO;

namespace CursoCSharp01.Api
{
    public static class ExtensaoString
    {
        //public static string ParseHome(this string path)
        //{
        //    string home = (Environment.OSVersion.Platform == PlatformID.Unix || Environment.OSVersion.Platform == PlatformID.MacOSX)
        //        ? Environment.GetEnvironmentVariable("HOME")
        //        : Environment.GetEnvironmentVariable("%HOMEDRIVE%%HOMEPATH%");
        //    return path.Replace("~", home);
        //}
    }
    internal class PrimeiroArquivo
    {
        public static void Executar()
        {
            // var path = @"C:\Users\lucas.freitas\Documents\C#\primeiro_arquivo.txt".ParseHome();
            var path = @"C:\Users\lucas.freitas\Documents\C#\primeiro_arquivo.txt";

            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Bagulho cria arquivo mane mto foda kKkKKkK");
                    sw.WriteLine("Bagulho cria arquivo mane mto foda kKkKKkK");
                    sw.WriteLine("Bagulho cria arquivo mane mto foda kKkKKkK");
                    sw.WriteLine("Bagulho cria arquivo mane mto foda kKkKKkK");
                    sw.WriteLine("Bagulho cria arquivo mane mto foda kKkKKkK");
                    sw.WriteLine("Bagulho cria arquivo mane mto foda kKkKKkK");
                    sw.WriteLine("Bagulho cria arquivo mane mto foda kKkKKkK");
                }
            }
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("EI BOLSONARO VAI TOMAR NO CU KKKKKKKKKKKKKKKKKKKKKKKKKKKKKK");
                sw.WriteLine("EI BOLSONARO VAI TOMAR NO CU KKKKKKKKKKKKKKKKKKKKKKKKKKKKKK");
                sw.WriteLine("EI BOLSONARO VAI TOMAR NO CU KKKKKKKKKKKKKKKKKKKKKKKKKKKKKK");
                sw.WriteLine("EI BOLSONARO VAI TOMAR NO CU KKKKKKKKKKKKKKKKKKKKKKKKKKKKKK");
                sw.WriteLine("EI BOLSONARO VAI TOMAR NO CU KKKKKKKKKKKKKKKKKKKKKKKKKKKKKK");
            }

        }
    }
}
