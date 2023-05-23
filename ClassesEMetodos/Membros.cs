using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Membros
    {
        public static void Executar()
        {
            /*instanciando a classe pessoa e criando um objeto*/

            /*Pessoa pessoa1 = new Pessoa();

            pessoa1.Nome = "Cleiton Peres";
            pessoa1.Idade = 22;

            Pessoa pessoa2 = new Pessoa();

            pessoa2.Nome = "Zezé de Camargo";
            pessoa2.Idade = 15;

            *//*Console.WriteLine($"Nome: {pessoa2.Nome}") ;
            Console.WriteLine($"Idade: {pessoa2.Idade}");*//*

            //chamando o método Aprensentar
            pessoa1.ApresentarnoConsole();*/

            Carro peca1 = new Carro();

            peca1.Cambio = "está ruim";
            peca1.Motor = "queboru";

            Console.WriteLine($"Seu cambio {peca1.Cambio}") ;
            Console.WriteLine($"Seu motor {peca1.Motor} \n");

            peca1.LocomoverConsole();

        }
    }
}
