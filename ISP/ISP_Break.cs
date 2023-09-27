namespace SOLID.ISP_Break;

// Fat Interface => Forcing clients to implement unnecessary methods
public interface IVehicle
{
    void Fly();
    void Drive();
}
public class FlyingCar : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("I can Drive");
    }

    public void Fly()
    {
        Console.WriteLine("I can Fly");
    }
}

public class Car : IVehicle
{
    public Car()
    {
    }

    public void Drive()
    {
        Console.WriteLine("I can Drive");
    }

    public void Fly()
    {
        throw new NotImplementedException();
    }
}

public class AeroPlane : IVehicle
{
    public void Drive()
    {
        throw new NotImplementedException();
    }

    public void Fly()
    {
        Console.WriteLine("I can Fly");
    }
}
