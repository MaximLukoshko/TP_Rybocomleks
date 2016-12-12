﻿using Rybocompleks.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rybocompleks.Perepherial
{
    public abstract class Sensor : ISensor
    {
        protected IMeasurment lastMeasurment = null;
        protected Location location;

        public Sensor(Location loc)
        {
            location = loc;
        }

        public IMeasurment GetLastMeasurment()
        {
            return lastMeasurment;
        }

        public Location GetLocation()
        {
            return location;
        }

        public void SetLocation(Location loc)
        {
           location = loc;
        }

        public abstract MeasurmentTypes.Type GetPropertyID();

        public abstract String GetName();

        public abstract Int32 GetIcon();
        public abstract IMeasurment Measure();
    }
}
