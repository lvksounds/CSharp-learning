using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CursoCSharp01.Colecoes;

namespace CursoCSharp01.Colecoes
{
    class Igualdade
    {
        public class Produto
        {
            public string Nome;
            public double Preco;

            public Produto(string nome, double preco)
            {
                Nome = nome;
                Preco = preco;
            }
        }
        public static void Executar()
        {
            var p1 = new Produto("Caneta", 1.89);        
            var p2 = new Produto("Caneta", 1.89);
            var p3 = p2;


            Console.WriteLine(p2.Nome.Equals(p1.Nome));
            Console.WriteLine(p2.Preco.Equals(p1.Preco));
            Console.WriteLine(p3.Equals(p2));
        }
    }
}
