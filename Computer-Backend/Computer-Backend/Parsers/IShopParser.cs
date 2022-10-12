using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Computer_Backend.Parsers
{
    interface IShopParser
    {
        IComputerInfo GetInfo(string href);
        IComputerInfo GetInfo(Uri href);
    }
}
