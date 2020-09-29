
using System;
using System.Collections.Generic;
using System.Text;

namespace JGNet.Manage.Models.GA
{
    /// <summary>
    /// 个体
    /// </summary>
    public class Individual
    {

        static int defaultGeneLength = 64;
        private int[] genes = new int[defaultGeneLength];
        private int fitness = 0;

        // 随机的个体
        public void GenerateIndividual()
        {
            for (int i = 0; i < Size(); i++)
            {
                //  Random random = new Random(GlobalUtil.GetRandomSeed());
                // int gene = random.Next(0, Size() - 1);
                //  byte gene = (byte)Math.Round(Math());
                int gene = (int)Math.Round(new Random().NextDouble());
                genes[i] = gene;
            }
        }

        // Use this if you want to create individuals with different gene Lengths
        public static void SetDefaultGeneLength(int Length)
        {
            defaultGeneLength = Length;
        }

        public int GetGene(int index)
        {
            return genes[index];
        }

        public void SetGene(int index, int value)
        {
            genes[index] = value;
            fitness = 0;
        }

        public int Size()
        {
            return genes.Length;
        }

        public int GetFitness()
        {
            if (fitness == 0)
            {
                fitness = FitnessCalc.GetFitness(this);
            }
            return fitness;
        }


        public override  String ToString()
        {
            String geneString = "";
            for (int i = 0; i < Size(); i++)
            {
                geneString += GetGene(i);
            }
            return geneString;
        }
    }

}
