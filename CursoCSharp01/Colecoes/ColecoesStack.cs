﻿using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp01.Colecoes
{
    internal class ColecoesStack
    {
        public static void Executar()
        {
            var pilha = new Stack();

            pilha.Push(3);
            pilha.Push("a");
            pilha.Push(true);
            pilha.Push(3.14);
        
            foreach(var item in pilha)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"\nPop: {pilha.Pop()}");
            Console.WriteLine($"\nPop: {pilha.Pop()}");
            Console.WriteLine($"\nPop: {pilha.Pop()}");
            Console.WriteLine($"\nPop: {pilha.Pop()}");

        }
    }
}
