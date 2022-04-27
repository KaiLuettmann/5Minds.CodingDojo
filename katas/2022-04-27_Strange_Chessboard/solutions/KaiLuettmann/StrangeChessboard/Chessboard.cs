namespace StrangeChessboard;
public class Chessboard
{
    private readonly ColumnSizes _columnSizes;
    private readonly RowSizes _rowSizes;

    public Chessboard(ColumnSizes columnSizes, RowSizes rowSizes)
    {
        _columnSizes = columnSizes;
        _rowSizes = rowSizes;
    }

    public int CalculateWhiteArea()
    {
        var whiteArea = 0;
        for (var i = 0; i < 5; i++)
        {
            var isEven = i % 2 == 0;
            if (isEven)
            {
                whiteArea += _columnSizes[i] * _rowSizes[0];
                whiteArea += _columnSizes[i] * _rowSizes[2];
                whiteArea += _columnSizes[i] * _rowSizes[4];
            }
            else
            {
                whiteArea += _columnSizes[i] * _rowSizes[1];
                whiteArea += _columnSizes[i] * _rowSizes[3];
            }
        }
        return whiteArea;
    }

    public int CalculateBlackArea()
    {
        var blackArea = 0;
        for (var i = 0; i < 5; i++)
        {
            var isOdd = i % 2 != 0;
            if (isOdd)
            {
                blackArea += _columnSizes[i] * _rowSizes[0];
                blackArea += _columnSizes[i] * _rowSizes[2];
                blackArea += _columnSizes[i] * _rowSizes[4];
            }
            else
            {
                blackArea += _columnSizes[i] * _rowSizes[1];
                blackArea += _columnSizes[i] * _rowSizes[3];
            }
        }
        return blackArea;
    }
}