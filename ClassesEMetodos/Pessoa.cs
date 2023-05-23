using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Pessoa
    {
        /*estados colocando o tipo public porque
         * quero que esse atributo fique visivel para
         * a minha classe,imagina que na vida real temos 
         * alguns atributos que precisam ser
         * publicos e outro atributos precisam ser privados*/
        public string Nome;
        public int Idade;

        public string Apresentar()
        {
            return string.Format($"Olá! Me chamo {Nome} e tenho {Idade}");
        }
        /*o método Format retorne uma string formatada e imrpime no console*/

        public void ApresentarnoConsole()
        {
            //aqui eu vou chamar no console o metodo que eu criei que é o apresentar
            Console.WriteLine(Apresentar());
        }
    }
}
