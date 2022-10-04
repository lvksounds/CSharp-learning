using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp01.ClassesEMetodos
{
    internal class DesafioAtributo
    {
        int a = 10;
        public static void Executar()
        {
            var acesso = new DesafioAtributo();
            Console.WriteLine(acesso.a);
        }
    }
}
