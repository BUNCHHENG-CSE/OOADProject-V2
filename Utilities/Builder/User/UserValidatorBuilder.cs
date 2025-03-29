using OOADPROV2.Models;

namespace OOADPROV2.Utilities.Builder.User;

public class UserValidatorBuilder : IBuilder<Validator<Users>>
{
    private UserValidatorBuilder() { }

    public static UserValidatorBuilder Create() => new();
    public Validator<Users> Build()
    {
        return new Validator<Users>()
             .AddRule(u => (!string.IsNullOrWhiteSpace(u.Username) && u.Username.Length <= 100,
                "Username is required or too long (max 100 characters)."))

            .AddRule(u => (!string.IsNullOrWhiteSpace(u.Password) && u.Password.Length <= 100,
                "Password is required or too long (max 100 characters)."))

            .AddRule(u => (u.Staff != null && u.Staff.StaffID > 0,
                "Valid Staff selection is required."));
    }
}

