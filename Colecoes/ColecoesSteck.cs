using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    class ColecoesSteck
    {
        public static void Executar()
        {
            var pilha = new Stack();

            //adicionando elementos na pilha
            pilha.Push(3);
            pilha.Push("a");
            pilha.Push(true);
            pilha.Push(3.14);

            //exibindo elementos da pilha
            foreach(var item in pilha)
            {
                Console.WriteLine($"{item}");
            }

            //removendo um elemento da pilha
            Console.WriteLine($"Pop: {pilha.Pop()}");

            foreach (var item in pilha)
            {
                Console.WriteLine($"{item}");
            }

            //usando peek
            Console.WriteLine($"Peek: {pilha.Peek()} ");
            //contando elementos
            Console.WriteLine(pilha.Count);
        }
    }
}
