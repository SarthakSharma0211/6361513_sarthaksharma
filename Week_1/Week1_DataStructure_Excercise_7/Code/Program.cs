using System;

class FinancialForecasting
{
    // Recursive method to calculate future value
    static double CalculateFutureValue(double principal, double growthRate, int years)
    {
        if (years == 0)
            return principal;

        return CalculateFutureValue(principal * (1 + growthRate), growthRate, years - 1);
    }

    // Iterative version for optimization
    static double CalculateFutureValueIterative(double principal, double growthRate, int years)
    {
        for (int i = 0; i < years; i++)
        {
            principal *= (1 + growthRate);
        }
        return principal;
    }

    // Formula-based version
    static double CalculateFutureValueFormula(double principal, double growthRate, int years)
    {
        return principal * Math.Pow(1 + growthRate, years);
    }

    static void Main(string[] args)
    {
        double initialAmount = 1000.0;
        double growthRate = 0.08; // 8%
        int years = 5;

        Console.WriteLine("Using Recursion:");
        Console.WriteLine($"Future Value: ₹{CalculateFutureValue(initialAmount, growthRate, years):F2}");

        Console.WriteLine("\nUsing Iteration:");
        Console.WriteLine($"Future Value: ₹{CalculateFutureValueIterative(initialAmount, growthRate, years):F2}");

        Console.WriteLine("\nUsing Formula:");
        Console.WriteLine($"Future Value: ₹{CalculateFutureValueFormula(initialAmount, growthRate, years):F2}");
    }
}