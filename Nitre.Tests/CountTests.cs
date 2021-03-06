using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Xunit;

namespace Nitre.Test
{
    public class CountTests
    {
        [Fact]
        public void ForIntegerWithStep()
        {
            var actual = Nitre.Count(0, 3).Take(10).ToList();

            Assert.StrictEqual(10, actual.Count);
            Assert.Equal(0, actual[0]);
            Assert.Equal(9, actual[3]);
        }

        [Fact]
        public void ForFloatWithNegativeStep()
        {
            var actual = Nitre.Count(6f, -7f).Take(3).ToList();

            Assert.Equal(new List<float> {6f, -1f, -8}, actual);
        }

        [Fact]
        public void ForNegativeDoubleWithoutStep()
        {
            var actual = Nitre.Count(-2d).Take(3).ToList();

            Assert.Equal(new List<double> {-2d, -1d, 0d}, actual);
        }

        [Fact]
        public void ForDecimalWithStep()
        {
            var actual = Nitre.Count(1.1m, -0.4m).Take(3).ToList();

            Assert.Equal(new List<decimal> {1.1m, 0.7m, 0.3m}, actual);
        }

        [Fact]
        public void ForAllTypes()
        {
            var actual = typeof(Nitre).GetMethods(BindingFlags.Public | BindingFlags.Static)
                .Where(mi => mi.Name == "Count")
                .Select(mi => mi.GetParameters()[0].ParameterType)
                .ToList();

            Assert.Contains(typeof(decimal), actual);
            Assert.Contains(typeof(double), actual);
            Assert.Contains(typeof(int), actual);
            Assert.Contains(typeof(float), actual);
        }
    }
}
