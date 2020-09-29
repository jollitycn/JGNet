using System;
using System.Collections.Generic;
using System.Text;

namespace JGNet.Manage.Models.GA
{
    /// <summary>
    /// 种群
    /// </summary>
    public class Population
    {
        public override String ToString()
        {
            String geneString = "";
            for (int i = 0; i < individuals.Length; i++)
            {
                geneString += individuals[i] + ",";
            }
            return geneString;
        }

        Individual[] individuals;
        // 建立一个总群
        public Population(int populationSize, bool initialise)
        {
            individuals = new Individual[populationSize];
            // 初始化种群
            if (initialise)
            {
                // 建立每一个个体
                for (int i = 0; i < Size(); i++)
                {
                    Individual newIndividual = new Individual();
                    newIndividual.GenerateIndividual();
                    SaveIndividual(i, newIndividual);
                }
            }
        }

        public Individual GetIndividual(int index)
        {
            return individuals[index];
        }

        public Individual GetFittest()
        {
            Individual fittest = individuals[0];
            // 取得适应度最高的个体作为种群的适应度
            for (int i = 0; i < Size(); i++)
            {
                if (fittest.GetFitness() <= GetIndividual(i).GetFitness())
                {
                    fittest = GetIndividual(i);
                }
            }
            return fittest;
        }

        // Get population size
        public int Size()
        {
            return individuals.Length;
        }

        // Save individual
        public void SaveIndividual(int index, Individual indiv)
        {
            individuals[index] = indiv;
        }
    }
}
