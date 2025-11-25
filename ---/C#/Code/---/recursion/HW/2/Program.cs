using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter num");
            int x = int.Parse(Console.ReadLine());
            Loop(x, 1, true, 0);
        }

        static int Loop(int max, int step, bool phase, int sum)
        {
            if (step > max) { Console.WriteLine(sum); return 0; }
            else if (phase == true)
            {
                sum += (step + (int)Math.Pow((step + 1), 2));
                step += 2;
                phase = false;
            }
            else
            {
                sum += 2 * step;
                step++;
                phase = true;
            }
            return Loop(max, step, phase, sum);
        }
    }
}
