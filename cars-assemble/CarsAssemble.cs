using System;
using System.Collections.Generic;
static class AssemblyLine
{
    
    public static double SuccessRate(int speed)
    {
        List<int> sucessRate0 = new List<int>();
        List<int> sucessRate100 = new List<int>();
        List<int> sucessRate90 = new List<int>();
        List<int> sucessRate80 = new List<int>();
        List<int> sucessRate77 = new List<int>();
        sucessRate0.Add(0);
        sucessRate100.Add(1);
        sucessRate100.Add(2);
        sucessRate100.Add(3);
        sucessRate100.Add(4);
        sucessRate90.Add(5);
        sucessRate90.Add(6);
        sucessRate90.Add(7);
        sucessRate90.Add(8);
        sucessRate80.Add(9);
        sucessRate77.Add(10);
        if (sucessRate0.Contains(speed))
        {
            return 0.0;
        }
        if (sucessRate100.Contains(speed))
        {
            return 1.00;
        }
        if (sucessRate90.Contains(speed))
        {
            return 0.90;
        }
        if (sucessRate80.Contains(speed))
        {
            return 0.80;
        }
        if (sucessRate77.Contains(speed))
        {
            return 0.77;
        }

        throw new NotImplementedException("Please implement the (static) AssemblyLine.SuccessRate() method");
    }
    
    public static double ProductionRatePerHour(int speed)
    {
         double sucessRate = SuccessRate(speed);
        return (221 * speed) * sucessRate;
        throw new NotImplementedException("Please implement the (static) AssemblyLine.ProductionRatePerHour() method");
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        double result = ProductionRatePerHour(speed) / 60;
       return Convert.ToInt32( Math.Floor(result));
        throw new NotImplementedException("Please implement the (static) AssemblyLine.WorkingItemsPerMinute() method");
    }
}
