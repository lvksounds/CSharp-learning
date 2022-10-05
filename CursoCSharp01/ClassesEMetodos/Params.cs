using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp01.ClassesEMetodos
{
    internal class Params
    {
<<<<<<< HEAD
        public static void Moradores(params string[] pessoas)
        {
            foreach (string pessoa in pessoas)
=======
        public static void Recepcionar(params string[] pessoas)
        {
            foreach(string pessoa in pessoas)
>>>>>>> c572b0a0dd7a60d90dad9ae887cbce82207ab0ec
            {
                Console.WriteLine(pessoa);
            }
        }
        public static void Executar()
        {
<<<<<<< HEAD
            Moradores("Lucas", "Julia", "Daniela");
=======
            Recepcionar("julia", "lucas", "pedro");

>>>>>>> c572b0a0dd7a60d90dad9ae887cbce82207ab0ec
        }
    }
}
