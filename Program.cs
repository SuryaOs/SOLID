// See https://aka.ms/new-console-template for more information
using SOLID.SRD;
using SOLID.LSP;

// -----------------------------SRD
Marker m = new("Blackiee", "Black", 2021, 100);
Invoice i = new(m, 4);
InvoiceDAL id = new();
id.SaveToDB(i);

//------------------OCP => Not Needed - It is Understandable
//------------------------------LSP
// Creating child class object and assigning to parent class variable
// I will get access to methods of parent class only
// if child class has over ridden it, then I will get output from child class
Employee e = new Manager();
e.Work();
// Below Call to Schedule Meeting Won't Work Because It Is Not a Generic Method for Employee
// Only Manager can Do This Work
// e.ScheduleMeetings()
//------------------------------ISP -- Understandabel
//------------------------------DIP
