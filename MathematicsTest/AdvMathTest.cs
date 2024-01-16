using Mathematics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicsTest
{
    public class AdvMathTest
    {
        [Fact]
        public void TestArea()
        {
            AdvMath advMath = new AdvMath();
            double result = advMath.Area(5, 8);
            Assert.True(result == 40);
        }
        [Fact]
        public void TestAverage()
        {
            AdvMath advMath = new AdvMath();
            double result = advMath.Average(2, 4, 6, 8);
            Assert.True(result == 5);
        }
        [Fact]
        public void TestSquared()
        {
            AdvMath advMath = new AdvMath();
            double result = advMath.Squared(3);
            Assert.True(result == 9);
        }
        [Fact]
        public void TestPythagoreanTheorem()
        {
            AdvMath advMath = new AdvMath();
            double result = advMath.PythagoreanTheorem(3, 4);
            Assert.True(result == 5);
        }
    }
}
