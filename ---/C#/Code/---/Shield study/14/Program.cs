using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        static string[] StudentByDifficulty(LearningPlatform platform, string difficulty)
        {
            int counter = 0;
            for (int i = 0; i < Platform1.GetRegistered().GetCompleted().Length; i++)
            {
                if (Platform1.GetRegistered().GetCompleted()[i].GetDiffuculty() == difficulty)
                {
                    counter++;
                }
            }
            string[] passers = new string[counter];
            for (int i = 0, step = 0; i < Platform1.GetRegisered().GetCompleted().Length; i++)
            {

                if (Platform1.GetRegistered().GetCompleted()[i].GetDiffuculty() == difficulty)
                {
                    passers[step] = Platform1.GetRegistered().GetCompleted()[i].GetName();
                    step++;
                }
            }

            return passers;
        }
    }
}
