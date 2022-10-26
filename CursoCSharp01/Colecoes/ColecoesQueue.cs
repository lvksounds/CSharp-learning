using System;
using System.Collections.Generic;
using System.Collections;

namespace CursoCSharp01.Colecoes
{
    internal class ColecoesQueue
    {
        public static void Executar()
        {
            var fila = new Queue<string>();

            fila.Enqueue("Ciclano");
            fila.Enqueue("Beltrano");
            fila.Enqueue("Fulano");

            Console.WriteLine(fila.Peek()); // metodo que pega o elemento ao topo da fila.
            Console.WriteLine(fila.Count); // Atributo que mostra o tamanho da fila. (semelhante ao lenght).

            Console.WriteLine(fila.Dequeue()); // remove o primeiro da fila
            Console.WriteLine(fila.Count);

            foreach(var pessoa in fila)
            {
                Console.WriteLine(pessoa);
            }

            var salada = new Queue();
            salada.Enqueue("Alface");
            salada.Enqueue(3);
            salada.Enqueue(true);
            salada.Enqueue(3.14);

            Console.WriteLine(salada.Contains("Alface"));

        }
    }
}
