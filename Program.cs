using System;
using System.Collections.Generic;
using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Variaveis e Constantes - Fundamentos",VariaveisEConstantes.Executar },
                {"Notação Ponto - Fundamentos ",NotacaoPonto.Executar },
                {"Lendo Dados - Fundamentos", LendoDados.Executar },
                {"Formatando Números - Fundamentos ",FormatandoNumeros.Executar},
                {"Operadores Aritméticos - Fundamentos", OperadoresAritmeticos.Executar },
                {"Atividade1 - Fundamentos", Atividade1.Executar },
                {"Atividade2 - Fundamentos", Atividade2.Executar },
                {"Convertendo Try Parse - EstruturaDeControle", ConvertendoTryParse.Executar},
                {"Executar Switch - EstruturaDeControle", ExecutarSwitch.Executar},
                {"Estrutura While e For - EstruturaDeControle", EstruturaWhileEFor.Executar},
                {"Estrutua de Repetição - EstruturaDeRepeticao", AtvidadeEstruturaDeRepeticao.Executar},
                {"Estrutua de Foreach - EstruturaForeach", EstruturaForech.Executar},
                // Estrutura de Controle
                

            });

            central.SelecionarEExecutar();
        }
    }
}