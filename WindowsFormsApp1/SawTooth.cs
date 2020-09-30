using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class SawTooth : Signal
    {
        double current = 0;
        
        public SawTooth(double amplitude, int frequency, string modularizationMode)
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
                current += Math.PI * frequency * (1 + FM.GetData()) / sampleCount;
              
            }
            else
            {
                current += Math.PI * frequency/ sampleCount;
            }

            if (AM != null)
            {
                tmp = ((Math.Atan(1 / Math.Tan(current)) * amplitude * (1 + AM.GetData()) * (-2) / Math.PI));

            }
            else
            {
                tmp = ((Math.Atan(1 / Math.Tan(current)) * amplitude * (-2) / Math.PI));
            }
           

            //current += step;

            return tmp;
        }
    }
}
