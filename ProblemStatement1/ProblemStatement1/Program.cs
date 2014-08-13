using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemStatement1
{
    class Program
    {
        static void Main(string[] args)
        {

            int maxPeriod;

            Console.WriteLine("enter value of maxperiod");

            maxPeriod = Convert.ToInt32(Console.ReadLine());

            string[] acgt = { "ACGTGCA" };

            string[] acgtold = acgt;
            // for (int i = 0; i < 3; i++)
            //   Console.WriteLine(acgtold);

            int k = MinChanges(maxPeriod, acgt);
            Console.WriteLine(k);
            Console.ReadKey(true);
        }
        public static int MinChanges(int maxPeriod, string[] acgt)
        {
            int count = 0;
            int min = 0;

            int l = 1;
            while (l <= maxPeriod)
            {
                int k;
                for (k = 0; k < l; k++)
                {
                    for (int i = k; i <= (acgt.Length) - maxPeriod; )
                    {
                        if (acgt[k] != acgt[i])
                        {
                            count++;
                            i++;
                        }
                        else
                        {
                            i++;
                        }


                    }
                    if (min == 0)
                        min = count;

                    if (count < min)
                        min = count;
                    l++;
                }
                return min;

            }

            return min;
        }
    }

}
