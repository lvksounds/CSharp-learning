using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CursoCSharp01.Fundamentos
{
    internal class FormatandoNumero
    {
        public static void Executar() {
            double valor = 15.175;

            Console.WriteLine(valor.ToString("F1")); // quantidade de casas decimais na formatação
            Console.WriteLine(valor.ToString("C"));  // Formatação para valores monetarios C - Currency
            Console.WriteLine(valor.ToString("P"));  // P - por padrao, multiplicao numero por 100 e adiciona o simplo de porcentagem
            Console.WriteLine(valor.ToString("#.##")); // um numero com duas casas deciamis
            
            CultureInfo cultura = new CultureInfo("pt-BR"); // inicializando um objeto de cultura BR
            Console.WriteLine(valor.ToString("C0", cultura)); // printa o valor monetario, com 0 casas decimais e com a informaçã de cultura de moeda brasileira.

        } 
    }
}
