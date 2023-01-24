using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp01.TopicosAvancados
{
    // um valor dynamic é um valor que nao precisa receber um tipo especifico.
    // Ele pode ser alterado de tipo de acordo com o tempo de execução. 

    class Dynamics
    {
        public static void Executar()
        {
            dynamic meuObjeto = "teste";

            meuObjeto = 3;
            meuObjeto++;

            Console.WriteLine(meuObjeto);

            dynamic aluno = new System.Dynamic.ExpandoObject();

            aluno.nome = "Lucas de Freitas Oliveira";
            aluno.nota = 10.0;
            aluno.ori = "Oxaguiã";
            aluno.cargo = "kambondo";

            Console.WriteLine(aluno.ori);
        }
    }
}
