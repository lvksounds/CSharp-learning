using System;
using System.Collections.Generic;

using CursoCSharp01.Fundamentos;


namespace CursoCSharp01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Variaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar}
            });

            central.SelecionarEExecutar();
        }
    }
}
