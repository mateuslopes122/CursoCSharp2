﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    class ExemploLambda
    {
        public static void Executar()
        {
            //criando função
            Action algoNoConsole = () =>
            {
                Console.WriteLine("Palmeiras não tem mundial");
            };

            //chamando a função
            //algoNoConsole();

            //criando uma função com retorno
            Func<int> jogarDado = () =>
            {
                Random random = new Random();
                return random.Next(1, 6);
            };

            Console.WriteLine(jogarDado());

            Func<int, int, int, string> formatarDado = (dia, mes, ano) =>
               {
                   return string.Format("{0:D2} / {1:D2} / {2:D2}", dia, mes, ano);
               };

            Console.WriteLine(formatarDado(25,05,2005));
        }
    }
}
