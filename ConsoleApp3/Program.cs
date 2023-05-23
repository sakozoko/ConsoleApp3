using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        const int n = 1000000;
        var primes = new List<int>();
        var isPrime = new bool[n + 1];
        Parallel.For(2, n + 1, i =>
        {
            if (!isPrime[i])
            {
                lock (primes)
                {
                    primes.Add(i);
                }
                for (int j = i * 2; j <= n; j += i)
                {
                    isPrime[j] = true;
                }
            }
        });
        Console.WriteLine("Primes: " + string.Join(", ", primes));
    }
}