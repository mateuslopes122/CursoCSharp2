using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class ExerciciosMetodosComRetorno
    {

        class Converter
        {
            public double Dolar(double n1)
            {
                return n1 / 4.95;
            }
 
            public double Fahrenheit(double a)
            {
               return a*1.8+32;
            }
        }

        public static void Executar()
        {
           var resultado = new Converter();


            //EXERCICIO 1,DÓLAR
            Console.WriteLine("Digite um número em real para converter para dólar: ");
            double real = double.Parse(Console.ReadLine());


            var total = resultado.Dolar(real);
            Console.WriteLine($"Total da conversão: {total}. \n");


            //EXERCICIO 2,CELSIUS
            var result = new Converter();

            Console.WriteLine("Digite um número em celsius para converter para fahrenheit: ");
            double celsius = double.Parse(Console.ReadLine());

            var valor = result.Fahrenheit(celsius);
            Console.WriteLine($"Total da conversão para fahrenheit: {valor}.");

        }
    }

    
}
