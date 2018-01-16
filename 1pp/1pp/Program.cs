using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1pp
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] s = line.Split(' ');
            int sum = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int cnt = 0;
                sum = int.Parse(s[i]);
                for (int j = 2; j <= Math.Sqrt(sum); j++)
                {
                    if (sum % j == 0)
                    {
                        cnt++;
                        break;
                    }

                }
                if (cnt == 0 && sum != 1)
                {
                    Console.WriteLine(sum);
                }
            }
            Console.ReadKey();
        }
    }
}
