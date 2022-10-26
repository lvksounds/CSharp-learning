using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CursoCSharp01.Colecoes;

namespace CursoCSharp01.Colecoes
{
    class ColecoesSet : ColecoesList
    {
        public static void Executar()
        {
            // sets nao sao estruturas indexaveis e nao aceitam repetição!
            
            var livro = new Produto("Game of thrones", 49.9);

            var carrinho = new HashSet<Produto>();
            carrinho.Add(livro);

            var combo = new HashSet<Produto>
            {
                new Produto("Camisa", 59.9),
                new Produto("Isqueiro", 7.5),
                new Produto("Poster", 10.0)

            };
            carrinho.UnionWith(combo);
        }
    }
}
