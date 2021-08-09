using System;

namespace MethodOverloadingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 22;
            int b = 40;
            //decimal c = .12;
            //decimal d = .55;
            int e = 130;
            int f = 900;

            var answer1 = Add(a, b);
            //var answer2 = Add(c, d);
            var answer3 = Add(e, f, true);
        }

        public static int  Add(int x, int y)
        {
            return x + y;
        }

        public static decimal Add(decimal x, decimal y)
        {
            return x + y;
        }

        public static string Add(int x, int y, bool check)
        {
            var sum = x + y;
            if(check == true && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if(check == true && sum == 1)
            {
                return $"{sum} dollar";
            }
            else if(check == true && sum < 1)
            {
                return $"{sum} dollars";
            }
            else
            {
                return sum.ToString();
            }
        }
    }
}
