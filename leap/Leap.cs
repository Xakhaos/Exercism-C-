using System;

public static class Leap
{
    public static bool IsLeapYear(int year)
    {
        
        bool modFour = year % 4 == 0;
        bool modHundred = year % 100 == 0;
        bool modFourHundred = year % 400 ==0;
        if (modFour && modHundred && modFourHundred)
        {
             return true;
        }
        if (modHundred && year % 3 !=0)
        {
            return false;
        }
        if (modHundred && modFourHundred == false)
        {
            return false;
        }
        if (modFour)
        {
             return true;
        }
        return false;
        throw new NotImplementedException("You need to implement this function.");
    }
}