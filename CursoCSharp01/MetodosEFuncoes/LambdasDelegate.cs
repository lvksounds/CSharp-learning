using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp01.MetodosEFuncoes
{
    internal class LambdasDelegate
    {
        delegate double Operacao(double x, double y); // Operacao nesse contexto, é um tipo. 
        public static void Executar()
        {
            // Delegate é definir um tipo que armazena a assinatura de uma função. 

            Operacao sum = (x, y) => x + y;
            Operacao sub = (x, y) => x - y;
            Operacao mult = (x, y) => x * y;

            Console.WriteLine(sum(10, 20).ToString());
            Console.WriteLine(sub(10, 20).ToString());
            Console.WriteLine(mult(10, 20).ToString());
        }
    }
}
