using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp01.ClassesEMetodos
{
    public class Dependente
    {
        public string Nome;
        public int Idade;
    }
    internal class ValorVsReferencia
    {
        public static void Executar()
        {
            Dependente dep = new Dependente
            {
                Nome = "Lucas",
                Idade = 24
            };

            Dependente copiaDep = dep;

            Console.WriteLine($"{dep.Nome} {copiaDep.Nome}");
            Console.WriteLine($"{dep.Idade} {copiaDep.Idade}");

            copiaDep.Nome = "Renato";
            dep.Idade = 35;

            Console.WriteLine($"{dep.Nome} {copiaDep.Nome}");
            Console.WriteLine($"{dep.Idade} {copiaDep.Idade}");
        }
    }
}
