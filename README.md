# What ChessRegex does?
ChessRegex is a collection of regular expressions to match all kind of chess moves given as algebraic notation.

# How can you install Chessmen?
You can install it from Nuget.org: [https://www.nuget.org/packages/Software64.ChessRegex/](https://www.nuget.org/packages/Software64.ChessRegex/)

Alternatively, you could pull the repository and add the two projects (Software64.ChessRegex and Software.ChessRegex.UnitTest) to your own solution.

# How to match which pieces has been moved?

```c#
using Software64.ChessRegex;

string move = "Nd5+!";

if (Regex.IsMatch(move, WhoMoved.Knight))
{
    // Do something when a Knight has been moved
}
```

**WhoMoved.Knight** will match all the following moves:

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
"Nc7xd5#"

# How to match what kind of move?

```c#
using Software64.ChessRegex;

string move = "N7xd5?";

if (Regex.IsMatch(move, WhatMove.PieceFromRowCaptures))
{
    // Do something when two pieces can move to the same square and the row is used to identify which one.
}
```

**WhatMove.PieceFromRowCaptures** will match all the following moves:

N7xd5, N7xd5!, N7xd5!!, N7xd5?, N7xd5??, N7xd5!?, N7xd5?!


# Specifications
It targets .NET Framework 4.6.1

