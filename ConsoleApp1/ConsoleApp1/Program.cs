using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for (int t = 1; t <= T; t++)
            {
                string line = Console.ReadLine();
                string[] space = line.Split('\n');
                int num = int.Parse(space[0]);
                bool SquarePerfect = IsperfectSquare(num);
                if (SquarePerfect)
                {
                    Console.WriteLine("Case {0}: YES", t);
                }
                else
                {
                    Console.WriteLine("Case {0}: NO", t);
                }
            }
        }
        public static bool IsperfectSquare(int n)
        {
            int root = (int)Math.Sqrt(n);
            return (int)Math.Pow(root, 2) == n;
        }
    }
}