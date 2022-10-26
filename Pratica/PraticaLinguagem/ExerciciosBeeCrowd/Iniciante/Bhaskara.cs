using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticaLinguagem.ExerciciosBeeCrowd.Iniciante
{
    internal class Bhaskara
    {

        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public double Delta { get
            {
                return Math.Pow(B, 2) - 4 * A * C;
            } }
        public double? x1
        {
            get
            {
                if(Delta >= 0)
                {
                    return (-B + Math.Sqrt(Delta)) / 2;
                }
                return null;
            }
        }
        public double? x2 { 
            get
            {
                if(Delta >= 0)
                {
                    return (-B - Math.Sqrt(Delta)) / 2;
                }
                return null;
            }
        }

        public Bhaskara(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public void CalcBhaskara()
        {
            if (Delta < 0)
            {
                Console.WriteLine("Não possui raizes reais");
            }
            else
            {
                Console.WriteLine($"x1 = {x1}, x2 = {x2}");
            }
        }
    }
}
