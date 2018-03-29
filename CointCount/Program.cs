using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombinationOfCoin
{
    class Program
    {
        static void Main(string[] args)
        {
            const int totalAmount = 200;
            var values = new List<int>() {200,100,50,20,10,5,2};
            int count = 0;

            for (int a = totalAmount; a >= 0; a -= values[0])
            {
                for (int b = a; b >= 0; b -= values[1])
                {
                    for (int c = b; c >= 0; c -= values[2])
                    {
                        for (int d = c; d >= 0; d -= values[3])
                        {
                            for (int e = d; e >= 0; e -= values[4])
                            {
                                for (int f = e; f >= 0; f -= values[5])
                                {
                                    for (int g = f; g >= 0; g -= values[6])
                                    {
                                        count++;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine(string.Format($"Answer is {count}"));
            Console.ReadLine();
        }
    }
}
