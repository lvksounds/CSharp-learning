using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PraticaLinguagem.ExerciciosBeeCrowd.Iniciante;


namespace PraticaLinguagem.ExerciciosBeeCrowd.Iniciante
{
    internal class Program
    {
        public static void Main()
        {
            Bhaskara bask1 = new Bhaskara(10.0, 20.1, 5.1);

            bask1.CalcBhaskara();
        }
    }
}
