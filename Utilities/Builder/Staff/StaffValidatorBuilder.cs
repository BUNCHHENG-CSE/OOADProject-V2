using OOADPROV2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOADPROV2.Utilities.Builder.Staff;

public class StaffValidatorBuilder : IBuilder<Validator<Staffs>>
{
    private StaffValidatorBuilder() { }
    public static StaffValidatorBuilder Create() => new();
    public Validator<Staffs> Build()
    {
        return new Validator<Staffs>()
            .AddRule(s => (!string.IsNullOrWhiteSpace(s.StaffName) && s.StaffName.Length <= 100,
                "Staff name is required or too long (max 100 characters)."))

            .AddRule(s => (!string.IsNullOrWhiteSpace(s.StaffAddress) && s.StaffAddress.Length <= 1000,
                "Staff address is required or too long (max 1000 characters)."))

            .AddRule(s => (!string.IsNullOrWhiteSpace(s.ContactNumber) && s.ContactNumber.Length <= 10,
                "Contact number is required or too long (max 10 characters)."))

            .AddRule(s => (!string.IsNullOrWhiteSpace(s.Gender),
                "Gender is required."))

            .AddRule(s => (!string.IsNullOrWhiteSpace(s.StaffPosition),
                "Staff position is required."))

            .AddRule(s => (s.BirthDate != default,
                "Birth date is required."))

            .AddRule(s => (s.HiredDate != default,
                "Hired date is required."));
    }
}

