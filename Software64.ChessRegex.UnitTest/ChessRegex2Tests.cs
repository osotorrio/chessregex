﻿using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using NUnit.Framework;

namespace Software64.ChessRegex.UnitTest
{
    [TestFixture]
    public class ChessRegex2Tests : ChessRegexTestBase
    {
        [Test]
        public void Pawn_moves_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "e4", "e4!", "e4!!", "e4?", "e4??", "e4!?", "e4?!",
                "e4+", "e4+!", "e4+!!", "e4+?", "e4+??", "e4+!?", "e4+?!",
                "e4++", "e4#"
            };

            AssertPatternReturnsExpected(ChessRegex2.PawnMoves, expected);
        }

        [Test]
        public void Pawn_promotes_move_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "e8=Q", "e8=Q!", "e8=Q!!", "e8=Q?", "e8=Q??", "e8=Q!?", "e8=Q?!",
                "e8=Q+", "e8=Q+!", "e8=Q+!!", "e8=Q+?", "e8=Q+??", "e8=Q+!?", "e8=Q+?!",
                "e8=Q++", "e8=Q#"
            };

            AssertPatternReturnsExpected(ChessRegex2.PawnPromotes, expected);
        }

        [Test]
        public void Pawn_captures_move_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "dxe4", "dxe4!", "dxe4!!", "dxe4?", "dxe4??", "dxe4!?", "dxe4?!",
                "dxe4+", "dxe4+!", "dxe4+!!", "dxe4+?", "dxe4+??", "dxe4+!?", "dxe4+?!",
                "dxe4++", "dxe4#"
            };

            AssertPatternReturnsExpected(ChessRegex2.PawnCaptures, expected);
        }

        [Test]
        public void Pawn_captures_and_promotes_move_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "dxe8=Q", "dxe8=Q!", "dxe8=Q!!", "dxe8=Q?", "dxe8=Q??", "dxe8=Q!?", "dxe8=Q?!",
                "dxe8=Q+", "dxe8=Q+!", "dxe8=Q+!!", "dxe8=Q+?", "dxe8=Q+??", "dxe8=Q+!?", "dxe8=Q+?!",
                "dxe8=Q++", "dxe8=Q#"
            };

            AssertPatternReturnsExpected(ChessRegex2.PawnCapturesPromotes, expected);
        }

        [Test]
        public void Rook_move_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "Rd1", "Rd1!", "Rd1!!", "Rd1?", "Rd1??", "Rd1!?", "Rd1?!",
                "Rd1+", "Rd1+!", "Rd1+!!", "Rd1+?", "Rd1+??", "Rd1+!?", "Rd1+?!",
                "Rd1++", "Rd1#"
            };

            AssertPatternReturnsExpected(ChessRegex2.RookMoves, expected);
        }

        [Test]
        public void Rook_move_from_file_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "Rad1", "Rad1!", "Rad1!!", "Rad1?", "Rad1??", "Rad1!?", "Rad1?!",
                "Rad1+", "Rad1+!", "Rad1+!!", "Rad1+?", "Rad1+??", "Rad1+!?", "Rad1+?!",
                "Rad1++", "Rad1#"
            };

            AssertPatternReturnsExpected(ChessRegex2.RookMovesFromFile, expected);
        }

        [Test]
        public void Rook_move_from_rank_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "R5d1", "R5d1!", "R5d1!!", "R5d1?", "R5d1??", "R5d1!?", "R5d1?!",
                "R5d1+", "R5d1+!", "R5d1+!!", "R5d1+?", "R5d1+??", "R5d1+!?", "R5d1+?!",
                "R5d1++", "R5d1#"
            };

            AssertPatternReturnsExpected(ChessRegex2.RookMovesFromRank, expected);
        }

        [Test]
        public void Rook_captures_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "Rxd1", "Rxd1!", "Rxd1!!", "Rxd1?", "Rxd1??", "Rxd1!?", "Rxd1?!",
                "Rxd1+", "Rxd1+!", "Rxd1+!!", "Rxd1+?", "Rxd1+??", "Rxd1+!?", "Rxd1+?!",
                "Rxd1++", "Rxd1#"
            };

            AssertPatternReturnsExpected(ChessRegex2.RookCaptures, expected);
        }

        [Test]
        public void Rook_captures_from_file_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "Raxd1", "Raxd1!", "Raxd1!!", "Raxd1?", "Raxd1??", "Raxd1!?", "Raxd1?!",
                "Raxd1+", "Raxd1+!", "Raxd1+!!", "Raxd1+?", "Raxd1+??", "Raxd1+!?", "Raxd1+?!",
                "Raxd1++", "Raxd1#"
            };

            AssertPatternReturnsExpected(ChessRegex2.RookCapturesFromFile, expected);
        }

        [Test]
        public void Rook_captures_from_rank_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "R5xd1", "R5xd1!", "R5xd1!!", "R5xd1?", "R5xd1??", "R5xd1!?", "R5xd1?!",
                "R5xd1+", "R5xd1+!", "R5xd1+!!", "R5xd1+?", "R5xd1+??", "R5xd1+!?", "R5xd1+?!",
                "R5xd1++", "R5xd1#"
            };

            AssertPatternReturnsExpected(ChessRegex2.RookCapturesFromRank, expected);
        }

        [Test]
        public void Knight_moves_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "Nd5", "Nd5!", "Nd5!!", "Nd5?", "Nd5??", "Nd5!?", "Nd5?!",
                "Nd5+", "Nd5+!", "Nd5+!!", "Nd5+?", "Nd5+??", "Nd5+!?", "Nd5+?!",
                "Nd5++", "Nd5#"
            };

            AssertPatternReturnsExpected(ChessRegex2.KnightMoves, expected);
        }

        [Test]
        public void Knight_moves_from_file_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "Ncd5", "Ncd5!", "Ncd5!!", "Ncd5?", "Ncd5??", "Ncd5!?", "Ncd5?!",
                "Ncd5+", "Ncd5+!", "Ncd5+!!", "Ncd5+?", "Ncd5+??", "Ncd5+!?", "Ncd5+?!",
                "Ncd5++", "Ncd5#"
            };

            AssertPatternReturnsExpected(ChessRegex2.KnightMovesFromFile, expected);
        }

        [Test]
        public void Knight_moves_from_rank_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "N7d5", "N7d5!", "N7d5!!", "N7d5?", "N7d5??", "N7d5!?", "N7d5?!",
                "N7d5+", "N7d5+!", "N7d5+!!", "N7d5+?", "N7d5+??", "N7d5+!?", "N7d5+?!",
                "N7d5++", "N7d5#"
            };

            AssertPatternReturnsExpected(ChessRegex2.KnightMovesFromRank, expected);
        }

        [Test]
        public void Knight_moves_from_square_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "Nc7d5", "Nc7d5!", "Nc7d5!!", "Nc7d5?", "Nc7d5??", "Nc7d5!?", "Nc7d5?!",
                "Nc7d5+", "Nc7d5+!", "Nc7d5+!!", "Nc7d5+?", "Nc7d5+??", "Nc7d5+!?", "Nc7d5+?!",
                "Nc7d5++", "Nc7d5#"
            };

            AssertPatternReturnsExpected(ChessRegex2.KnightMovesFromSquare, expected);
        }

        [Test]
        public void Knight_captures_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "Nxd5", "Nxd5!", "Nxd5!!", "Nxd5?", "Nxd5??", "Nxd5!?", "Nxd5?!",
                "Nxd5+", "Nxd5+!", "Nxd5+!!", "Nxd5+?", "Nxd5+??", "Nxd5+!?", "Nxd5+?!",
                "Nxd5++", "Nxd5#"
            };

            AssertPatternReturnsExpected(ChessRegex2.KnightCaptures, expected);
        }

        [Test]
        public void Knight_captures_from_file_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "Ncxd5", "Ncxd5!", "Ncxd5!!", "Ncxd5?", "Ncxd5??", "Ncxd5!?", "Ncxd5?!",
                "Ncxd5+", "Ncxd5+!", "Ncxd5+!!", "Ncxd5+?", "Ncxd5+??", "Ncxd5+!?", "Ncxd5+?!",
                "Ncxd5++", "Ncxd5#",
            };

            AssertPatternReturnsExpected(ChessRegex2.KnightCapturesFromFile, expected);
        }

        [Test]
        public void Knight_captures_from_rank_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "N7xd5", "N7xd5!", "N7xd5!!", "N7xd5?", "N7xd5??", "N7xd5!?", "N7xd5?!",
                "N7xd5+", "N7xd5+!", "N7xd5+!!", "N7xd5+?", "N7xd5+??", "N7xd5+!?", "N7xd5+?!",
                "N7xd5++", "N7xd5#",
            };

            AssertPatternReturnsExpected(ChessRegex2.KnightCapturesFromRank, expected);
        }

        [Test]
        public void Knight_captures_from_square_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "Nc7xd5", "Nc7xd5!", "Nc7xd5!!", "Nc7xd5?", "Nc7xd5??", "Nc7xd5!?", "Nc7xd5?!",
                "Nc7xd5+", "Nc7xd5+!", "Nc7xd5+!!", "Nc7xd5+?", "Nc7xd5+??", "Nc7xd5+!?", "Nc7xd5+?!",
                "Nc7xd5++", "Nc7xd5#",
            };

            AssertPatternReturnsExpected(ChessRegex2.KnightCapturesFromSquare, expected);
        }

        [Test]
        public void Bishop_moves_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "Be4", "Be4!", "Be4!!", "Be4?", "Be4??", "Be4!?", "Be4?!",
                "Be4+", "Be4+!", "Be4+!!", "Be4+?", "Be4+??", "Be4+!?", "Be4+?!",
                "Be4++", "Be4#"
            };

            AssertPatternReturnsExpected(ChessRegex2.BishopMoves, expected);
        }

        [Test]
        public void Bishop_moves_from_file_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "Bhe4", "Bhe4!", "Bhe4!!", "Bhe4?", "Bhe4??", "Bhe4!?", "Bhe4?!",
                "Bhe4+", "Bhe4+!", "Bhe4+!!", "Bhe4+?", "Bhe4+??", "Bhe4+!?", "Bhe4+?!",
                "Bhe4++", "Bhe4#"
            };

            AssertPatternReturnsExpected(ChessRegex2.BishopMovesFromFile, expected);
        }

        [Test]
        public void Bishop_moves_from_rank_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "B7e4", "B7e4!", "B7e4!!", "B7e4?", "B7e4??", "B7e4!?", "B7e4?!",
                "B7e4+", "B7e4+!", "B7e4+!!", "B7e4+?", "B7e4+??", "B7e4+!?", "B7e4+?!",
                "B7e4++", "B7e4#"
            };

            AssertPatternReturnsExpected(ChessRegex2.BishopMovesFromRank, expected);
        }

        [Test]
        public void Bishop_moves_from_square_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "Bh7e4", "Bh7e4!", "Bh7e4!!", "Bh7e4?", "Bh7e4??", "Bh7e4!?", "Bh7e4?!",
                "Bh7e4+", "Bh7e4+!", "Bh7e4+!!", "Bh7e4+?", "Bh7e4+??", "Bh7e4+!?", "Bh7e4+?!",
                "Bh7e4++", "Bh7e4#"
            };

            AssertPatternReturnsExpected(ChessRegex2.BishopMovesFromSquare, expected);
        }

        [Test]
        public void Bishop_captures_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "Bxe4", "Bxe4!", "Bxe4!!", "Bxe4?", "Bxe4??", "Bxe4!?", "Bxe4?!",
                "Bxe4+", "Bxe4+!", "Bxe4+!!", "Bxe4+?", "Bxe4+??", "Bxe4+!?", "Bxe4+?!",
                "Bxe4++", "Bxe4#"
            };

            AssertPatternReturnsExpected(ChessRegex2.BishopCaptures, expected);
        }

        [Test]
        public void Bishop_captures_from_file_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "Bhxe4", "Bhxe4!", "Bhxe4!!", "Bhxe4?", "Bhxe4??", "Bhxe4!?", "Bhxe4?!",
                "Bhxe4+", "Bhxe4+!", "Bhxe4+!!", "Bhxe4+?", "Bhxe4+??", "Bhxe4+!?", "Bhxe4+?!",
                "Bhxe4++", "Bhxe4#"
            };

            AssertPatternReturnsExpected(ChessRegex2.BishopCapturesFromFile, expected);
        }

        [Test]
        public void Bishop_captures_from_rank_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "B7xe4", "B7xe4!", "B7xe4!!", "B7xe4?", "B7xe4??", "B7xe4!?", "B7xe4?!",
                "B7xe4+", "B7xe4+!", "B7xe4+!!", "B7xe4+?", "B7xe4+??", "B7xe4+!?", "B7xe4+?!",
                "B7xe4++", "B7xe4#"
            };

            AssertPatternReturnsExpected(ChessRegex2.BishopCapturesFromRank, expected);
        }

        [Test]
        public void Bishop_captures_from_square_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "Bh7xe4", "Bh7xe4!", "Bh7xe4!!", "Bh7xe4?", "Bh7xe4??", "Bh7xe4!?", "Bh7xe4?!",
                "Bh7xe4+", "Bh7xe4+!", "Bh7xe4+!!", "Bh7xe4+?", "Bh7xe4+??", "Bh7xe4+!?", "Bh7xe4+?!",
                "Bh7xe4++", "Bh7xe4#"
            };

            AssertPatternReturnsExpected(ChessRegex2.BishopCapturesFromSquare, expected);
        }

        [Test]
        public void Queen_moves_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "Qd5", "Qd5!", "Qd5!!", "Qd5?", "Qd5??", "Qd5!?", "Qd5?!",
                "Qd5+", "Qd5+!", "Qd5+!!", "Qd5+?", "Qd5+??", "Qd5+!?", "Qd5+?!",
                "Qd5++", "Qd5#"
            };

            AssertPatternReturnsExpected(ChessRegex2.QueenMoves, expected);
        }

        [Test]
        public void Queen_moves_from_file_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "Qad5", "Qad5!", "Qad5!!", "Qad5?", "Qad5??", "Qad5!?", "Qad5?!",
                "Qad5+", "Qad5+!", "Qad5+!!", "Qad5+?", "Qad5+??", "Qad5+!?", "Qad5+?!",
                "Qad5++", "Qad5#"
            };

            AssertPatternReturnsExpected(ChessRegex2.QueenMovesFromFile, expected);
        }

        [Test]
        public void Queen_moves_from_rank_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "Q2d5", "Q2d5!", "Q2d5!!", "Q2d5?", "Q2d5??", "Q2d5!?", "Q2d5?!",
                "Q2d5+", "Q2d5+!", "Q2d5+!!", "Q2d5+?", "Q2d5+??", "Q2d5+!?", "Q2d5+?!",
                "Q2d5++", "Q2d5#"
            };

            AssertPatternReturnsExpected(ChessRegex2.QueenMovesFromRank, expected);
        }

        [Test]
        public void Queen_moves_from_square_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "Qa2d5", "Qa2d5!", "Qa2d5!!", "Qa2d5?", "Qa2d5??", "Qa2d5!?", "Qa2d5?!",
                "Qa2d5+", "Qa2d5+!", "Qa2d5+!!", "Qa2d5+?", "Qa2d5+??", "Qa2d5+!?", "Qa2d5+?!",
                "Qa2d5++", "Qa2d5#"
            };

            AssertPatternReturnsExpected(ChessRegex2.QueenMovesFromSquare, expected);
        }

        [Test]
        public void Queen_captures_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "Qxd5", "Qxd5!", "Qxd5!!", "Qxd5?", "Qxd5??", "Qxd5!?", "Qxd5?!",
                "Qxd5+", "Qxd5+!", "Qxd5+!!", "Qxd5+?", "Qxd5+??", "Qxd5+!?", "Qxd5+?!",
                "Qxd5++", "Qxd5#"
            };

            AssertPatternReturnsExpected(ChessRegex2.QueenCaptures, expected);
        }

        [Test]
        public void Queen_captures_from_file_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "Qaxd5", "Qaxd5!", "Qaxd5!!", "Qaxd5?", "Qaxd5??", "Qaxd5!?", "Qaxd5?!",
                "Qaxd5+", "Qaxd5+!", "Qaxd5+!!", "Qaxd5+?", "Qaxd5+??", "Qaxd5+!?", "Qaxd5+?!",
                "Qaxd5++", "Qaxd5#"
            };

            AssertPatternReturnsExpected(ChessRegex2.QueenCapturesFromFile, expected);
        }

        [Test]
        public void Queen_captures_from_rank_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "Q2xd5", "Q2xd5!", "Q2xd5!!", "Q2xd5?", "Q2xd5??", "Q2xd5!?", "Q2xd5?!",
                "Q2xd5+", "Q2xd5+!", "Q2xd5+!!", "Q2xd5+?", "Q2xd5+??", "Q2xd5+!?", "Q2xd5+?!",
                "Q2xd5++", "Q2xd5#"
            };

            AssertPatternReturnsExpected(ChessRegex2.QueenCapturesFromRank, expected);
        }

        [Test]
        public void Queen_captures_from_square_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "Qa2xd5", "Qa2xd5!", "Qa2xd5!!", "Qa2xd5?", "Qa2xd5??", "Qa2xd5!?", "Qa2xd5?!",
                "Qa2xd5+", "Qa2xd5+!", "Qa2xd5+!!", "Qa2xd5+?", "Qa2xd5+??", "Qa2xd5+!?", "Qa2xd5+?!",
                "Qa2xd5++", "Qa2xd5#"
            };

            AssertPatternReturnsExpected(ChessRegex2.QueenCapturesFromSquare, expected);
        }

        [Test]
        public void King_moves_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "Kd1", "Kd1!", "Kd1!!", "Kd1?", "Kd1??", "Kd1!?", "Kd1?!",
                "Kd1+", "Kd1+!", "Kd1+!!", "Kd1+?", "Kd1+??", "Kd1+!?", "Kd1+?!",
                "Kd1++", "Kd1#"
            };

            AssertPatternReturnsExpected(ChessRegex2.KingMoves, expected);
        }

        [Test]
        public void King_captures_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "Kxd1", "Kxd1!", "Kxd1!!", "Kxd1?", "Kxd1??", "Kxd1!?", "Kxd1?!",
                "Kxd1+", "Kxd1+!", "Kxd1+!!", "Kxd1+?", "Kxd1+??", "Kxd1+!?", "Kxd1+?!",
                "Kxd1++", "Kxd1#"
            };

            AssertPatternReturnsExpected(ChessRegex2.KingCaptures, expected);
        }

        [Test]
        public void Castled_King_side_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "O-O", "O-O!", "O-O!!", "O-O?", "O-O??", "O-O!?", "O-O?!",
                "O-O+", "O-O+!", "O-O+!!", "O-O+?", "O-O+??", "O-O+!?", "O-O+?!",
                "O-O++", "O-O#"
            };

            AssertPatternReturnsExpected(ChessRegex2.CastledKingSide, expected);
        }

        [Test]
        public void Castled_Queen_side_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "O-O-O", "O-O-O!", "O-O-O!!", "O-O-O?", "O-O-O??", "O-O-O!?", "O-O-O?!",
                "O-O-O+", "O-O-O+!", "O-O-O+!!", "O-O-O+?", "O-O-O+??", "O-O-O+!?", "O-O-O+?!",
                "O-O-O++", "O-O-O#"
            };

            AssertPatternReturnsExpected(ChessRegex2.CastledQueenSide, expected);
        }
    }
}
