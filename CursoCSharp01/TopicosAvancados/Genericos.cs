using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp01.TopicosAvancados
{
    // Conceito de generics. 
    // 


    public class Caixa<T>
    {
        T valorPrivado; 
        public T Coisa { get; set; }

        public Caixa(T coisa)
        {
            this.Coisa = coisa;
            this.valorPrivado = coisa;
        }

        public T metodoGenerico(T valor)
        {
            return new Random().Next(0,2) == 0 ? Coisa : valor;
        }

        public T getValor()
        {
            return valorPrivado;
        }
    }

    class CaixaInt : Caixa<int>
    {
        public CaixaInt() : base(0)
        {

        }
    }

    class Genericos
    {
        public static void Executar()
        {

            var caixa1 = new Caixa<int>(1000);

            Console.WriteLine(caixa1.metodoGenerico(10));
            
        }
    }
}
