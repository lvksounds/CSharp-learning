using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp01.ClassesEMetodos
{
    class Pessoa
    {
        public string Nome;
        public int Idade;
        public string Apresentar()
        {
            var frase = $"Oi, me chamo {Nome} e tenho {Idade} anos.";
            return frase;
        }

        public void PrintaTexto()
        {
            Console.WriteLine(Apresentar());
        }
    }
}
