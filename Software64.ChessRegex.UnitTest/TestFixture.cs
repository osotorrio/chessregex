using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software64.ChessRegex.UnitTest
{
    public static class TestFixture
    {
        public static List<string> MoveExamples { get; } = new List<string>
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
                "Naxd1#",

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
                "Baxd1#",

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
                "Qaxd1#",

                "Kd1", "Kd1!", "Kd1!!", "Kd1?", "Kd1??", "Kd1!?", "Kd1?!",
                "Kd1+", "Kd1+!", "Kd1+!!", "Kd1+?", "Kd1+??", "Kd1+!?", "Kd1+?!",
                "Kd1#",
                "Kxd1", "Kxd1!", "Kxd1!!", "Kxd1?", "Kxd1??", "Kxd1!?", "Kxd1?!",
                "Kxd1+", "Kxd1+!", "Kxd1+!!", "Kxd1+?", "Kxd1+??", "Kxd1+!?", "Kxd1+?!",
                "Kxd1#",

                "O-O", "O-O!", "O-O!!", "O-O?", "O-O??", "O-O!?", "O-O?!",
                "O-O+", "O-O+!", "O-O+!!", "O-O+?", "O-O+??", "O-O+!?", "O-O+?!",
                "O-O#",

                "O-O-O", "O-O-O!", "O-O-O!!", "O-O-O?", "O-O-O??", "O-O-O!?", "O-O-O?!",
                "O-O-O+", "O-O-O+!", "O-O-O+!!", "O-O-O+?", "O-O-O+??", "O-O-O+!?", "O-O-O+?!",
                "O-O-O#"
            }; 
    }
}
