using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAritmeticos
    {
        public static void Executar()
        {

            //soma de dois numeros
            //Console.WriteLine("Digite um número:");
            //int n1 = int.Parse(Console.ReadLine());

            //Console.WriteLine($"Seu primeiro número é: {n1}\n");

            //Console.WriteLine("Digite outro número");
            //int n2 = int.Parse(Console.ReadLine());

            //Console.WriteLine($"Seu segundo número é: {n2}\n");

            //nt soma = n1 + n2;

            //Console.WriteLine($"A soma dos números deu o resultado: {soma} \n \n");
            //*soma de dois numeros

            //base e altura do triangulo
            Console.WriteLine("Digite um número base do triângulo:");
            double basee = double.Parse(Console.ReadLine());

            Console.WriteLine($"O número base do triangulo é: {basee}\n");

            Console.WriteLine("Digite a altura do triângulo:");
            double altura = double.Parse(Console.ReadLine());

            double total = basee * altura/2;

            Console.WriteLine($"A área do triangulo é de: {total}");
            


        }
    }
}
