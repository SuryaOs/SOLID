namespace SOLID.LSP_Break;
// Definition - Child class object should be able to replace parent class object without breaking the behavior
// Other words - Child class should extend parent class not narrow it.
// Here Developer won't review code or schedule meetings but he is getting access to it.
// Getting access is not violating LSP rather it is violating ISP
// If I use Interface and make subclasses Implement it will return exception for unauthorized methods
public class Employee
{
    public virtual void Work()
    {
        Console.WriteLine("Employee is working.");
    }
    public virtual void WriteCode()
    {
        Console.WriteLine("Employee is writing code.");
    }

    public virtual void ReviewCode()
    {
        Console.WriteLine("Employee is reviewing code.");
    }
    public virtual void ScheduleMeetings()
    {
        Console.WriteLine("Employee is scheduling meetings.");
    }
}

class Developer : Employee
{
    public override void Work()
    {
        Console.WriteLine("Developer is coding.");
    }

    public override void WriteCode()
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

    public override void ReviewCode()
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

    public override void ScheduleMeetings()
    {
        Console.WriteLine("Manager is scheduling meetings.");
    }
}
