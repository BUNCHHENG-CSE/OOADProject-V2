using OOADPROV2.Models;
using OOADPROV2.Utilities.Commands.Staff.Action;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOADPROV2.Utilities.Commands.Staff;

public class StaffCommands
{
    public static bool AddStaff(Staffs staff)
    {
        return new AddCommand(staff).Execute();
    }
    public static bool UpdateStaff(Staffs staff)
    {
        return new UpdateCommand(staff).Execute();
    }
    public static bool DeleteStaff(int id)
    {
        return new DeleteCommand(id).Execute();
    }
}
