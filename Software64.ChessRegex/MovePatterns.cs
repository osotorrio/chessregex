namespace Software64.ChessRegex
{
    public static class MovePatterns
    {
        public static string Pawn => @"^([a-h][1-8](\s*[\!\?]+)?)$";

        public static string PawnCheck => @"^([a-h][1-8]\s*\+(\s*[\!\?]+)?)$";

        public static string PawnCheckmate => @"^([a-h][1-8]\s*\#)$";

        public static string PawnPromotes => @"^([a-h][1-8]\=[RNBQK](\s*[\!\?]+)?)$";

        public static string PawnPromotesCheck => @"^([a-h][1-8]\=[RNBQK]\s*\+(\s*[\!\?]+)?)$";

        public static string PawnPromotesCheckmate => @"^([a-h][1-8]\=[RNBQK]\s*\#)$";

        public static string PawnCaptures => @"^([a-h]x[a-h][1-8](\s*[\!\?]+)?)$";

        public static string PawnCapturesCheck => @"^([a-h]x[a-h][1-8]\s*\+(\s*[\!\?]+)?)$";

        public static string PawnCapturesCheckmate => @"^([a-h]x[a-h][1-8]\s*\#)$";

        public static string PawnCapturesPromotes => @"^([a-h]x[a-h][1-8]\=[RNBQK](\s*[\!\?]+)?)$";

        public static string PawnCapturesPromotesCheck => @"^([a-h]x[a-h][1-8]\=[RNBQK]\s*\+(\s*[\!\?]+)?)$";

        public static string PawnCapturesPromotesCheckmate => @"^([a-h]x[a-h][1-8]\=[RNBQK]\s*\#)$";

        public static string Piece => @"^([RNBQK][a-h][1-8](\s*[\!\?]+)?)$";

        public static string PieceCheck => @"^([RNBQK][a-h][1-8]\s*\+(\s*[\!\?]+)?)$";

        public static string PieceCheckmate => @"^([RNBQK][a-h][1-8]\s*\#)$";

        public static string PieceFrom => @"^([RNBQK][a-h][a-h][1-8](\s*[\!\?]+)?)$";

        public static string PieceFromCheck => @"^([RNBQK][a-h][a-h][1-8]\s*\+(\s*[\!\?]+)?)$";

        public static string PieceFromCheckmate => @"^([RNBQK][a-h][a-h][1-8]\s*\#)$";

        public static string PieceCaptures => @"^([RNBQK]x[a-h][1-8](\s*[\!\?]+)?)$";

        public static string PieceCapturesCheck => @"^([RNBQK]x[a-h][1-8]\s*\+(\s*[\!\?]+)?)$";

        public static string PieceCapturesCheckmate => @"^([RNBQK]x[a-h][1-8]\s*\#)$";

        public static string PieceFromCaptures => @"^([RNBQK][a-h]x[a-h][1-8](\s*[\!\?]+)?)$";

        public static string PieceFromCapturesCheck => @"^([RNBQK][a-h]x[a-h][1-8]\s*\+(\s*[\!\?]+)?)$";

        public static string PieceFromCapturesCheckmate => @"^([RNBQK][a-h]x[a-h][1-8]\s*\#)$";

        public static string CastledKingside => @"^((O-O|0-0)(\s*[\!\?]+)?)$";

        public static string CastledKingsideCheck => @"^((O-O|0-0)\s*\+(\s*[\!\?]+)?)$";

        public static string CastledKingsideCheckmate => @"^((O-O|0-0)\s*\#)$";

        public static string CastledQueenside => @"^((O-O-O|0-0-0)(\s*[\!\?]+)?)$";

        public static string CastledQueensideCheck => @"^((O-O-O|0-0-0)\s*\+(\s*[\!\?]+)?)$";

        public static string CastledQueensideCheckmate => @"^((O-O-O|0-0-0)\s*\#)$";
    }
}
