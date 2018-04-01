# What ChessRegex does?
ChessRegex is a collection of regular expressions to match all kind of chess moves given as algebraic notation.

# How can you install Chessmen?
You can install it from Nuget.org: [https://www.nuget.org/packages/Software64.ChessRegex/](https://www.nuget.org/packages/Software64.ChessRegex/)

Alternatively, you could pull the repository and add the two projects (Software64.ChessRegex and Software.ChessRegex.UnitTest) to your own solution.

# How to match which pieces has been moved?

```c#
using Software64.ChessRegex;

string move = "Nd5+!";

if (Regex.IsMatch(move, ChessRegex1.KnightMoves))
{
    // Do something when a Knight has been moved
}
```

# Meet the 4 levels of pattern that ChessRegex contains

ChessRegex has 4 levels of patterns. From 0 to 3, or from generic to more specific.

- Level 0. 
**ChessRegex0.AllMoves** is the only property on this level. It will match all kind of chess moves includring promotion, castling and so on. For instance:

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
        "dxe8=Q++", "dxe8=Q#",

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
        "R5xd1++", "R5xd1#",

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
        "Nc7xd5++", "Nc7xd5#",

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

        "Kd1", "Kd1!", "Kd1!!", "Kd1?", "Kd1??", "Kd1!?", "Kd1?!",
        "Kd1+", "Kd1+!", "Kd1+!!", "Kd1+?", "Kd1+??", "Kd1+!?", "Kd1+?!",
        "Kd1++", "Kd1#",
        "Kxd1", "Kxd1!", "Kxd1!!", "Kxd1?", "Kxd1??", "Kxd1!?", "Kxd1?!",
        "Kxd1+", "Kxd1+!", "Kxd1+!!", "Kxd1+?", "Kxd1+??", "Kxd1+!?", "Kxd1+?!",
        "Kxd1++", "Kxd1#",

        "O-O", "O-O!", "O-O!!", "O-O?", "O-O??", "O-O!?", "O-O?!",
        "O-O+", "O-O+!", "O-O+!!", "O-O+?", "O-O+??", "O-O+!?", "O-O+?!",
        "O-O++", "O-O#",

        "O-O-O", "O-O-O!", "O-O-O!!", "O-O-O?", "O-O-O??", "O-O-O!?", "O-O-O?!",
        "O-O-O+", "O-O-O+!", "O-O-O+!!", "O-O-O+?", "O-O-O+??", "O-O-O+!?", "O-O-O+?!",
        "O-O-O++", "O-O-O#"

- Level 1.
**ChessRegex1.PawnMoves** is 1 of the 7 properties on this level. It will match any kind of moves for Pawns, Rooks, Knights, Bishops, Queens, Kings and both side of castling respectively. For instance:

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

- Level 2.
**ChessRegex2.PawnMoves** is 1 of the 38 properties on this level. It will match only Pawns, Rooks, Knights, Bishops, Queens, Kings and Castle Kingside or Castle Queenside moves respectively. In the case of a pawn, it will not match promotions, neither captures, only simple moves. For instance:

        "e4", "e4!", "e4!!", "e4?", "e4??", "e4!?", "e4?!",
        "e4+", "e4+!", "e4+!!", "e4+?", "e4+??", "e4+!?", "e4+?!",
        "e4++", "e4#"

- Level 3.
**ChessRegex3.PawnMoves** is 1 of the 114 properties on this level. It will match only Pawns, Rooks, Knights, Bishops, Queens, Kings and Castle Kingside or Castle Queenside simple moves respectively. In the case of a pawn, it will not match moves with check, neither checkmate, only simple moves. For instance:

        "e4", "e4!", "e4!!", "e4?", "e4??", "e4!?", "e4?!"


# Specifications
It targets .NET Framework 4.6.1

