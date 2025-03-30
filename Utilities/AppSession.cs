using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOADPROV2.Utilities
{
    internal class AppSession
    {
        public static int? CurrentStaffID { get; set; }

        public static int GetStaffIDOrThrow()
        {
            return CurrentStaffID ?? throw new InvalidOperationException("No staff is currently logged in.");
        }
    }
}

