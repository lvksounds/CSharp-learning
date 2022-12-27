using System;
using System.Collections.Generic;
using CursoCSharp01.ClassesEMetodos;
using CursoCSharp01.MetodosEFuncoes;
using CursoCSharp01.Fundamentos;
using CursoCSharp01.Colecoes;
using CursoCSharp01.OO;

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
                {"Params - Classes e métodos", Params.Executar},
                {"Parametros nomeados - Classes e métodos", ParametrosNomeados.Executar},
                {"Metodos com retorno - Classes e métodos", MetodosComRetorno.Executar},
                {"Metodos Estaticos - Classes e métodos", MetodosEstaticos.Executar},
                {"Atributos Estaticos - Classes e métodos", AtributosEstaticos.Executar},
                {"Desafio Atributos - Classes e métodos", DesafioAtributo.Executar},
                {"Getters e setters - Classes e métodos", GetSet.Executar},
                {"Propriedades - Classes e métodos", Propriedades.Executar},
                {"Readonly - Classes e métodos", Readonly.Executar},
                {"Enum - Classes e métodos", Enums.Executar},
                {"Structs - Classes e métodos", ExemploStructs.Executar},
                {"Struct vs Classe - Classes e métodos", StructVsClasse.Executar},
                {"Atribuição valor x referencia - Classes e métodos", ValorVsReferencia.Executar},
                {"Parametros por referencia - Classes e métodos", ParametrosPorReferencia.Executar},

                // Coleções
                {"Array - Coleções", Colecoes.Array.Executar},
                {"List - Coleções", ColecoesList.Executar},
                {"ArrayList - Coleções", ColecoesArrayList.Executar},
                {"Set - Coleções", ColecoesSet.Executar},
                {"Queue - Coleções", ColecoesQueue.Executar},
                {"Igualdade - Coleções", Igualdade.Executar},
                {"Stack - Coleções", ColecoesStack.Executar},
                {"Disctionary - Coleções", ColecoesDisctionary.Executar},

                //Orientação a objetos
                {"Herança - O.O", Heranca.Executar},
                {"Construtor this - O.O", ConstrutorThis.Executar},
                //{"Encapsulamento - O.O", OO.Encapsulamento.Executar},
                {"Polimorfismo - O.O", OO.Polimorfismo.Executar},
                {"Classes abstratas - O.O", OO.Abstract.Executar},
                {"Interfaces - O.O", OO.Interfaces.Executar},
                
                

                //Metodos e funcoes
                {"Exemplo Lambda", ExemploLambda.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}
