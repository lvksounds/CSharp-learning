using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp01.ClassesEMetodos
{


    public class CarroOpcional
    {
        double desconto = 0.1;
        string nome;

        public string Nome
        {
            get { return "Opcional: " + nome; }
            set { nome = value; }
        }

        // propriedades autoimplementadas
        public double Preco { get; set; }

        public double PrecoComDesconto
        {
            get => Preco - (desconto * Preco);
        }

        public CarroOpcional(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }
    internal class Propriedades
    {
        public static void Executar()
        {
            var carro = new CarroOpcional("Gol", 2000);
            Console.WriteLine(carro.PrecoComDesconto);


        }
    }
}
