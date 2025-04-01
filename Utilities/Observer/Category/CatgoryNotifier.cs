using OOADPROV2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOADPROV2.Utilities.Observer.Category;

public class CatgoryNotifier : ISubjects<Categories>
{
    private readonly List<IObservers<Categories>> _observers = [];
    public void Attach(IObservers<Categories> observer) => _observers.Add(observer);

    public void Detach(IObservers<Categories> observer) => _observers.Remove(observer);
   
    public void Notify(Categories category) => _observers.ForEach(observer => observer.Update(category));
    
}
