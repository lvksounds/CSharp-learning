using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp01.Colecoes
{
    internal class Array
    {
        public static void Executar()
        {
            string[] alunos = new string[5] { "Lucas", "Sarah", "Gustavo", "Jader", "Matthew"};

            foreach(string aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            double somatorio = 0;
            double[] notas = { 7.8, 6.1, 8,2, 10.0 };
            
            foreach(double nota in notas)
            {
                somatorio += nota;
            }
            Console.WriteLine(somatorio);

            double media = somatorio / notas.Length;

            Console.WriteLine(media);
        }
    }
}
