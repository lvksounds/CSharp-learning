﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Classes abstratas não podem ser instanciadas;
// Criamos classes abstratas quando iremos passa-las por herança;
// Métodos abstratos para serem implementados precisam do nivel de acesso override;

namespace CursoCSharp01.OO
{
    public abstract class Celular
    {
        public abstract string Assistente();

        public string Tocar()
        {
            return "trim trim trim";
        }
    }

    public class Samsung : Celular
    {
        public override string Assistente()
        {
            return "Ol! Meu nome é Bixby";
        }
    }

    public class Iphone : Celular
    {
        public override string Assistente()
        {
            return "Ola! Meu nome é Siri";
        }
    }

    internal class Abstract
    {
        public static void Executar()
        {
            var celulares = new List<Celular>
            {
                new Iphone(),
                new Samsung()
            };

            foreach(var celular in celulares)
            {
                Console.WriteLine(celular.Assistente());
            }
            
        }
    }
}
