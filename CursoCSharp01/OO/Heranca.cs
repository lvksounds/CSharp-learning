using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp01.OO
{
    public class Carro
    {
        protected readonly int VelocidadeMaxima;
        int VelocidadeAtual;
        public Carro(int velocidadeMaxima)
        {
            VelocidadeMaxima = velocidadeMaxima;
        }

        protected int AlterarVelocidade(int delta)
        {
            int novaVelocidade = VelocidadeAtual + delta;
            if(novaVelocidade < 0)
            {
                VelocidadeAtual = 0;
            }
            else if(novaVelocidade > VelocidadeMaxima)
            {
                VelocidadeAtual = VelocidadeMaxima;
            }
            else
            {
                VelocidadeAtual = novaVelocidade;
            }
            return VelocidadeAtual;
        }
        public virtual int Acelerar()
        {
            return AlterarVelocidade(5);
        }

        public int Frear()
        {
            return AlterarVelocidade(-5);
        }
        
    }

    public class Uno : Carro
    {
        public Uno() : base(200)
        {

        }
    }
    public class Ferrari : Carro
    {
        public Ferrari() : base(300)
        {

        }

        // resscrevendo o metodo acelerar com sobrecarga
        public override int Acelerar()
        {
            return AlterarVelocidade(15);
        }


        // oculta o metodo da classe pai, pois no pai o metodo base nao é marcado com virtual
        public new int Frear()
        {
            return AlterarVelocidade(-10);
        }
    }

    internal class Heranca
    {
        public static void Executar()
        {
            Console.WriteLine("uno..");
            var carro1 = new Uno();


            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());

            Console.WriteLine("Ferrari...");
            var carro2 = new Ferrari();

            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());


            Console.WriteLine("Ferrari com tipo Carro");
            Carro carro3 = new Ferrari(); // polimorfismo. 
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());

            Console.WriteLine("Uno com tipo Carro");
            carro3 = new Uno();
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());

        }
    }
}
