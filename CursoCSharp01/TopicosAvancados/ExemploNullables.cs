using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Conceito de Nullables: É o conceito de termos o controle de uma variavel que nao foi definida ainda. 

namespace CursoCSharp01.TopicosAvancados
{
    class ExemploNullables
    {
        public static void Executar()
        {
            Nullable<int> num1 = null;

            int? num2 = null;

            if (num1.HasValue)
            {
                Console.WriteLine($"Valor de num1: {num1}");
            } else
            {
                Console.WriteLine("A variável não possuí valor."); 
            }

            int valor = num1 ?? 1000; // nesse caso, se num1 for null, ele pega o valor de 1000. 

            Console.WriteLine(valor);

            bool? booleana = null;
            bool resultado = booleana.GetValueOrDefault();

            Console.WriteLine(resultado);

            try
            {
                int x = num1.GetValueOrDefault();
                int y = num2.GetValueOrDefault();

                Console.WriteLine(x + y);
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
