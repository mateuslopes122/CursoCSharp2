using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class Atividade2
    {
        public static void Executar()
        {

            //EXERCICIO 1

            /*Console.WriteLine("Digite o seu ano de nascimento: ");
            
            int nasc = int.Parse(Console.ReadLine());
            int ano = 2023-nasc;

            if(ano >= 18 && ano <= 70)
            {
                Console.WriteLine($"Você pode votar por já ter {ano}");
            }
            else
            {
                Console.WriteLine($"Você não é obrigado por ter {ano}");
            }*/
            //-------------------------------------------------------------------

            //EXERCICIO 2

            /*Console.WriteLine("Escreva sua senha: ");
            var senha = "7taz9HvJ";
            var senha2 = (Console.ReadLine());

            if(senha2 == senha)
            {
                Console.WriteLine("ACESSO PERMITIDO");
            }
            else
            {
                Console.WriteLine("ACESSO NEGADO");
            }*/
            //-------------------------------------------------------------------

            //EXERCICIO 3

            /*Console.WriteLine("Digite sua primeiro nota: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua segunda nota: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua terceira nota:");
            double n3 = double.Parse(Console.ReadLine());

            double media = (n1 + n2 + n3) / 3;

            if(media >= 7)
            {
                Console.WriteLine("\n APROVADO");
            }else if(media >= 5 && media < 7)
            {
                Console.WriteLine($"\n Sua media foi de:");
                Console.WriteLine(media.ToString("#.## \n"));
                Console.WriteLine("Você está de recuperação");
            }
            else if(media < 5)
            {
                Console.WriteLine("\n REPROVADO");
            }*/
            //----------------------------------------------------------

            //EXERCICIO 4


            Console.WriteLine("Digite sua altura");
            double altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu peso");
            double peso = double.Parse(Console.ReadLine());

            double imc = peso/(altura*altura);

            if (imc < 18.5)
            {
                Console.WriteLine("\n Abaixo do peso:\n");
                Console.WriteLine(imc.ToString("##.#"));
            }
            else if (imc > 18.5 && imc <= 24.9)
            {
                Console.WriteLine("\n Peso Normal: \n");
                Console.WriteLine(imc.ToString("##.#"));
            }
            else if (imc > 24.9 && imc <= 29.9)
            {
                Console.WriteLine("\n Acima do peso:");
                Console.WriteLine(imc.ToString("##.#"));
            }
            else if (imc > 29.9 && imc <= 34.9)
            {
                Console.WriteLine("\n Obesidade grau I: \n");
                Console.WriteLine(imc.ToString("##.#"));
            }
            else if (imc > 34.9 && imc <= 39.9)
            {
                Console.WriteLine("\n Obesidade grau II: \n");
                Console.WriteLine(imc.ToString("##.#"));
            }
            else
            {
                Console.WriteLine("\n Obesidade grau III: \n");
                Console.WriteLine(imc.ToString("##.#"));
            }





        }
    }
}
