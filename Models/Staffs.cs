namespace OOADPROV2.Models;

public class Staffs
{
    public int StaffID { get; set; }
    public string? StaffName { get; set; }
    public string? Gender { get; set; }
    public DateTime? BirthDate { get; set; }
    public string? StaffPosition { get; set; }
    public string? StaffAddress { get; set; }
    public string? ContactNumber { get; set; }
    public DateTime? HiredDate { get; set; }
    public byte[]? Photo { get; set; }

}
