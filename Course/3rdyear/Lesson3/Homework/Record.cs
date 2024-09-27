namespace Homework;

public class Record 
{
    public string Date { get; set; }
    public string Product { get; set; }
    
    public string Region { get; set; }
    public int Quantity { get; set; }
    public double Price { get; set; }
    public Record(string date, string product, string region, int quantity, double price)
    {
        Date = date;
        Product = product; 
        Region = region;
        Quantity = quantity;
        Price = price;
    }

    public Record() { }
    
}