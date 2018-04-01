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
        public static string PawnMoves => @"^([a-h][1-8]([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: "e4+", "e4+!", "e4+!!", "e4+?", "e4+??", "e4+!?", "e4+?!"
        /// </summary>
        public static string PawnMovesCheck => @"^([a-h][1-8](\+)([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: "e4++", "e4#"
        /// </summary>
        public static string PawnMovesCheckmate => @"^([a-h][1-8](\+{2}|#))$";

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
        /// It matches the following type of moves: "Nd5", "Nd5!", "Nd5!!", "Nd5?", "Nd5??", "Nd5!?", "Nd5?!"
        /// </summary>
        public static string KnightMoves => @"^(N[a-h][1-8]([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: "Nd5+", "Nd5+!", "Nd5+!!", "Nd5+?", "Nd5+??", "Nd5+!?", "Nd5+?!"
        /// </summary>
        public static string KnightMovesCheck => @"^(N[a-h][1-8](\+)([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: "Nd5++", "Nd5#"
        /// </summary>
        public static string KnightMovesCheckmate => @"^(N[a-h][1-8](\+{2}|#))$";

        /// <summary>
        /// It matches the following type of moves: "Ncd5", "Ncd5!", "Ncd5!!", "Ncd5?", "Ncd5??", "Ncd5!?", "Ncd5?!"
        /// </summary>
        public static string KnightMovesFromFile => @"^(N[a-h][a-h][1-8]([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: "Ncd5+", "Ncd5+!", "Ncd5+!!", "Ncd5+?", "Ncd5+??", "Ncd5+!?", "Ncd5+?!"
        /// </summary>
        public static string KnightMovesFromFileCheck => @"^(N[a-h][a-h][1-8](\+)([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: "Ncd5++", "Ncd5#"
        /// </summary>
        public static string KnightMovesFromFileCheckmate => @"^(N[a-h][a-h][1-8](\+{2}|#))$";

        /// <summary>
        /// It matches the following type of moves: "N7d5", "N7d5!", "N7d5!!", "N7d5?", "N7d5??", "N7d5!?", "N7d5?!"
        /// </summary>
        public static string KnightMovesFromRank => @"^(N[1-8][a-h][1-8]([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: "N7d5+", "N7d5+!", "N7d5+!!", "N7d5+?", "N7d5+??", "N7d5+!?", "N7d5+?!"
        /// </summary>
        public static string KnightMovesFromRankCheck => @"^(N[1-8][a-h][1-8](\+)([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: "N7d5++", "N7d5#"
        /// </summary>
        public static string KnightMovesFromRankCheckmate => @"^(N[1-8][a-h][1-8](\+{2}|#))$";

        /// <summary>
        /// It matches the following type of moves: "Nc7d5", "Nc7d5!", "Nc7d5!!", "Nc7d5?", "Nc7d5??", "Nc7d5!?", "Nc7d5?!"
        /// </summary>
        public static string KnightMovesFromSquare => @"^(N[a-h][1-8][a-h][1-8]([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: "Nc7d5+", "Nc7d5+!", "Nc7d5+!!", "Nc7d5+?", "Nc7d5+??", "Nc7d5+!?", "Nc7d5+?!"
        /// </summary>
        public static string KnightMovesFromSquareCheck => @"^(N[a-h][1-8][a-h][1-8](\+)([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: "Nc7d5++", "Nc7d5#"
        /// </summary>
        public static string KnightMovesFromSquareCheckmate => @"^(N[a-h][1-8][a-h][1-8](\+{2}|#))$";
















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
