﻿using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using NUnit.Framework;

namespace Software64.ChessRegex.UnitTest
{
    [TestFixture]
    public class ChessRegex3Tests : ChessRegexTestBase
    {
        [Test]
        public void Pawn_moves_test()
        {   
            // Arrange
            var expected = new List<string>
            {
                "e4", "e4!", "e4!!", "e4?", "e4??", "e4!?", "e4?!"
            };

            AssertPatternReturnsExpected(ChessRegex3.PawnMoves, expected);
        }

        [Test] 
        public void Pawn_moves_with_check_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "e4+", "e4+!", "e4+!!", "e4+?", "e4+??", "e4+!?", "e4+?!"
            };

            AssertPatternReturnsExpected(ChessRegex3.PawnMovesCheck, expected);
        }

        [Test]
        public void Pawn_moves_with_checkmate_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "e4++", "e4#"
            };

            AssertPatternReturnsExpected(ChessRegex3.PawnMovesCheckmate, expected);
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
        public void Rook_moves_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "Rd1", "Rd1!", "Rd1!!", "Rd1?", "Rd1??", "Rd1!?", "Rd1?!"
            };

            AssertPatternReturnsExpected(ChessRegex3.RookMoves, expected);
        }

        [Test]
        public void Rook_moves_with_check_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "Rd1+", "Rd1+!", "Rd1+!!", "Rd1+?", "Rd1+??", "Rd1+!?", "Rd1+?!"
            };

            AssertPatternReturnsExpected(ChessRegex3.RookMovesCheck, expected);
        }

        [Test]
        public void Rook_moves_with_checkmate_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "Rd1++", "Rd1#"
            };

            AssertPatternReturnsExpected(ChessRegex3.RookMovesCheckmate, expected);
        }

        [Test]
        public void Rook_moves_from_file_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "Rad1", "Rad1!", "Rad1!!", "Rad1?", "Rad1??", "Rad1!?", "Rad1?!"
            };

            AssertPatternReturnsExpected(ChessRegex3.RookMovesFromFile, expected);
        }

        [Test]
        public void Rook_moves_from_file_with_check_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "Rad1+", "Rad1+!", "Rad1+!!", "Rad1+?", "Rad1+??", "Rad1+!?", "Rad1+?!"
            };

            AssertPatternReturnsExpected(ChessRegex3.RookMovesFromFileCheck, expected);
        }

        [Test]
        public void Rook_moves_from_file_with_checkmate_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "Rad1++", "Rad1#"
            };

            AssertPatternReturnsExpected(ChessRegex3.RookMovesFromFileCheckmate, expected);
        }

        [Test]
        public void Rook_moves_from_rank_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "R5d1", "R5d1!", "R5d1!!", "R5d1?", "R5d1??", "R5d1!?", "R5d1?!"
            };

            AssertPatternReturnsExpected(ChessRegex3.RookMovesFromRank, expected);
        }

        [Test]
        public void Rook_moves_from_rank_with_check_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "R5d1+", "R5d1+!", "R5d1+!!", "R5d1+?", "R5d1+??", "R5d1+!?", "R5d1+?!"
            };

            AssertPatternReturnsExpected(ChessRegex3.RookMovesFromRankCheck, expected);
        }

        [Test]
        public void Rook_moves_from_rank_with_checkmate_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "R5d1++", "R5d1#"
            };

            AssertPatternReturnsExpected(ChessRegex3.RookMovesFromRankCheckmate, expected);
        }

        [Test]
        public void Rook_captures_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "Rxd1", "Rxd1!", "Rxd1!!", "Rxd1?", "Rxd1??", "Rxd1!?", "Rxd1?!"
            };

            AssertPatternReturnsExpected(ChessRegex3.RookCaptures, expected);
        }

        [Test]
        public void Rook_captures_with_check_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "Rxd1+", "Rxd1+!", "Rxd1+!!", "Rxd1+?", "Rxd1+??", "Rxd1+!?", "Rxd1+?!"
            };

            AssertPatternReturnsExpected(ChessRegex3.RookCapturesCheck, expected);
        }

        [Test]
        public void Rook_captures_with_checkmate_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "Rxd1++", "Rxd1#"
            };

            AssertPatternReturnsExpected(ChessRegex3.RookCapturesCheckmate, expected);
        }

        [Test]
        public void Rook_captures_from_file_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "Raxd1", "Raxd1!", "Raxd1!!", "Raxd1?", "Raxd1??", "Raxd1!?", "Raxd1?!"
            };

            AssertPatternReturnsExpected(ChessRegex3.RookCapturesFromFile, expected);
        }

        [Test]
        public void Rook_captures_from_file_with_check_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "Raxd1+", "Raxd1+!", "Raxd1+!!", "Raxd1+?", "Raxd1+??", "Raxd1+!?", "Raxd1+?!"
            };

            AssertPatternReturnsExpected(ChessRegex3.RookCapturesFromFileCheck, expected);
        }

        [Test]
        public void Rook_captures_from_file_with_checkmate_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "Raxd1++", "Raxd1#"
            };

            AssertPatternReturnsExpected(ChessRegex3.RookCapturesFromFileCheckmate, expected);
        }

        [Test]
        public void Rook_captures_from_rank_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "R5xd1", "R5xd1!", "R5xd1!!", "R5xd1?", "R5xd1??", "R5xd1!?", "R5xd1?!"
            };

            AssertPatternReturnsExpected(ChessRegex3.RookCapturesFromRank, expected);
        }

        [Test]
        public void Rook_captures_from_rank_with_check_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "R5xd1+", "R5xd1+!", "R5xd1+!!", "R5xd1+?", "R5xd1+??", "R5xd1+!?", "R5xd1+?!"
            };

            AssertPatternReturnsExpected(ChessRegex3.RookCapturesFromRankCheck, expected);
        }

        [Test]
        public void Rook_captures_from_rank_with_checkmate_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "R5xd1++", "R5xd1#"
            };

            AssertPatternReturnsExpected(ChessRegex3.RookCapturesFromRankCheckmate, expected);
        }

        [Test]
        public void Knight_moves_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "Nd5", "Nd5!", "Nd5!!", "Nd5?", "Nd5??", "Nd5!?", "Nd5?!"
            };

            AssertPatternReturnsExpected(ChessRegex3.KnightMoves, expected);
        }

        [Test]
        public void Knight_moves_with_check_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "Nd5+", "Nd5+!", "Nd5+!!", "Nd5+?", "Nd5+??", "Nd5+!?", "Nd5+?!"
            };

            AssertPatternReturnsExpected(ChessRegex3.KnightMovesCheck, expected);
        }

        [Test]
        public void Knight_moves_with_checkmate_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "Nd5++", "Nd5#"
            };

            AssertPatternReturnsExpected(ChessRegex3.KnightMovesCheckmate, expected);
        }

        [Test]
        public void Knight_moves_from_file_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "Ncd5", "Ncd5!", "Ncd5!!", "Ncd5?", "Ncd5??", "Ncd5!?", "Ncd5?!"
            };

            AssertPatternReturnsExpected(ChessRegex3.KnightMovesFromFile, expected);
        }

        [Test]
        public void Knight_moves_from_file_with_check_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "Ncd5+", "Ncd5+!", "Ncd5+!!", "Ncd5+?", "Ncd5+??", "Ncd5+!?", "Ncd5+?!"
            };

            AssertPatternReturnsExpected(ChessRegex3.KnightMovesFromFileCheck, expected);
        }

        [Test]
        public void Knight_moves_from_file_with_checkmate_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "Ncd5++", "Ncd5#"
            };

            AssertPatternReturnsExpected(ChessRegex3.KnightMovesFromFileCheckmate, expected);
        }

        [Test]
        public void Knight_moves_from_rank_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "N7d5", "N7d5!", "N7d5!!", "N7d5?", "N7d5??", "N7d5!?", "N7d5?!"
            };

            AssertPatternReturnsExpected(ChessRegex3.KnightMovesFromRank, expected);
        }

        [Test]
        public void Knight_moves_from_rank_with_check_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "N7d5+", "N7d5+!", "N7d5+!!", "N7d5+?", "N7d5+??", "N7d5+!?", "N7d5+?!"
            };

            AssertPatternReturnsExpected(ChessRegex3.KnightMovesFromRankCheck, expected);
        }

        [Test]
        public void Knight_moves_from_rank_with_checkmate_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "N7d5++", "N7d5#"
            };

            AssertPatternReturnsExpected(ChessRegex3.KnightMovesFromRankCheckmate, expected);
        }

        [Test]
        public void Knight_moves_from_square_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "Nc7d5", "Nc7d5!", "Nc7d5!!", "Nc7d5?", "Nc7d5??", "Nc7d5!?", "Nc7d5?!"
            };

            AssertPatternReturnsExpected(ChessRegex3.KnightMovesFromSquare, expected);
        }

        [Test]
        public void Knight_moves_from_square_with_check_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "Nc7d5+", "Nc7d5+!", "Nc7d5+!!", "Nc7d5+?", "Nc7d5+??", "Nc7d5+!?", "Nc7d5+?!"
            };

            AssertPatternReturnsExpected(ChessRegex3.KnightMovesFromSquareCheck, expected);
        }

        [Test]
        public void Knight_moves_from_square_with_checkmate_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "Nc7d5++", "Nc7d5#"
            };

            AssertPatternReturnsExpected(ChessRegex3.KnightMovesFromSquareCheckmate, expected);
        }

        [Test]
        public void Knight_captures_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "Nxd5", "Nxd5!", "Nxd5!!", "Nxd5?", "Nxd5??", "Nxd5!?", "Nxd5?!"
            };

            AssertPatternReturnsExpected(ChessRegex3.KnightCaptures, expected);
        }

        [Test]
        public void Knight_captures_with_check_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "Nxd5+", "Nxd5+!", "Nxd5+!!", "Nxd5+?", "Nxd5+??", "Nxd5+!?", "Nxd5+?!"
            };

            AssertPatternReturnsExpected(ChessRegex3.KnightCapturesCheck, expected);
        }

        [Test]
        public void Knight_captures_with_checkmate_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "Nxd5++", "Nxd5#"
            };

            AssertPatternReturnsExpected(ChessRegex3.KnightCapturesCheckmate, expected);
        }

        [Test]
        public void Knight_captures_from_file_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "Ncxd5", "Ncxd5!", "Ncxd5!!", "Ncxd5?", "Ncxd5??", "Ncxd5!?", "Ncxd5?!"
            };

            AssertPatternReturnsExpected(ChessRegex3.KnightCapturesFromFile, expected);
        }

        [Test]
        public void Knight_captures_from_file_with_check_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "Ncxd5+", "Ncxd5+!", "Ncxd5+!!", "Ncxd5+?", "Ncxd5+??", "Ncxd5+!?", "Ncxd5+?!"
            };

            AssertPatternReturnsExpected(ChessRegex3.KnightCapturesFromFileCheck, expected);
        }

        [Test]
        public void Knight_captures_from_file_with_checkmate_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "Ncxd5++", "Ncxd5#"
            };

            AssertPatternReturnsExpected(ChessRegex3.KnightCapturesFromFileCheckmate, expected);
        }

        [Test]
        public void Knight_captures_from_rank_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "N7xd5", "N7xd5!", "N7xd5!!", "N7xd5?", "N7xd5??", "N7xd5!?", "N7xd5?!"
            };

            AssertPatternReturnsExpected(ChessRegex3.KnightCapturesFromRank, expected);
        }

        [Test]
        public void Knight_captures_from_rank_with_check_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "N7xd5+", "N7xd5+!", "N7xd5+!!", "N7xd5+?", "N7xd5+??", "N7xd5+!?", "N7xd5+?!"
            };

            AssertPatternReturnsExpected(ChessRegex3.KnightCapturesFromRankCheck, expected);
        }

        [Test]
        public void Knight_captures_from_rank_with_checkmate_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "N7xd5++", "N7xd5#"
            };

            AssertPatternReturnsExpected(ChessRegex3.KnightCapturesFromRankCheckmate, expected);
        }

        [Test]
        public void Knight_captures_from_square_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "Nc7xd5", "Nc7xd5!", "Nc7xd5!!", "Nc7xd5?", "Nc7xd5??", "Nc7xd5!?", "Nc7xd5?!"
            };

            AssertPatternReturnsExpected(ChessRegex3.KnightCapturesFromSquare, expected);
        }

        [Test]
        public void Knight_captures_from_square_with_check_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "Nc7xd5+", "Nc7xd5+!", "Nc7xd5+!!", "Nc7xd5+?", "Nc7xd5+??", "Nc7xd5+!?", "Nc7xd5+?!"
            };

            AssertPatternReturnsExpected(ChessRegex3.KnightCapturesFromSquareCheck, expected);
        }

        [Test]
        public void Knight_captures_from_square_with_checkmate_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "Nc7xd5++", "Nc7xd5#"
            };

            AssertPatternReturnsExpected(ChessRegex3.KnightCapturesFromSquareCheckmate, expected);
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
    }
}
