using System;
using System.Numerics;
using System.Threading;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Task asynctime = Time();
            Fibonacci();
            Console.ReadLine();
        }





        static async Task Time()
        {
            await Task.Run(() =>
            {
                DateTime time = new DateTime();
                while (true)
                {
                    Thread.Sleep(3000);
                    time += new TimeSpan(0, 0, 3);
                    Console.WriteLine($"Czas działania aplikacji: {time.Minute}:{time.Second}.");
                };
            });


        }

        static void Fibonacci()
        {            
            BigInteger a = new BigInteger(1);
            BigInteger b = new BigInteger(1);
            BigInteger integer = new BigInteger(2);
            while (true)
            { 
                a = b;
                b = integer;
                integer = a + b;
                Console.WriteLine(integer);
                Thread.Sleep(1000);
            }            
        }
    }
}
