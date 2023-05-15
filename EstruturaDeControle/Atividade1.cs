using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class Atividade1
    {
        public static void Executar()
        {
             //EXERCICIO 1

            /*Console.WriteLine("Digite sua primeira Nota:");
            double n1 = double.Parse(Console.ReadLine());

             Console.WriteLine("Digite sua segunda Nota:");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua terceira Nota:");
            double n3 = double.Parse(Console.ReadLine()); 

            double nota = (n1 + n2 + n3) / 3;
            Console.WriteLine($"A sua média é de: {nota}");*/
            //-------------------------------------------------------------

            //EXERCICIO 2:


            /*Console.WriteLine("Digite sua primeira Nota:");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua segunda Nota:");
            double n2 = double.Parse(Console.ReadLine()); 

            double media1 = n1 * 3.5;
            double media2 = n2 * 7.5;
            double total = (media1 + media2) /11;

            Console.WriteLine($"A sua média é de: {total}");*/
            //------------------------------------------------------------

            //EXERCICO 3:

            Console.WriteLine("Digite o número de funcionários:");
            double funcionarios = double.Parse(Console.ReadLine());

            Console.WriteLine("Número de horas trabalhadas: ");
            double horas = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor que recebe por hora:");
            double salario = double.Parse(Console.ReadLine());

            double total = horas * salario;

            Console.WriteLine($"Funcionarios: {funcionarios}");
            Console.WriteLine($"Seu salário é: {total}");


        }
    }
}
