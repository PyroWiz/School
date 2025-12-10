namespace Recursion
{
    internal class Exs
    {
        static public void Ex14()
        {
            int[] arr = new int[] { 1, 2, 3, 4 };

            Console.WriteLine(Sum(arr, 2, 0, 0));

            int Sum(int[] arr, int i, int s, int sum)
            {
                if (s > i) return sum;

                return Sum(arr, i, s + 1, sum += arr[s]);
            }

        }
        static public void Ex15()
        {
            int[] arr = new int[] { 1, 2, 3, 4 };

            Console.WriteLine(Sum(arr, 2, 0, 0));

            int Sum(int[] arr, int i, int s, int sum)
            {
                if (s > i) return sum;
                if (arr[s] % 2 == 0) sum++;
                return Sum(arr, i, s + 1, sum);
            }
        }

        static public void Ex16()
        {
            int[] arr = new int[] { 1, 2, 3, 4 };

            Console.WriteLine(Find(arr, 8, 0));

            int Find(int[] arr, int d, int pos)
            {
                if (pos == arr.Length) return -1;
                if (arr[pos] == d) return pos;

                return Find(arr, d, pos + 1);
            }
        }

        static public void Ex17()
        {
            int[] arr = new int[] { 2, 2, 3, 4 };

            Console.WriteLine(Uppies(arr, 1));

            bool Uppies(int[] arr, int pos)
            {
                if (pos == arr.Length) return true;
                if (arr[pos] <= arr[pos - 1]) return false;

                return Uppies(arr, pos + 1);
            }
        }

        static public void Ex18()
        {
            int[] arr = new int[] { 4, 4, 4 };

            Console.WriteLine(First(arr, 0));

            bool First(int[] arr, int pos)
            {
                if (pos == arr.Length) return true;
                if (!FCheck(arr[pos])) return false;

                return First(arr, pos + 1);
            }

            bool FCheck(int num)
            {
                int count = 0;
                for (int i = 1; i <= num; i++)
                {
                    if (num % i == 0) count++;
                    if (count > 2) return true;
                }
                return false;
            }
        }

    }
}
