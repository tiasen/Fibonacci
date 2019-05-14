using Fibonacci;
using Xunit;

namespace FibonacciTest
{
    public class Tests
    {
        [Fact]
        public void Test1()
        {
            Assert.True(true);
        }

        [Fact]
        public void OutputFirst()
        {
            var result = Program.GetResult(1);
            Assert.Equal(1, result);
        }

        [Fact]
        public void OutputSecond()
        {
            var result = Program.GetResult(number: 2);
            Assert.Equal(1, result);
        }

        [Fact]
        public void OutputThird()
        {
            var result = Program.GetResult(3);
            Assert.Equal(2, result);
        }


        [Theory]
        [InlineData(-1, 0)]
        [InlineData(0, 0)]
        [InlineData(1, 1)]
        [InlineData(2, 1)]
        [InlineData(3, 2)]
        [InlineData(5, 5)]
        [InlineData(10, 55)]
        public void OutputN(int value, int except)
        {
            var result = Program.GetResult( value);
            Assert.Equal(except, result);
        }

        [Fact]
        public void GetResultCache()
        {
            var valueCache = Program.GetValueCache(10);
            Assert.Equal(11, valueCache.Length);
        }

        [Theory]
        [InlineData(-1, 0)]
        [InlineData(0, 0)]
        [InlineData(1, 1)]
        [InlineData(2, 1)]
        [InlineData(3, 2)]
        [InlineData(5, 5)]
        [InlineData(10, 55)]
        [InlineData(50, 12586269025)]
        [InlineData(92, 7540113804746346429)]
        public void GetResultNew(int value, ulong except)
        {
            var resultNew = Program.GetResultNew(value);
            Assert.Equal(except, resultNew);
        }
        
        

    }
    
}