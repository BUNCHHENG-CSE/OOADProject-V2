namespace OOADPROV2.Models;

public class OrderDetail
{
    public int OrderDetailID { get; set; }
    public int OrderQty { get; set; }
    public float UnitPrice { get; set; }
    public Customer? Customer { get; set; }
    public Order? Order { get; set; }
    public Products? Products { get; set; }

}
