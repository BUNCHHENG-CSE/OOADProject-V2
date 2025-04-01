using OOADPROV2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOADPROV2.Utilities.Observer.Product;

public class ProductNotifier : ISubjects<Products>
{
    private readonly List<IObservers<Products>> _observers = [];

    public void Attach(IObservers<Products> observer) => _observers.Add(observer);
    public void Detach(IObservers<Products> observer) => _observers.Remove(observer);
    public void Notify(Products product) => _observers.ForEach(observer => observer.Update(product));
}
