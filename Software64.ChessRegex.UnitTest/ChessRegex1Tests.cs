﻿using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using NUnit.Framework;

namespace Software64.ChessRegex.UnitTest
{
    [TestFixture]
    public class ChessRegex1Tests : ChessRegexTestBase
    {
        [Test]
        public void Pawn_moves_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "e4", "e4!", "e4!!", "e4?", "e4??", "e4!?", "e4?!",
                "e4+", "e4+!", "e4+!!", "e4+?", "e4+??", "e4+!?", "e4+?!",
                "e4++", "e4#",
                "e8=Q", "e8=Q!", "e8=Q!!", "e8=Q?", "e8=Q??", "e8=Q!?", "e8=Q?!",
                "e8=Q+", "e8=Q+!", "e8=Q+!!", "e8=Q+?", "e8=Q+??", "e8=Q+!?", "e8=Q+?!",
                "e8=Q++", "e8=Q#",
                "dxe4", "dxe4!", "dxe4!!", "dxe4?", "dxe4??", "dxe4!?", "dxe4?!",
                "dxe4+", "dxe4+!", "dxe4+!!", "dxe4+?", "dxe4+??", "dxe4+!?", "dxe4+?!",
                "dxe4++", "dxe4#",
                "dxe8=Q", "dxe8=Q!", "dxe8=Q!!", "dxe8=Q?", "dxe8=Q??", "dxe8=Q!?", "dxe8=Q?!",
                "dxe8=Q+", "dxe8=Q+!", "dxe8=Q+!!", "dxe8=Q+?", "dxe8=Q+??", "dxe8=Q+!?", "dxe8=Q+?!",
                "dxe8=Q++", "dxe8=Q#"
            };

            AssertPatternReturnsExpected(ChessRegex1.PawnMoves, expected);
        }

        [Test]
        public void Rook_moves_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "Rd1", "Rd1!", "Rd1!!", "Rd1?", "Rd1??", "Rd1!?", "Rd1?!",
                "Rd1+", "Rd1+!", "Rd1+!!", "Rd1+?", "Rd1+??", "Rd1+!?", "Rd1+?!",
                "Rd1++", "Rd1#",
                "Rad1", "Rad1!", "Rad1!!", "Rad1?", "Rad1??", "Rad1!?", "Rad1?!",
                "Rad1+", "Rad1+!", "Rad1+!!", "Rad1+?", "Rad1+??", "Rad1+!?", "Rad1+?!",
                "Rad1++", "Rad1#",
                "R5d1", "R5d1!", "R5d1!!", "R5d1?", "R5d1??", "R5d1!?", "R5d1?!",
                "R5d1+", "R5d1+!", "R5d1+!!", "R5d1+?", "R5d1+??", "R5d1+!?", "R5d1+?!",
                "R5d1++", "R5d1#",
                "Rxd1", "Rxd1!", "Rxd1!!", "Rxd1?", "Rxd1??", "Rxd1!?", "Rxd1?!",
                "Rxd1+", "Rxd1+!", "Rxd1+!!", "Rxd1+?", "Rxd1+??", "Rxd1+!?", "Rxd1+?!",
                "Rxd1++", "Rxd1#",
                "Raxd1", "Raxd1!", "Raxd1!!", "Raxd1?", "Raxd1??", "Raxd1!?", "Raxd1?!",
                "Raxd1+", "Raxd1+!", "Raxd1+!!", "Raxd1+?", "Raxd1+??", "Raxd1+!?", "Raxd1+?!",
                "Raxd1++", "Raxd1#",
                "R5xd1", "R5xd1!", "R5xd1!!", "R5xd1?", "R5xd1??", "R5xd1!?", "R5xd1?!",
                "R5xd1+", "R5xd1+!", "R5xd1+!!", "R5xd1+?", "R5xd1+??", "R5xd1+!?", "R5xd1+?!",
                "R5xd1++", "R5xd1#"
            };

            AssertPatternReturnsExpected(ChessRegex1.RookMoves, expected);
        }

        [Test]
        public void Knight_moves_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "Nd5", "Nd5!", "Nd5!!", "Nd5?", "Nd5??", "Nd5!?", "Nd5?!",
                "Nd5+", "Nd5+!", "Nd5+!!", "Nd5+?", "Nd5+??", "Nd5+!?", "Nd5+?!",
                "Nd5++", "Nd5#",
                "Ncd5", "Ncd5!", "Ncd5!!", "Ncd5?", "Ncd5??", "Ncd5!?", "Ncd5?!",
                "Ncd5+", "Ncd5+!", "Ncd5+!!", "Ncd5+?", "Ncd5+??", "Ncd5+!?", "Ncd5+?!",
                "Ncd5++", "Ncd5#",
                "N7d5", "N7d5!", "N7d5!!", "N7d5?", "N7d5??", "N7d5!?", "N7d5?!",
                "N7d5+", "N7d5+!", "N7d5+!!", "N7d5+?", "N7d5+??", "N7d5+!?", "N7d5+?!",
                "N7d5++", "N7d5#",
                "Nc7d5", "Nc7d5!", "Nc7d5!!", "Nc7d5?", "Nc7d5??", "Nc7d5!?", "Nc7d5?!",
                "Nc7d5+", "Nc7d5+!", "Nc7d5+!!", "Nc7d5+?", "Nc7d5+??", "Nc7d5+!?", "Nc7d5+?!",
                "Nc7d5++", "Nc7d5#",
                "Nxd5", "Nxd5!", "Nxd5!!", "Nxd5?", "Nxd5??", "Nxd5!?", "Nxd5?!",
                "Nxd5+", "Nxd5+!", "Nxd5+!!", "Nxd5+?", "Nxd5+??", "Nxd5+!?", "Nxd5+?!",
                "Nxd5++", "Nxd5#",
                "Ncxd5", "Ncxd5!", "Ncxd5!!", "Ncxd5?", "Ncxd5??", "Ncxd5!?", "Ncxd5?!",
                "Ncxd5+", "Ncxd5+!", "Ncxd5+!!", "Ncxd5+?", "Ncxd5+??", "Ncxd5+!?", "Ncxd5+?!",
                "Ncxd5++", "Ncxd5#",
                "N7xd5", "N7xd5!", "N7xd5!!", "N7xd5?", "N7xd5??", "N7xd5!?", "N7xd5?!",
                "N7xd5+", "N7xd5+!", "N7xd5+!!", "N7xd5+?", "N7xd5+??", "N7xd5+!?", "N7xd5+?!",
                "N7xd5++", "N7xd5#",
                "Nc7xd5", "Nc7xd5!", "Nc7xd5!!", "Nc7xd5?", "Nc7xd5??", "Nc7xd5!?", "Nc7xd5?!",
                "Nc7xd5+", "Nc7xd5+!", "Nc7xd5+!!", "Nc7xd5+?", "Nc7xd5+??", "Nc7xd5+!?", "Nc7xd5+?!",
                "Nc7xd5++", "Nc7xd5#"
            };

            AssertPatternReturnsExpected(ChessRegex1.KnightMoves, expected);
        }

        [Test]
        public void Bishop_moves_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "Be4", "Be4!", "Be4!!", "Be4?", "Be4??", "Be4!?", "Be4?!",
                "Be4+", "Be4+!", "Be4+!!", "Be4+?", "Be4+??", "Be4+!?", "Be4+?!",
                "Be4++", "Be4#",
                "Bhe4", "Bhe4!", "Bhe4!!", "Bhe4?", "Bhe4??", "Bhe4!?", "Bhe4?!",
                "Bhe4+", "Bhe4+!", "Bhe4+!!", "Bhe4+?", "Bhe4+??", "Bhe4+!?", "Bhe4+?!",
                "Bhe4++", "Bhe4#",
                "B7e4", "B7e4!", "B7e4!!", "B7e4?", "B7e4??", "B7e4!?", "B7e4?!",
                "B7e4+", "B7e4+!", "B7e4+!!", "B7e4+?", "B7e4+??", "B7e4+!?", "B7e4+?!",
                "B7e4++", "B7e4#",
                "Bh7e4", "Bh7e4!", "Bh7e4!!", "Bh7e4?", "Bh7e4??", "Bh7e4!?", "Bh7e4?!",
                "Bh7e4+", "Bh7e4+!", "Bh7e4+!!", "Bh7e4+?", "Bh7e4+??", "Bh7e4+!?", "Bh7e4+?!",
                "Bh7e4++", "Bh7e4#",
                "Bxe4", "Bxe4!", "Bxe4!!", "Bxe4?", "Bxe4??", "Bxe4!?", "Bxe4?!",
                "Bxe4+", "Bxe4+!", "Bxe4+!!", "Bxe4+?", "Bxe4+??", "Bxe4+!?", "Bxe4+?!",
                "Bxe4++", "Bxe4#",
                "Bhxe4", "Bhxe4!", "Bhxe4!!", "Bhxe4?", "Bhxe4??", "Bhxe4!?", "Bhxe4?!",
                "Bhxe4+", "Bhxe4+!", "Bhxe4+!!", "Bhxe4+?", "Bhxe4+??", "Bhxe4+!?", "Bhxe4+?!",
                "Bhxe4++", "Bhxe4#",
                "B7xe4", "B7xe4!", "B7xe4!!", "B7xe4?", "B7xe4??", "B7xe4!?", "B7xe4?!",
                "B7xe4+", "B7xe4+!", "B7xe4+!!", "B7xe4+?", "B7xe4+??", "B7xe4+!?", "B7xe4+?!",
                "B7xe4++", "B7xe4#",
                "Bh7xe4", "Bh7xe4!", "Bh7xe4!!", "Bh7xe4?", "Bh7xe4??", "Bh7xe4!?", "Bh7xe4?!",
                "Bh7xe4+", "Bh7xe4+!", "Bh7xe4+!!", "Bh7xe4+?", "Bh7xe4+??", "Bh7xe4+!?", "Bh7xe4+?!",
                "Bh7xe4++", "Bh7xe4#",
            };

            AssertPatternReturnsExpected(ChessRegex1.BishopMoves, expected);
        }

        [Test]
        public void Queen_moves_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "Qd5", "Qd5!", "Qd5!!", "Qd5?", "Qd5??", "Qd5!?", "Qd5?!",
                "Qd5+", "Qd5+!", "Qd5+!!", "Qd5+?", "Qd5+??", "Qd5+!?", "Qd5+?!",
                "Qd5++", "Qd5#",
                "Qad5", "Qad5!", "Qad5!!", "Qad5?", "Qad5??", "Qad5!?", "Qad5?!",
                "Qad5+", "Qad5+!", "Qad5+!!", "Qad5+?", "Qad5+??", "Qad5+!?", "Qad5+?!",
                "Qad5++", "Qad5#",
                "Q2d5", "Q2d5!", "Q2d5!!", "Q2d5?", "Q2d5??", "Q2d5!?", "Q2d5?!",
                "Q2d5+", "Q2d5+!", "Q2d5+!!", "Q2d5+?", "Q2d5+??", "Q2d5+!?", "Q2d5+?!",
                "Q2d5++", "Q2d5#",
                "Qa2d5", "Qa2d5!", "Qa2d5!!", "Qa2d5?", "Qa2d5??", "Qa2d5!?", "Qa2d5?!",
                "Qa2d5+", "Qa2d5+!", "Qa2d5+!!", "Qa2d5+?", "Qa2d5+??", "Qa2d5+!?", "Qa2d5+?!",
                "Qa2d5++", "Qa2d5#",
                "Qxd5", "Qxd5!", "Qxd5!!", "Qxd5?", "Qxd5??", "Qxd5!?", "Qxd5?!",
                "Qxd5+", "Qxd5+!", "Qxd5+!!", "Qxd5+?", "Qxd5+??", "Qxd5+!?", "Qxd5+?!",
                "Qxd5++", "Qxd5#",
                "Qaxd5", "Qaxd5!", "Qaxd5!!", "Qaxd5?", "Qaxd5??", "Qaxd5!?", "Qaxd5?!",
                "Qaxd5+", "Qaxd5+!", "Qaxd5+!!", "Qaxd5+?", "Qaxd5+??", "Qaxd5+!?", "Qaxd5+?!",
                "Qaxd5++", "Qaxd5#",
                "Q2xd5", "Q2xd5!", "Q2xd5!!", "Q2xd5?", "Q2xd5??", "Q2xd5!?", "Q2xd5?!",
                "Q2xd5+", "Q2xd5+!", "Q2xd5+!!", "Q2xd5+?", "Q2xd5+??", "Q2xd5+!?", "Q2xd5+?!",
                "Q2xd5++", "Q2xd5#",
                "Qa2xd5", "Qa2xd5!", "Qa2xd5!!", "Qa2xd5?", "Qa2xd5??", "Qa2xd5!?", "Qa2xd5?!",
                "Qa2xd5+", "Qa2xd5+!", "Qa2xd5+!!", "Qa2xd5+?", "Qa2xd5+??", "Qa2xd5+!?", "Qa2xd5+?!",
                "Qa2xd5++", "Qa2xd5#",
            };

            AssertPatternReturnsExpected(ChessRegex1.QueenMoves, expected);
        }

        [Test]
        public void King_moves_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "Kd1", "Kd1!", "Kd1!!", "Kd1?", "Kd1??", "Kd1!?", "Kd1?!",
                "Kd1+", "Kd1+!", "Kd1+!!", "Kd1+?", "Kd1+??", "Kd1+!?", "Kd1+?!",
                "Kd1++", "Kd1#",
                "Kxd1", "Kxd1!", "Kxd1!!", "Kxd1?", "Kxd1??", "Kxd1!?", "Kxd1?!",
                "Kxd1+", "Kxd1+!", "Kxd1+!!", "Kxd1+?", "Kxd1+??", "Kxd1+!?", "Kxd1+?!",
                "Kxd1++", "Kxd1#"
            };

            AssertPatternReturnsExpected(ChessRegex1.KingMoves, expected);
        }

        [Test]
        public void Castle_moves_test()
        {
            // Arrange
            var expected = new List<string>
            {
                "O-O", "O-O!", "O-O!!", "O-O?", "O-O??", "O-O!?", "O-O?!",
                "O-O+", "O-O+!", "O-O+!!", "O-O+?", "O-O+??", "O-O+!?", "O-O+?!",
                "O-O++", "O-O#",
                "O-O-O", "O-O-O!", "O-O-O!!", "O-O-O?", "O-O-O??", "O-O-O!?", "O-O-O?!",
                "O-O-O+", "O-O-O+!", "O-O-O+!!", "O-O-O+?", "O-O-O+??", "O-O-O+!?", "O-O-O+?!",
                "O-O-O++", "O-O-O#"
            };

            AssertPatternReturnsExpected(ChessRegex1.Castled, expected);
        }
    }
}
