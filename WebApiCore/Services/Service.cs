using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiCore.Interfaces;

namespace WebApiCore.Services
{
    public class Service : IService
    {
        public int FindValues(int id)
        {
            return id;
        }
    }
}
