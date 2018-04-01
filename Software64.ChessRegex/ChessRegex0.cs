namespace Software64.ChessRegex
{
    /// <summary>
    /// It contains regular expressions which match piece's moves on Level 0.
    /// </summary>
    public static class ChessRegex0
    {
        /// <summary>
        /// It matches all king of chess moves
        /// </summary>
        public static string AllMoves => @"((?:[NBRQK]?[a-h]?[1-8]?x?[a-h][1-8](?:\=[RNBQ])?|O(-?O){1,2})[\+#]?([\!\?]{1,2})?)";
    }
}
