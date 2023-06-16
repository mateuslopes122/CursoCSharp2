using System;
using System.Collections.Generic;
using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.POO;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.Excecoes;

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
                {"Classes e Métodos - ", EstruturaForech.Executar},
               // {"Classes e Métodos - ", Construtor.Executar},
                {"Classes e Métodos - ClassesEMetodos", Membros.Executar},
                {"Classes e Métodos - Construtores", Construtores.Executar},
                {"Classes e Métodos - Metodos Com Retorno", MetodosComRetorno.Executar},
                {"Classes e Métodos - Exercicios Metodos Com Retorno", ExerciciosMetodosComRetorno.Executar},
                {"Classes e Métodos - Metodos Estáticos", MetodosEstaticos.Executar},
                {"Classes e Métodos - Get Set", GetSet.Executar},
                {"Classes e Métodos - Params", Params.Executar},
                {"Classes e Métodos - Get e Set Segundo Exemplo", GetESetSgundoExemplo.Executar},
                {"Classes e Métodos - Exercicio 1", Exercicio1.Executar},
                {"Classes e Métodos - Exercicio 2", Exercicio2.Executar},
                {"Classes e Métodos - Exercicio 3", Exercicio3.Executar},

                //Coleções
                {"Coleções - Array", Arrays.Executar},
                {"Coleções - Queue", ColecoesQueue.Executar},
                {"Coleções - Stack", ColecoesSteck.Executar},

                //POO
                {"POO - Herença", Heranca.Executar},
                {"POO - Copntrutor This", ConstrutorThis.Executar},
                {"POO - Encapsulamento",POO.Encapsulamento.Executar}, 
                {"POO - Abstração", Abstracao.Executar},
                {"POO - Sealed", Sealed.Executar},

                //Metodos e Funções
                {"Métodos e Funções - Exemplo Lambda", ExemploLambda.Executar},
                {"Métodos e Funções - Exercicio Lambda", ExercicioLambda.Executar},

                //Excecões
                {"Excecões - Primeira Exceção", PrimeiraExcecao.Executar},


            });

            central.SelecionarEExecutar();
        }
    }
}