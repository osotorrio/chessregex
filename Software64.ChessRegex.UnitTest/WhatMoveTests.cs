using System.Collections.Generic;
using System.Text.RegularExpressions;
using NUnit.Framework;

namespace Software64.ChessRegex.UnitTest
{
    [TestFixture]
    public class WhatMoveTests
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
            AssertPatternReturnsExpected(WhatMove.Pawn, "e4, e4!, e4!!, e4?, e4??, e4!?, e4?!");
        }

        [Test] 
        public void Pawn_moves_with_check()
        {
            AssertPatternReturnsExpected(WhatMove.PawnCheck, "e4+, e4+!, e4+!!, e4+?, e4+??, e4+!?, e4+?!");
        }

        [Test]
        public void Pawn_moves_with_checkmate()
        {
            AssertPatternReturnsExpected(WhatMove.PawnCheckmate, "e4#");
        }

        [Test]
        public void Pawn_promotes()
        {
            AssertPatternReturnsExpected(WhatMove.PawnPromotes, "e8=Q, e8=Q!, e8=Q!!, e8=Q?, e8=Q??, e8=Q!?, e8=Q?!");
        }

        [Test]
        public void Pawn_promotes_with_check()
        {
            AssertPatternReturnsExpected(WhatMove.PawnPromotesCheck, "e8=Q+, e8=Q+!, e8=Q+!!, e8=Q+?, e8=Q+??, e8=Q+!?, e8=Q+?!");
        }

        [Test]
        public void Pawn_promotes_with_checkmate()
        {
            AssertPatternReturnsExpected(WhatMove.PawnPromotesCheckmate, "e8=Q#");
        }

        [Test]
        public void Pawn_captures()
        {
            AssertPatternReturnsExpected(WhatMove.PawnCaptures, "dxe4, dxe4!, dxe4!!, dxe4?, dxe4??, dxe4!?, dxe4?!");
        }

        [Test]
        public void Pawn_captures_with_check()
        {
            AssertPatternReturnsExpected(WhatMove.PawnCapturesCheck, "dxe4+, dxe4+!, dxe4+!!, dxe4+?, dxe4+??, dxe4+!?, dxe4+?!");
        }
        
        [Test]
        public void Pawn_captures_with_checkmate()
        {
            AssertPatternReturnsExpected(WhatMove.PawnCapturesCheckmate, "dxe4#");
        }
     
        [Test]
        public void Pawn_captures_and_promotes()
        {
            AssertPatternReturnsExpected(WhatMove.PawnCapturesPromotes, "dxe8=Q, dxe8=Q!, dxe8=Q!!, dxe8=Q?, dxe8=Q??, dxe8=Q!?, dxe8=Q?!");
        }

        [Test]
        public void Pawn_captures_and_promotes_with_check()
        {
            AssertPatternReturnsExpected(WhatMove.PawnCapturesPromotesCheck, "dxe8=Q+, dxe8=Q+!, dxe8=Q+!!, dxe8=Q+?, dxe8=Q+??, dxe8=Q+!?, dxe8=Q+?!");
        }

        [Test]
        public void Pawn_captures_and_promotes_with_checkmate()
        {
            AssertPatternReturnsExpected(WhatMove.PawnCapturesPromotesCheckmate, "dxe8=Q#");
        }

        [Test]
        public void Piece_moves()
        {
            AssertPatternReturnsExpected(WhatMove.Piece, "Rd1, Rd1!, Rd1!!, Rd1?, Rd1??, Rd1!?, Rd1?!");
        }

        [Test]
        public void Piece_moves_with_check()
        {
            AssertPatternReturnsExpected(WhatMove.PieceCheck, "Rd1+, Rd1+!, Rd1+!!, Rd1+?, Rd1+??, Rd1+!?, Rd1+?!");
        }

        [Test]
        public void Piece_moves_with_checkmate()
        {
            AssertPatternReturnsExpected(WhatMove.PieceCheckmate, "Rd1#");
        }

        [Test]
        public void Piece_moves_from()
        {
            AssertPatternReturnsExpected(WhatMove.PieceFrom, "Rad1, Rad1!, Rad1!!, Rad1?, Rad1??, Rad1!?, Rad1?!");
        }

        [Test]
        public void Piece_moves_from_with_check()
        {
            AssertPatternReturnsExpected(WhatMove.PieceFromCheck, "Rad1+, Rad1+!, Rad1+!!, Rad1+?, Rad1+??, Rad1+!?, Rad1+?!");
        }

        [Test]
        public void Piece_moves_from_with_checkmate()
        {
            AssertPatternReturnsExpected(WhatMove.PieceFromCheckmate, "Rad1#");
        }

        [Test]
        public void Piece_captures()
        {
            AssertPatternReturnsExpected(WhatMove.PieceCaptures, "Rxd1, Rxd1!, Rxd1!!, Rxd1?, Rxd1??, Rxd1!?, Rxd1?!");
        }

        [Test]
        public void Piece_captures_with_check()
        {
            AssertPatternReturnsExpected(WhatMove.PieceCapturesCheck, "Rxd1+, Rxd1+!, Rxd1+!!, Rxd1+?, Rxd1+??, Rxd1+!?, Rxd1+?!");
        }

        [Test]
        public void Piece_captures_with_checkmate()
        {
            AssertPatternReturnsExpected(WhatMove.PieceCapturesCheckmate, "Rxd1#");
        }
        
        [Test]
        public void Piece_captures_from()
        {
            AssertPatternReturnsExpected(WhatMove.PieceFromCaptures, "Raxd1, Raxd1!, Raxd1!!, Raxd1?, Raxd1??, Raxd1!?, Raxd1?!");
        }

        [Test]
        public void Piece_captures_from_with_check()
        {
            AssertPatternReturnsExpected(WhatMove.PieceFromCapturesCheck, "Raxd1+, Raxd1+!, Raxd1+!!, Raxd1+?, Raxd1+??, Raxd1+!?, Raxd1+?!");
        }

        [Test]
        public void Piece_captures_from_with_checkmate()
        {
            AssertPatternReturnsExpected(WhatMove.PieceFromCapturesCheckmate, "Raxd1#");
        }

        [Test]
        public void Castling_kingside()
        {
            AssertPatternReturnsExpected(WhatMove.CastledKingside, "O-O, O-O!, O-O!!, O-O?, O-O??, O-O!?, O-O?!");
        }

        [Test]
        public void Castling_kingside_with_check()
        {
            AssertPatternReturnsExpected(WhatMove.CastledKingsideCheck, "O-O+, O-O+!, O-O+!!, O-O+?, O-O+??, O-O+!?, O-O+?!");
        }

        [Test]
        public void Castling_kingside_with_checkmate()
        {
            AssertPatternReturnsExpected(WhatMove.CastledKingsideCheckmate, "O-O#");
        }


        [Test]
        public void Castling_queenside()
        {
            AssertPatternReturnsExpected(WhatMove.CastledQueenside, "O-O-O, O-O-O!, O-O-O!!, O-O-O?, O-O-O??, O-O-O!?, O-O-O?!");
        }

        [Test]
        public void Castling_queenside_with_check()
        {
            AssertPatternReturnsExpected(WhatMove.CastledQueensideCheck, "O-O-O+, O-O-O+!, O-O-O+!!, O-O-O+?, O-O-O+??, O-O-O+!?, O-O-O+?!");
        }

        [Test]
        public void Castling_queenside_with_checkmate()
        {
            AssertPatternReturnsExpected(WhatMove.CastledQueensideCheckmate, "O-O-O#");
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
