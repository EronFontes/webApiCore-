﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiCore.Interfaces
{
    public interface IService
    {
        Task<string> FindValues(int id);
    }
}
