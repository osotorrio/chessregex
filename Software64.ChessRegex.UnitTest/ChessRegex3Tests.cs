using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using NUnit.Framework;

namespace Software64.ChessRegex.UnitTest
{
    [TestFixture]
    public class ChessRegex3Tests
    {
        [Test]
        public void Pawn_moves_test()
        {   
            // Arrange
            var expected = new List<string>
            {
                "e4", "e4!", "e4!!", "e4?", "e4??", "e4!?", "e4?!"
            };

            AssertPatternReturnsExpected(ChessRegex3.Pawn, expected);
        }

        [Test] 
        public void Pawn_moves_with_check_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "e4+", "e4+!", "e4+!!", "e4+?", "e4+??", "e4+!?", "e4+?!"
            };

            AssertPatternReturnsExpected(ChessRegex3.PawnCheck, expected);
        }

        [Test]
        public void Pawn_moves_with_checkmate_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "e4++", "e4#"
            };

            AssertPatternReturnsExpected(ChessRegex3.PawnCheckmate, expected);
        }

        [Test]
        public void Pawn_promotes_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "e8=Q", "e8=Q!", "e8=Q!!", "e8=Q?", "e8=Q??", "e8=Q!?", "e8=Q?!"
            };

            AssertPatternReturnsExpected(ChessRegex3.PawnPromotes, expected);
        }

        [Test]
        public void Pawn_promotes_with_check_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "e8=Q+", "e8=Q+!", "e8=Q+!!", "e8=Q+?", "e8=Q+??", "e8=Q+!?", "e8=Q+?!"
            };

            AssertPatternReturnsExpected(ChessRegex3.PawnPromotesCheck, expected);
        }

        [Test]
        public void Pawn_promotes_with_checkmate_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "e8=Q++", "e8=Q#"
            };
            
            AssertPatternReturnsExpected(ChessRegex3.PawnPromotesCheckmate, expected);
        }

        [Test]
        public void Pawn_captures_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "dxe4", "dxe4!", "dxe4!!", "dxe4?", "dxe4??", "dxe4!?", "dxe4?!"
            };

            AssertPatternReturnsExpected(ChessRegex3.PawnCaptures, expected);
        }

        [Test]
        public void Pawn_captures_with_check_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "dxe4+", "dxe4+!", "dxe4+!!", "dxe4+?", "dxe4+??", "dxe4+!?", "dxe4+?!"
            };

            AssertPatternReturnsExpected(ChessRegex3.PawnCapturesCheck, expected);
        }
        
        [Test]
        public void Pawn_captures_with_checkmate_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "dxe4++", "dxe4#"
            };

            AssertPatternReturnsExpected(ChessRegex3.PawnCapturesCheckmate, expected);
        }
     
        [Test]
        public void Pawn_captures_and_promotes_test()
        {            
            // Arrange
            var expected = new List<string>
            {
                "dxe8=Q", "dxe8=Q!", "dxe8=Q!!", "dxe8=Q?", "dxe8=Q??", "dxe8=Q!?", "dxe8=Q?!"
            };

            AssertPatternReturnsExpected(ChessRegex3.PawnCapturesPromotes, expected);
        }

        [Test]
        public void Pawn_captures_and_promotes_with_check_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "dxe8=Q+", "dxe8=Q+!", "dxe8=Q+!!", "dxe8=Q+?", "dxe8=Q+??", "dxe8=Q+!?", "dxe8=Q+?!",
            };

            AssertPatternReturnsExpected(ChessRegex3.PawnCapturesPromotesCheck, expected);
        }

        [Test]
        public void Pawn_captures_and_promotes_with_checkmate_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "dxe8=Q++", "dxe8=Q#"
            };

            AssertPatternReturnsExpected(ChessRegex3.PawnCapturesPromotesCheckmate, expected);
        }

        [Test]
        public void Castling_kingside_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "O-O", "O-O!", "O-O!!", "O-O?", "O-O??", "O-O!?", "O-O?!"
            };

            AssertPatternReturnsExpected(ChessRegex3.CastledKingside, expected);
        }

        [Test]
        public void Castling_kingside_with_check_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "O-O+", "O-O+!", "O-O+!!", "O-O+?", "O-O+??", "O-O+!?", "O-O+?!"
            };

            AssertPatternReturnsExpected(ChessRegex3.CastledKingsideCheck, expected);
        }

        [Test]
        public void Castling_kingside_with_checkmate_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "O-O++", "O-O#"
            };

            AssertPatternReturnsExpected(ChessRegex3.CastledKingsideCheckmate, expected);
        }

        [Test]
        public void Castling_queenside_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "O-O-O", "O-O-O!", "O-O-O!!", "O-O-O?", "O-O-O??", "O-O-O!?", "O-O-O?!"
            };

            AssertPatternReturnsExpected(ChessRegex3.CastledQueenside, expected);
        }

        [Test]
        public void Castling_queenside_with_check_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "O-O-O+", "O-O-O+!", "O-O-O+!!", "O-O-O+?", "O-O-O+??", "O-O-O+!?", "O-O-O+?!"
            };

            AssertPatternReturnsExpected(ChessRegex3.CastledQueensideCheck, expected);
        }

        [Test]
        public void Castling_queenside_with_checkmate_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "O-O-O++", "O-O-O#"
            };

            AssertPatternReturnsExpected(ChessRegex3.CastledQueensideCheckmate, expected);
        }

        private static void AssertPatternReturnsExpected(string pattern, List<string> expected)
        {
            // Act
            var actual = TestFixture.MoveExamples.Where(move => Regex.IsMatch(move, pattern)).ToList();

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
