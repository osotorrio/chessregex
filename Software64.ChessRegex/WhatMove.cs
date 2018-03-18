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
        /// It matches the following type of moves: Rd1, Rd1!, Rd1!!, Rd1?, Rd1??, Rd1!?, Rd1?!
        /// </summary>
        public static string Piece => @"^([RNBQK][a-h][1-8](\s*[\!\?]+)?)$";

        /// <summary>
        /// It matches the following type of moves: Rd1+, Rd1+!, Rd1+!!, Rd1+?, Rd1+??, Rd1+!?, Rd1+?!
        /// </summary>
        public static string PieceCheck => @"^([RNBQK][a-h][1-8]\s*\+(\s*[\!\?]+)?)$";

        /// <summary>
        /// It matches the following type of moves: Rd1#
        /// </summary>
        public static string PieceCheckmate => @"^([RNBQK][a-h][1-8]\s*\#)$";

        /// <summary>
        /// It matches the following type of moves: Rad1, Rad1!, Rad1!!, Rad1?, Rad1??, Rad1!?, Rad1?!
        /// </summary>
        public static string PieceFrom => @"^([RNBQK][a-h][a-h][1-8](\s*[\!\?]+)?)$";

        /// <summary>
        /// It matches the following type of moves: Rad1+, Rad1+!, Rad1+!!, Rad1+?, Rad1+??, Rad1+!?, Rad1+?!
        /// </summary>
        public static string PieceFromCheck => @"^([RNBQK][a-h][a-h][1-8]\s*\+(\s*[\!\?]+)?)$";

        /// <summary>
        /// It matches the following type of moves: Rad1#
        /// </summary>
        public static string PieceFromCheckmate => @"^([RNBQK][a-h][a-h][1-8]\s*\#)$";

        /// <summary>
        /// It matches the following type of moves: Rxd1, Rxd1!, Rxd1!!, Rxd1?, Rxd1??, Rxd1!?, Rxd1?!
        /// </summary>
        public static string PieceCaptures => @"^([RNBQK]x[a-h][1-8](\s*[\!\?]+)?)$";

        /// <summary>
        /// It matches the following type of moves: Rxd1+, Rxd1+!, Rxd1+!!, Rxd1+?, Rxd1+??, Rxd1+!?, Rxd1+?!
        /// </summary>
        public static string PieceCapturesCheck => @"^([RNBQK]x[a-h][1-8]\s*\+(\s*[\!\?]+)?)$";

        /// <summary>
        /// It matches the following type of moves: Rxd1#
        /// </summary>
        public static string PieceCapturesCheckmate => @"^([RNBQK]x[a-h][1-8]\s*\#)$";

        /// <summary>
        /// It matches the following type of moves: Raxd1, Raxd1!, Raxd1!!, Raxd1?, Raxd1??, Raxd1!?, Raxd1?!
        /// </summary>
        public static string PieceFromCaptures => @"^([RNBQK][a-h]x[a-h][1-8](\s*[\!\?]+)?)$";

        /// <summary>
        /// It matches the following type of moves: Raxd1+, Raxd1+!, Raxd1+!!, Raxd1+?, Raxd1+??, Raxd1+!?, Raxd1+?!
        /// </summary>
        public static string PieceFromCapturesCheck => @"^([RNBQK][a-h]x[a-h][1-8]\s*\+(\s*[\!\?]+)?)$";

        /// <summary>
        /// It matches the following type of moves: Raxd1#
        /// </summary>
        public static string PieceFromCapturesCheckmate => @"^([RNBQK][a-h]x[a-h][1-8]\s*\#)$";

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
