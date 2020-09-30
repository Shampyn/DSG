using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;
using System.Runtime.InteropServices;
using NAudio.Wave;



namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
  
        const int BYTES_PER_SAMPLE = 2;
        const int SAMPLE_RATE = 44100;
        const int LENGTH = 10;
        double[] data = new double[SAMPLE_RATE * LENGTH];
        uint radioButton = 0;
        Dictionary<string, Signal> types = new Dictionary<string, Signal>();
        Dictionary<string, Signal> modulTypes = new Dictionary<string, Signal>();

        public Form1()
        {
            InitializeComponent();

        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            float[] result = new float[data.Length];
            for(int i = 0; i < data.Length; i++)
            {
                result[i] = (float)data[i];       
            }


            FileStream fs = new FileStream("MySound2.wav", FileMode.Create);



            using (WaveFileWriter waveFileWriter = new WaveFileWriter(fs, new WaveFormat(SAMPLE_RATE, 16, 1))) { 
                 
                waveFileWriter.WriteSamples(result, 0, result.Length);
               
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Signal signal;

            int sampleCount = (int)(((double)SAMPLE_RATE) * LENGTH);
            short[] tempBuffer = new short[sampleCount];
            double amplitude = Convert.ToDouble(tbAmplitude.Text);
            int frequency = Convert.ToInt32(tbFrequency.Text);
            if(radioButton != 0) {
                modulTypes.Clear();
               double amplitudeModul = Convert.ToDouble(tbModulAmpl.Text);
                int frequencyModul = Convert.ToInt32(tbModulFreq.Text);
                modulTypes.Add("Sinusoid", new Sinus(amplitudeModul, frequencyModul, "None"));
                modulTypes.Add("Noise", new Noise(amplitudeModul, "None"));
                modulTypes.Add("Triangle", new Triangle(amplitudeModul, frequencyModul, "None"));
                modulTypes.Add("Sawtooth", new SawTooth(amplitudeModul, frequencyModul, "None"));

                if (cbModulTypes.Text == "Pulse")
                {
                    modulTypes.Add("Pulse", new Pulse(amplitudeModul, frequencyModul, "None", Convert.ToDouble(tbModulDC.Text)));
                }
            }
        
            types.Clear();

            types.Add("Sinusoid", new Sinus(amplitude, frequency, "None"));
            types.Add("Noise", new Noise(amplitude, "None"));
            types.Add("Triangle", new Triangle(amplitude, frequency, "None"));
            types.Add("Sawtooth", new SawTooth(amplitude, frequency, "None"));


            if (cbWaveTypes.Text == "Pulse")
            {
                types.Add("Pulse", new Pulse(amplitude, frequency, "None", Convert.ToDouble(tbDutyCycle.Text)));
            }
                switch (radioButton)
                {
                    case 0:
                        for (int i = 0; i < tempBuffer.Length; ++i)
                        {
                            data[i] += types[cbWaveTypes.Text].GetData();
                        }
                        break;
                    case 1:
                    signal = types[cbWaveTypes.Text];
                    signal.AM = modulTypes[cbModulTypes.Text]; //modulTypes[cbModulTypes.Text];
                    signal.FM = null;
                    for (int i = 0; i < tempBuffer.Length; ++i)
                        {
                        data[i] += (types[cbWaveTypes.Text].GetData()); 
                        }
                    break;
                    case 2:
                    signal = types[cbWaveTypes.Text];
                    signal.FM = modulTypes[cbModulTypes.Text];
                    signal.AM = null;
                    for (int i = 0; i < tempBuffer.Length; ++i)
                    {                                             
                        data[i] += types[cbWaveTypes.Text].GetData();
                    }
                    break;

                }          
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            data = new double[SAMPLE_RATE * LENGTH]; 
        }

        private void tbNone_CheckedChanged(object sender, EventArgs e)
        {
            radioButton = 0;
        }

        private void rbAmplitude_CheckedChanged(object sender, EventArgs e)
        {
            radioButton = 1;
        }

        private void rbFrequency_CheckedChanged(object sender, EventArgs e)
        {
            radioButton = 2;
        }
    }
}
