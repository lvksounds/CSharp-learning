using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp01.ClassesEMetodos
{
    class Construtores
    {
        class Carro
        {
            public string Modelo;
            public string Fabricante;
            public int Ano;

            public Carro(string modelo, string fabricante, int ano)
            {
                Modelo = modelo;
                Fabricante = fabricante;
                Ano = ano;
            }
            public Carro()
            {

            }
        }
        public static void Executar()
        {
            Carro carro1 = new Carro();
            carro1.Modelo = "Gol";
            carro1.Fabricante = "Volkswagem";
            carro1.Ano = 2010;

            Console.WriteLine(
                $"Hoje comprei um carro novo, um {carro1.Modelo}, da {carro1.Fabricante}, ano {carro1.Ano}");

            var carro2 = new Carro("Uno", "Fiat", 1998);
            Console.WriteLine(
                $"Hoje comprei um carro novo, um {carro2.Modelo}, da {carro2.Fabricante}, ano {carro2.Ano}");

            var carro3 = new Carro()
            {
                Modelo = "Civic",
                Ano = 2017,
                Fabricante = "Honda"
            };
            Console.WriteLine(
                $"Hoje comprei um carro novo, um {carro3.Modelo}, da {carro3.Fabricante}, ano {carro3.Ano}");

        }
    }
}
