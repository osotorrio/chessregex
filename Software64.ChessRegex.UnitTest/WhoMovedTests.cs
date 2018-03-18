using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using NUnit.Framework;

namespace Software64.ChessRegex.UnitTest
{
    [TestFixture]
    public class WhoMovedTests
    {
        [Test]
        public void Pawn_moves()
        {
            // Arrange
            var expected = new List<string>
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
                "dxe8=Q#"
            };

            ActAndAssert(WhoMoved.Pawn, expected);
        }

        [Test]
        public void Rook_moves()
        {
            // Arrange
            var expected = new List<string>
            {
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
                "Raxd1#"
            };

            ActAndAssert(WhoMoved.Rook, expected);
        }

        [Test]
        public void Knight_moves()
        {
            // Arrange
            var expected = new List<string>
            {
                "Nd1", "Nd1!", "Nd1!!", "Nd1?", "Nd1??", "Nd1!?", "Nd1?!",
                "Nd1+", "Nd1+!", "Nd1+!!", "Nd1+?", "Nd1+??", "Nd1+!?", "Nd1+?!",
                "Nd1#",
                "Nad1", "Nad1!", "Nad1!!", "Nad1?", "Nad1??", "Nad1!?", "Nad1?!",
                "Nad1+", "Nad1+!", "Nad1+!!", "Nad1+?", "Nad1+??", "Nad1+!?", "Nad1+?!",
                "Nad1#",
                "Nxd1", "Nxd1!", "Nxd1!!", "Nxd1?", "Nxd1??", "Nxd1!?", "Nxd1?!",
                "Nxd1+", "Nxd1+!", "Nxd1+!!", "Nxd1+?", "Nxd1+??", "Nxd1+!?", "Nxd1+?!",
                "Nxd1#",
                "Naxd1", "Naxd1!", "Naxd1!!", "Naxd1?", "Naxd1??", "Naxd1!?", "Naxd1?!",
                "Naxd1+", "Naxd1+!", "Naxd1+!!", "Naxd1+?", "Naxd1+??", "Naxd1+!?", "Naxd1+?!",
                "Naxd1#"
            };

            ActAndAssert(WhoMoved.Knight, expected);
        }

        [Test]
        public void Bishop_moves()
        {
            // Arrange
            var expected = new List<string>
            {
                "Bd1", "Bd1!", "Bd1!!", "Bd1?", "Bd1??", "Bd1!?", "Bd1?!",
                "Bd1+", "Bd1+!", "Bd1+!!", "Bd1+?", "Bd1+??", "Bd1+!?", "Bd1+?!",
                "Bd1#",
                "Bad1", "Bad1!", "Bad1!!", "Bad1?", "Bad1??", "Bad1!?", "Bad1?!",
                "Bad1+", "Bad1+!", "Bad1+!!", "Bad1+?", "Bad1+??", "Bad1+!?", "Bad1+?!",
                "Bad1#",
                "Bxd1", "Bxd1!", "Bxd1!!", "Bxd1?", "Bxd1??", "Bxd1!?", "Bxd1?!",
                "Bxd1+", "Bxd1+!", "Bxd1+!!", "Bxd1+?", "Bxd1+??", "Bxd1+!?", "Bxd1+?!",
                "Bxd1#",
                "Baxd1", "Baxd1!", "Baxd1!!", "Baxd1?", "Baxd1??", "Baxd1!?", "Baxd1?!",
                "Baxd1+", "Baxd1+!", "Baxd1+!!", "Baxd1+?", "Baxd1+??", "Baxd1+!?", "Baxd1+?!",
                "Baxd1#"
            };

            ActAndAssert(WhoMoved.Bishop, expected);
        }

        [Test]
        public void Queen_moves()
        {
            // Arrange
            var expected = new List<string>
            {
                "Qd1", "Qd1!", "Qd1!!", "Qd1?", "Qd1??", "Qd1!?", "Qd1?!",
                "Qd1+", "Qd1+!", "Qd1+!!", "Qd1+?", "Qd1+??", "Qd1+!?", "Qd1+?!",
                "Qd1#",
                "Qad1", "Qad1!", "Qad1!!", "Qad1?", "Qad1??", "Qad1!?", "Qad1?!",
                "Qad1+", "Qad1+!", "Qad1+!!", "Qad1+?", "Qad1+??", "Qad1+!?", "Qad1+?!",
                "Qad1#",
                "Qxd1", "Qxd1!", "Qxd1!!", "Qxd1?", "Qxd1??", "Qxd1!?", "Qxd1?!",
                "Qxd1+", "Qxd1+!", "Qxd1+!!", "Qxd1+?", "Qxd1+??", "Qxd1+!?", "Qxd1+?!",
                "Qxd1#",
                "Qaxd1", "Qaxd1!", "Qaxd1!!", "Qaxd1?", "Qaxd1??", "Qaxd1!?", "Qaxd1?!",
                "Qaxd1+", "Qaxd1+!", "Qaxd1+!!", "Qaxd1+?", "Qaxd1+??", "Qaxd1+!?", "Qaxd1+?!",
                "Qaxd1#"
            };

            ActAndAssert(WhoMoved.Queen, expected);
        }

        [Test]
        public void King_moves()
        {
            // Arrange
            var expected = new List<string>
            {
                "Kd1", "Kd1!", "Kd1!!", "Kd1?", "Kd1??", "Kd1!?", "Kd1?!",
                "Kd1+", "Kd1+!", "Kd1+!!", "Kd1+?", "Kd1+??", "Kd1+!?", "Kd1+?!",
                "Kd1#",
                "Kxd1", "Kxd1!", "Kxd1!!", "Kxd1?", "Kxd1??", "Kxd1!?", "Kxd1?!",
                "Kxd1+", "Kxd1+!", "Kxd1+!!", "Kxd1+?", "Kxd1+??", "Kxd1+!?", "Kxd1+?!",
                "Kxd1#",
            };

            ActAndAssert(WhoMoved.King, expected);
        }

        [Test]
        public void CastleKingside_moves()
        {
            // Arrange
            var expected = new List<string>
            {
                "O-O", "O-O!", "O-O!!", "O-O?", "O-O??", "O-O!?", "O-O?!",
                "O-O+", "O-O+!", "O-O+!!", "O-O+?", "O-O+??", "O-O+!?", "O-O+?!",
                "O-O#"
            };

            ActAndAssert(WhoMoved.CastledKingSide, expected);
        }

        [Test]
        public void CastleQueenside_moves()
        {
            // Arrange
            var expected = new List<string>
            {
                "O-O-O", "O-O-O!", "O-O-O!!", "O-O-O?", "O-O-O??", "O-O-O!?", "O-O-O?!",
                "O-O-O+", "O-O-O+!", "O-O-O+!!", "O-O-O+?", "O-O-O+??", "O-O-O+!?", "O-O-O+?!",
                "O-O-O#"
            };

            ActAndAssert(WhoMoved.CastledQueenSide, expected);
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
