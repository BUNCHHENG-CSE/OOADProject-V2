namespace OOADPROV2.Models;

public class Users
{
    public int UserID { get; set; }
    public string? Username { get; set; }
    public string? Password { get; set; }
    public Staffs? Staff { get; set; }
}
