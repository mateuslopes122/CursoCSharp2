namespace CursoCSharp.ClassesEMetodos
{
    class Exercicio2
    {

        class Aluno
        {

            private double n1;
            private double n2;
            private double n3;
            public string nome;


            public double Media
            {
                get
                {
                    return (n1 + n2 + n3) / 3;
                }
                set
                {
                    n1 = value;
                    n2 = value;
                    n3 = value;
                }
            }

            public string Nome
            {
                get
                {
                    return Nome;
                }
                set
                {
                    nome = value;
                }
            }


            public Aluno(string nome, double n1, double n2, double n3)
            {
                Nome = nome;
                this.n1 = n1;
                this.n2 = n2;
                this.n3 = n3;


            }


        }




        public static void Executar()
        {
            /* var total = new Aluno("Jonas", 1, 4, 5);

             Console.WriteLine($"Olá");
             Console.WriteLine(total.nome);
             Console.WriteLine("Sua média foi:");
             Console.WriteLine(total.Media);*/

            

        }
    }
}
