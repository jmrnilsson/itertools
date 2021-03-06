﻿using System.Linq;
using Xunit;

namespace Nitre.Test
{
	public class TakeWhileTests
    {
        [Fact]
        public void ForIndexed()
        {
            var iterable0 = Enumerable.Range(0, 12);
            var actual = Nitre.TakeWhile(iterable0, (it, i) => i < 4 && (it < 3 || it % 3 == 0)).ToList();

            Assert.Equal(4, actual.Count);
            Assert.Equal(1, actual[1]);
        }

        [Fact]
        public void ForNonIndexed_AndOverloaded()
        {
            var iterable0 = Enumerable.Range(0, 12);
            var actual = iterable0.TakeWhile(it => it < 4).ToList();

            Assert.Equal(4, actual.Count);
            Assert.Equal(3, actual[3]);
        }
    }
}
