namespace Software64.ChessRegex
{
    /// <summary>
    /// It contains regular expressions which match specific type of moves
    /// </summary>
    public static class WhatMove
    {
        /// <summary>
        /// It matches the following type of moves: e4, e4!, e4!!, e4?, e4??, e4!?, e4?!
        /// </summary>
        public static string Pawn => @"^([a-h][1-8](\s*[\!\?]+)?)$";

        /// <summary>
        /// It matches the following type of moves: e4+, e4+!, e4+!!, e4+?, e4+??, e4+!?, e4+?!
        /// </summary>
        public static string PawnCheck => @"^([a-h][1-8]\s*\+(\s*[\!\?]+)?)$";

        /// <summary>
        /// It matches the following type of moves: e4#
        /// </summary>
        public static string PawnCheckmate => @"^([a-h][1-8]\s*\#)$";

        /// <summary>
        /// It matches the following type of moves: e8=Q, e8=Q!, e8=Q!!, e8=Q?, e8=Q??, e8=Q!?, e8=Q?!
        /// </summary>
        public static string PawnPromotes => @"^([a-h][1-8]\=[RNBQK](\s*[\!\?]+)?)$";

        /// <summary>
        /// It matches the following type of moves: e8=Q+, e8=Q+!, e8=Q+!!, e8=Q+?, e8=Q+??, e8=Q+!?, e8=Q+?!
        /// </summary>
        public static string PawnPromotesCheck => @"^([a-h][1-8]\=[RNBQK]\s*\+(\s*[\!\?]+)?)$";

        /// <summary>
        /// It matches the following type of moves: e8=Q#
        /// </summary>
        public static string PawnPromotesCheckmate => @"^([a-h][1-8]\=[RNBQK]\s*\#)$";

        /// <summary>
        /// It matches the following type of moves: dxe4, dxe4!, dxe4!!, dxe4?, dxe4??, dxe4!?, dxe4?!
        /// </summary>
        public static string PawnCaptures => @"^([a-h]x[a-h][1-8](\s*[\!\?]+)?)$";

        /// <summary>
        /// It matches the following type of moves: dxe4+, dxe4+!, dxe4+!!, dxe4+?, dxe4+??, dxe4+!?, dxe4+?!
        /// </summary>
        public static string PawnCapturesCheck => @"^([a-h]x[a-h][1-8]\s*\+(\s*[\!\?]+)?)$";

        /// <summary>
        /// It matches the following type of moves: dxe4#
        /// </summary>
        public static string PawnCapturesCheckmate => @"^([a-h]x[a-h][1-8]\s*\#)$";

        /// <summary>
        /// It matches the following type of moves: dxe8=Q, dxe8=Q!, dxe8=Q!!, dxe8=Q?, dxe8=Q??, dxe8=Q!?, dxe8=Q?!
        /// </summary>
        public static string PawnCapturesPromotes => @"^([a-h]x[a-h][1-8]\=[RNBQK](\s*[\!\?]+)?)$";

        /// <summary>
        /// It matches the following type of moves: dxe8=Q+, dxe8=Q+!, dxe8=Q+!!, dxe8=Q+?, dxe8=Q+??, dxe8=Q+!?, dxe8=Q+?!
        /// </summary>
        public static string PawnCapturesPromotesCheck => @"^([a-h]x[a-h][1-8]\=[RNBQK]\s*\+(\s*[\!\?]+)?)$";

        /// <summary>
        /// It matches the following type of moves: dxe8=Q#
        /// </summary>
        public static string PawnCapturesPromotesCheckmate => @"^([a-h]x[a-h][1-8]\=[RNBQK]\s*\#)$";

        /// <summary>
        /// It matches the following type of moves: Nd5, Nd5!, Nd5!!, Nd5?, Nd5??, Nd5!?, Nd5?!
        /// </summary>
        public static string Piece => @"^([RNBQK][a-h][1-8](\s*[\!\?]+)?)$";

        /// <summary>
        /// It matches the following type of moves: Nd5+, Nd5+!, Nd5+!!, Nd5+?, Nd5+??, Nd5+!?, Nd5+?!
        /// </summary>
        public static string PieceCheck => @"^([RNBQK][a-h][1-8]\s*\+(\s*[\!\?]+)?)$";

        /// <summary>
        /// It matches the following type of moves: Nd5#
        /// </summary>
        public static string PieceCheckmate => @"^([RNBQK][a-h][1-8]\s*\#)$";

        /// <summary>
        /// It matches the following type of moves: Ncd5, Ncd5!, Ncd5!!, Ncd5?, Ncd5??, Ncd5!?, Ncd5?!
        /// </summary>
        public static string PieceFromColumn => @"^([RNBQK][a-h][a-h][1-8](\s*[\!\?]+)?)$";

        /// <summary>
        /// It matches the following type of moves: Ncd5+, Ncd5+!, Ncd5+!!, Ncd5+?, Ncd5+??, Ncd5+!?, Ncd5+?!
        /// </summary>
        public static string PieceFromColumnCheck => @"^([RNBQK][a-h][a-h][1-8]\s*\+(\s*[\!\?]+)?)$";

        /// <summary>
        /// It matches the following type of moves: Ncd5#
        /// </summary>
        public static string PieceFromColumnCheckmate => @"^([RNBQK][a-h][a-h][1-8]\s*\#)$";

        /// <summary>
        /// It matches the following type of moves: N7d5, N7d5!, N7d5!!, N7d5?, N7d5??, N7d5!?, N7d5?!
        /// </summary>
        public static string PieceFromRow => @"^([RNBQK][1-8][a-h][1-8](\s*[\!\?]+)?)$";

        /// <summary>
        /// It matches the following type of moves: N7d5+, N7d5+!, N7d5+!!, N7d5+?, N7d5+??, N7d5+!?, N7d5+?!
        /// </summary>
        public static string PieceFromRowCheck => @"^([RNBQK][1-8][a-h][1-8]\s*\+(\s*[\!\?]+)?)$";

        /// <summary>
        /// It matches the following type of moves: N7d5#
        /// </summary>
        public static string PieceFromRowCheckmate => @"^([RNBQK][1-8][a-h][1-8]\s*\#)$";

        /// <summary>
        /// It matches the following type of moves: Nc7d5, Nc7d5!, Nc7d5!!, Nc7d5?, Nc7d5??, Nc7d5!?, Nc7d5?!
        /// </summary>
        public static string PieceFromSquare => @"^([RNBQK][a-h][1-8][a-h][1-8](\s*[\!\?]+)?)$";

        /// <summary>
        /// It matches the following type of moves: Nc7d5+, Nc7d5+!, Nc7d5+!!, Nc7d5+?, Nc7d5+??, Nc7d5+!?, Nc7d5+?!
        /// </summary>
        public static string PieceFromSquareCheck => @"^([RNBQK][a-h][1-8][a-h][1-8]\s*\+(\s*[\!\?]+)?)$";

        /// <summary>
        /// It matches the following type of moves: Nc7d5#
        /// </summary>
        public static string PieceFromSquareCheckmate => @"^([RNBQK][a-h][1-8][a-h][1-8]\s*\#)$";

        /// <summary>
        /// It matches the following type of moves: Nxd5, Nxd5!, Nxd5!!, Nxd5?, Nxd5??, Nxd5!?, Nxd5?!
        /// </summary>
        public static string PieceCaptures => @"^([RNBQK]x[a-h][1-8](\s*[\!\?]+)?)$";

        /// <summary>
        /// It matches the following type of moves: Nxd5+, Nxd5+!, Nxd5+!!, Nxd5+?, Nxd5+??, Nxd5+!?, Nxd5+?!
        /// </summary>
        public static string PieceCapturesCheck => @"^([RNBQK]x[a-h][1-8]\s*\+(\s*[\!\?]+)?)$";

        /// <summary>
        /// It matches the following type of moves: Nxd5#
        /// </summary>
        public static string PieceCapturesCheckmate => @"^([RNBQK]x[a-h][1-8]\s*\#)$";

        /// <summary>
        /// It matches the following type of moves: Ncxd5, Ncxd5!, Ncxd5!!, Ncxd5?, Ncxd5??, Ncxd5!?, Ncxd5?!
        /// </summary>
        public static string PieceFromColumnCaptures => @"^([RNBQK][a-h]x[a-h][1-8](\s*[\!\?]+)?)$";

        /// <summary>
        /// It matches the following type of moves: Ncxd5+, Ncxd5+!, Ncxd5+!!, Ncxd5+?, Ncxd5+??, Ncxd5+!?, Ncxd5+?!
        /// </summary>
        public static string PieceFromColumnCapturesCheck => @"^([RNBQK][a-h]x[a-h][1-8]\s*\+(\s*[\!\?]+)?)$";

        /// <summary>
        /// It matches the following type of moves: Ncxd5#
        /// </summary>
        public static string PieceFromColumnCapturesCheckmate => @"^([RNBQK][a-h]x[a-h][1-8]\s*\#)$";

        /// <summary>
        /// It matches the following type of moves: N7xd5, N7xd5!, N7xd5!!, N7xd5?, N7xd5??, N7xd5!?, N7xd5?!
        /// </summary>
        public static string PieceFromRowCaptures => @"^([RNBQK][1-8]x[a-h][1-8](\s*[\!\?]+)?)$";

        /// <summary>
        /// It matches the following type of moves: N7xd5+, N7xd5+!, N7xd5+!!, N7xd5+?, N7xd5+??, N7xd5+!?, N7xd5+?!
        /// </summary>
        public static string PieceFromRowCapturesCheck => @"^([RNBQK][1-8]x[a-h][1-8]\s*\+(\s*[\!\?]+)?)$";

        /// <summary>
        /// It matches the following type of moves: N7xd5#
        /// </summary>
        public static string PieceFromRowCapturesCheckmate => @"^([RNBQK][1-8]x[a-h][1-8]\s*\#)$";

        /// <summary>
        /// It matches the following type of moves: Nc7xd5, Nc7xd5!, Nc7xd5!!, Nc7xd5?, Nc7xd5??, Nc7xd5!?, Nc7xd5?!
        /// </summary>
        public static string PieceFromSquareCaptures => @"^([RNBQK][a-h][1-8]x[a-h][1-8](\s*[\!\?]+)?)$";

        /// <summary>
        /// It matches the following type of moves: Nc7xd5+, Nc7xd5+!, Nc7xd5+!!, Nc7xd5+?, Nc7xd5+??, Nc7xd5+!?, Nc7xd5+?!
        /// </summary>
        public static string PieceFromSquareCapturesCheck => @"^([RNBQK][a-h][1-8]x[a-h][1-8]\s*\+(\s*[\!\?]+)?)$";

        /// <summary>
        /// It matches the following type of moves: Nc7xd5#
        /// </summary>
        public static string PieceFromSquareCapturesCheckmate => @"^([RNBQK][a-h][1-8]x[a-h][1-8]\s*\#)$";

        /// <summary>
        /// It matches the following type of moves: O-O, O-O!, O-O!!, O-O?, O-O??, O-O!?, O-O?!
        /// </summary>
        public static string CastledKingside => @"^((O-O|0-0)(\s*[\!\?]+)?)$";

        /// <summary>
        /// It matches the following type of moves: O-O+, O-O+!, O-O+!!, O-O+?, O-O+??, O-O+!?, O-O+?!
        /// </summary>
        public static string CastledKingsideCheck => @"^((O-O|0-0)\s*\+(\s*[\!\?]+)?)$";

        /// <summary>
        /// It matches the following type of moves: O-O#
        /// </summary>
        public static string CastledKingsideCheckmate => @"^((O-O|0-0)\s*\#)$";

        /// <summary>
        /// It matches the following type of moves: O-O-O, O-O-O!, O-O-O!!, O-O-O?, O-O-O??, O-O-O!?, O-O-O?!
        /// </summary>
        public static string CastledQueenside => @"^((O-O-O|0-0-0)(\s*[\!\?]+)?)$";

        /// <summary>
        /// It matches the following type of moves: O-O-O+, O-O-O+!, O-O-O+!!, O-O-O+?, O-O-O+??, O-O-O+!?, O-O-O+?!
        /// </summary>
        public static string CastledQueensideCheck => @"^((O-O-O|0-0-0)\s*\+(\s*[\!\?]+)?)$";

        /// <summary>
        /// It matches the following type of moves: O-O-O#
        /// </summary>
        public static string CastledQueensideCheckmate => @"^((O-O-O|0-0-0)\s*\#)$";
    }
}
