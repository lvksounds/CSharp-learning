using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp01.ClassesEMetodos
{

    public class Moto
    {
        private string Marca;
        private string Modelo;
        private int Cilindrada;

        public Moto(string marca, string modelo, int cilindrada)
        {
            Marca = marca;
            Modelo = modelo;
            Cilindrada = cilindrada;
        }

        public Moto()
        {

        }

        public string GetMarca()
        {
            return Marca;
        }

        public void SetMarca(string marca)
        {
            Marca = marca;
        }
        public string GetModelo()
        {
            return Modelo;
        }
        public void SetModelo(string modelo)
        {
            Modelo = modelo;
        }

        public int GetCilindrada()
        {
            return Cilindrada;
        }
        public void SetCilindrada(int cilindrada)
        {
            if(cilindrada > 0)
            {
                Cilindrada = cilindrada;
            } else
            {
                Cilindrada = 0;
            }
        }
    }

    internal class GetSet
    {

        public static void Executar()
        {
            Moto moto = new Moto("Mobilete", "Antiga", 50);
            Console.WriteLine(moto.GetCilindrada());
            Console.WriteLine(moto.GetModelo());
            Console.WriteLine(moto.GetMarca());

            var moto2 = new Moto();

            moto2.SetCilindrada(600);
            moto2.SetModelo("hornet");
            moto2.SetMarca("honda");

            Console.WriteLine(moto2.GetCilindrada());
            Console.WriteLine(moto2.GetModelo());
            Console.WriteLine(moto2.GetMarca());
        }
    }
}
