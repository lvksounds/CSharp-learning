using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticaLinguagem.Testes
{
    internal class CountWhiteSpaces
    {
        static string mystring = "Lucas de Freitas Oliveira";
        int countSpaces = mystring.Count(Char.IsWhiteSpace);
    }
}
