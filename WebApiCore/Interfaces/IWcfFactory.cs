using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiCore.Interfaces
{
    public interface IWcfFactory
    {
        Task<string> GetData(int valor);
    }
}
