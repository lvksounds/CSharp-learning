using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp01.OO
{
    interface OperacaoBinaria
    {
        int Operacao(int a, int b);
    }
    class Interfaces
    {
        class Soma : OperacaoBinaria
        {
            public int Operacao(int a, int b)
            {
                return a + b;
            }
        }
        class Subtracao : OperacaoBinaria
        {
            public int Operacao(int a, int b)
            {
                return a - b;
            }
        }
        class Multiplicacap : OperacaoBinaria
        {
            public int Operacao(int a, int b)
            {
                return a * b;
            }
        }
        class Calculadora
        {
            public List<OperacaoBinaria> operacoes = new List<OperacaoBinaria>
            {
                new Soma(),
                new Subtracao(),
                new Multiplicacap(),
            };

            public string ExecutarOperacoes(int a, int b)
            {
                string resultado = "";
                foreach(var op in operacoes)
                {
                    resultado += $"Usando a operação {op.GetType().Name} = {op.Operacao(a, b)}";
                    
                }
                return resultado;
            }

        }
        public static void Executar()
        {
            Calculadora calc = new Calculadora();
            calc.ExecutarOperacoes(10, 20);
            calc.ExecutarOperacoes(14, 25);
            calc.ExecutarOperacoes(10, 4);
            

        }
    }
}
