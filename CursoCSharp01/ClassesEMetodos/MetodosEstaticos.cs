using System;

namespace CursoCSharp01.ClassesEMetodos
{
    internal class MetodosEstaticos
    {
        public class CalculadoraEstatica
        {
            // Quando um método é estático, eu nao preciso instanciar um objeto na classe pai dele

            //Metodo de classe
            public static int Soma(int a, int b)
            {
                return a + b;
            }

            //Metodo de instancia
            public int Subtracao(int a, int b)
            {
                return a - b;
            }

        }
        public static void Executar()
        {
            var resultado = CalculadoraEstatica.Soma(2, 1); // metodo da classe (static) sendo acessivel necessidade de instanciar

            var sub = new CalculadoraEstatica();

            Console.WriteLine(sub.Subtracao(4, 2));
        }

    }
}
