using System;

namespace CursoCSharp01.Excecoes
{
    public class NegativoException : Exception
    {
        public NegativoException() { }

        public NegativoException(string message) : base(message) { }

        public NegativoException(string messagem, Exception inner) : base(messagem, inner) { }
    }

    public class ImparException : Exception
    {
        public ImparException(string message) : base(message){ }
    }
    internal class ExcecoesPersonalizadas
    {
        public static int PositivoPar()
        {
            Random random = new Random();

            int valor = random.Next(-30, 30);

            if (valor < 0)
            {
                throw new NegativoException("Numero Negativo");
            }

            if (valor % 2 == 1)
            {
                throw new ImparException("Valor impar...");
            }

            return valor;
        }
        public static void Executar()
        {
            try
            {
                Console.WriteLine(PositivoPar());
            } 
            catch(NegativoException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(ImparException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
