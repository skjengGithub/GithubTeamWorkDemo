using System;

namespace GithubTeamWorkDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("skjGH 06132015");
            Console.WriteLine("skj1957 06142015");
            Print_skj1957_06162015();
            Print_skjGH_06162015();
            Test1_skjGH test = new Test1_skjGH("skjGH 06172015");
            test.Print();
        }

        public static void Print_skj1957_06162015()
        {
            Console.WriteLine("skj1957 06162015");
        }

        public  static void Print_skjGH_06162015()
        {
            Console.WriteLine("skjGH 06162015");
        }
    }
}
