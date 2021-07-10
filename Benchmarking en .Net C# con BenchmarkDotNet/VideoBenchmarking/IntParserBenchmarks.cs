using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Order;

namespace VideoBenchmarking
{
    [RankColumn]
    [SimpleJob(RuntimeMoniker.NetCoreApp30)]
    [SimpleJob(RuntimeMoniker.NetCoreApp31)]
    [SimpleJob(RuntimeMoniker.Net50)]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [MemoryDiagnoser]
    public class IntParserBenchmarks
    {
        private const string IntAsString = "609";

        [Benchmark]
        public void GetIntByStringUsingParser()
        {
            var number = IntParser.GetIntFromString(IntAsString);
        }

        [Benchmark]
        public void GetIntByStringUsingAscii()
        {
            var number = IntParser.GetIntFromStringByAscii(IntAsString);
        }
        
        [Benchmark]
        public void GetIntFromStringByAsciiWithoutMath()
        {
            var number = IntParser.GetIntFromStringByAsciiWithoutMath(IntAsString);
        }        
        
        [Benchmark]
        public void GetIntFromStringByAsciiWithoutVariables()
        {
            var number = IntParser.GetIntFromStringByAsciiWithoutVariables(IntAsString);
        }
        
        [Benchmark]
        public void GetIntFromStringByAsciiUsingLINQ()
        {
            var number = IntParser.GetIntFromStringByAsciiUsingLINQ(IntAsString);
        }
    }
}