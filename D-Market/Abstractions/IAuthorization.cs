using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace D_Market.Abstractions
{
    interface IAuthorization<T>
    {
        T Auth(string email, string password);
    }
}
