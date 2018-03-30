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

                "Nd5", "Nd5!", "Nd5!!", "Nd5?", "Nd5??", "Nd5!?", "Nd5?!",
                "Nd5+", "Nd5+!", "Nd5+!!", "Nd5+?", "Nd5+??", "Nd5+!?", "Nd5+?!",
                "Nd5#",
                "Ncd5", "Ncd5!", "Ncd5!!", "Ncd5?", "Ncd5??", "Ncd5!?", "Ncd5?!",
                "Ncd5+", "Ncd5+!", "Ncd5+!!", "Ncd5+?", "Ncd5+??", "Ncd5+!?", "Ncd5+?!",
                "Ncd5#",
                "N7d5", "N7d5!", "N7d5!!", "N7d5?", "N7d5??", "N7d5!?", "N7d5?!",
                "N7d5+", "N7d5+!", "N7d5+!!", "N7d5+?", "N7d5+??", "N7d5+!?", "N7d5+?!",
                "N7d5#",
                "Nc7d5", "Nc7d5!", "Nc7d5!!", "Nc7d5?", "Nc7d5??", "Nc7d5!?", "Nc7d5?!",
                "Nc7d5+", "Nc7d5+!", "Nc7d5+!!", "Nc7d5+?", "Nc7d5+??", "Nc7d5+!?", "Nc7d5+?!",
                "Nc7d5#",
                "Nxd5", "Nxd5!", "Nxd5!!", "Nxd5?", "Nxd5??", "Nxd5!?", "Nxd5?!",
                "Nxd5+", "Nxd5+!", "Nxd5+!!", "Nxd5+?", "Nxd5+??", "Nxd5+!?", "Nxd5+?!",
                "Nxd5#",
                "Ncxd5", "Ncxd5!", "Ncxd5!!", "Ncxd5?", "Ncxd5??", "Ncxd5!?", "Ncxd5?!",
                "Ncxd5+", "Ncxd5+!", "Ncxd5+!!", "Ncxd5+?", "Ncxd5+??", "Ncxd5+!?", "Ncxd5+?!",
                "Ncxd5#",
                "N7xd5", "N7xd5!", "N7xd5!!", "N7xd5?", "N7xd5??", "N7xd5!?", "N7xd5?!",
                "N7xd5+", "N7xd5+!", "N7xd5+!!", "N7xd5+?", "N7xd5+??", "N7xd5+!?", "N7xd5+?!",
                "N7xd5#",
                "Nc7xd5", "Nc7xd5!", "Nc7xd5!!", "Nc7xd5?", "Nc7xd5??", "Nc7xd5!?", "Nc7xd5?!",
                "Nc7xd5+", "Nc7xd5+!", "Nc7xd5+!!", "Nc7xd5+?", "Nc7xd5+??", "Nc7xd5+!?", "Nc7xd5+?!",
                "Nc7xd5#",

                "O-O", "O-O!", "O-O!!", "O-O?", "O-O??", "O-O!?", "O-O?!",
                "O-O+", "O-O+!", "O-O+!!", "O-O+?", "O-O+??", "O-O+!?", "O-O+?!",
                "O-O#",
                "O-O-O", "O-O-O!", "O-O-O!!", "O-O-O?", "O-O-O??", "O-O-O!?", "O-O-O?!",
                "O-O-O+", "O-O-O+!", "O-O-O+!!", "O-O-O+?", "O-O-O+??", "O-O-O+!?", "O-O-O+?!",
                "O-O-O#"
            };
        }

        [Test]
        public void Pawn_moves_test()
        {
            AssertPatternReturnsExpected(WhatMove.Pawn, "e4, e4!, e4!!, e4?, e4??, e4!?, e4?!");
        }

        [Test] 
        public void Pawn_moves_with_check_test()
        {
            AssertPatternReturnsExpected(WhatMove.PawnCheck, "e4+, e4+!, e4+!!, e4+?, e4+??, e4+!?, e4+?!");
        }

        [Test]
        public void Pawn_moves_with_checkmate_test()
        {
            AssertPatternReturnsExpected(WhatMove.PawnCheckmate, "e4#");
        }

        [Test]
        public void Pawn_promotes_test()
        {
            AssertPatternReturnsExpected(WhatMove.PawnPromotes, "e8=Q, e8=Q!, e8=Q!!, e8=Q?, e8=Q??, e8=Q!?, e8=Q?!");
        }

        [Test]
        public void Pawn_promotes_with_check_test()
        {
            AssertPatternReturnsExpected(WhatMove.PawnPromotesCheck, "e8=Q+, e8=Q+!, e8=Q+!!, e8=Q+?, e8=Q+??, e8=Q+!?, e8=Q+?!");
        }

        [Test]
        public void Pawn_promotes_with_checkmate_test()
        {
            AssertPatternReturnsExpected(WhatMove.PawnPromotesCheckmate, "e8=Q#");
        }

        [Test]
        public void Pawn_captures_test()
        {
            AssertPatternReturnsExpected(WhatMove.PawnCaptures, "dxe4, dxe4!, dxe4!!, dxe4?, dxe4??, dxe4!?, dxe4?!");
        }

        [Test]
        public void Pawn_captures_with_check_test()
        {
            AssertPatternReturnsExpected(WhatMove.PawnCapturesCheck, "dxe4+, dxe4+!, dxe4+!!, dxe4+?, dxe4+??, dxe4+!?, dxe4+?!");
        }
        
        [Test]
        public void Pawn_captures_with_checkmate_test()
        {
            AssertPatternReturnsExpected(WhatMove.PawnCapturesCheckmate, "dxe4#");
        }
     
        [Test]
        public void Pawn_captures_and_promotes_test()
        {
            AssertPatternReturnsExpected(WhatMove.PawnCapturesPromotes, "dxe8=Q, dxe8=Q!, dxe8=Q!!, dxe8=Q?, dxe8=Q??, dxe8=Q!?, dxe8=Q?!");
        }

        [Test]
        public void Pawn_captures_and_promotes_with_check_test()
        {
            AssertPatternReturnsExpected(WhatMove.PawnCapturesPromotesCheck, "dxe8=Q+, dxe8=Q+!, dxe8=Q+!!, dxe8=Q+?, dxe8=Q+??, dxe8=Q+!?, dxe8=Q+?!");
        }

        [Test]
        public void Pawn_captures_and_promotes_with_checkmate_test()
        {
            AssertPatternReturnsExpected(WhatMove.PawnCapturesPromotesCheckmate, "dxe8=Q#");
        }

        [Test]
        public void Piece_moves_test()
        {
            AssertPatternReturnsExpected(WhatMove.Piece, "Nd5, Nd5!, Nd5!!, Nd5?, Nd5??, Nd5!?, Nd5?!");
        }

        [Test]
        public void Piece_moves_with_check_test()
        {
            AssertPatternReturnsExpected(WhatMove.PieceCheck, "Nd5+, Nd5+!, Nd5+!!, Nd5+?, Nd5+??, Nd5+!?, Nd5+?!");
        }

        [Test]
        public void Piece_moves_with_checkmate_test()
        {
            AssertPatternReturnsExpected(WhatMove.PieceCheckmate, "Nd5#");
        }

        [Test]
        public void Piece_moves_from_column_test()
        {
            AssertPatternReturnsExpected(WhatMove.PieceFromColumn, "Ncd5, Ncd5!, Ncd5!!, Ncd5?, Ncd5??, Ncd5!?, Ncd5?!");
        }

        [Test]
        public void Piece_moves_from_column_with_check_test()
        {
            AssertPatternReturnsExpected(WhatMove.PieceFromColumnCheck, "Ncd5+, Ncd5+!, Ncd5+!!, Ncd5+?, Ncd5+??, Ncd5+!?, Ncd5+?!");
        }

        [Test]
        public void Piece_moves_from_column_with_checkmate_test()
        {
            AssertPatternReturnsExpected(WhatMove.PieceFromColumnCheckmate, "Ncd5#");
        }

        [Test]
        public void Piece_moves_from_row_test()
        {
            AssertPatternReturnsExpected(WhatMove.PieceFromRow, "N7d5, N7d5!, N7d5!!, N7d5?, N7d5??, N7d5!?, N7d5?!");
        }

        [Test]
        public void Piece_moves_from_row_with_check_test()
        {
            AssertPatternReturnsExpected(WhatMove.PieceFromRowCheck, "N7d5+, N7d5+!, N7d5+!!, N7d5+?, N7d5+??, N7d5+!?, N7d5+?!");
        }

        [Test]
        public void Piece_moves_from_row_with_checkmate_test()
        {
            AssertPatternReturnsExpected(WhatMove.PieceFromRowCheckmate, "N7d5#");
        }

        [Test]
        public void Piece_moves_from_square_test()
        {
            AssertPatternReturnsExpected(WhatMove.PieceFromSquare, "Nc7d5, Nc7d5!, Nc7d5!!, Nc7d5?, Nc7d5??, Nc7d5!?, Nc7d5?!");
        }

        [Test]
        public void Piece_moves_from_square_with_check_test()
        {
            AssertPatternReturnsExpected(WhatMove.PieceFromSquareCheck, "Nc7d5+, Nc7d5+!, Nc7d5+!!, Nc7d5+?, Nc7d5+??, Nc7d5+!?, Nc7d5+?!");
        }

        [Test]
        public void Piece_moves_from_square_with_checkmate_test()
        {
            AssertPatternReturnsExpected(WhatMove.PieceFromSquareCheckmate, "Nc7d5#");
        }

        [Test]
        public void Piece_captures_test()
        {
            AssertPatternReturnsExpected(WhatMove.PieceCaptures, "Nxd5, Nxd5!, Nxd5!!, Nxd5?, Nxd5??, Nxd5!?, Nxd5?!");
        }

        [Test]
        public void Piece_captures_with_check_test()
        {
            AssertPatternReturnsExpected(WhatMove.PieceCapturesCheck, "Nxd5+, Nxd5+!, Nxd5+!!, Nxd5+?, Nxd5+??, Nxd5+!?, Nxd5+?!");
        }

        [Test]
        public void Piece_captures_with_checkmate_test()
        {
            AssertPatternReturnsExpected(WhatMove.PieceCapturesCheckmate, "Nxd5#");
        }
        
        [Test]
        public void Piece_captures_from_column_test()
        {
            AssertPatternReturnsExpected(WhatMove.PieceFromColumnCaptures, "Ncxd5, Ncxd5!, Ncxd5!!, Ncxd5?, Ncxd5??, Ncxd5!?, Ncxd5?!");
        }

        [Test]
        public void Piece_captures_from_column_with_check_test()
        {
            AssertPatternReturnsExpected(WhatMove.PieceFromColumnCapturesCheck, "Ncxd5+, Ncxd5+!, Ncxd5+!!, Ncxd5+?, Ncxd5+??, Ncxd5+!?, Ncxd5+?!");
        }

        [Test]
        public void Piece_captures_from_column_with_checkmate_test()
        {
            AssertPatternReturnsExpected(WhatMove.PieceFromColumnCapturesCheckmate, "Ncxd5#");
        }

        [Test]
        public void Piece_captures_from_row_test()
        {
            AssertPatternReturnsExpected(WhatMove.PieceFromRowCaptures, "N7xd5, N7xd5!, N7xd5!!, N7xd5?, N7xd5??, N7xd5!?, N7xd5?!");
        }

        [Test]
        public void Piece_captures_from_row_with_check_test()
        {
            AssertPatternReturnsExpected(WhatMove.PieceFromRowCapturesCheck, "N7xd5+, N7xd5+!, N7xd5+!!, N7xd5+?, N7xd5+??, N7xd5+!?, N7xd5+?!");
        }

        [Test]
        public void Piece_captures_from_row_with_checkmate_test()
        {
            AssertPatternReturnsExpected(WhatMove.PieceFromRowCapturesCheckmate, "N7xd5#");
        }

        [Test]
        public void Piece_captures_from_square_test()
        {
            AssertPatternReturnsExpected(WhatMove.PieceFromSquareCaptures, "Nc7xd5, Nc7xd5!, Nc7xd5!!, Nc7xd5?, Nc7xd5??, Nc7xd5!?, Nc7xd5?!");
        }

        [Test]
        public void Piece_captures_from_square_with_check_test()
        {
            AssertPatternReturnsExpected(WhatMove.PieceFromSquareCapturesCheck, "Nc7xd5+, Nc7xd5+!, Nc7xd5+!!, Nc7xd5+?, Nc7xd5+??, Nc7xd5+!?, Nc7xd5+?!");
        }

        [Test]
        public void Piece_captures_from_square_with_checkmate_test()
        {
            AssertPatternReturnsExpected(WhatMove.PieceFromSquareCapturesCheckmate, "Nc7xd5#");
        }

        [Test]
        public void Castling_kingside_test()
        {
            AssertPatternReturnsExpected(WhatMove.CastledKingside, "O-O, O-O!, O-O!!, O-O?, O-O??, O-O!?, O-O?!");
        }

        [Test]
        public void Castling_kingside_with_check_test()
        {
            AssertPatternReturnsExpected(WhatMove.CastledKingsideCheck, "O-O+, O-O+!, O-O+!!, O-O+?, O-O+??, O-O+!?, O-O+?!");
        }

        [Test]
        public void Castling_kingside_with_checkmate_test()
        {
            AssertPatternReturnsExpected(WhatMove.CastledKingsideCheckmate, "O-O#");
        }


        [Test]
        public void Castling_queenside_test()
        {
            AssertPatternReturnsExpected(WhatMove.CastledQueenside, "O-O-O, O-O-O!, O-O-O!!, O-O-O?, O-O-O??, O-O-O!?, O-O-O?!");
        }

        [Test]
        public void Castling_queenside_with_check_test()
        {
            AssertPatternReturnsExpected(WhatMove.CastledQueensideCheck, "O-O-O+, O-O-O+!, O-O-O+!!, O-O-O+?, O-O-O+??, O-O-O+!?, O-O-O+?!");
        }

        [Test]
        public void Castling_queenside_with_checkmate_test()
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
