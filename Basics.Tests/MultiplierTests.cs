using System;
using System.Collections.Generic;
using Basics.Algorithm;
using Xunit;
using Xunit.Extensions;

namespace Basics.Tests
{
    public class MultiplierTests
    {
        private Multiplier multiplier = new Multiplier();

        [Theory]
        [MemberData(nameof(MultiplicationTestData))]
        public void Multiply(int first, int second)
        {
            var multiplierResult = multiplier.Multiply(first, second);
            var actual = first * second;

            Assert.Equal(actual, multiplierResult);
        }

        public static IEnumerable<object[]> MultiplicationTestData 
        {
            get
            {
                for (int i = 0; i <= 100; i++) 
                {
                    for(int j = 0; j <= 100; j++) 
                    {
                        yield return new object[] { i, j };
                    }
                }
            }
        }
    }
}
