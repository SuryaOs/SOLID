namespace SOLID.ISP;

// Should not force client to implement method that is not needed
public interface IDrivable {
    void Drive();
}

public interface IFlyable {
    void Fly();
}

public class Car : IDrivable
{
    public void Drive()
    {
       Console.WriteLine("I Can Drive");
    }
}
public class FlyingCar : IDrivable, IFlyable
{
    public void Drive()
    {
        Console.WriteLine("I Can Drive");
    }

    public void Fly()
    {
        Console.WriteLine("I Can Fly");
    }
}