using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gpt1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "shay";
            Console.WriteLine(Reverse(name));
            if (name == Reverse(name)) Console.WriteLine("is poli");
            else Console.WriteLine("not poly");
            Console.WriteLine(Vowel(name));
            Console.WriteLine(Credit("1234-1234-1234-1234"));
            Console.WriteLine("document.pdf".Substring("document.pdf".LastIndexOf('.') + 1), "document.pdf".Length);
            foreach (string p in "t,e,s,t".Split(','))
                Console.WriteLine(p);
            Console.WriteLine($"name:{"ido"} | date: {new DateTime(2025, 06, 30):yyyy-MM-dd} | score: {90.10:F2}");
            Console.WriteLine("     ido dwadsd dwad     ".Trim());
            Console.WriteLine(Sum("1.2.3.4.5.6.7"));

        }

        static string Reverse(string s)
        {
            string news = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                news += s[i];
            }
            return news;
        }
        static int Vowel(string s)
        {
            int i = 0;
            foreach (char c in s)
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u') i++;
            }
            return i;
        }

        static string Credit(string s)
        {
            string a = "";
            for (int i = 0; i < 14; i++)
            {
                if (!(s[i] == '-')) a += '*';
                else a += '-';
            }
            for (int i = 14; i < 19; i++)
            {
                a += s[i];
            }
            return a;
        }

        static int Sum(string s)
        {
            int[] arr = s.Split('.')[s.Split('.').Length];
        }


    }
}
