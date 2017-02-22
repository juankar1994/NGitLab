using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGitLab.Models
{
    public enum AccessLevel
    {
        Guest = 10,
        Reporter = 20,
        Developer = 30,
        Master = 40,
        Owner = 50
    }
}
