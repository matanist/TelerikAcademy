using System;

class Garden
{
    static void Main()
    {
        decimal[] prices = { 0.5m, 0.4m, 0.25m, 0.6m, 0.3m, 0.4m };
        decimal totalCost = 0;
        int beansArea = 250;

        for (int i = 0; i < 6; i++)
        {
            totalCost += prices[i] * int.Parse(Console.ReadLine());
            if (i < 5) beansArea -= int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Total costs: {0:F2}", totalCost);
        if (beansArea < 0) Console.WriteLine("Insufficient area");
        else if (beansArea == 0) Console.WriteLine("No area for beans");
        else Console.WriteLine("Beans area: {0}", beansArea);
    }
}