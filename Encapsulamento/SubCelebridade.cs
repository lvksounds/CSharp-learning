using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class SubCelebridade
    {
        // niveis de acesso dos atributos

        // Todos
        public string InfoPublica = "Tenho um instagram!";

        // Herença
        protected string CorDosOlhos = "Verde";

        // mesmo projeto (Assembly)
        internal ulong NumeroCelular = 5511999999999;

        // herança e mesmo projeto
        protected internal string JeitoDeFalar = "Uso muitas girias";

        // mesma classe ou herança no mesmo projeto
        private protected string SegredoFamilia = "Bla Bla";

        //private - padrao, visivel apenas dentro da propria classe
        bool UsaMuitoPhotoshop = true;

        public void MeusAcessos()
        {
            Console.WriteLine("Subcelebridade");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDosOlhos);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoFamilia);
            Console.WriteLine(UsaMuitoPhotoshop);
        }

    }
}
