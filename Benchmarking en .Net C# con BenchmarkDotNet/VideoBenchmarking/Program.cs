using System;
using BenchmarkDotNet.Running;

namespace VideoBenchmarking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Kernel!");
            BenchmarkRunner.Run<IntParserBenchmarks>();
        }
    }
}