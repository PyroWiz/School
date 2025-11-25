using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "dyutS";
            int[] arr = new int[5] { 3, 4, 2, 1, 0 };
            Console.WriteLine(OriginalText(word, arr));
        }

        static string OriginalText(string text, int[] arr)
        {
            char[] chacha = new char[text.Length];
            chacha = text.ToCharArray();
            int temp = 0;
            char cha = 'a';
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;

                        cha = chacha[j];
                        chacha[j] = chacha[j + 1];
                        chacha[j + 1] = cha;
                    }
                }
            }
            String word = new String(chacha);
            return word;
        }
    }
}
