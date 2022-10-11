using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp01.ClassesEMetodos
{
    internal class Params
    {

        public static void Moradores(params string[] pessoas)
        {
            foreach (string pessoa in pessoas)
            {
                Console.WriteLine(pessoa);
            }
        }

        public static void Recepcionar(params string[] moradores)
        {
            foreach(string morador in moradores)
            {
                Console.WriteLine(morador);
            }
        }

            public static void Executar()
            {

                Moradores("Lucas", "Julia", "Daniela");

                Recepcionar("julia", "lucas", "pedro");

            }
        }
    }
 
