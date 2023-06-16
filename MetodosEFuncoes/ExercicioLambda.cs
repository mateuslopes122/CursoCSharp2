using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    class ExercicioLambda
    {



        public static void Executar()
        {
            Func<int, bool> ParImpar = (total) =>
            {
                if(total %2 == 0)
                {
                    Console.WriteLine("O seu número é Par");
                    return true;
                }
                else
                {
                    Console.WriteLine("Número Ímpar");
                    return false;
                }
            };

            Console.WriteLine(ParImpar(2));
        }
    }
}
