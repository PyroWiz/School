using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Soundex("doritos"));
        }

        public static string Soundex(string word)
        {
            word = word.ToLower();
            int c = 0;
            string dex = word;
            char[] arr = dex.ToCharArray();
            arr[0] = word[0];

            for (int step = 0; step < 2; step++)
            {

                if (step == 1)
                {
                    for (int s = 0; s < arr.Length; s++)
                    {
                        arr[s] = '0';
                    }
                }
                int special = 0;
                for (int i = 1; i < word.Length; i++)
                {
                    if (special > c) break;
                    switch (word[i])
                    {
                        case 'b':
                        case 'f':
                        case 'p':
                        case 'v':
                            if (step == 0)
                            {
                                c++;
                                if (word[i - 1] == word[i]) c--;
                            }
                            if (step == 1)
                            {
                                if (!(word[i - 1] == word[i]))
                                {
                                    arr[special] = '1'; special++;
                                }
                            }
                            break;
                        case 'c':
                        case 'j':
                        case 'k':
                        case 'q':
                        case 's':
                        case 'x':
                        case 'z':
                            if (step == 0)
                            {
                                c++;
                                if (word[i - 1] == word[i]) c--;
                            }
                            if (step == 1)
                            {
                                if (!(word[i - 1] == word[i]))
                                {
                                    arr[special] = '2'; special++;
                                }
                            }
                            break;
                        case 'd':
                        case 't':
                            if (step == 0)
                            {
                                c++;
                                if (word[i - 1] == word[i]) c--;
                            }
                            if (step == 1)
                            {
                                if (!(word[i - 1] == word[i]))
                                {
                                    arr[special] = '3'; special++;
                                }
                            }
                            break;
                        case 'l':
                            if (step == 0)
                            {
                                c++;
                                if (word[i - 1] == word[i]) c--;
                            }
                            if (step == 1)
                            {
                                if (!(word[i - 1] == word[i]))
                                {
                                    arr[special] = '4'; special++;
                                }
                            }
                            break;

                        case 'm':
                        case 'n':
                            if (step == 0)
                            {
                                c++;
                                if (word[i - 1] == word[i]) c--;
                            }
                            if (step == 1)
                            {
                                if (!(word[i - 1] == word[i]))
                                {
                                    arr[special] = '5'; special++;
                                }
                            }
                            break;
                        case 'r':
                            if (step == 0)
                            {
                                c++;
                                if (word[i - 1] == word[i]) c--;
                            }
                            if (step == 1)
                            {
                                if (!(word[i - 1] == word[i]))
                                {
                                    arr[special] = '6'; special++;
                                }
                            }
                            break;

                    }
                }
            }

            arr[0] = word[0];
            string s1 = new string(arr);
            s1.Remove(c);
            return s1;
        }
    }
}
