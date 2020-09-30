using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
   public class Sinus: Signal
    {
        double current = 0;
        public Sinus(double amplitude, int frequency, string modularizationMode)
        {
            this.amplitude = amplitude;
            this.frequency = frequency;
            this.modularizationMode = modularizationMode;
        }

        public override double GetData()
        {

            double tmp;
            if (FM != null)
            {
                current += Math.PI * 2.0 * frequency * (1 + FM.GetData()) / sampleCount;
            }
            else
            {
                current += Math.PI * 2 * frequency / sampleCount;
            }
            if (AM != null)
            {
                var s = AM.GetData();
                tmp = ((Math.Sin(current)) * amplitude * (1 + s));               
            }
            else
            {
                tmp = ((Math.Sin(current)) * amplitude);
            }               
            return tmp;
        }

    }
}
