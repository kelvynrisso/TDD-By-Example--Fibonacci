using System;
using Xunit;

namespace Fibonacci
{
    public class FibonacciTests
    {
        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 1)]
        [InlineData(2, 1)]
        [InlineData(3, 2)]
        [InlineData(4, 3)]
        [InlineData(5, 5)]
        [InlineData(11, 89)]
        [InlineData(35, 9227465)]
        public void FibonacciTest(long n, long expect)
        {
            Assert.Equal(expect, Fibonacci.Fib(n));
        }
    }

    public class Fibonacci
    {
        public static int Fib(long n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return Fib(n - 1) + Fib(n - 2);
        }
    }


}
