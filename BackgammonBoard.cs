namespace Twksqr.Games.Backgammon;

public class BackgammonBoard
{
    public int[] WhitePieces { get; }
    public int[] BlackPieces { get; }

    public BackgammonBoard()
    {
        WhitePieces = GetStandardBoardSetup().ToArray();
        BlackPieces = GetStandardBoardSetup().ToArray();
    }

    public static IEnumerable<int> GetStandardBoardSetup()
    {
        return
        [
            2, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 4,
            0, 0, 0, 0, 3, 0,
            5, 0, 0, 0, 0, 0
        ];
    }
}