using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Carro
    {

        public string Cambio;
        public string Motor;

        public string Locomover()
        {
            return string.Format($"O motor do seu carro {Motor} e o câmbio {Cambio}!  ");
        }

        public void LocomoverConsole()
        {
            Console.WriteLine(Locomover());
        }
    }
}
