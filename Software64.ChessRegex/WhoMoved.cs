using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software64.ChessRegex
{
    public static class WhoMoved
    {
        public static string Pawn => @"^([a-h]?x?[a-h][1-8](\=[RNBQK])?(\s*[\+\#])?(\s*[\!\?]{1,2})?)$";

        public static string Rock => @"^(R[a-h]?x?[a-h][1-8](\s*[\+\#])?(\s*[\!\?]{1,2})?)$";

        public static string Knight => @"^(N[a-h]?x?[a-h][1-8](\s*[\+\#])?(\s*[\!\?]{1,2})?)$";

        public static string Bishop => @"^(B[a-h]?x?[a-h][1-8](\s*[\+\#])?(\s*[\!\?]{1,2})?)$";

        public static string Queen => @"^(Q[a-h]?x?[a-h][1-8](\s*[\+\#])?(\s*[\!\?]{1,2})?)$";

        public static string King => @"^(K(x)?[a-h][1-8](\s*[\+\#])?(\s*[\!\?]{1,2})?)$";

        public static string CastledKingSide => @"^((O-O|0-0)(\s*[\+\#])?(\s*[\!\?]{1,2})?)$";

        public static string CastledQueenSide => @"^((O-O-O|0-0-0)(\s*[\+\#])?(\s*[\!\?]{1,2})?)$";
    }
}
