namespace LearningDotNet.Models;

public class BusCompany
{
    private const double InitialFee = 2500;
    private double Distance = 0;
    private static double[][] Pricing = [
        [100, 10], 
        [500, 8], 
        [Double.PositiveInfinity, 6],
    ]; //[up_to_distance, km_price]

    public BusCompany() {}
    
    public double CalculateCost()
    {
        //Run through pricing minus last one, and find a match
        for (int i = 0; i < Pricing.Length - 1; i++)
        {
            if (Distance < Pricing[i][0]) return Pricing[i][1] * Distance + InitialFee;
        }
        //Reaching here means it must be the last one.
        //This makes it safe and adjustable.
        return Pricing.Last()[1] * Distance + InitialFee;
    }

    public void SetDistance(double distance) => Distance = distance;
    
}