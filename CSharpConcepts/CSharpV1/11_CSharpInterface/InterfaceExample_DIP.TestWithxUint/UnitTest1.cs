using Moq;
using InterfaceExample_DIP;
namespace InterfaceExample_DIP.TestWithxUint
{
    public class DeskFanTests
    {
        [Fact]
        public void PowerLowerThanZero_OK()
        {
            var mock = new Mock<IPowerSupply>();
            mock.Setup(ps => ps.GetPower()).Returns(() => 0);

            var fan = new DeskFan(mock.Object);
            var expected = "Won't work.";
            var actual = fan.Work();
            Assert.Equal(expected, actual); 
        }


        [Fact]
        public void PowerLowerThan200_Warning()
        {
            var fan = new DeskFan(new PowerSupplyHigherThan200());
            var expected = "Warning!";
            var actual = fan.Work();
            Assert.Equal(expected, actual); 
        }
    }

	public class PowerSupplyHigherThan200 : IPowerSupply
    {
        public int GetPower()
        {
            return 200;
        }
    }
}

