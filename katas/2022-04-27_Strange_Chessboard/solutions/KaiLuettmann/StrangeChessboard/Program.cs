// See https://aka.ms/new-console-template for more information

using StrangeChessboard;

var columnSizes = new ColumnSizes(new []{3,1,2,7,1});
var rowSizes = new RowSizes(new []{1,8,4,5,2});
var chessBoard = new Chessboard(columnSizes, rowSizes);
var totalWhiteArea = chessBoard.CalculateWhiteArea();
var totalBlackArea = chessBoard.CalculateBlackArea();

Console.WriteLine($"Total white area: {totalWhiteArea}");
Console.WriteLine($"Total black area: {totalBlackArea}");
Console.ReadLine();