interface IThermometer
{
    double GetTemperature();  // Returns Celsius
}

class CelsiusSensor : IThermometer
{
    public double GetTemperature() => 25.0;
}

class FahrenheitSensor
{
    public double ReadFahrenheit() => 98.6;
}

class FahrenheitSensorAdapter : IThermometer
{
    // TODO: Declare a private FahrenheitSensor field

    public FahrenheitSensorAdapter(FahrenheitSensor sensor)
    {
        // TODO: Store the sensor reference
    }

    public double GetTemperature()
    {
        // TODO: Read the Fahrenheit value from the sensor
        // TODO: Convert Fahrenheit to Celsius using (F - 32) * 5.0 / 9.0
        return 0; // TODO: Return the converted Celsius value
    }
}

public class Program
{
    public static void Main()
    {
        IThermometer celsius = new CelsiusSensor();
        Console.WriteLine($"Celsius sensor: {celsius.GetTemperature():F1} C");

        // TODO: Uncomment the lines below after implementing the adapter
        // var sensor = new FahrenheitSensor();
        // IThermometer adapted = new FahrenheitSensorAdapter(sensor);
        // Console.WriteLine($"Fahrenheit sensor (adapted): {adapted.GetTemperature():F1} C");
    }
}