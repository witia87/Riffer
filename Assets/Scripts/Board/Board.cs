using System;
using Assets.Scripts;

public class Board
{
    public static int WIDTH = 32;
    public static int HEIGHT = 32;

    private Field[,] _fields = new Field[HEIGHT, WIDTH];

    public Board(SubstanceId[,] initialSubstanceDistribution)
    {
        for (var row = 0; row < Board.HEIGHT; row++)
        {
            for (var column = 0; column < Board.WIDTH; column++)
            {
                _fields[row, column] = new Field(row, column, initialSubstanceDistribution[row, column]);
            }
        }
    }

    public Board(Board otherBoard)
    {
        otherBoard.ForEach(field => { _fields[field.Row, field.Column] = new Field(field); });
    }

    public void ForEach(Action<Field> action)
    {
        for (var row = 0; row < Board.HEIGHT; row++)
        {
            for (var column = 0; column < Board.WIDTH; column++)
            {
                action(_fields[row, column]);
            }
        }
    }

    public Field GetField(int row, int column)
    {
        return _fields[row, column];
    }
}
