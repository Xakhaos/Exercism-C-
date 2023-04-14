using System;

public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)
    {
        int square = 0;        
        for (int i = 0; i <= max; i++)
        {
            square = square+i;
        }
        return square * square;

        throw new NotImplementedException("You need to implement this function.");
    }

    public static int CalculateSumOfSquares(int max)
    {
        int square = 0;        
        for (int i = 0; i <= max; i++)
        {
            int actualSquare = i*i;
            square =square+actualSquare;
        }
        return square;
                
        throw new NotImplementedException("You need to implement this function.");
    }

    public static int CalculateDifferenceOfSquares(int max)
    {
        return CalculateSquareOfSum(max) - CalculateSumOfSquares(max) ;
        throw new NotImplementedException("You need to implement this function.");
    }
}