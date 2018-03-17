using System.Collections.Generic;
using System.Text.RegularExpressions;
using NUnit.Framework;

namespace Software64.ChessRegex.UnitTest
{
    [TestFixture]
    public class MovePatternsTest
    {
        private static List<string> _moveTypes;
                    
        [OneTimeSetUp]
        public void RunOnceBeforeAnyTest()
        {
            _moveTypes = new List<string>
            {
                "e4", "e4!", "e4!!", "e4?", "e4??", "e4!?", "e4?!",
                "e4+", "e4+!", "e4+!!", "e4+?", "e4+??", "e4+!?", "e4+?!",
                "e4#",
                "e8=Q", "e8=Q!", "e8=Q!!", "e8=Q?", "e8=Q??", "e8=Q!?", "e8=Q?!",
                "e8=Q+", "e8=Q+!", "e8=Q+!!", "e8=Q+?", "e8=Q+??", "e8=Q+!?", "e8=Q+?!",
                "e8=Q#",
                "dxe4", "dxe4!", "dxe4!!", "dxe4?", "dxe4??", "dxe4!?", "dxe4?!",
                "dxe4+", "dxe4+!", "dxe4+!!", "dxe4+?", "dxe4+??", "dxe4+!?", "dxe4+?!",
                "dxe4#",
                "dxe8=Q", "dxe8=Q!", "dxe8=Q!!", "dxe8=Q?", "dxe8=Q??", "dxe8=Q!?", "dxe8=Q?!",
                "dxe8=Q+", "dxe8=Q+!", "dxe8=Q+!!", "dxe8=Q+?", "dxe8=Q+??", "dxe8=Q+!?", "dxe8=Q+?!",
                "dxe8=Q#",
                "Rd1", "Rd1!", "Rd1!!", "Rd1?", "Rd1??", "Rd1!?", "Rd1?!",
                "Rd1+", "Rd1+!", "Rd1+!!", "Rd1+?", "Rd1+??", "Rd1+!?", "Rd1+?!",
                "Rd1#",
                "Rad1", "Rad1!", "Rad1!!", "Rad1?", "Rad1??", "Rad1!?", "Rad1?!",
                "Rad1+", "Rad1+!", "Rad1+!!", "Rad1+?", "Rad1+??", "Rad1+!?", "Rad1+?!",
                "Rad1#",
                "Rxd1", "Rxd1!", "Rxd1!!", "Rxd1?", "Rxd1??", "Rxd1!?", "Rxd1?!",
                "Rxd1+", "Rxd1+!", "Rxd1+!!", "Rxd1+?", "Rxd1+??", "Rxd1+!?", "Rxd1+?!",
                "Rxd1#",
                "Raxd1", "Raxd1!", "Raxd1!!", "Raxd1?", "Raxd1??", "Raxd1!?", "Raxd1?!",
                "Raxd1+", "Raxd1+!", "Raxd1+!!", "Raxd1+?", "Raxd1+??", "Raxd1+!?", "Raxd1+?!",
                "Raxd1#",
                "O-O", "O-O!", "O-O!!", "O-O?", "O-O??", "O-O!?", "O-O?!",
                "O-O+", "O-O+!", "O-O+!!", "O-O+?", "O-O+??", "O-O+!?", "O-O+?!",
                "O-O#",
                "O-O-O", "O-O-O!", "O-O-O!!", "O-O-O?", "O-O-O??", "O-O-O!?", "O-O-O?!",
                "O-O-O+", "O-O-O+!", "O-O-O+!!", "O-O-O+?", "O-O-O+??", "O-O-O+!?", "O-O-O+?!",
                "O-O-O#"
            };
        }

        [Test]
        public void Pawn_moves()
        {
            AssertPatternReturnsExpected(MovePatterns.Pawn, "e4, e4!, e4!!, e4?, e4??, e4!?, e4?!");
        }

        [Test] 
        public void Pawn_moves_with_check()
        {
            AssertPatternReturnsExpected(MovePatterns.PawnCheck, "e4+, e4+!, e4+!!, e4+?, e4+??, e4+!?, e4+?!");
        }

        [Test]
        public void Pawn_moves_with_checkmate()
        {
            AssertPatternReturnsExpected(MovePatterns.PawnCheckmate, "e4#");
        }

        [Test]
        public void Pawn_promotes()
        {
            AssertPatternReturnsExpected(MovePatterns.PawnPromotes, "e8=Q, e8=Q!, e8=Q!!, e8=Q?, e8=Q??, e8=Q!?, e8=Q?!");
        }

        [Test]
        public void Pawn_promotes_with_check()
        {
            AssertPatternReturnsExpected(MovePatterns.PawnPromotesCheck, "e8=Q+, e8=Q+!, e8=Q+!!, e8=Q+?, e8=Q+??, e8=Q+!?, e8=Q+?!");
        }

        [Test]
        public void Pawn_promotes_with_checkmate()
        {
            AssertPatternReturnsExpected(MovePatterns.PawnPromotesCheckmate, "e8=Q#");
        }

        [Test]
        public void Pawn_captures()
        {
            AssertPatternReturnsExpected(MovePatterns.PawnCaptures, "dxe4, dxe4!, dxe4!!, dxe4?, dxe4??, dxe4!?, dxe4?!");
        }

        [Test]
        public void Pawn_captures_with_check()
        {
            AssertPatternReturnsExpected(MovePatterns.PawnCapturesCheck, "dxe4+, dxe4+!, dxe4+!!, dxe4+?, dxe4+??, dxe4+!?, dxe4+?!");
        }
        
        [Test]
        public void Pawn_captures_with_checkmate()
        {
            AssertPatternReturnsExpected(MovePatterns.PawnCapturesCheckmate, "dxe4#");
        }
     
        [Test]
        public void Pawn_captures_and_promotes()
        {
            AssertPatternReturnsExpected(MovePatterns.PawnCapturesPromotes, "dxe8=Q, dxe8=Q!, dxe8=Q!!, dxe8=Q?, dxe8=Q??, dxe8=Q!?, dxe8=Q?!");
        }

        [Test]
        public void Pawn_captures_and_promotes_with_check()
        {
            AssertPatternReturnsExpected(MovePatterns.PawnCapturesPromotesCheck, "dxe8=Q+, dxe8=Q+!, dxe8=Q+!!, dxe8=Q+?, dxe8=Q+??, dxe8=Q+!?, dxe8=Q+?!");
        }

        [Test]
        public void Pawn_captures_and_promotes_with_checkmate()
        {
            AssertPatternReturnsExpected(MovePatterns.PawnCapturesPromotesCheckmate, "dxe8=Q#");
        }

        [Test]
        public void Piece_moves()
        {
            AssertPatternReturnsExpected(MovePatterns.Piece, "Rd1, Rd1!, Rd1!!, Rd1?, Rd1??, Rd1!?, Rd1?!");
        }

        [Test]
        public void Piece_moves_with_check()
        {
            AssertPatternReturnsExpected(MovePatterns.PieceCheck, "Rd1+, Rd1+!, Rd1+!!, Rd1+?, Rd1+??, Rd1+!?, Rd1+?!");
        }

        [Test]
        public void Piece_moves_with_checkmate()
        {
            AssertPatternReturnsExpected(MovePatterns.PieceCheckmate, "Rd1#");
        }

        [Test]
        public void Piece_moves_from()
        {
            AssertPatternReturnsExpected(MovePatterns.PieceFrom, "Rad1, Rad1!, Rad1!!, Rad1?, Rad1??, Rad1!?, Rad1?!");
        }

        [Test]
        public void Piece_moves_from_with_check()
        {
            AssertPatternReturnsExpected(MovePatterns.PieceFromCheck, "Rad1+, Rad1+!, Rad1+!!, Rad1+?, Rad1+??, Rad1+!?, Rad1+?!");
        }

        [Test]
        public void Piece_moves_from_with_checkmate()
        {
            AssertPatternReturnsExpected(MovePatterns.PieceFromCheckmate, "Rad1#");
        }

        [Test]
        public void Piece_captures()
        {
            AssertPatternReturnsExpected(MovePatterns.PieceCaptures, "Rxd1, Rxd1!, Rxd1!!, Rxd1?, Rxd1??, Rxd1!?, Rxd1?!");
        }

        [Test]
        public void Piece_captures_with_check()
        {
            AssertPatternReturnsExpected(MovePatterns.PieceCapturesCheck, "Rxd1+, Rxd1+!, Rxd1+!!, Rxd1+?, Rxd1+??, Rxd1+!?, Rxd1+?!");
        }

        [Test]
        public void Piece_captures_with_checkmate()
        {
            AssertPatternReturnsExpected(MovePatterns.PieceCapturesCheckmate, "Rxd1#");
        }
        
        [Test]
        public void Piece_captures_from()
        {
            AssertPatternReturnsExpected(MovePatterns.PieceFromCaptures, "Raxd1, Raxd1!, Raxd1!!, Raxd1?, Raxd1??, Raxd1!?, Raxd1?!");
        }

        [Test]
        public void Piece_captures_from_with_check()
        {
            AssertPatternReturnsExpected(MovePatterns.PieceFromCapturesCheck, "Raxd1+, Raxd1+!, Raxd1+!!, Raxd1+?, Raxd1+??, Raxd1+!?, Raxd1+?!");
        }

        [Test]
        public void Piece_captures_from_with_checkmate()
        {
            AssertPatternReturnsExpected(MovePatterns.PieceFromCapturesCheckmate, "Raxd1#");
        }

        [Test]
        public void Castling_kingside()
        {
            AssertPatternReturnsExpected(MovePatterns.CastledKingside, "O-O, O-O!, O-O!!, O-O?, O-O??, O-O!?, O-O?!");
        }

        [Test]
        public void Castling_kingside_with_check()
        {
            AssertPatternReturnsExpected(MovePatterns.CastledKingsideCheck, "O-O+, O-O+!, O-O+!!, O-O+?, O-O+??, O-O+!?, O-O+?!");
        }

        [Test]
        public void Castling_kingside_with_checkmate()
        {
            AssertPatternReturnsExpected(MovePatterns.CastledKingsideCheckmate, "O-O#");
        }


        [Test]
        public void Castling_queenside()
        {
            AssertPatternReturnsExpected(MovePatterns.CastledQueenside, "O-O-O, O-O-O!, O-O-O!!, O-O-O?, O-O-O??, O-O-O!?, O-O-O?!");
        }

        [Test]
        public void Castling_queenside_with_check()
        {
            AssertPatternReturnsExpected(MovePatterns.CastledQueensideCheck, "O-O-O+, O-O-O+!, O-O-O+!!, O-O-O+?, O-O-O+??, O-O-O+!?, O-O-O+?!");
        }

        [Test]
        public void Castling_queenside_with_checkmate()
        {
            AssertPatternReturnsExpected(MovePatterns.CastledQueensideCheckmate, "O-O-O#");
        }

        private void AssertPatternReturnsExpected(string pattern, string expected)
        {
            // Act
            var actual = GetMatches(pattern);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        private string GetMatches(string pattern)
        {
            var matches = new List<string>();

            foreach (var move in _moveTypes)
            {
                if (Regex.IsMatch(move, pattern))
                {
                    matches.Add(move);
                }
            }

            return string.Join(", ", matches);
        }
    }
}
