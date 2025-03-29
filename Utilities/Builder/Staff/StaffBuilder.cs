using OOADPROV2.Models;
using OOADPROV2.Utilities.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOADPROV2.Utilities.Builder.Staff;

public class StaffBuilder : IBuilder<Staffs>
{
    private readonly Staffs _staff = new();

    private StaffBuilder() { }

    public static StaffBuilder Create() => new();

    public StaffBuilder WithName(string name)
    {
        _staff.StaffName = name;
        return this;
    }

    public StaffBuilder WithGender(string gender)
    {
        _staff.Gender = gender;
        return this;
    }

    public StaffBuilder WithBirthDate(DateTime birthdate)
    {
        _staff.BirthDate = birthdate;
        return this;
    }

    public StaffBuilder WithPosition(string position)
    {
        _staff.StaffPosition = position;
        return this;
    }

    public StaffBuilder WithAddress(string address)
    {
        _staff.StaffAddress = address;
        return this;
    }

    public StaffBuilder WithContactNumber(string contactnumber)
    {
        _staff.ContactNumber = contactnumber;
        return this;
    }

    public StaffBuilder WithHiredDate(DateTime hireddate)
    {
        _staff.HiredDate = hireddate;
        return this;
    }

    public StaffBuilder WithPhoto(byte[]? photo)
    {
        _staff.Photo = photo;
        return this;
    }

    public Staffs Build()
    {
        var (isValid, errorMessage) = StaffValidatorBuilder.Create().Build().Validate(_staff);
        if (!isValid)
            throw new InvalidOperationException(errorMessage);

        return EntityFactory.CreateStaff(
            0,
            _staff.StaffName,
            _staff.Gender,
            _staff.BirthDate,
            _staff.StaffPosition,
            _staff.StaffAddress,
            _staff.ContactNumber,
            _staff.HiredDate,
            _staff.Photo
        );
    }
}