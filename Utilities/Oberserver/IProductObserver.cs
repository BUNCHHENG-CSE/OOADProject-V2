using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOADPROV2.Utilities.Oberserver
{
    interface IProductObserver
    {
        void OnProductChanged(string message);
    }
}
