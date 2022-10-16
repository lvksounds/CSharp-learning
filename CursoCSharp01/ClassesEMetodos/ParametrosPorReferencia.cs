using CursoCSharp01.Fundamentos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp01.ClassesEMetodos
{
    internal class ParametrosPorReferencia
    {
        public static void AlterarRef(ref int numero)
        {
            numero = numero + 1000;

        }
        public static void AlterarOut(out int numero1, out int numero2)
        {
            numero1 = 0;
            numero2 = 0;

            numero1 = numero1 + 15;
            numero2 = numero2 + 10;
            
        }

        public static void Executar()
        {
            int a = 3;
            AlterarRef(ref a);
            Console.WriteLine(a);

            // int b = 4;
            AlterarOut(out int b, out int c);
            Console.WriteLine($"{b} {c}");

            //string str = "100";
            //if (int.TryParse(str, out int num))
            //{
            //    Console.WriteLine("{0}", num + 1);
            //}
            //else
            //{
            //    Console.WriteLine("A conversão falhou!");
            //}
        }
    }
}
