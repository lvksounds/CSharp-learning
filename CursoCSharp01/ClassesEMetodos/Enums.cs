using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp01.ClassesEMetodos
{
    internal class Enums
    {
        public enum Genero { Acao, Aventura, Terror, Animacao, Comedia};
        public class Filme
        {
            public string Titulo;
            public Genero GeneroDoFilme;
        }
        public static void Executar()
        {
            int id = (int)Genero.Terror;
            Console.WriteLine(id);

            var FilmeInfantil = new Filme();
            FilmeInfantil.Titulo = "Bob Esponja";
            FilmeInfantil.GeneroDoFilme = Genero.Animacao;

            Console.WriteLine($"O genero do Filme {FilmeInfantil.Titulo} é {FilmeInfantil.GeneroDoFilme}");
        }
    }
}
