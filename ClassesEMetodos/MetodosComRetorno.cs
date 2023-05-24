using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class MetodosComRetorno
    {

        class CalculadoraComum
        {
            public int Somar(int a, int b)
            {
                return a + b;
            }

            public int Subtrair(int c, int d)
            {
                return c - d;
            }

            public int Multiplicar(int e, int f)
            {
                return e * f;
            }
        }

        public static void Executar()
        {
            //instaciando o meu objeto CalculadoraComum
            var calculadoraComum = new CalculadoraComum();

            var resultado = calculadoraComum.Somar(27, 42);
            Console.WriteLine(resultado);

            Console.WriteLine(calculadoraComum.Subtrair(5, 18));

            Console.WriteLine(calculadoraComum.Multiplicar(8, 12));


        }
    }
}
