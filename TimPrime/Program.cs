using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
namespace TimPrime
{
    class Program
    {
        static Task<bool> FindPrimeNumberAsync(int n)
        {
            return Task.Run<bool>(() =>
             {
                 int dem = 0;
                 for (int i = 1; i <= n; i++)
                 {
                     if (n % i == 0) dem++;
                     if (dem > 2) break;
                 }
                 return dem == 2 ? true : false;
             });
        }
        static async Task Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int i = 1; i < 100; i++)
            {
                if (await FindPrimeNumberAsync(i)) Console.WriteLine(i);

            }
            Console.WriteLine(stopWatch.Elapsed);
            stopWatch.Stop();
        }
    }
}
