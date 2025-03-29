using OOADPROV2.Models;
using OOADPROV2.Utilities.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OOADPROV2.Utilities.Builder.User;

public class UserBuilder : IBuilder<Users>
{
    private readonly Users _user = new();

    private UserBuilder() { }

    public static UserBuilder Create() => new();

    public UserBuilder WithUsername(string username)
    {
        _user.Username = username;
        return this;
    }

    public UserBuilder WithPassword(string password)
    {
        _user.Password = SecurityHelper.HashPassword(password);
        return this;
    }

    public UserBuilder WithStaff(int staffId, string staffName, string staffPosition)
    {
        _user.Staff = new Staffs
        {
            StaffID = staffId,
            StaffName = staffName,
            StaffPosition = staffPosition
        };
        return this;
    }

    public Users Build()
    {
        var (isValid, errorMessage) = UserValidatorBuilder.Create().Build().Validate(_user);
        if (!isValid)
            throw new InvalidOperationException(errorMessage);

        return EntityFactory.CreateUser(
            0,
            _user.Username,
            _user.Password,
            _user.Staff
        );
    }
}
