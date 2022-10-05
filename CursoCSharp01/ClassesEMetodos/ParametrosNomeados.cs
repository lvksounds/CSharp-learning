using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp01.ClassesEMetodos
{
    internal class ParametrosNomeados
    {
        public static void Formatar(int dia, int mes, int ano)
        {
            Console.WriteLine("{0:D2}/{1:D2}/{2}", dia, mes, ano);
        }
        public static void Executar()
        {
<<<<<<< HEAD
            Formatar(dia: 10, mes: 6, ano: 1998);
=======
            Formatar(mes: 6, dia: 10, ano: 1998);
>>>>>>> c572b0a0dd7a60d90dad9ae887cbce82207ab0ec
        }
    }
}
