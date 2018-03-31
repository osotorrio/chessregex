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
        public static string PawnMoves => @"^([a-h][1-8](\+|\++|\#)?([\!\?]{1,2})?)$";

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
        /// It matches the following type of moves: 
        /// "dxe8=Q", "dxe8=Q!", "dxe8=Q!!", "dxe8=Q?", "dxe8=Q??", "dxe8=Q!?", "dxe8=Q?!",
        /// "dxe8=Q+", "dxe8=Q+!", "dxe8=Q+!!", "dxe8=Q+?", "dxe8=Q+??", "dxe8=Q+!?", "dxe8=Q+?!",
        /// "dxe8=Q++", "dxe8=Q#"
        /// </summary>
        public static string PawnCapturesPromotes => @"^([a-h]x[a-h][1-8]=[RNBQ](\+|\++|\#)?([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: 
        /// "Rd1", "Rd1!", "Rd1!!", "Rd1?", "Rd1??", "Rd1!?", "Rd1?!",
        /// "Rd1+", "Rd1+!", "Rd1+!!", "Rd1+?", "Rd1+??", "Rd1+!?", "Rd1+?!",
        /// "Rd1++", "Rd1#"
        /// </summary>
        public static string RookMoves => @"^(R[a-h][1-8](\+|\++|\#)?([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: 
        /// "Rad1", "Rad1!", "Rad1!!", "Rad1?", "Rad1??", "Rad1!?", "Rad1?!",
        /// "Rad1+", "Rad1+!", "Rad1+!!", "Rad1+?", "Rad1+??", "Rad1+!?", "Rad1+?!",
        /// "Rad1++", "Rad1#"
        /// </summary>
        public static string RookMovesFromFile => @"^(R[a-h][a-h][1-8](\+|\++|\#)?([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: 
        /// "R5d1", "R5d1!", "R5d1!!", "R5d1?", "R5d1??", "R5d1!?", "R5d1?!",
        /// "R5d1+", "R5d1+!", "R5d1+!!", "R5d1+?", "R5d1+??", "R5d1+!?", "R5d1+?!",
        /// "R5d1++", "R5d1#",
        /// </summary>
        public static string RookMovesFromRank => @"^(R[1-8][a-h][1-8](\+|\++|\#)?([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: 
        /// "Rxd1", "Rxd1!", "Rxd1!!", "Rxd1?", "Rxd1??", "Rxd1!?", "Rxd1?!",
        /// "Rxd1+", "Rxd1+!", "Rxd1+!!", "Rxd1+?", "Rxd1+??", "Rxd1+!?", "Rxd1+?!",
        /// "Rxd1++", "Rxd1#",
        /// </summary>
        public static string RookCaptures => @"^(Rx[a-h][1-8](\+|\++|\#)?([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: 
        /// "Raxd1", "Raxd1!", "Raxd1!!", "Raxd1?", "Raxd1??", "Raxd1!?", "Raxd1?!",
        /// "Raxd1+", "Raxd1+!", "Raxd1+!!", "Raxd1+?", "Raxd1+??", "Raxd1+!?", "Raxd1+?!",
        /// "Raxd1++", "Raxd1#",
        /// </summary>
        public static string RookCapturesFromFile => @"^(R[a-h]x[a-h][1-8](\+|\++|\#)?([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: 
        /// "Raxd1", "Raxd1!", "Raxd1!!", "Raxd1?", "Raxd1??", "Raxd1!?", "Raxd1?!",
        /// "Raxd1+", "Raxd1+!", "Raxd1+!!", "Raxd1+?", "Raxd1+??", "Raxd1+!?", "Raxd1+?!",
        /// "Raxd1++", "Raxd1#",
        /// </summary>
        public static string RookCapturesFromRank => @"^(R[1-8]x[a-h][1-8](\+|\++|\#)?([\!\?]{1,2})?)$";
    }
}
