using System.Collections.Generic;
using System.Text.RegularExpressions;
using NUnit.Framework;

namespace Software64.ChessRegex.UnitTest
{
    [TestFixture]
    public class ChessRegex3Tests
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
            AssertPatternReturnsExpected(ChessRegex3.Pawn, "e4, e4!, e4!!, e4?, e4??, e4!?, e4?!");
        }

        [Test] 
        public void Pawn_moves_with_check_test()
        {
            AssertPatternReturnsExpected(ChessRegex3.PawnCheck, "e4+, e4+!, e4+!!, e4+?, e4+??, e4+!?, e4+?!");
        }

        [Test]
        public void Pawn_moves_with_checkmate_test()
        {
            AssertPatternReturnsExpected(ChessRegex3.PawnCheckmate, "e4#");
        }

        [Test]
        public void Pawn_promotes_test()
        {
            AssertPatternReturnsExpected(ChessRegex3.PawnPromotes, "e8=Q, e8=Q!, e8=Q!!, e8=Q?, e8=Q??, e8=Q!?, e8=Q?!");
        }

        [Test]
        public void Pawn_promotes_with_check_test()
        {
            AssertPatternReturnsExpected(ChessRegex3.PawnPromotesCheck, "e8=Q+, e8=Q+!, e8=Q+!!, e8=Q+?, e8=Q+??, e8=Q+!?, e8=Q+?!");
        }

        [Test]
        public void Pawn_promotes_with_checkmate_test()
        {
            AssertPatternReturnsExpected(ChessRegex3.PawnPromotesCheckmate, "e8=Q#");
        }

        [Test]
        public void Pawn_captures_test()
        {
            AssertPatternReturnsExpected(ChessRegex3.PawnCaptures, "dxe4, dxe4!, dxe4!!, dxe4?, dxe4??, dxe4!?, dxe4?!");
        }

        [Test]
        public void Pawn_captures_with_check_test()
        {
            AssertPatternReturnsExpected(ChessRegex3.PawnCapturesCheck, "dxe4+, dxe4+!, dxe4+!!, dxe4+?, dxe4+??, dxe4+!?, dxe4+?!");
        }
        
        [Test]
        public void Pawn_captures_with_checkmate_test()
        {
            AssertPatternReturnsExpected(ChessRegex3.PawnCapturesCheckmate, "dxe4#");
        }
     
        [Test]
        public void Pawn_captures_and_promotes_test()
        {
            AssertPatternReturnsExpected(ChessRegex3.PawnCapturesPromotes, "dxe8=Q, dxe8=Q!, dxe8=Q!!, dxe8=Q?, dxe8=Q??, dxe8=Q!?, dxe8=Q?!");
        }

        [Test]
        public void Pawn_captures_and_promotes_with_check_test()
        {
            AssertPatternReturnsExpected(ChessRegex3.PawnCapturesPromotesCheck, "dxe8=Q+, dxe8=Q+!, dxe8=Q+!!, dxe8=Q+?, dxe8=Q+??, dxe8=Q+!?, dxe8=Q+?!");
        }

        [Test]
        public void Pawn_captures_and_promotes_with_checkmate_test()
        {
            AssertPatternReturnsExpected(ChessRegex3.PawnCapturesPromotesCheckmate, "dxe8=Q#");
        }

        [Test]
        public void Piece_moves_test()
        {
            AssertPatternReturnsExpected(ChessRegex3.Piece, "Nd5, Nd5!, Nd5!!, Nd5?, Nd5??, Nd5!?, Nd5?!");
        }

        [Test]
        public void Piece_moves_with_check_test()
        {
            AssertPatternReturnsExpected(ChessRegex3.PieceCheck, "Nd5+, Nd5+!, Nd5+!!, Nd5+?, Nd5+??, Nd5+!?, Nd5+?!");
        }

        [Test]
        public void Piece_moves_with_checkmate_test()
        {
            AssertPatternReturnsExpected(ChessRegex3.PieceCheckmate, "Nd5#");
        }

        [Test]
        public void Piece_moves_from_column_test()
        {
            AssertPatternReturnsExpected(ChessRegex3.PieceFromColumn, "Ncd5, Ncd5!, Ncd5!!, Ncd5?, Ncd5??, Ncd5!?, Ncd5?!");
        }

        [Test]
        public void Piece_moves_from_column_with_check_test()
        {
            AssertPatternReturnsExpected(ChessRegex3.PieceFromColumnCheck, "Ncd5+, Ncd5+!, Ncd5+!!, Ncd5+?, Ncd5+??, Ncd5+!?, Ncd5+?!");
        }

        [Test]
        public void Piece_moves_from_column_with_checkmate_test()
        {
            AssertPatternReturnsExpected(ChessRegex3.PieceFromColumnCheckmate, "Ncd5#");
        }

        [Test]
        public void Piece_moves_from_row_test()
        {
            AssertPatternReturnsExpected(ChessRegex3.PieceFromRow, "N7d5, N7d5!, N7d5!!, N7d5?, N7d5??, N7d5!?, N7d5?!");
        }

        [Test]
        public void Piece_moves_from_row_with_check_test()
        {
            AssertPatternReturnsExpected(ChessRegex3.PieceFromRowCheck, "N7d5+, N7d5+!, N7d5+!!, N7d5+?, N7d5+??, N7d5+!?, N7d5+?!");
        }

        [Test]
        public void Piece_moves_from_row_with_checkmate_test()
        {
            AssertPatternReturnsExpected(ChessRegex3.PieceFromRowCheckmate, "N7d5#");
        }

        [Test]
        public void Piece_moves_from_square_test()
        {
            AssertPatternReturnsExpected(ChessRegex3.PieceFromSquare, "Nc7d5, Nc7d5!, Nc7d5!!, Nc7d5?, Nc7d5??, Nc7d5!?, Nc7d5?!");
        }

        [Test]
        public void Piece_moves_from_square_with_check_test()
        {
            AssertPatternReturnsExpected(ChessRegex3.PieceFromSquareCheck, "Nc7d5+, Nc7d5+!, Nc7d5+!!, Nc7d5+?, Nc7d5+??, Nc7d5+!?, Nc7d5+?!");
        }

        [Test]
        public void Piece_moves_from_square_with_checkmate_test()
        {
            AssertPatternReturnsExpected(ChessRegex3.PieceFromSquareCheckmate, "Nc7d5#");
        }

        [Test]
        public void Piece_captures_test()
        {
            AssertPatternReturnsExpected(ChessRegex3.PieceCaptures, "Nxd5, Nxd5!, Nxd5!!, Nxd5?, Nxd5??, Nxd5!?, Nxd5?!");
        }

        [Test]
        public void Piece_captures_with_check_test()
        {
            AssertPatternReturnsExpected(ChessRegex3.PieceCapturesCheck, "Nxd5+, Nxd5+!, Nxd5+!!, Nxd5+?, Nxd5+??, Nxd5+!?, Nxd5+?!");
        }

        [Test]
        public void Piece_captures_with_checkmate_test()
        {
            AssertPatternReturnsExpected(ChessRegex3.PieceCapturesCheckmate, "Nxd5#");
        }
        
        [Test]
        public void Piece_captures_from_column_test()
        {
            AssertPatternReturnsExpected(ChessRegex3.PieceFromColumnCaptures, "Ncxd5, Ncxd5!, Ncxd5!!, Ncxd5?, Ncxd5??, Ncxd5!?, Ncxd5?!");
        }

        [Test]
        public void Piece_captures_from_column_with_check_test()
        {
            AssertPatternReturnsExpected(ChessRegex3.PieceFromColumnCapturesCheck, "Ncxd5+, Ncxd5+!, Ncxd5+!!, Ncxd5+?, Ncxd5+??, Ncxd5+!?, Ncxd5+?!");
        }

        [Test]
        public void Piece_captures_from_column_with_checkmate_test()
        {
            AssertPatternReturnsExpected(ChessRegex3.PieceFromColumnCapturesCheckmate, "Ncxd5#");
        }

        [Test]
        public void Piece_captures_from_row_test()
        {
            AssertPatternReturnsExpected(ChessRegex3.PieceFromRowCaptures, "N7xd5, N7xd5!, N7xd5!!, N7xd5?, N7xd5??, N7xd5!?, N7xd5?!");
        }

        [Test]
        public void Piece_captures_from_row_with_check_test()
        {
            AssertPatternReturnsExpected(ChessRegex3.PieceFromRowCapturesCheck, "N7xd5+, N7xd5+!, N7xd5+!!, N7xd5+?, N7xd5+??, N7xd5+!?, N7xd5+?!");
        }

        [Test]
        public void Piece_captures_from_row_with_checkmate_test()
        {
            AssertPatternReturnsExpected(ChessRegex3.PieceFromRowCapturesCheckmate, "N7xd5#");
        }

        [Test]
        public void Piece_captures_from_square_test()
        {
            AssertPatternReturnsExpected(ChessRegex3.PieceFromSquareCaptures, "Nc7xd5, Nc7xd5!, Nc7xd5!!, Nc7xd5?, Nc7xd5??, Nc7xd5!?, Nc7xd5?!");
        }

        [Test]
        public void Piece_captures_from_square_with_check_test()
        {
            AssertPatternReturnsExpected(ChessRegex3.PieceFromSquareCapturesCheck, "Nc7xd5+, Nc7xd5+!, Nc7xd5+!!, Nc7xd5+?, Nc7xd5+??, Nc7xd5+!?, Nc7xd5+?!");
        }

        [Test]
        public void Piece_captures_from_square_with_checkmate_test()
        {
            AssertPatternReturnsExpected(ChessRegex3.PieceFromSquareCapturesCheckmate, "Nc7xd5#");
        }

        [Test]
        public void Castling_kingside_test()
        {
            AssertPatternReturnsExpected(ChessRegex3.CastledKingside, "O-O, O-O!, O-O!!, O-O?, O-O??, O-O!?, O-O?!");
        }

        [Test]
        public void Castling_kingside_with_check_test()
        {
            AssertPatternReturnsExpected(ChessRegex3.CastledKingsideCheck, "O-O+, O-O+!, O-O+!!, O-O+?, O-O+??, O-O+!?, O-O+?!");
        }

        [Test]
        public void Castling_kingside_with_checkmate_test()
        {
            AssertPatternReturnsExpected(ChessRegex3.CastledKingsideCheckmate, "O-O#");
        }


        [Test]
        public void Castling_queenside_test()
        {
            AssertPatternReturnsExpected(ChessRegex3.CastledQueenside, "O-O-O, O-O-O!, O-O-O!!, O-O-O?, O-O-O??, O-O-O!?, O-O-O?!");
        }

        [Test]
        public void Castling_queenside_with_check_test()
        {
            AssertPatternReturnsExpected(ChessRegex3.CastledQueensideCheck, "O-O-O+, O-O-O+!, O-O-O+!!, O-O-O+?, O-O-O+??, O-O-O+!?, O-O-O+?!");
        }

        [Test]
        public void Castling_queenside_with_checkmate_test()
        {
            AssertPatternReturnsExpected(ChessRegex3.CastledQueensideCheckmate, "O-O-O#");
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
