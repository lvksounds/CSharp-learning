using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp01.ClassesEMetodos
{
    class Membros
    {
        public static void Executar()
        {
            Pessoa pes = new();
            pes.Idade = 10;
            pes.Nome = "Lucas";

            pes.PrintaTexto();

            var Fulano = new Pessoa();
            Fulano.Nome = "Pedro";
            Fulano.Idade = 12;

            Fulano.PrintaTexto();
        }
    }
}
