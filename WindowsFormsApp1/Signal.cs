using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public abstract class Signal
    {
        public Signal AM = null;
        public Signal FM = null;
       public const int SAMPLE_RATE = 44100;
       public const int LENGTH = 10;
       public string modularizationMode = "None";
       public double amplitude;
       public int frequency;
       public const int sampleRate = 44100;
       public int sampleCount = SAMPLE_RATE*LENGTH;


        // make get data by step? not all by one 
       public abstract double GetData();
    }
}
