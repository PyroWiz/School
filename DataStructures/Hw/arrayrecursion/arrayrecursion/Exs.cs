namespace arrayrecursion
{
    internal class Exs
    {
        static public void Ex14()
        {
            int i = 3;
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine(Sum(arr, i));

            int Sum(int[] arr, int i)
            {
                if (i == 0) return arr[i];

                return arr[i] + (Sum(arr, i - 1));

            }
        }
        static public void Ex15()
        {
            int i = 3;
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine(Pos(arr, i));


            int Pos(int[] arr, int i)
            {

                return (arr[i] % 2 == 0 ? )
            }
        }
    }
}
