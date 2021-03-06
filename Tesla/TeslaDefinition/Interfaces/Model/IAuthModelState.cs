﻿using Exrin.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeslaDefinition.Interfaces.Model
{
    public interface IAuthModelState: IModelState
    {
        string Pin { get; set; }

        bool IsAuthenticated { get; set; }
    }
}
