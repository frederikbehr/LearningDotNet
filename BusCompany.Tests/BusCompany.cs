using Xunit;

namespace BusCompany.Tests
{
    public class BusCompanyTests
    {
        [Fact] // This attribute indicates a test method
        public void GetSmallPrice()
        {
            //Instance
            BusCompanyManager busCompany = new BusCompanyManager();

            //Set distance
            busCompany.SetDistance(50);
            double price = busCompany.CalculateCost();
            
            // Assert
            Assert.Equal(50*10+2500, price);
        }
        
        [Fact] // This attribute indicates a test method
        public void GetMediumPrice()
        {
            //Instance
            BusCompanyManager busCompany = new BusCompanyManager();

            //Set distance
            busCompany.SetDistance(400);
            double price = busCompany.CalculateCost();
            
            // Assert
            Assert.Equal(400*8+2500, price);
        }
        
        [Fact] // This attribute indicates a test method
        public void GetMediumBorderPrice()
        {
            //Instance
            BusCompanyManager busCompany = new BusCompanyManager();

            //Set distance
            busCompany.SetDistance(500);
            double price = busCompany.CalculateCost();
            
            // Assert
            Assert.Equal(500*6+2500, price);
        }
        
        [Fact] // This attribute indicates a test method
        public void GetBigPrice()
        {
            //Instance
            BusCompanyManager busCompany = new BusCompanyManager();

            //Set distance
            busCompany.SetDistance(1000);
            double price = busCompany.CalculateCost();
            
            // Assert
            Assert.Equal(1000*6+2500, price);
        }
    }

}