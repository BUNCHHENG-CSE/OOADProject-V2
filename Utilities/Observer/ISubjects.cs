using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOADPROV2.Utilities.Observer;
public interface ISubjects<T>
{

    void Attach(IObservers<T> observer);
    void Detach(IObservers<T> observer);
    void Notify(T data);
}

