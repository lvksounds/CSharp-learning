using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp01.Fundamentos
{
    internal class VariaveisEConstantes
    {
        public static void Executar()
        {
            // area da circunferencia 
            double raio = 4.5;
            const double PI = 3.14;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            Console.WriteLine("A area é: " + area);


            //tipos internos
            // byte - 1 byte
            // short - 2 bytes
            // int - 4 bytes
            // long - 8 bytes
            bool estaChovendo = true;

            Console.WriteLine("Está chovendo " + estaChovendo);

            byte idade = 45;
        }
    }
}
