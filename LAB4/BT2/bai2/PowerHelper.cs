using System;

public static class PowerHelper
{
    public static double Power(double x, int n)
    {
        if (n == 0)
            return 1;

        if (n < 0)
            return 1 / Power(x, -n);

        double result = 1;
        for (int i = 0; i < n; i++)
        {
            result *= x;
        }

        return result;
    }
}
