using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Software64.ChessRegex.UnitTest
{
    public abstract class ChessRegexTestBase
    {
        protected void AssertPatternReturnsExpected(string pattern, List<string> expected)
        {
            // Act
            var actual = TestFixture.MoveExamples.Where(move => Regex.IsMatch(move, pattern)).ToList();

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
