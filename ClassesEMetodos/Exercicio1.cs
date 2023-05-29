using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class ExerciciosGetESet
    {

        
        //==========================================  EXERCICIO 1 ==============================


        class Pessoa
        {
            private string nome;
            private DateTime dataNascimento;
            private double altura;
            
           

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

            public DateTime DataNascimento
            {
                get
                {
                    return DataNascimento;
                }
                set
                {
                    dataNascimento = value;
                }
            }

            public double Altura
            {
                get
                {
                    return altura;
                }
                set
                {
                    altura = value;
                }
            }


            public int calcularidade()
            {
                return DateTime.Today.Year - dataNascimento.Year;
            }

            public void imprimir()
            {
                Console.WriteLine($"Seu nome é: {nome}  Sua data de nascimento: {dataNascimento}  Sua altura é: {altura}");
            }

        }


        public static void Executar()
        {
            Pessoa pessoas = new Pessoa();

            pessoas.Nome = "Joaquim";
            pessoas.Altura = 1.80;
            pessoas.DataNascimento = new DateTime(2003, 05, 06);


            pessoas.imprimir();
           // pessoas.calcularidade();

            int idade = pessoas.calcularidade();

            Console.WriteLine($"Sua Idade:{idade}");
            


            
        }

    }

}



 

    

