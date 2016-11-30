﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rybocompleks.Data
{
    interface ITemperatureMeasurment : IMeasurment
    {
        Int16 GetTemperature();
    }
}
