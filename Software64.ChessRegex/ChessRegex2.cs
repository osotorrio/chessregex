namespace Software64.ChessRegex
{
    /// <summary>
    /// It contains regular expressions which match pieces moves Level 2
    /// </summary>
    public static class ChessRegex2
    {
        /// <summary>
        /// It matches the following type of moves: 
        /// "e4", "e4!", "e4!!", "e4?", "e4??", "e4!?", "e4?!",
        /// "e4+", "e4+!", "e4+!!", "e4+?", "e4+??", "e4+!?", "e4+?!",
        /// "e4++", "e4#"
        /// </summary>
        public static string PawnStandard => @"^([a-h][1-8](\+|\++|\#)?([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: 
        /// "e8=Q", "e8=Q!", "e8=Q!!", "e8=Q?", "e8=Q??", "e8=Q!?", "e8=Q?!",
        /// "e8=Q+", "e8=Q+!", "e8=Q+!!", "e8=Q+?", "e8=Q+??", "e8=Q+!?", "e8=Q+?!",
        /// "e8=Q++", "e8=Q#"
        /// </summary>
        public static string PawnPromotes => @"^([a-h][1-8]=[RNBQ](\+|\++|\#)?([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: 
        /// "dxe4", "dxe4!", "dxe4!!", "dxe4?", "dxe4??", "dxe4!?", "dxe4?!",
        /// "dxe4+", "dxe4+!", "dxe4+!!", "dxe4+?", "dxe4+??", "dxe4+!?", "dxe4+?!",
        /// "dxe4++", "dxe4#"
        /// </summary>
        public static string PawnCaptures => @"^([a-h]x[a-h][1-8](\+|\++|\#)?([\!\?]{1,2})?)$";

        /// <summary>
        /// "dxe8=Q", "dxe8=Q!", "dxe8=Q!!", "dxe8=Q?", "dxe8=Q??", "dxe8=Q!?", "dxe8=Q?!",
        /// "dxe8=Q+", "dxe8=Q+!", "dxe8=Q+!!", "dxe8=Q+?", "dxe8=Q+??", "dxe8=Q+!?", "dxe8=Q+?!",
        /// "dxe8=Q++", "dxe8=Q#"
        /// </summary>
        public static string PawnCapturesPromotes => @"^([a-h]x[a-h][1-8]=[RNBQ](\+|\++|\#)?([\!\?]{1,2})?)$";
    }
}
