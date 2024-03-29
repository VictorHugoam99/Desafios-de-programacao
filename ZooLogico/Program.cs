﻿using System;
using System.Linq;
using ZooLogico.Interfaces;
using ZooLogico.Models.Animais;
using ZooLogico.Models.Jaulas;
using System.Collections.Generic;


namespace ZooLogico
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variável de controle do Loop Principal
            Animal [] Pasto = new Animal [3];
            Animal [] Gaiola = new Animal [3];
            Animal [] CasaEmArvore = new Animal [3];
            Animal [] CavernaDePedra = new Animal [3];
            Animal [] PiscinaGelada = new Animal [3];
            Animal [] Piscina = new Animal [3];
            Animal [] Aquario = new Animal [3];
            
            #region Loop Principal
            var encerrouPrograma = false;

            do
            {
                #region Menu Principal
                var codigo = 0;
                Console.Clear();
                System.Console.WriteLine("++++++++++++++++++++++++++++++");
                System.Console.WriteLine("|  Bem vindo ao ZooLógico!   |");
                System.Console.WriteLine("++++++++++++++++++++++++++++++");
                // Gerar os itens do menu de forma automática
                foreach (var item in Arca.Animais.Values)
                {
                    System.Console.WriteLine($"{"",5}{++codigo}. {item.GetType().Name}");
                }
                #endregion
                System.Console.Write($"\n{"",2}Digite o código do animal: ");
                
                // Testando se o usuário digitou um código correto ou não
                try
                {
                    var opcaoUsuario = int.Parse(Console.ReadLine());
                    var animal = Arca.Animais[opcaoUsuario];
                    ClassificarAnimal(animal);
                }
                catch (Exception e)
                {
                    System.Console.WriteLine("Por favor, digite um código válido");
                    Console.ReadLine();
                    
                }
            } while (!encerrouPrograma);
            #endregion
        }
        public static void ClassificarAnimal(Animal animal, Animal Aquario, Animal CasaEmArvore, Animal CavernaDePedra, Animal Gaiola, Animal Pasto, Animal Piscina, Animal PiscinaGelada)  
        {
            // Esse @ é para que possamos usar o nome interface para a variável, que é uma palavra reservada do C#!
            var classe = animal.GetType();
            var @interface = classe.GetInterfaces().FirstOrDefault();

            if ((typeof(IAquatico)).Equals(@interface))
            {
                System.Console.WriteLine($":::{classe.Name} pode ir para a Piscina:::");
            }
            else if ((typeof(IArboricula)).Equals(@interface))
            {
                System.Console.WriteLine($":::{classe.Name} pode ir para a Casa na Árvore:::");
            }
            else if ((typeof(IBranquiado)).Equals(@interface))
            {
                System.Console.WriteLine($":::{classe.Name} pode ir para o Aquário:::");
            }
            else if ((typeof(IQuionofilo)).Equals(@interface))
            {
                System.Console.WriteLine($":::{classe.Name} pode ir para a Piscina Gelada:::");
            }
            else if ((typeof(ITerrestre)).Equals(@interface))
            {
                System.Console.WriteLine($":::{classe.Name} pode ir para os Pastos ou Caverna de Pedra:::");
            }
            else if ((typeof(IVoador)).Equals(@interface))
            {
                System.Console.WriteLine($":::{classe.Name} pode ir para a Gaiola:::");
            }

            Console.ReadLine();

        }


    }
}
