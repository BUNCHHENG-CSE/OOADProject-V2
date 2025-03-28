namespace OOADPROV2.Models;

public class OrderDetails
{
    public int OrderDetailID { get; set; }
    public int OrderQty { get; set; }
    public float UnitPrice { get; set; }
    public Customers? Customer { get; set; }
    public Orders? Order { get; set; }
    public Products? Products { get; set; }

}
