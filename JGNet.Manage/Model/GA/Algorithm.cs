using System;
using System.Collections.Generic;
using System.Text;

namespace JGNet.Manage.Models.GA

{ 
        public class Algorithm
        {

        //配置项
            private const double uniformRate = 0.5;
            private const double mutationRate = 0.015;
            private const int tournamentSize = 5;
            private const bool elitism = true;

            // 进化一个种群
            public static Population EvolvePopulation(Population pop)
            {
                Population newPopulation = new Population(pop.Size(), false);

                // 保留最优秀的个体
                if (elitism)
                {
                    newPopulation.SaveIndividual(0, pop.GetFittest());
                }
                // 交叉种群
                int elitismOffset;
                if (elitism)
                {
                    elitismOffset = 1;
                }
                else
                {
                    elitismOffset = 0;
                }
                // 交叉产生新的个体
                for (int i = elitismOffset; i < pop.Size(); i++)
                {
                    //确保不要把最差的个体选进来
                    Individual indiv1 = TournamentSelection(pop);
                    Individual indiv2 = TournamentSelection(pop);
                    Individual newIndiv = Crossover(indiv1, indiv2);
                    newPopulation.SaveIndividual(i, newIndiv);
                }

                // 变异
                for (int i = elitismOffset; i < newPopulation.Size(); i++)
                {
                    Mutate(newPopulation.GetIndividual(i));
                }

                return newPopulation;
            }

            // 交叉
            private static Individual Crossover(Individual indiv1, Individual indiv2)
            {
                Individual newSol = new Individual();
                // Loop through genes
                for (int i = 0; i < indiv1.Size(); i++)
                {
                    ;
                    // 以一定概率交叉
                    if (new Random().NextDouble() <= uniformRate)
                    {
                        newSol.SetGene(i, indiv1.GetGene(i));
                    }
                    else
                    {
                        newSol.SetGene(i, indiv2.GetGene(i));
                    }
                }
                return newSol;
            }

            // 变异
            private static void Mutate(Individual indiv)
            {
                // Loop through genes
                for (int i = 0; i < indiv.Size(); i++)
                {
                    if (new Random().NextDouble() <= mutationRate)
                    {
                        // 以一定概率变异
                        //   Random random = new Random(GlobalUtil.GetRandomSeed()); 
                        // int gene = random.Next(0, indiv.Size() - 1);

                        int gene= (int)Math.Round(new Random().NextDouble());
                        indiv.SetGene(i, gene);
                    }
                }
            }

            // 选择用于交叉的个体，确保最差的个体不会进来
            private static Individual TournamentSelection(Population pop)
            {
                Population tournament = new Population(tournamentSize, false);
                for (int i = 0; i < tournamentSize; i++)
                {
                    int randomId = (int)(new Random().NextDouble() * pop.Size());
                    tournament.SaveIndividual(i, pop.GetIndividual(randomId));
                }
                Individual fittest = tournament.GetFittest();
                return fittest;
            }
        }
}
