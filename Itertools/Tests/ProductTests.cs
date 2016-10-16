﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Xunit;

namespace Itertools.Tests
{
    public class ProductTest
    {
        [Fact]
        public void ProductTwoLists()
        {
            var first = Enumerable.Range(1, 3);
            var second = Enumerable.Range(65, 4).Select(alpha => (char) alpha);
            var actual = Itertools.Product(first, second).ToList();

            Assert.StrictEqual(actual.Count, 12);
            Assert.Equal(new Tuple<int, char>(1, 'A'), actual[0]);
            Assert.Equal(new Tuple<int, char>(1, 'C'), actual[2]);
            Assert.Equal(new Tuple<int, char>(3, 'D'), actual[11]);
        }

        [Fact]
        public void ProductWithRepeat()
        {
            var first = Enumerable.Range(1, 5);
            var second = new []{'a', 'b', 'c'};
            var actual = Itertools.Product(first, second, repeat: 2).ToList();

            Assert.StrictEqual(actual.Count, 30);
            Assert.Equal(new Tuple<int, char>(1, 'c'), actual[2]);
            Assert.Equal(new Tuple<int, char>(5, 'c'), actual[29]);
            Assert.Equal(actual[13], actual[28]);
        }
    }
}