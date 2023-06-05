using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Exercicio3
    {
        class Animal { 

        string nome;
        string tipo;

        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }

        }
         
        public string Tipo
        {
            get
            {
                return tipo;
            }
            set
            {
                if(tipo == "Cachorro" || tipo == "Gato" || tipo == "Ave")
                {
                    tipo = value;
                }
                else
                {
                    tipo = "Ave";
                }
            }
        }

        }


        public static void Executar()
        {

            var animal1 = new Animal();

            Console.WriteLine("Digite o nome do animal:");
            animal1.Nome = (Console.ReadLine());

            Console.WriteLine("Digite o tipo animal:");
            animal1.Tipo = (Console.ReadLine());


            Console.WriteLine(animal1.Nome);
            Console.WriteLine(animal1.Tipo);
        }
    }
}
