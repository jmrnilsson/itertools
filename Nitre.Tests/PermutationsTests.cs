﻿using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Nitre.Test
{
    public class PermutationsTests
    {
		/// <summary>
		/// Example from https://docs.python.org/3/library/itertools.html#module-itertools
		/// </summary>
		[Fact(Skip = "Not implemented yet")]
		public void VerifiedExample()
		{
			var iterables = "ABCD".ToCharArray();

			// var actual = new string(Nitre.Permutations(iterables, 2).ToArray());
			var expected = new List<string> { "AB", "AC", "AD", "BA", "BC", "BD", "CA", "CB", "CD", "DA", "DB", "DC" };

			Assert.False(true);
			Assert.Equal(expected, new List<string> { "actual" });
		}
	}
}
