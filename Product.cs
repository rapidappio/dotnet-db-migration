namespace net_migration;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
    
    // New column
    public string Description { get; set; } // This is the new column you're adding.
}