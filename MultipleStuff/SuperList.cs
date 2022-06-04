using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleStuff
{
    public class SuperList : List<double>
    {
        public struct MinMax
        {
            public double Min { get; }
            public double Max { get; }

            public MinMax(double min, double max)
            {
                Min = min;
                Max = max;
            }
        }

        public void GetMinMax1(out double min, out double max)
        {
            double currentMin = this[0];
            double currentMax = this[0];
            foreach (double d in this)
            {
                if (d < currentMin)
                {
                    currentMin = d;
                }
                else if (d > currentMax)
                {
                    currentMax = d;
                }
            }
            min = currentMin;
            max = currentMax;
        }

        public MinMax GetMinMax2()
        {
            double currentMin = this[0];
            double currentMax = this[0];
            foreach (double d in this)
            {
                if (d < currentMin)
                {
                    currentMin = d;
                }
                else if (d > currentMax)
                {
                    currentMax = d;
                }
            }

            return new MinMax(currentMin, currentMax);
        }

        public Tuple<double, double> GetMinMax3()
        {
            double currentMin = this[0];
            double currentMax = this[0];
            foreach (double d in this)
            {
                if (d < currentMin)
                {
                    currentMin = d;
                }
                else if (d > currentMax)
                {
                    currentMax = d;
                }
            }

            return new Tuple<double, double>(currentMin, currentMax);
        }

        public (double, double) GetMinMax4()
        {
            double currentMin = this[0];
            double currentMax = this[0];
            foreach (double d in this)
            {
                if (d < currentMin)
                {
                    currentMin = d;
                }
                else if (d > currentMax)
                {
                    currentMax = d;
                }
            }

            return (currentMin, currentMax);
        }
    }
}
