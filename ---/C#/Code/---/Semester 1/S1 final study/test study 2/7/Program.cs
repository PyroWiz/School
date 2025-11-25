namespace _7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tom = 0, mor = 150.5, shir = 200;

            for (int i = 0; i < 3; i++)
            {
                Random rnd = new Random();
                double lot = rnd.NextDouble() * (1000 - 100) + 100;

                if (lot % 1 == 0)
                {
                    lot += 210;
                }
                int temp = (int)lot;
                bool dig = true;
                while (temp > 0)
                { 
                    int last = temp % 10;                         //int last = temp %10;
                    temp /= 10;                                   //temp /=10;
                    dig = (temp % 10 == last) ? true : false;     // if (last != temp%10)
                    temp *= (dig == true) ? 1 : 0;                // allsame=false;  <new vairbale starts with true
                }
                if (dig == true)
                {
                    lot *= 10;
                }
                temp = (int)lot;
                {
                    int first = temp % 10;
                    temp /= 100;
                    int second = temp % 10;
                    if (first == second) lot -= 80;
                }

                switch (i)
                {
                    case 0:
                        tom += lot;
                        break;
                    case 1:
                        mor += lot;
                        break;
                    case 2:
                        shir += lot;
                        break;
                }


            }

            double bigcheck = Math.Max(Math.Max(tom, shir), mor);
            double smallcheck = Math.Min(Math.Min(tom, shir), mor);
            string small = "", big = "", medium = "";
            double smallwin = 0, mediumwin = 0, bigwin = 0;

            if (tom == bigcheck) { big = "tom"; bigwin = tom; }
            else if (tom == smallcheck) { small = "tom"; smallwin = tom; }
            else { medium = "tom"; mediumwin = tom; }

            if (mor == bigcheck) { big = "mor"; bigwin = mor; }
            else if (mor == smallcheck) { small = "mor"; smallwin = mor; }
            else { medium = "mor"; mediumwin = mor; }

            if (shir == bigcheck) { big = "shir"; bigwin = shir; }
            else if (shir == smallcheck) { small = "shir"; smallwin = shir; }
            else { medium = "shir"; mediumwin = shir; }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Winnings: \nBiggest winner - {big} with {bigwin:f}$\nMiddle of the pack - {medium} with {mediumwin:f3}$!\nSmallest winner - {small} with {smallwin:f3}$!");



        }
    }
}
