using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOADPROV2.Models;
using OOADPROV2.Utilities.Commands.User.Action;
namespace OOADPROV2.Utilities.Commands.User;

public class UserCommands
{
    public static IEnumerable<Users> GetUsers()
    {
        return new GetAllCommand().Execute();
    }
    public static bool AddUser(Users user)
    {
        return new AddCommand(user).Execute();
    }
    public static bool UpdateUser(Users user)
    {
        return new UpdateCommand(user).Execute();
    }
    public static bool DeleteUser(int id)
    {
        return new DeleteCommand(id).Execute();
    }
   
   
}
