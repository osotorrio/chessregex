# What ChessRegex does?
ChessRegex is a collection of regular expressions to match all kind of chess moves given as algebraic notation.

# How can you install Chessmen?
You can install it from Nuget.org: [https://www.nuget.org/packages/Software64.ChessRegex/](https://www.nuget.org/packages/Software64.ChessRegex/)

Alternatively, you could pull the repository and add the two projects (Software64.ChessRegex and Software.ChessRegex.UnitTest) to your own solution.

# How can you use Chessmen?

```c#
using Software64.Chessmen;
using Software64.Chessmen.Contracts;
using Software64.Chessmen.Enums;

string currentSquare = "d4";
string targetSquare = "d1";

ChessmenBase rook = new Rook(Color.White, currentSquare);

bool canMove = rook.CanMoveTo(targetSquare);

if (canMove)
{
  rook.MoveTo(targetSquare);
}

IEnumerable<string> pseudoMoves = rook.GetPseudoMoves();

// pseudoMoves = [a1, b1, c1, d2, d3, d4, d5, d6, d7, d8, e1, f1, g1, h1]
```
All Chessmen objects (Rook, Queen, Bishop, etc) internally use [Square](https://github.com/osotorrio/chessmen/blob/master/Software64.Chessmen/Square.cs) which validates if the string (currentSquare) passed is valid. 

There is a third namespace **Software64.Chessmen.Enums** where you can find:
* [ColorEnum](https://github.com/osotorrio/chessmen/blob/master/Software64.Chessmen/Enums/ColorEnum.cs)
* [ColumnEnum](https://github.com/osotorrio/chessmen/blob/master/Software64.Chessmen/Enums/ColumnEnum.cs)
* [RowEnum](https://github.com/osotorrio/chessmen/blob/master/Software64.Chessmen/Enums/RowEnum.cs)

# Specifications
It targets .NET Framework 4.6.1

