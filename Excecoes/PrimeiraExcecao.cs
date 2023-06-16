using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Excecoes
{
    class PrimeiraExcecao
    {

        public class Conta
        {
            private double Saldo;

            public Conta(double saldo)
            {
                Saldo = saldo;
            }

            public void Sacar(double valor)
            {
                if (valor > Saldo)
                {
                    throw new ArgumentException("Saldo Insuficiente");
                }

                //se o usuário sacar um valor menos o saldo
                //entao só subtraimos esse valor da conta dele
                Saldo -= valor;
            }
        }

        


        public static void Executar()
        {
            var conta = new Conta(1200);

            try
            {
                //aqui vanmos tentar sacar, se der certo o valor será retirado
                conta.Sacar(500);
                Console.WriteLine("Valor retirado com sucesso");
            }
            catch (Exception ex)
            {
                //aqui dentro vamos receber a exceção (erro) que foi lançado
                Console.WriteLine(ex.Message);
                //além do try e catch temos o finally que é executado em qualquer situação
            }
            finally
            {
                Console.WriteLine("Obrigado");
            }

        }
    }
}
