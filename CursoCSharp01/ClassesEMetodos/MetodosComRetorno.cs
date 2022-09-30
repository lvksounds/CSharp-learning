using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp01.ClassesEMetodos
{
    class CalculadoraComum
    {
        public int Somar(int a, int b)
        {
            return a + b;
        }
        public int Subtrair(int a, int b)
        {
            return a - b;
        }

        public int Multiplicar(int a, int b)
        {
            return a * b;
        }

        public int Dividir(int a, int b)
        {
            return a / b;
        }

    }

    public class CalculadoraCadeia
    {
        private int memoria;

        public CalculadoraCadeia Somar(int a)
        {
            memoria += a;

            return this;
        }

        public CalculadoraCadeia Multiplicar(int a)
        {
            memoria *= a;
            return this;
        }

        public CalculadoraCadeia Limpar()
        {
            memoria = 0;
            return this;
        }

        public CalculadoraCadeia Imprimir()
        {
            Console.WriteLine(memoria);
            return this;
        }

        public int Resultado()
        {
            return memoria;
        } 
    }
    class MetodosComRetorno
    {
        public static void Executar()
        {
            var calculos = new CalculadoraComum();
            var soma = calculos.Somar(5, 5);
            var subtrai = calculos.Subtrair(10, 5);
            var multiplica = calculos.Subtrair(6, 2);
            var divide = calculos.Dividir(25, 5);

            Console.WriteLine($"soma: {soma}, subtração: {subtrai}, multiplicação: {multiplica}, divisão: {divide}");

            var calculadoraCadeia = new CalculadoraCadeia();

            calculadoraCadeia.Somar(3).Multiplicar(5).Somar(40).Imprimir().Limpar().Imprimir();

            var resultado = calculadoraCadeia.Somar(10).Multiplicar(2).Resultado().ToString();

            Console.WriteLine(resultado);
        }
    }
}
