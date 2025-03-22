namespace OOADPROV2.Models;

public class Order
{
    public int OrderID { get; set; }
    public DateTime? DateOrder { get; set; }
    public decimal TotalPrice { get; set; }
    public Customer? Customer { get; set; }

}
