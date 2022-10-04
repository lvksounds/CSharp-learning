using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp01.ClassesEMetodos
{
    internal class Params
    {
        public static void Recepcionar(params string[] pessoas)
        {
            foreach(string pessoa in pessoas)
            {
                Console.WriteLine(pessoa);
            }
        }
        public static void Executar()
        {
            Recepcionar("julia", "lucas", "pedro");

        }
    }
}
