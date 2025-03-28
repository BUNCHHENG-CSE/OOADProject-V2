namespace OOADPROV2.Models;

public class Orders
{
    public int OrderID { get; set; }
    public DateTime? DateOrder { get; set; }
    public decimal TotalPrice { get; set; }
    public Customers? Customer { get; set; }

}
