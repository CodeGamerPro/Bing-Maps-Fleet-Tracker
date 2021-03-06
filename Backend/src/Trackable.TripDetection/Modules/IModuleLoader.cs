﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trackable.TripDetection.Modules
{
    public interface IModuleLoader
    {
        Task<IModule> LoadModule();

        Type ModuleType();
    }
}
