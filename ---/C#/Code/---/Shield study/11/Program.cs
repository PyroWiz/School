namespace _11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 10, 20 };      // length = 2
            int[] arr2 = { 1, 2, 3, 4 };  // length = 4
            int[] arr3 = { 5, 6, 7 };     // length = 3

            int[,] array = Ord(arr1, arr2, arr3);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write($"{array[i, j]},");
                }
                Console.WriteLine();
            }
        }

        public static int[,] Ord(int[] arr1, int[] arr2, int[] arr3)
        {
            int max = (Math.Max(Math.Max(arr1.Length, arr2.Length), arr3.Length));
            int min = (Math.Min(Math.Min(arr1.Length, arr2.Length), arr3.Length));

            int[,] final = new int[3, max];

            if ((min == max) || (arr1.Length == arr2.Length || arr1.Length == arr3.Length || arr3.Length == arr2.Length))
            {
                int[] one = arr1;
                int[] two = arr2;
                int[] three = arr3;

                for (int i = 0; i < max; i++)
                {
                    if (i >= one.Length) final[0, i] = -1;
                    else final[0, i] = one[i];
                    if (i >= two.Length) final[1, i] = -1;
                    else final[1, i] = two[i];
                    if (i >= three.Length) final[2, i] = -1;
                    else final[2, i] = three[i];
                }

                return final;
            } //equal

            int[][] jagged = new int[3][];

            if (arr1.Length == max) { jagged[2] = arr1; }
            if (arr2.Length == max) { jagged[2] = arr2; }
            if (arr3.Length == max) { jagged[2] = arr3; }

            if (arr1.Length == min) { jagged[0] = arr1; }
            if (arr2.Length == min) { jagged[0] = arr2; }
            if (arr3.Length == min) { jagged[0] = arr3; }

            if (arr1.Length != min && arr1.Length != max) { jagged[1] = arr1; }
            if (arr2.Length != min && arr2.Length != max) { jagged[1] = arr2; }
            if (arr3.Length != min && arr3.Length != max) { jagged[1] = arr3; }


            for (int i = 0; i < max; i++)
            {
                final[0, i] = (i >= jagged[0].Length) ? -1 : jagged[0][i];
                final[1, i] = (i >= jagged[1].Length) ? -1 : jagged[1][i];
                final[2, i] = (i >= jagged[2].Length) ? -1 : jagged[2][i];
            }

            return final;
        }
    }
}
