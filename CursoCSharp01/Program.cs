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
<<<<<<< HEAD
                {"Params - Classes e métodos", Params.Executar},
                {"Parametros nomeados - Classes e métodos", ParametrosNomeados.Executar},
=======
                {"Metodos com retorno - Classes e métodos", MetodosComRetorno.Executar},
                {"Metodos Estaticos - Classes e métodos", MetodosEstaticos.Executar},
                {"Atributos Estaticos - Classes e métodos", AtributosEstaticos.Executar},
                {"Desafio Atributos - Classes e métodos", DesafioAtributo.Executar},
>>>>>>> 347db542f2e10654bdf1644e57ec8b6a958bfdd8
            });

            central.SelecionarEExecutar();
        }
    }
}
