using System;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    class Pulse : Signal
    {
        public double fiAngle = 0.0;
        public double dutyCycle;
        public Pulse(double amplitude, int frequency, string modularizationMode,double dutyCycle)
        {
            this.amplitude = amplitude;
            this.frequency = frequency;
            this.modularizationMode = modularizationMode;
            this.dutyCycle = dutyCycle;
           
        }

        public override double GetData()
        {          
            var cycle = 2 * Math.PI;
            if (FM != null)
            {
                fiAngle += 2 * Math.PI * frequency * (1 + FM.GetData()) / sampleCount;

            }
            else
            {
                fiAngle += 2 * Math.PI * frequency/ sampleCount;
            }

            if (AM != null)
            {
                return ((fiAngle % cycle) / cycle > dutyCycle ? 0.0 : amplitude * (1 + AM.GetData()));

            }
            else
            {
                return ((fiAngle % cycle) / cycle > dutyCycle ? 0.0 : amplitude);
            }                                  
        }
    }
}
