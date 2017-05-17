using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lob.Interfaces
{
    public interface IApiService
    {
        TResponse Post<TResponse>(string url, string data);
    }
}
