namespace SOLID.SRD;

// Invoice class has Marker and Quantity
// it also has three methods CalculatePrice, SaveToSQL, PrintInvoice
// it has 3 responsibilties => Calculating Price, Saving To Database, Printing Invoice
public class Invoice_Break
{
    private Marker _marker;
    private int _quantity;

    public Invoice_Break(Marker marker, int quantity)
    {
        _marker = marker;
        _quantity = quantity;
    }
    public int CalculatePrice()
    {
        return _marker.Price * _quantity;
    }

    public void SaveToSQL()
    {
        // save to sql
    }
    public void PrintInvoice()
    {
        // print the invoice
    }
}

// SRD - Single Class Single Responsibilty
public class Invoice
{
    public readonly Marker _marker;
    public readonly int _quantity;

    public Invoice(Marker marker, int quantity)
    {
        _marker = marker;
        _quantity = quantity;
    }
    public int CalculatePrice()
    {
        return _marker.Price * _quantity;
    }
}
public class InvoiceDAL
{    public void SaveToDB(Invoice invoice)
    {
        var invoiceEntity = new
        {
            MarkerName = invoice._marker.Name,
            Quantity = invoice._quantity,
            TotalPrice = invoice.CalculatePrice()
        };
        Console.WriteLine(invoiceEntity.ToString());
    }

}
public class InvoicePrinter
{
    private Invoice _invoice;
    public InvoicePrinter(Invoice invoice)
    {
        _invoice = invoice;
    }
    public void Print()
    {
        //PrintLogic
    }
}