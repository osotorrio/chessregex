namespace Software64.ChessRegex
{
    /// <summary>
    /// It contains regular expressions which match specific type of moves
    /// </summary>
    public static class ChessRegex3
    {
        /// <summary>
        /// It matches the following type of moves: "e4", "e4!", "e4!!", "e4?", "e4??", "e4!?", "e4?!"
        /// </summary>
        public static string Pawn => @"^([a-h][1-8]([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: "e4+", "e4+!", "e4+!!", "e4+?", "e4+??", "e4+!?", "e4+?!"
        /// </summary>
        public static string PawnCheck => @"^([a-h][1-8](\+)([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: "e4++", "e4#"
        /// </summary>
        public static string PawnCheckmate => @"^([a-h][1-8](\+{2}|#))$";

        /// <summary>
        /// It matches the following type of moves: "e8=Q", "e8=Q!", "e8=Q!!", "e8=Q?", "e8=Q??", "e8=Q!?", "e8=Q?!"
        /// </summary>
        public static string PawnPromotes => @"^([a-h][1-8](\=[RNBQ])([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: "e8=Q+", "e8=Q+!", "e8=Q+!!", "e8=Q+?", "e8=Q+??", "e8=Q+!?", "e8=Q+?!"
        /// </summary>
        public static string PawnPromotesCheck => @"^([a-h][1-8](\=[RNBQ])(\+)([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: "e8=Q++", "e8=Q#"
        /// </summary>
        public static string PawnPromotesCheckmate => @"^([a-h][1-8](\=[RNBQ])(\+{2}|#))$";

        /// <summary>
        /// It matches the following type of moves: "dxe4", "dxe4!", "dxe4!!", "dxe4?", "dxe4??", "dxe4!?", "dxe4?!"
        /// </summary>
        public static string PawnCaptures => @"^([a-h]x[a-h][1-8]([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: "dxe4+", "dxe4+!", "dxe4+!!", "dxe4+?", "dxe4+??", "dxe4+!?", "dxe4+?!",
        /// </summary>
        public static string PawnCapturesCheck => @"^([a-h]x[a-h][1-8](\+)([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: "dxe4++", "dxe4#",
        /// </summary>
        public static string PawnCapturesCheckmate => @"^([a-h]x[a-h][1-8](\+{2}|#))$";

        /// <summary>
        /// It matches the following type of moves: "dxe8=Q", "dxe8=Q!", "dxe8=Q!!", "dxe8=Q?", "dxe8=Q??", "dxe8=Q!?", "dxe8=Q?!"
        /// </summary>
        public static string PawnCapturesPromotes => @"^([a-h]x[a-h][1-8](\=[RNBQ])([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: "dxe8=Q+", "dxe8=Q+!", "dxe8=Q+!!", "dxe8=Q+?", "dxe8=Q+??", "dxe8=Q+!?", "dxe8=Q+?!"
        /// </summary>
        public static string PawnCapturesPromotesCheck => @"^([a-h]x[a-h][1-8](\=[RNBQ])(\+)([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: "dxe8=Q++", "dxe8=Q#"
        /// </summary>
        public static string PawnCapturesPromotesCheckmate => @"^([a-h]x[a-h][1-8](\=[RNBQ])(\+{2}|#))$";

        /// <summary>
        /// It matches the following type of moves:  "O-O", "O-O!", "O-O!!", "O-O?", "O-O??", "O-O!?", "O-O?!"
        /// </summary>
        public static string CastledKingside => @"^((O-O|0-0)([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: "O-O+", "O-O+!", "O-O+!!", "O-O+?", "O-O+??", "O-O+!?", "O-O+?!"
        /// </summary>
        public static string CastledKingsideCheck => @"^((O-O|0-0)(\+)([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: "O-O++", "O-O#"
        /// </summary>
        public static string CastledKingsideCheckmate => @"^((O-O|0-0)(\+{2}|#))$";

        /// <summary>
        /// It matches the following type of moves: "O-O-O", "O-O-O!", "O-O-O!!", "O-O-O?", "O-O-O??", "O-O-O!?", "O-O-O?!"
        /// </summary>
        public static string CastledQueenside => @"^((O-O-O|0-0-0)([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: "O-O-O+", "O-O-O+!", "O-O-O+!!", "O-O-O+?", "O-O-O+??", "O-O-O+!?", "O-O-O+?!"
        /// </summary>
        public static string CastledQueensideCheck => @"^((O-O-O|0-0-0)(\+)([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: "O-O-O++", "O-O-O#"
        /// </summary>
        public static string CastledQueensideCheckmate => @"^((O-O-O|0-0-0)(\+{2}|#))$";
    }
}
