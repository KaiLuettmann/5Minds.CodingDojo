using System.Collections;

namespace StrangeChessboard;

public class ChessboardSizes : IEnumerable<int>
{
    private readonly IEnumerable<int> _chessboardSizes;

    protected ChessboardSizes(IEnumerable<int> chessboardSizes)
    {
        ArgumentNullException.ThrowIfNull(chessboardSizes);
        var enumerable = chessboardSizes as int[] ?? chessboardSizes.ToArray();
        if (enumerable.Count() != 5)
        {
            throw new ArgumentOutOfRangeException($"{nameof(chessboardSizes)} must have count of 5.");
        }
        _chessboardSizes = enumerable;
    }

    public IEnumerator<int> GetEnumerator()
    {
        return _chessboardSizes.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return ((IEnumerable)_chessboardSizes).GetEnumerator();
    }

    public int this[int i] => _chessboardSizes.ElementAt(i);
}