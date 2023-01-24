namespace SimpleAPI.Test;

using SimpleAPI.Controllers;

public class UnitTest1
{
    WeatherForecastController controller = new WeatherForecastController();
    [Fact]
    public void GetMessage()
    {
        var value = controller.GetMessage("akash");
        Assert.True(value);
    }

    [Fact]
    public void Test1()
    {
        Assert.True(true);
    }
}