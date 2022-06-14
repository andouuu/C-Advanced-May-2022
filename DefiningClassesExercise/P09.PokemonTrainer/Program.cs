using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace DefiningClasses
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            string cmd;
            Dictionary<string,Trainer> trainers = new Dictionary<string, Trainer>();
            while ((cmd=Console.ReadLine())!="Tournament")
            {
                string[] command=cmd.Split(' ',StringSplitOptions.RemoveEmptyEntries);
                Trainer currTrainer=new Trainer();
                string currTrainerName=command[0];
                currTrainer.Name=currTrainerName;
                Pokemon currPokemon=new Pokemon();
                currPokemon.Name = command[1];
                currPokemon.Element=command[2];
                currPokemon.Health = int.Parse(command[3]);
                if (!trainers.ContainsKey(currTrainerName))
                {
                    currTrainer.Pokemons.Add(currPokemon);
                    trainers.Add(currTrainerName,currTrainer);
                }
                else
                {
                    trainers[currTrainerName].Pokemons.Add(currPokemon);
                }
            }

            string cmd2;
            while ((cmd2=Console.ReadLine())!="End")
            {
                if (cmd2=="Fire"|| cmd2 == "Water" || cmd2 == "Electricity")
                {
                    foreach (var trainer in trainers)
                    {
                        if (trainer.Value.Pokemons.FirstOrDefault(x=>x.Element==cmd2)!=null)
                        {
                            trainer.Value.Badges++;
                        }
                        else
                        {
                            foreach (var pokemon in trainer.Value.Pokemons)
                            {
                                pokemon.Health -= 10;
                            }

                            trainer.Value.Pokemons.RemoveAll(x => x.Health <= 0);

                        }
                    }
                }
               
            }

            foreach (var trainer in trainers.OrderByDescending(x=>x.Value.Badges))
            {
                Console.WriteLine($"{trainer.Key} {trainer.Value.Badges} {trainer.Value.Pokemons.Count}");
            }
        }
    }
}
