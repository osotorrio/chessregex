using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using NUnit.Framework;

namespace Software64.ChessRegex.UnitTest
{
    [TestFixture]
    public class ChessRegex2Tests
    {
        [Test]
        public void Pawn_standard_move_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "e4", "e4!", "e4!!", "e4?", "e4??", "e4!?", "e4?!",
                "e4+", "e4+!", "e4+!!", "e4+?", "e4+??", "e4+!?", "e4+?!",
                "e4#"
            };

            ActAndAssert(ChessRegex2.PawnStandard, expected);
        }

        [Test]
        public void Pawn_promotes_move_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "e8=Q", "e8=Q!", "e8=Q!!", "e8=Q?", "e8=Q??", "e8=Q!?", "e8=Q?!",
                "e8=Q+", "e8=Q+!", "e8=Q+!!", "e8=Q+?", "e8=Q+??", "e8=Q+!?", "e8=Q+?!",
                "e8=Q#",
            };

            ActAndAssert(ChessRegex2.PawnPromotes, expected);
        }

        [Test]
        public void Pawn_captures_move_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "dxe4", "dxe4!", "dxe4!!", "dxe4?", "dxe4??", "dxe4!?", "dxe4?!",
                "dxe4+", "dxe4+!", "dxe4+!!", "dxe4+?", "dxe4+??", "dxe4+!?", "dxe4+?!",
                "dxe4#",
            };

            ActAndAssert(ChessRegex2.PawnCaptures, expected);
        }

        [Test]
        public void Pawn_captures_and_promotes_move_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "dxe8=Q", "dxe8=Q!", "dxe8=Q!!", "dxe8=Q?", "dxe8=Q??", "dxe8=Q!?", "dxe8=Q?!",
                "dxe8=Q+", "dxe8=Q+!", "dxe8=Q+!!", "dxe8=Q+?", "dxe8=Q+??", "dxe8=Q+!?", "dxe8=Q+?!",
                "dxe8=Q#",
            };

            ActAndAssert(ChessRegex2.PawnCapturesPromotes, expected);
        }

        private static void ActAndAssert(string pattern, List<string> expected)
        {
            // Act
            var actual = TestFixture.MoveExamples.Where(move => Regex.IsMatch(move, pattern)).ToList();

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
