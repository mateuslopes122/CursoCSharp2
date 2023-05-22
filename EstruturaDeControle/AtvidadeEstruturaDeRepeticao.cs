using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    class AtvidadeEstruturaDeRepeticao
    {
        public static void Executar()
        {

            //====================EXERCICIO 1=====================


            /*int soma = 0;
            for (int contador = 0; contador < 10; contador++) 
            {
                Console.WriteLine("Digite um número:");
                

                
               soma += i;
            }

            Console.WriteLine($"A soma total foi: {soma}");*/


            
            int contador2 = 1;

            Console.WriteLine("Digite um número para contar a contagem:");
            int.TryParse(Console.ReadLine(), out int n1);

            

            while(contador2 <= n1)
            {
                
                Console.WriteLine($"{contador2}");
                contador2++;
            }




            //====================EXERCICIO 3=====================

            /*int contador1 = 1;

            Console.WriteLine("Digite um número para saber sua tabuada:");
            int.TryParse(Console.ReadLine(), out int n1);
            while (contador1 <= 10) {
                
                Console.WriteLine($"{n1} X {contador1} = {n1*contador1}");
                contador1++;
            }*/
        }

       
    }
}
