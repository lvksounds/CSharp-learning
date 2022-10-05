using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticaLinguagem.ExerciciosBeeCrowd.Iniciante
{
    internal class Cedulas
    {
        public static void CalculaNotas()
        {
            /*
                Leia um valor inteiro. 
                A seguir, calcule o menor número de notas possíveis (cédulas) no qual o valor pode ser decomposto.
                As notas consideradas são de 100, 50, 20, 10, 5, 2 e 1. 
                A seguir mostre o valor lido e a relação de notas necessárias.
                
                Imprima o valor lido e, em seguida, a quantidade mínima de notas de cada tipo necessárias, conforme o exemplo fornecido.
                Não esqueça de imprimir o fim de linha após cada linha, caso contrário seu programa apresentará a mensagem: “Presentation Error”.
                
                576
                5 nota(s) de R$ 100,00
                1 nota(s) de R$ 50,00
                1 nota(s) de R$ 20,00
                0 nota(s) de R$ 10,00
                1 nota(s) de R$ 5,00
                0 nota(s) de R$ 2,00
                1 nota(s) de R$ 1,00
            */


            
            
            Console.Write("Valor Desejado: ");
            int valor = int.Parse(Console.ReadLine());
            int total = valor;
            int ced = 100; // maior valor possivel
            int totced = 0;

            while (true)
            {
                if (total >= ced)
                {
                    total -= ced;
                    totced++;
                } else
                {
                    Console.WriteLine("{0} nota(s) de R${1}", totced, ced);
                    if(ced == 100)
                    {
                        ced = 50;
                    }
                    else if (ced == 50)
                    {
                        ced = 20;
                    }
                    else if (ced == 20)
                    {
                        ced = 10;
                    }
                    else if (ced == 10)
                    {
                        ced = 5;
                    }
                    else if (ced == 5)
                    {
                        ced = 2;
                    }
                    else if (ced == 2)
                    {
                        ced = 1;
                    }
                    totced = 0;

                    if(total == 0)
                    {
                        break;
                    }

                }
            }
        }
    }
}


