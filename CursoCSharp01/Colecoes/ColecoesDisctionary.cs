using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp01.Colecoes
{
    internal class ColecoesDisctionary
    {
        public static void Executar()
        {
            var filmes = new Dictionary<int, string>();

            filmes.Add(2000, "StarWars - A lenda do Sith");
            filmes.Add(2002, "Homem-Aranha");
            filmes.Add(2018, "Avengers - Endgame");

            foreach (var filme in filmes)
            {
                Console.WriteLine(filme);
            }
            if (filmes.ContainsKey(2018)){
                Console.WriteLine("Existe!");
            }
        }
    }
}
