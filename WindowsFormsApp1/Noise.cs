using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Noise : Signal
    {
        Random random = new Random();
        public Noise(double amplitude, string modularizationMode)
        {
            this.amplitude = amplitude;
            this.modularizationMode = modularizationMode;
        }

        public override double GetData()
        {
            if (AM != null)
            {
                return (random.Next((int)(-amplitude * (1 + AM.GetData())),(int) (amplitude * (1 + AM.GetData()))));
            }
            else
            {
                return (random.Next((int)(-amplitude) , (int)(amplitude) ));
            }
                           
        }
    }
}
