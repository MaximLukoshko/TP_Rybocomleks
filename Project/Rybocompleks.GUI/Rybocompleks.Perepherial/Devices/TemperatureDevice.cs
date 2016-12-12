﻿using Rybocompleks.Perepherial;
using Rybocompleks.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rybocompleks.Perepherial
{
    public class TemperatureDevice : Device
    {
        public TemperatureDevice(Location loc) : base(loc)
        {
            SetState( new TemperatureMeasurment(0) );
        }
        public override void SetState(IMeasurment state)
        {
            State = null != (ITemperatureMeasurment)state ? state : new TemperatureMeasurment(0);
            Nature.Temperature = (ITemperatureMeasurment)State;
        }

        public override MeasurmentTypes.Type GetPropertyID()
        {
            return MeasurmentTypes.Type.Temperature;
        }

        public override string GetName()
        {
            return "Нагреватель";
        }

        public override int GetIcon()
        {
            throw new NotImplementedException();
        }
    }
}
