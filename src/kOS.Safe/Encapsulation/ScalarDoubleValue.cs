﻿namespace kOS.Safe.Encapsulation
{
    public class ScalarDoubleValue : ScalarValue
    {
        public override bool IsDouble
        {
            get { return true; }
        }

        public override bool IsInt
        {
            get { return false; }
        }

        public ScalarDoubleValue(double value)
        {
            Value = value;
        }

        public static implicit operator ScalarDoubleValue(double val)
        {
            return new ScalarDoubleValue(val);
        }
    }
}