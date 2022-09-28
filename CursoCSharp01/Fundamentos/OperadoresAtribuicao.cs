using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp01.Fundamentos
{
    internal class OperadoresAtribuicao
    {
        public static void Executar()
        {
            var num = 3;
            num += 10;
            num -= 3;
            num *= 5;
            num /= 4;

            Console.WriteLine(num);
            
        }
    }
}
