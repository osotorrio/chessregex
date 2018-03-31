namespace Software64.ChessRegex
{
    /// <summary>
    /// It contains regular expressions which match pieces moves
    /// </summary>
    public static class ChessRegex1
    {
        /// <summary>
        /// It matches when a Pawn is moved
        /// </summary>
        public static string Pawn => @"^([a-h]?x?[a-h][1-8](\=[RNBQK])?(\s*[\+\#])?(\s*[\!\?]{1,2})?)$";

        /// <summary>
        /// It matches when a Rook is moved
        /// </summary>
        public static string Rook => @"^(R([a-h]|[1-8])?x?[a-h][1-8](\s*[\+\#])?(\s*[\!\?]{1,2})?)$";

        /// <summary>
        /// It matches when a Knight is moved
        /// </summary>
        public static string Knight => @"^(N[a-h]?[1-8]?x?[a-h][1-8](\s*[\+\#])?(\s*[\!\?]{1,2})?)$";

        /// <summary>
        /// It matches when a Bishop is moved
        /// </summary>
        public static string Bishop => @"^(B[a-h]?[1-8]?x?[a-h][1-8](\s*[\+\#])?(\s*[\!\?]{1,2})?)$";

        /// <summary>
        /// It matches when a Queen
        /// </summary>
        public static string Queen => @"^(Q[a-h]?[1-8]?x?[a-h][1-8](\s*[\+\#])?(\s*[\!\?]{1,2})?)$";

        /// <summary>
        /// It matches when a King
        /// </summary>
        public static string King => @"^(K(x)?[a-h][1-8](\s*[\+\#])?(\s*[\!\?]{1,2})?)$";

        /// <summary>
        /// It matches when a King side castled is moved
        /// </summary>
        public static string CastledKingSide => @"^((O-O|0-0)(\s*[\+\#])?(\s*[\!\?]{1,2})?)$";

        /// <summary>
        /// It matches when a Queen side castled is move
        /// </summary>
        public static string CastledQueenSide => @"^((O-O-O|0-0-0)(\s*[\+\#])?(\s*[\!\?]{1,2})?)$";
    }
}
