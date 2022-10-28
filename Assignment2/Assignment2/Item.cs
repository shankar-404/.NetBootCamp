namespace Assignment2 { 
public class Item
{
    public string? name { get; set; }
    public double price { get; set; }
    public Item(string name, double price)
    {
        this.name = name;
        this.price = price;
    }
}
}