using System;
using System.Collections.Generic;
using CursoCSharp01.ClassesEMetodos;
using CursoCSharp01.Fundamentos;


namespace CursoCSharp01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Variaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo dados - Fundamentos", LendoDados.Executar},
                {"Formatação e numeros - Fundamentos", FormatandoNumero.Executar},
                {"Conversoes - Fundamentos", Conversoes.Executar},
                {"Operadores de atribuição - Fundamentos", OperadoresAtribuicao.Executar},

                //Classes e metodos
                {"Membros - Classes e métodos", Membros.Executar},
                {"Construtores - Classes e métodos", Construtores.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}
