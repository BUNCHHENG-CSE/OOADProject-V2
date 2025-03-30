using OOADPROV2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOADPROV2.Utilities.Oberserver.Product;

public class ProductNotifier : ISubject<Products>
{
    private readonly List<IObserver<Products>> _observers = new();

    public void Attach(IObserver<Products> observer) => _observers.Add(observer);

    public void Detach(IObserver<Products> observer) => _observers.Remove(observer);

    public void Notify(Products product)
    {
        foreach (var observer in _observers)
            observer.Update(product);
    }
}
