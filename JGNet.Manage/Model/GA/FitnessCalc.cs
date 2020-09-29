using System;
using System.Collections.Generic;
using System.Text;

namespace JGNet.Manage.Models.GA
{

    public class FitnessCalc
    {
         
        static byte[] solution = new byte[64];

        // 设置一个候选解
        public static void SetSolution(byte[] newSolution)
        {
            solution = newSolution;
        }

        // 设置一个候选解 就是参数类型不一样，这里做个转换
        public  static void SetSolution(String newSolution)
        {
            solution = new byte[newSolution.Length];
            // Loop through each character of our string and save it in our byte 
            // array
            for (int i = 0; i < newSolution.Length; i++)
            {
                String character = newSolution.Substring(i, i + 1);
                if (character.Contains("0") || character.Contains("1"))
                {
                    solution[i] = Byte.Parse(character);
                }
                else
                {
                    solution[i] = 0;
                }
            }
        }

        // 计算某一个个体的适应度
     public   static int GetFitness(Individual individual)
        {
            int fitness = 0;
            // 个体和候选解比较，约接近候选集，适应度越高
            for (int i = 0; i < individual.Size() && i < solution.Length; i++)
            {
                if (individual.GetGene(i) == solution[i])
                {
                    fitness++;
                }
            }
            return fitness;
        }

        // 适应度的最大值
        public static int GetMaxFitness()
        {
            int maxFitness = solution.Length;
            return maxFitness;
        }
    }
}
