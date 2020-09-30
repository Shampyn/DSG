using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{

    public class Triangle : Signal
    {
        double current = 0;
        public Triangle(double amplitude, int frequency, string modularizationMode)
        {
            this.amplitude = amplitude;
            this.frequency = frequency;
            this.modularizationMode = modularizationMode;
        }

        public override double GetData()
        {
            double tmp;
            if(FM!= null)
            {
                current += Math.PI * 2.0d * frequency * (1 + FM.GetData()) / sampleCount;
            }
            else
            {
                current += Math.PI * 2.0d * frequency / sampleCount;
            }

            if (AM != null)
            {
                tmp = ((Math.Asin(Math.Sin(current)) * amplitude * (1 + AM.GetData()) * 2 / Math.PI));

            }
            else
            {
                tmp = ((Math.Asin(Math.Sin(current)) * amplitude * 2 / Math.PI));
            }
           
           

           // current += step;

            return tmp;
        }
    }
}
