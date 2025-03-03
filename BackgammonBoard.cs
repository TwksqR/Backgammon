namespace Twksqr.Games.Backgammon;

public class BackgammonBoard
{
    public int[] WhitePieces { get; }
    public int[] BlackPieces { get; }

    public bool IsWhitesTurn { get; set; }

    public List<(int start, int end)> Moves { get; }

    private readonly Random _rand = new(DateTime.UtcNow.Millisecond);

    public BackgammonBoard()
    {
        WhitePieces = GetStandardBoardSetup().ToArray();
        BlackPieces = GetStandardBoardSetup().Reverse().ToArray();

        IsWhitesTurn = true;

        Moves = new List<(int start, int end)>();
    }

    public BackgammonBoard(IEnumerable<int> whitePieces, IEnumerable<int> blackPieces, bool isWhitesTurn, IEnumerable<(int, int)> moves)
    {
        WhitePieces = whitePieces.ToArray();
        BlackPieces = blackPieces.Reverse().ToArray();

        IsWhitesTurn = isWhitesTurn;

        Moves = moves.ToList();
    }

    public static IEnumerable<int> GetStandardBoardSetup()
    {
        return
        [
            2, 0, 0, 0, 0, 0,
            0, 0, 0, 0, 0, 5,
            0, 0, 0, 0, 3, 0,
            5, 0, 0, 0, 0, 0
        ];
    }

    public int GetDieRoll(int maxRoll)
    {
        return _rand.Next(maxRoll) + 1;
    }
}