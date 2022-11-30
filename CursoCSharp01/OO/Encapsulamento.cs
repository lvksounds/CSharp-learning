using System;
using Encapsulamento;

namespace CursoCSharp01.OO
{
    class Encapsulamento
    {
        public class FilhoNaoReconhecido : SubCelebridade
        {
            public new void MeusAcessos()
            {
                Console.WriteLine("Filho nao Reconhecido");

                Console.WriteLine(InfoPublica);
                Console.WriteLine(JeitoDeFalar);
                Console.WriteLine(CorDosOlhos);
                //Console.WriteLine(NumerodoCelular);
                //Console.WriteLine(SegredoFamilia);
                //Console.WriteLine(UsoMuitoPhotoshop);
            }
            public class AmigoDistante
            {
                public readonly SubCelebridade amiga = new SubCelebridade();
                public void MeusAcessos()
                {
                    Console.WriteLine(amiga.InfoPublica);
                    //Console.WriteLine(amiga.CorDoOlho);
                    //Console.WriteLine(amiga.NumerodoCelular);
                    //Console.WriteLine(amiga.JeitoDeFalar);
                    //Console.WriteLine(amiga.SegredoDefamilia);
                    //Console.WriteLine(amiga.UsoMuitPhotoshop);

                }
            }
        }
        public static void Executar()
        {
            SubCelebridade sub = new SubCelebridade();
            sub.MeusAcessos();

            //new FilhoReconhecido.MeusAcessos();
            //new AmigoProximo.MeusAcessos();
        }
    }
}
