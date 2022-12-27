using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp01.MetodosEFuncoes
{
    class ExemploLambda
    {
        public static void Executar()
        {
            Action algoNoConsole = () => Console.WriteLine("Algo no console.");

            algoNoConsole();

            Func<int> jogarDado = () =>
            {
                Random random = new Random();
                return random.Next(1, 7);
            };

            Console.WriteLine(jogarDado());


            Func<int, string> conversorHex = (numero) => numero.ToString("X");

            Console.WriteLine(conversorHex(1234));
        
        }
    }
}
