using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CursoCSharp.POO
{
    class Heranca
    {

        public class Carro
        {
            protected readonly int VelocidadeMaxima;
            //a velocidade maxima será transmitida por herença
            //por isso que estamos usando o protected
            int VelocidadeAtual;

            //criando o contrutor de carro
            public Carro(int velocidadeMaxima)
            {
                VelocidadeMaxima = velocidadeMaxima;
            }

            //criando método para acelerar o carro
            protected int AlterarVelocidade(int delta)
            {
                int novaVelocidade = VelocidadeAtual + delta;
                if (novaVelocidade < 0)
                {
                    VelocidadeAtual = 0;
                } else if (novaVelocidade > VelocidadeMaxima)
                {
                    VelocidadeAtual = VelocidadeMaxima;
                }
                else
                {
                    VelocidadeAtual = novaVelocidade;
                }

                return VelocidadeAtual;
            }
            public int Acelerar()
            {
                return AlterarVelocidade(5);
            }

            public int Frear()
            {
                return AlterarVelocidade(-5);
            }
        }

        public class Uno : Carro
        {
            /* o número de 200 que está entre base () 
             significa a velocidadeMaxima que foi herdade de carro
            usamos base para nao precisar fazer o contrutor novamente*/
            public Uno() : base(300)
            {

            }
        }

        public class CorsaWind : Carro
        {
            public CorsaWind() : base(400)
            {

            }
        }




    public static void Executar()
            {
                Console.WriteLine("Uno...");
                //intanciar carro1 em Uno
                Uno carro1 = new Uno();

                Console.WriteLine(carro1.Acelerar());
                Console.WriteLine(carro1.Acelerar());
                Console.WriteLine(carro1.Acelerar());
                Console.WriteLine(carro1.Acelerar());
                Console.WriteLine(carro1.Acelerar());
                Console.WriteLine(carro1.Frear());
            Console.WriteLine("\n");

            //instaciar carro2 em CorsaWind
            CorsaWind carro2 = new CorsaWind();

            Console.WriteLine("CorsaWind...");
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro1.Frear());

        }
    }
    }
