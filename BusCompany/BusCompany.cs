namespace BusCompany;
    
public class BusCompanyManager
{
    private const double InitialFee = 2500;
    private double _distance = 0;
    private static readonly double[][] Pricing = [
        [100, 10], 
        [500, 8], 
        [Double.PositiveInfinity, 6],
    ]; //[up_to_distance, km_price]

    public BusCompanyManager() {}  
    
    public double CalculateCost()
    {
        //Run through pricing minus last one, and find a match
        for (int i = 0; i < Pricing.Length - 1; i++)
        {
            if (_distance < Pricing[i][0]) return Pricing[i][1] * _distance + InitialFee;
        }
        //Reaching here means it must be the last one.
        //This makes it safe and adjustable.
        return Pricing.Last()[1] * _distance + InitialFee;
    }

    public void SetDistance(double distance) => _distance = distance;
    
}