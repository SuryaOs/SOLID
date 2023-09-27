namespace SOLID.SRD;

public class Marker
{
    public string Name { get; set; } = string.Empty;
    public string Color { get; set; } = string.Empty;
    public int Year { get; set; }
    public int Price { get; set; }

    public Marker(string name, string color, int year, int price)
    {
        Name = name;
        Color = color;
        Year = year;
        Price = price;
    }
}