using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp01.Fundamentos
{
    internal class NotacaoPonto
    {
        public static void Executar()
        {
            var saudacao = "Ola".Insert(3, " Mundo")
                .Replace("Mundo", "World");
            Console.WriteLine(saudacao);
        }
    }
}
