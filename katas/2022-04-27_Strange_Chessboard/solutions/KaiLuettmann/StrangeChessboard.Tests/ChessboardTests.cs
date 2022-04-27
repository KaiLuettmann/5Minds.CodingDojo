using Xunit;

namespace StrangeChessboard.Tests;

public class ChessboardTests
{
    private readonly Fixture _fixture;

    public ChessboardTests()
    {
        _fixture = new Fixture();
    }

    [Fact]
    public void CalculateBlackArea()
    {
        // Arrange
        _fixture.SetupColumnSizes();
        _fixture.SetupRowSizes();
        var testObject = _fixture.CreateTestObject();

        // Act
        var result = testObject.CalculateBlackArea();

        // Assert
        Assert.Equal(134, result);
    }

    [Fact]
    public void CalculateWhiteArea()
    {
        // Arrange
        _fixture.SetupColumnSizes();
        _fixture.SetupRowSizes();
        var testObject = _fixture.CreateTestObject();

        // Act
        var result = testObject.CalculateWhiteArea();

        // Assert
        Assert.Equal(146, result);
    }

    private sealed class Fixture
    {
        private ColumnSizes? _columnSizes;
        private RowSizes? _rowSizes;

        public Chessboard CreateTestObject()
        {
            return new Chessboard(_columnSizes!, _rowSizes!);
        }

        public void SetupColumnSizes()
        {
            _columnSizes = new ColumnSizes(new[] { 3, 1, 2, 7, 1 });
        }

        public void SetupRowSizes()
        {
            _rowSizes = new RowSizes(new[] { 1, 8, 4, 5, 2 });
        }
    }
}