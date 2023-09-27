namespace SOLID.LSP;

// with Employee as DataType on Left Hand Side
// Manager as Object on Right hand side.
// You can access Work method of Employee and get Manager is working
// but You cannot access Manager's Schedule Meeting method
public class Employee
{
    public virtual void Work()
    {
        Console.WriteLine("Employee is working.");
    }
}

class Developer : Employee
{
    public override void Work()
    {
        Console.WriteLine("Developer is coding.");
    }

    public void WriteCode()
    {
        Console.WriteLine("Developer is writing code.");
    }
}

class TeamLead : Employee
{
    public override void Work()
    {
        Console.WriteLine("Team Lead is managing the team and coding.");
    }

    public void ReviewCode()
    {
        Console.WriteLine("Team Lead is reviewing code.");
    }
}

class Manager : Employee
{
    public override void Work()
    {
        Console.WriteLine("Manager is overseeing the project.");
    }

    public void ScheduleMeetings()
    {
        Console.WriteLine("Manager is scheduling meetings.");
    }
}
