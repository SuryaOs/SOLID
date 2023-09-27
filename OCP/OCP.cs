using SOLID.SRD;

namespace SOLID.OCP;

// From SRD, You can see InvoiceDAL Class, You are Saving to sql Now, 
// What if you want to save to file or mongodb
// either you will add new method or rewrite old method ?
// in both case we are modifying the class
// we can fix it by having interface
public class InvoiceDAL
{
    public void SaveToDB(Invoice invoice)
    {
        var invoiceEntity = new
        {
            MarkerName = invoice._marker.Name,
            Quantity = invoice._quantity,
            TotalPrice = invoice.CalculatePrice()
        };
        Console.WriteLine(invoiceEntity.ToString());
    }

    public void saveToFile()
    {

    }
}

// Fix
public interface IInvoiceDAL {
    public void Save(Invoice invoice);
}
public class DatabaseInvoice : IInvoiceDAL
{
    public void Save(Invoice invoice)
    {
        // Save to Db
    }
}

public class FileInvoice : IInvoiceDAL
{
    public void Save(Invoice invoice)
    {
        // save to file
    }
}