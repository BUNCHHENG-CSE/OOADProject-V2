namespace OOADPROV2.Utilities.Oberserver;

class ProductNotifier
{
    private readonly List<IProductObserver> _observers = new();

    public void Subscribe(IProductObserver observer)
    {
        if (!_observers.Contains(observer))
            _observers.Add(observer);
    }

    public void Unsubscribe(IProductObserver observer)
    {
        if (_observers.Contains(observer))
            _observers.Remove(observer);
    }

    public void Notify(string message)
    {
        foreach (var observer in _observers)
        {
            observer.OnProductChanged(message);
        }
    }

}
