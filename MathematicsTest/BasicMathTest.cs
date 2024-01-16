using Mathematics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MathematicsTest
{
    public class BasicMathTest
    {
        [Fact]
        public void TestAddNumbers()
        {
            var math = new BasicMath();
            var result = math.AddNumbers(5, 5);
            Assert.True(result == 10);
        }
        [Fact]
        public void TestSubNumbers()
        {
            var math = new BasicMath();
            var result = math.SubNumbers(10, 5);
            Assert.True(result == 5);
        }
        [Fact]
        public void TestMulNumbers()
        {
            var math = new BasicMath();
            var result = math.MulNumbers(2, 5);
            Assert.True(result == 10);
        }
        [Fact]
        public void TestDivNumbers()
        {
            var math = new BasicMath();
            var result = math.DivNumbers(10, 5);
            Assert.True(result == 2);
        }
    }
}
