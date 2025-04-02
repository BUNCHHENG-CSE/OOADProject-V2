using OOADPROV2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOADPROV2.Utilities.Observer.User;

public class UserNotifier : ISubjects<Users>
{
    private readonly List<IObservers<Users>> _observers = [];
    public void Attach(IObservers<Users> observer) => _observers.Add(observer);
    public void Detach(IObservers<Users> observer) => _observers.Remove(observer);
    public void Notify(Users user) => _observers.ForEach(observer => observer.Update(user));

}
