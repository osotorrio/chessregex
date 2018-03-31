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
        /// "R5d1++", "R5d1#"
        /// </summary>
        public static string RookMovesFromRank => @"^(R[1-8][a-h][1-8](\+|\++|\#)?([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: 
        /// "Rxd1", "Rxd1!", "Rxd1!!", "Rxd1?", "Rxd1??", "Rxd1!?", "Rxd1?!",
        /// "Rxd1+", "Rxd1+!", "Rxd1+!!", "Rxd1+?", "Rxd1+??", "Rxd1+!?", "Rxd1+?!",
        /// "Rxd1++", "Rxd1#"
        /// </summary>
        public static string RookCaptures => @"^(Rx[a-h][1-8](\+|\++|\#)?([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: 
        /// "Raxd1", "Raxd1!", "Raxd1!!", "Raxd1?", "Raxd1??", "Raxd1!?", "Raxd1?!",
        /// "Raxd1+", "Raxd1+!", "Raxd1+!!", "Raxd1+?", "Raxd1+??", "Raxd1+!?", "Raxd1+?!",
        /// "Raxd1++", "Raxd1#"
        /// </summary>
        public static string RookCapturesFromFile => @"^(R[a-h]x[a-h][1-8](\+|\++|\#)?([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: 
        /// "Raxd1", "Raxd1!", "Raxd1!!", "Raxd1?", "Raxd1??", "Raxd1!?", "Raxd1?!",
        /// "Raxd1+", "Raxd1+!", "Raxd1+!!", "Raxd1+?", "Raxd1+??", "Raxd1+!?", "Raxd1+?!",
        /// "Raxd1++", "Raxd1#"
        /// </summary>
        public static string RookCapturesFromRank => @"^(R[1-8]x[a-h][1-8](\+|\++|\#)?([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: 
        /// "Nd5", "Nd5!", "Nd5!!", "Nd5?", "Nd5??", "Nd5!?", "Nd5?!",
        /// "Nd5+", "Nd5+!", "Nd5+!!", "Nd5+?", "Nd5+??", "Nd5+!?", "Nd5+?!",
        /// "Nd5++", "Nd5#"
        /// </summary>
        public static string KnightMoves => @"^(N[a-h][1-8](\+|\++|\#)?([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: 
        /// "Ncd5", "Ncd5!", "Ncd5!!", "Ncd5?", "Ncd5??", "Ncd5!?", "Ncd5?!",
        /// "Ncd5+", "Ncd5+!", "Ncd5+!!", "Ncd5+?", "Ncd5+??", "Ncd5+!?", "Ncd5+?!",
        /// "Ncd5++", "Ncd5#"
        /// </summary>
        public static string KnightMovesFromFile => @"^(N[a-h][a-h][1-8](\+|\++|\#)?([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: 
        /// "N7d5", "N7d5!", "N7d5!!", "N7d5?", "N7d5??", "N7d5!?", "N7d5?!",
        /// "N7d5+", "N7d5+!", "N7d5+!!", "N7d5+?", "N7d5+??", "N7d5+!?", "N7d5+?!",
        /// "N7d5++", "N7d5#"
        /// </summary>
        public static string KnightMovesFromRank => @"^(N[1-8][a-h][1-8](\+|\++|\#)?([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: 
        /// "Nc7d5", "Nc7d5!", "Nc7d5!!", "Nc7d5?", "Nc7d5??", "Nc7d5!?", "Nc7d5?!",
        /// "Nc7d5+", "Nc7d5+!", "Nc7d5+!!", "Nc7d5+?", "Nc7d5+??", "Nc7d5+!?", "Nc7d5+?!",
        /// "Nc7d5++", "Nc7d5#"
        /// </summary>
        public static string KnightMovesFromSquare => @"^(N[a-h][1-8][a-h][1-8](\+|\++|\#)?([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: 
        /// "Nxd5", "Nxd5!", "Nxd5!!", "Nxd5?", "Nxd5??", "Nxd5!?", "Nxd5?!",
        /// "Nxd5+", "Nxd5+!", "Nxd5+!!", "Nxd5+?", "Nxd5+??", "Nxd5+!?", "Nxd5+?!",
        /// "Nxd5++", "Nxd5#"
        /// </summary>
        public static string KnightCaptures => @"^(Nx[a-h][1-8](\+|\++|\#)?([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: 
        /// "Ncxd5", "Ncxd5!", "Ncxd5!!", "Ncxd5?", "Ncxd5??", "Ncxd5!?", "Ncxd5?!",
        /// "Ncxd5+", "Ncxd5+!", "Ncxd5+!!", "Ncxd5+?", "Ncxd5+??", "Ncxd5+!?", "Ncxd5+?!",
        /// "Ncxd5++", "Ncxd5#"
        /// </summary>
        public static string KnightCapturesFromFile => @"^(N[a-h]x[a-h][1-8](\+|\++|\#)?([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: 
        /// "N7xd5", "N7xd5!", "N7xd5!!", "N7xd5?", "N7xd5??", "N7xd5!?", "N7xd5?!",
        /// "N7xd5+", "N7xd5+!", "N7xd5+!!", "N7xd5+?", "N7xd5+??", "N7xd5+!?", "N7xd5+?!",
        /// "N7xd5++", "N7xd5#"
        /// </summary>
        public static string KnightCapturesFromRank => @"^(N[1-8]x[a-h][1-8](\+|\++|\#)?([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: 
        /// "Nc7xd5", "Nc7xd5!", "Nc7xd5!!", "Nc7xd5?", "Nc7xd5??", "Nc7xd5!?", "Nc7xd5?!",
        /// "Nc7xd5+", "Nc7xd5+!", "Nc7xd5+!!", "Nc7xd5+?", "Nc7xd5+??", "Nc7xd5+!?", "Nc7xd5+?!",
        /// "Nc7xd5++", "Nc7xd5#"
        /// </summary>
        public static string KnightCapturesFromSquare => @"^(N[a-h][1-8]x[a-h][1-8](\+|\++|\#)?([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: 
        /// "Be4", "Be4!", "Be4!!", "Be4?", "Be4??", "Be4!?", "Be4?!",
        /// "Be4+", "Be4+!", "Be4+!!", "Be4+?", "Be4+??", "Be4+!?", "Be4+?!",
        /// "Be4++", "Be4#"
        /// </summary>
        public static string BishopMoves => @"^(B[a-h][1-8](\+|\++|\#)?([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: 
        /// "Bhe4", "Bhe4!", "Bhe4!!", "Bhe4?", "Bhe4??", "Bhe4!?", "Bhe4?!",
        /// "Bhe4+", "Bhe4+!", "Bhe4+!!", "Bhe4+?", "Bhe4+??", "Bhe4+!?", "Bhe4+?!",
        /// "Bhe4++", "Bhe4#"
        /// </summary>
        public static string BishopMovesFromFile => @"^(B[a-h][a-h][1-8](\+|\++|\#)?([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: 
        /// "B7e4", "B7e4!", "B7e4!!", "B7e4?", "B7e4??", "B7e4!?", "B7e4?!",
        /// "B7e4+", "B7e4+!", "B7e4+!!", "B7e4+?", "B7e4+??", "B7e4+!?", "B7e4+?!",
        /// "B7e4++", "B7e4#"
        /// </summary>
        public static string BishopMovesFromRank => @"^(B[1-8][a-h][1-8](\+|\++|\#)?([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: 
        /// "Bh7e4", "Bh7e4!", "Bh7e4!!", "Bh7e4?", "Bh7e4??", "Bh7e4!?", "Bh7e4?!",
        /// "Bh7e4+", "Bh7e4+!", "Bh7e4+!!", "Bh7e4+?", "Bh7e4+??", "Bh7e4+!?", "Bh7e4+?!",
        /// "Bh7e4++", "Bh7e4#"
        /// </summary>
        public static string BishopMovesFromSquare => @"^(B[a-h][1-8][a-h][1-8](\+|\++|\#)?([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: 
        /// "Bxe4", "Bxe4!", "Bxe4!!", "Bxe4?", "Bxe4??", "Bxe4!?", "Bxe4?!",
        /// "Bxe4+", "Bxe4+!", "Bxe4+!!", "Bxe4+?", "Bxe4+??", "Bxe4+!?", "Bxe4+?!",
        /// "Bxe4++", "Bxe4#"
        /// </summary>
        public static string BishopCaptures => @"^(Bx[a-h][1-8](\+|\++|\#)?([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: 
        /// "Bhxe4", "Bhxe4!", "Bhxe4!!", "Bhxe4?", "Bhxe4??", "Bhxe4!?", "Bhxe4?!",
        /// "Bhxe4+", "Bhxe4+!", "Bhxe4+!!", "Bhxe4+?", "Bhxe4+??", "Bhxe4+!?", "Bhxe4+?!",
        /// "Bhxe4++", "Bhxe4#"
        /// </summary>
        public static string BishopCapturesFromFile => @"^(B[a-h]x[a-h][1-8](\+|\++|\#)?([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: 
        /// "B7xe4", "B7xe4!", "B7xe4!!", "B7xe4?", "B7xe4??", "B7xe4!?", "B7xe4?!",
        /// "B7xe4+", "B7xe4+!", "B7xe4+!!", "B7xe4+?", "B7xe4+??", "B7xe4+!?", "B7xe4+?!",
        /// "B7xe4++", "B7xe4#"
        /// </summary>
        public static string BishopCapturesFromRank => @"^(B[1-8]x[a-h][1-8](\+|\++|\#)?([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: 
        /// "Bh7xe4", "Bh7xe4!", "Bh7xe4!!", "Bh7xe4?", "Bh7xe4??", "Bh7xe4!?", "Bh7xe4?!",
        /// "Bh7xe4+", "Bh7xe4+!", "Bh7xe4+!!", "Bh7xe4+?", "Bh7xe4+??", "Bh7xe4+!?", "Bh7xe4+?!",
        /// "Bh7xe4++", "Bh7xe4#"
        /// </summary>
        public static string BishopCapturesFromSquare => @"^(B[a-h][1-8]x[a-h][1-8](\+|\++|\#)?([\!\?]{1,2})?)$";
    }
}
