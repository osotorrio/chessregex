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
        /// It matches the following type of moves: "Rd1", "Rd1!", "Rd1!!", "Rd1?", "Rd1??", "Rd1!?", "Rd1?!"
        /// </summary>
        public static string RookMoves => @"^(R[a-h][1-8]([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: "Rd1+", "Rd1+!", "Rd1+!!", "Rd1+?", "Rd1+??", "Rd1+!?", "Rd1+?!"
        /// </summary>
        public static string RookMovesCheck => @"^(R[a-h][1-8](\+)([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: "Rd1++", "Rd1#"
        /// </summary>
        public static string RookMovesCheckmate => @"^(R[a-h][1-8](\+{2}|#))$";

        /// <summary>
        /// It matches the following type of moves: "Rad1", "Rad1!", "Rad1!!", "Rad1?", "Rad1??", "Rad1!?", "Rad1?!"
        /// </summary>
        public static string RookMovesFromFile => @"^(R[a-h][a-h][1-8]([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: "Rad1+", "Rad1+!", "Rad1+!!", "Rad1+?", "Rad1+??", "Rad1+!?", "Rad1+?!"
        /// </summary>
        public static string RookMovesFromFileCheck => @"^(R[a-h][a-h][1-8](\+)([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: "Rad1++", "Rad1#"
        /// </summary>
        public static string RookMovesFromFileCheckmate => @"^(R[a-h][a-h][1-8](\+{2}|#))$";

        /// <summary>
        /// It matches the following type of moves: "R5d1", "R5d1!", "R5d1!!", "R5d1?", "R5d1??", "R5d1!?", "R5d1?!"
        /// </summary>
        public static string RookMovesFromRank => @"^(R[1-8][a-h][1-8]([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: "R5d1+", "R5d1+!", "R5d1+!!", "R5d1+?", "R5d1+??", "R5d1+!?", "R5d1+?!"
        /// </summary>
        public static string RookMovesFromRankCheck => @"^(R[1-8][a-h][1-8](\+)([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: "R5d1++", "R5d1#"
        /// </summary>
        public static string RookMovesFromRankCheckmate => @"^(R[1-8][a-h][1-8](\+{2}|#))$";

        /// <summary>
        /// It matches the following type of moves: "Rxd1", "Rxd1!", "Rxd1!!", "Rxd1?", "Rxd1??", "Rxd1!?", "Rxd1?!"
        /// </summary>
        public static string RookCaptures => @"^(Rx[a-h][1-8]([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: "Rxd1+", "Rxd1+!", "Rxd1+!!", "Rxd1+?", "Rxd1+??", "Rxd1+!?", "Rxd1+?!"
        /// </summary>
        public static string RookCapturesCheck => @"^(Rx[a-h][1-8](\+)([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: "Rxd1++", "Rxd1#"
        /// </summary>
        public static string RookCapturesCheckmate => @"^(Rx[a-h][1-8](\+{2}|#))$";

        /// <summary>
        /// It matches the following type of moves: "Raxd1", "Raxd1!", "Raxd1!!", "Raxd1?", "Raxd1??", "Raxd1!?", "Raxd1?!"
        /// </summary>
        public static string RookCapturesFromFile => @"^(R[a-h]x[a-h][1-8]([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: "Raxd1+", "Raxd1+!", "Raxd1+!!", "Raxd1+?", "Raxd1+??", "Raxd1+!?", "Raxd1+?!"
        /// </summary>
        public static string RookCapturesFromFileCheck => @"^(R[a-h]x[a-h][1-8](\+)([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: "Raxd1++", "Raxd1#"
        /// </summary>
        public static string RookCapturesFromFileCheckmate => @"^(R[a-h]x[a-h][1-8](\+{2}|#))$";

        /// <summary>
        /// It matches the following type of moves: "R5xd1", "R5xd1!", "R5xd1!!", "R5xd1?", "R5xd1??", "R5xd1!?", "R5xd1?!"
        /// </summary>
        public static string RookCapturesFromRank => @"^(R[1-8]x[a-h][1-8]([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: "R5xd1+", "R5xd1+!", "R5xd1+!!", "R5xd1+?", "R5xd1+??", "R5xd1+!?", "R5xd1+?!"
        /// </summary>
        public static string RookCapturesFromRankCheck => @"^(R[1-8]x[a-h][1-8](\+)([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: "R5xd1++", "R5xd1#"
        /// </summary>
        public static string RookCapturesFromRankCheckmate => @"^(R[1-8]x[a-h][1-8](\+{2}|#))$";

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
        /// It matches the following type of moves: "Nxd5", "Nxd5!", "Nxd5!!", "Nxd5?", "Nxd5??", "Nxd5!?", "Nxd5?!"
        /// </summary>
        public static string KnightCaptures => @"^(Nx[a-h][1-8]([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: "Nxd5+", "Nxd5+!", "Nxd5+!!", "Nxd5+?", "Nxd5+??", "Nxd5+!?", "Nxd5+?!"
        /// </summary>
        public static string KnightCapturesCheck => @"^(Nx[a-h][1-8](\+)([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: "Nxd5++", "Nxd5#"
        /// </summary>
        public static string KnightCapturesCheckmate => @"^(Nx[a-h][1-8](\+{2}|#))$";

        /// <summary>
        /// It matches the following type of moves: "Ncxd5", "Ncxd5!", "Ncxd5!!", "Ncxd5?", "Ncxd5??", "Ncxd5!?", "Ncxd5?!"
        /// </summary>
        public static string KnightCapturesFromFile => @"^(N[a-h]x[a-h][1-8]([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: "Ncxd5+", "Ncxd5+!", "Ncxd5+!!", "Ncxd5+?", "Ncxd5+??", "Ncxd5+!?", "Ncxd5+?!"
        /// </summary>
        public static string KnightCapturesFromFileCheck => @"^(N[a-h]x[a-h][1-8](\+)([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: "Ncxd5++", "Ncxd5#"
        /// </summary>
        public static string KnightCapturesFromFileCheckmate => @"^(N[a-h]x[a-h][1-8](\+{2}|#))$";

        /// <summary>
        /// It matches the following type of moves: "N7xd5", "N7xd5!", "N7xd5!!", "N7xd5?", "N7xd5??", "N7xd5!?", "N7xd5?!"
        /// </summary>
        public static string KnightCapturesFromRank => @"^(N[1-8]x[a-h][1-8]([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: "N7xd5+", "N7xd5+!", "N7xd5+!!", "N7xd5+?", "N7xd5+??", "N7xd5+!?", "N7xd5+?!"
        /// </summary>
        public static string KnightCapturesFromRankCheck => @"^(N[1-8]x[a-h][1-8](\+)([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: "N7xd5++", "N7xd5#"
        /// </summary>
        public static string KnightCapturesFromRankCheckmate => @"^(N[1-8]x[a-h][1-8](\+{2}|#))$";

        /// <summary>
        /// It matches the following type of moves: "Nc7xd5", "Nc7xd5!", "Nc7xd5!!", "Nc7xd5?", "Nc7xd5??", "Nc7xd5!?", "Nc7xd5?!"
        /// </summary>
        public static string KnightCapturesFromSquare => @"^(N[a-h][1-8]x[a-h][1-8]([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: "Nc7xd5+", "Nc7xd5+!", "Nc7xd5+!!", "Nc7xd5+?", "Nc7xd5+??", "Nc7xd5+!?", "Nc7xd5+?!"
        /// </summary>
        public static string KnightCapturesFromSquareCheck => @"^(N[a-h][1-8]x[a-h][1-8](\+)([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: "Nc7xd5++", "Nc7xd5#"
        /// </summary>
        public static string KnightCapturesFromSquareCheckmate => @"^(N[a-h][1-8]x[a-h][1-8](\+{2}|#))$";

        /// <summary>
        /// It matches the following type of moves: "Be4", "Be4!", "Be4!!", "Be4?", "Be4??", "Be4!?", "Be4?!"
        /// </summary>
        public static string BishopMoves => @"^(B[a-h][1-8]([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: "Be4+", "Be4+!", "Be4+!!", "Be4+?", "Be4+??", "Be4+!?", "Be4+?!"
        /// </summary>
        public static string BishopMovesCheck => @"^(B[a-h][1-8](\+)([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: "Be4++", "Be4#"
        /// </summary>
        public static string BishopMovesCheckmate => @"^(B[a-h][1-8](\+{2}|#))$";

        /// <summary>
        /// It matches the following type of moves: "Bhe4", "Bhe4!", "Bhe4!!", "Bhe4?", "Bhe4??", "Bhe4!?", "Bhe4?!"
        /// </summary>
        public static string BishopMovesFromFile => @"^(B[a-h][a-h][1-8]([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: "Bhe4+", "Bhe4+!", "Bhe4+!!", "Bhe4+?", "Bhe4+??", "Bhe4+!?", "Bhe4+?!"
        /// </summary>
        public static string BishopMovesFromFileCheck => @"^(B[a-h][a-h][1-8](\+)([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: "Bhe4++", "Bhe4#"
        /// </summary>
        public static string BishopMovesFromFileCheckmate => @"^(B[a-h][a-h][1-8](\+{2}|#))$";

        /// <summary>
        /// It matches the following type of moves: "B7e4", "B7e4!", "B7e4!!", "B7e4?", "B7e4??", "B7e4!?", "B7e4?!"
        /// </summary>
        public static string BishopMovesFromRank => @"^(B[1-8][a-h][1-8]([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: "B7e4+", "B7e4+!", "B7e4+!!", "B7e4+?", "B7e4+??", "B7e4+!?", "B7e4+?!"
        /// </summary>
        public static string BishopMovesFromRankCheck => @"^(B[1-8][a-h][1-8](\+)([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: "B7e4++", "B7e4#"
        /// </summary>
        public static string BishopMovesFromRankCheckmate => @"^(B[1-8][a-h][1-8](\+{2}|#))$";

        /// <summary>
        /// It matches the following type of moves: "Bh7e4", "Bh7e4!", "Bh7e4!!", "Bh7e4?", "Bh7e4??", "Bh7e4!?", "Bh7e4?!"
        /// </summary>
        public static string BishopMovesFromSquare => @"^(B[a-h][1-8][a-h][1-8]([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: "Bh7e4+", "Bh7e4+!", "Bh7e4+!!", "Bh7e4+?", "Bh7e4+??", "Bh7e4+!?", "Bh7e4+?!"
        /// </summary>
        public static string BishopMovesFromSquareCheck => @"^(B[a-h][1-8][a-h][1-8](\+)([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: "Bh7e4++", "Bh7e4#"
        /// </summary>
        public static string BishopMovesFromSquareCheckmate => @"^(B[a-h][1-8][a-h][1-8](\+{2}|#))$";

        /// <summary>
        /// It matches the following type of moves: "Bxe4", "Bxe4!", "Bxe4!!", "Bxe4?", "Bxe4??", "Bxe4!?", "Bxe4?!"
        /// </summary>
        public static string BishopCaptures => @"^(Bx[a-h][1-8]([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: "Bxe4+", "Bxe4+!", "Bxe4+!!", "Bxe4+?", "Bxe4+??", "Bxe4+!?", "Bxe4+?!"
        /// </summary>
        public static string BishopCapturesCheck => @"^(Bx[a-h][1-8](\+)([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: "Bxe4++", "Bxe4#"
        /// </summary>
        public static string BishopCapturesCheckmate => @"^(Bx[a-h][1-8](\+{2}|#))$";

        /// <summary>
        /// It matches the following type of moves: "Bhxe4", "Bhxe4!", "Bhxe4!!", "Bhxe4?", "Bhxe4??", "Bhxe4!?", "Bhxe4?!"
        /// </summary>
        public static string BishopCapturesFromFile => @"^(B[a-h]x[a-h][1-8]([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: "Bhxe4+", "Bhxe4+!", "Bhxe4+!!", "Bhxe4+?", "Bhxe4+??", "Bhxe4+!?", "Bhxe4+?!"
        /// </summary>
        public static string BishopCapturesFromFileCheck => @"^(B[a-h]x[a-h][1-8](\+)([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: "Bhxe4++", "Bhxe4#"
        /// </summary>
        public static string BishopCapturesFromFileCheckmate => @"^(B[a-h]x[a-h][1-8](\+{2}|#))$";

        /// <summary>
        /// It matches the following type of moves: "B7xe4", "B7xe4!", "B7xe4!!", "B7xe4?", "B7xe4??", "B7xe4!?", "B7xe4?!"
        /// </summary>
        public static string BishopCapturesFromRank => @"^(B[1-8]x[a-h][1-8]([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: "B7xe4+", "B7xe4+!", "B7xe4+!!", "B7xe4+?", "B7xe4+??", "B7xe4+!?", "B7xe4+?!"
        /// </summary>
        public static string BishopCapturesFromRankCheck => @"^(B[1-8]x[a-h][1-8](\+)([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: "B7xe4++", "B7xe4#"
        /// </summary>
        public static string BishopCapturesFromRankCheckmate => @"^(B[1-8]x[a-h][1-8](\+{2}|#))$";

        /// <summary>
        /// It matches the following type of moves: "Bh7xe4", "Bh7xe4!", "Bh7xe4!!", "Bh7xe4?", "Bh7xe4??", "Bh7xe4!?", "Bh7xe4?!"
        /// </summary>
        public static string BishopCapturesFromSquare => @"^(B[a-h][1-8]x[a-h][1-8]([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: "Bh7xe4+", "Bh7xe4+!", "Bh7xe4+!!", "Bh7xe4+?", "Bh7xe4+??", "Bh7xe4+!?", "Bh7xe4+?!"
        /// </summary>
        public static string BishopCapturesFromSquareCheck => @"^(B[a-h][1-8]x[a-h][1-8](\+)([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: "Bh7xe4++", "Bh7xe4#"
        /// </summary>
        public static string BishopCapturesFromSquareCheckmate => @"^(B[a-h][1-8]x[a-h][1-8](\+{2}|#))$";
        
        /// <summary>
        /// It matches the following type of moves: "Qd5", "Qd5!", "Qd5!!", "Qd5?", "Qd5??", "Qd5!?", "Qd5?!",
        /// </summary>
        public static string QueenMoves => @"^(Q[a-h][1-8]([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: "Qd5+", "Qd5+!", "Qd5+!!", "Qd5+?", "Qd5+??", "Qd5+!?", "Qd5+?!"
        /// </summary>
        public static string QueenMovesCheck => @"^(Q[a-h][1-8](\+)([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: "Qd5++", "Qd5#"
        /// </summary>
        public static string QueenMovesCheckmate => @"^(Q[a-h][1-8](\+{2}|#))$";

        /// <summary>
        /// It matches the following type of moves: "Qad5", "Qad5!", "Qad5!!", "Qad5?", "Qad5??", "Qad5!?", "Qad5?!"
        /// </summary>
        public static string QueenMovesFromFile => @"^(Q[a-h][a-h][1-8]([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: "Qad5+", "Qad5+!", "Qad5+!!", "Qad5+?", "Qad5+??", "Qad5+!?", "Qad5+?!"
        /// </summary>
        public static string QueenMovesFromFileCheck => @"^(Q[a-h][a-h][1-8](\+)([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: "Qad5++", "Qad5#"
        /// </summary>
        public static string QueenMovesFromFileCheckmate => @"^(Q[a-h][a-h][1-8](\+{2}|#))$";

        /// <summary>
        /// It matches the following type of moves: "Q2d5", "Q2d5!", "Q2d5!!", "Q2d5?", "Q2d5??", "Q2d5!?", "Q2d5?!"
        /// </summary>
        public static string QueenMovesFromRank => @"^(Q[1-8][a-h][1-8]([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: "Q2d5+", "Q2d5+!", "Q2d5+!!", "Q2d5+?", "Q2d5+??", "Q2d5+!?", "Q2d5+?!"
        /// </summary>
        public static string QueenMovesFromRankCheck => @"^(Q[1-8][a-h][1-8](\+)([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: "Q2d5++", "Q2d5#"
        /// </summary>
        public static string QueenMovesFromRankCheckmate => @"^(Q[1-8][a-h][1-8](\+{2}|#))$";

        /// <summary>
        /// It matches the following type of moves: "Qa2d5", "Qa2d5!", "Qa2d5!!", "Qa2d5?", "Qa2d5??", "Qa2d5!?", "Qa2d5?!"
        /// </summary>
        public static string QueenMovesFromSquare => @"^(Q[a-h][1-8][a-h][1-8]([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: "Qa2d5+", "Qa2d5+!", "Qa2d5+!!", "Qa2d5+?", "Qa2d5+??", "Qa2d5+!?", "Qa2d5+?!"
        /// </summary>
        public static string QueenMovesFromSquareCheck => @"^(Q[a-h][1-8][a-h][1-8](\+)([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: "Qa2d5++", "Qa2d5#"
        /// </summary>
        public static string QueenMovesFromSquareCheckmate => @"^(Q[a-h][1-8][a-h][1-8](\+{2}|#))$";

        /// <summary>
        /// It matches the following type of moves: "Qxd5", "Qxd5!", "Qxd5!!", "Qxd5?", "Qxd5??", "Qxd5!?", "Qxd5?!"
        /// </summary>
        public static string QueenCaptures => @"^(Qx[a-h][1-8]([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: "Qxd5+", "Qxd5+!", "Qxd5+!!", "Qxd5+?", "Qxd5+??", "Qxd5+!?", "Qxd5+?!"
        /// </summary>
        public static string QueenCapturesCheck => @"^(Qx[a-h][1-8](\+)([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: "Qxd5++", "Qxd5#"
        /// </summary>
        public static string QueenCapturesCheckmate => @"^(Qx[a-h][1-8](\+{2}|#))$";

        /// <summary>
        /// It matches the following type of moves: "Qaxd5", "Qaxd5!", "Qaxd5!!", "Qaxd5?", "Qaxd5??", "Qaxd5!?", "Qaxd5?!"
        /// </summary>
        public static string QueenCapturesFromFile => @"^(Q[a-h]x[a-h][1-8]([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: "Qaxd5+", "Qaxd5+!", "Qaxd5+!!", "Qaxd5+?", "Qaxd5+??", "Qaxd5+!?", "Qaxd5+?!"
        /// </summary>
        public static string QueenCapturesFromFileCheck => @"^(Q[a-h]x[a-h][1-8](\+)([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: "Qaxd5++", "Qaxd5#"
        /// </summary>
        public static string QueenCapturesFromFileCheckmate => @"^(Q[a-h]x[a-h][1-8](\+{2}|#))$";

        /// <summary>
        /// It matches the following type of moves: "Q2xd5", "Q2xd5!", "Q2xd5!!", "Q2xd5?", "Q2xd5??", "Q2xd5!?", "Q2xd5?!"
        /// </summary>
        public static string QueenCapturesFromRank => @"^(Q[1-8]x[a-h][1-8]([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: "Q2xd5+", "Q2xd5+!", "Q2xd5+!!", "Q2xd5+?", "Q2xd5+??", "Q2xd5+!?", "Q2xd5+?!"
        /// </summary>
        public static string QueenCapturesFromRankCheck => @"^(Q[1-8]x[a-h][1-8](\+)([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: "Q2xd5++", "Q2xd5#"
        /// </summary>
        public static string QueenCapturesFromRankCheckmate => @"^(Q[1-8]x[a-h][1-8](\+{2}|#))$";

        /// <summary>
        /// It matches the following type of moves: "Qa2xd5", "Qa2xd5!", "Qa2xd5!!", "Qa2xd5?", "Qa2xd5??", "Qa2xd5!?", "Qa2xd5?!"
        /// </summary>
        public static string QueenCapturesFromSquare => @"^(Q[a-h][1-8]x[a-h][1-8]([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: "Qa2xd5+", "Qa2xd5+!", "Qa2xd5+!!", "Qa2xd5+?", "Qa2xd5+??", "Qa2xd5+!?", "Qa2xd5+?!"
        /// </summary>
        public static string QueenCapturesFromSquareCheck => @"^(Q[a-h][1-8]x[a-h][1-8](\+)([\!\?]{1,2})?)$";

        /// <summary>
        /// It matches the following type of moves: "Qa2xd5++", "Qa2xd5#"
        /// </summary>
        public static string QueenCapturesFromSquareCheckmate => @"^(Q[a-h][1-8]x[a-h][1-8](\+{2}|#))$";
        
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
