using System;

class Program
{
    static void Main(string[] args)
    {
        var timer = new System.Diagnostics.Stopwatch();
        timer.Start();
        const int n = 1000000;
        var isPrime = new bool[n + 1];
        for (int i = 2; i <= n; i++)
        {
            isPrime[i] = true;
        }
        for (int i = 2; i <= n; i++)
        {
            if (isPrime[i])
            {
                Console.Write(i + " ");
                for (int j = i * 2; j <= n; j += i)
                {
                    isPrime[j] = false;
                }
            }
        }
        timer.Stop();
        Console.WriteLine(timer.Elapsed + " seconds");
    }
}