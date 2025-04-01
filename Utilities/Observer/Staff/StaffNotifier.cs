using OOADPROV2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOADPROV2.Utilities.Observer.Staff;

public class StaffNotifier : ISubjects<Staffs>
{
    private readonly List<IObservers<Staffs>> _observers = [];
    public void Attach(IObservers<Staffs> observer) => _observers.Add(observer);  
    public void Detach(IObservers<Staffs> observer) => _observers.Remove(observer);
    public void Notify(Staffs staff) => _observers.ForEach(observer => observer.Update(staff));
    
}
