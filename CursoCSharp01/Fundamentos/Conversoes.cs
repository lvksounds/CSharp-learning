using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp01.Fundamentos
{
    internal class Conversoes
    {
        public static void Executar()
        {
            // convertendo valores de forma explicita
            double nota = 9.7;
            int notaTruncada = (int) nota; // casting - consiste em forçar a conversão do valopr antigo para o entre parenteses.

            Console.WriteLine($"Nota truncada: {notaTruncada}");
        }
    }
}
