﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kOS.Control
{
    public interface IFlightControlParameter
    {
        bool Enabled { get; }
        bool IsAutopilot { get; }
        object Value { get; set; }
        uint ControlPartId { get; }
        void UpdateValue(object value, SharedObjects shared);
        void UpdateValue(object value);
        object GetValue();
        SharedObjects GetShared();
        void UpdateState();
        void UpdateAutopilot(FlightCtrlState c);
        void EnableControl(SharedObjects shared);
        void DisableControl(SharedObjects shared);
        void DisableControl();
        void CopyFrom(IFlightControlParameter origin);
    }
}
