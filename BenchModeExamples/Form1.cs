using System;
using System.Windows.Forms;
using AudioPrecision.API;

namespace BenchModeExamples
{
    public partial class Form1 : Form
    {
        private APx500 APx;
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            
            //Start APx in Bench Mode
       //     APx = new APx500(APxOperatingMode.BenchMode);

       //     //Make APx visible
        //    APx.Visible = true;
        }

        private void buttonGetSettledReadings_Click(object sender, EventArgs e)
        {
            //Set output configuration to Analog Unbalanced, 2 channels
            APx.BenchMode.Setup.OutputConnector.Type = OutputConnectorType.AnalogUnbalanced;
            APx.BenchMode.Setup.AnalogOutput.ChannelCount = 2;

            //Set input configuration to Analog Unbalanced, 2 channels
            APx.BenchMode.Setup.InputConnector.Type = InputConnectorType.AnalogUnbalanced;
            APx.BenchMode.Setup.AnalogInput.ChannelCount = 2;

            try
            {
                //Ask APx to make settled readings for RMS Level and THD+N Ratio
                ISettledResultCollection results = APx.BenchMode.GetSettledMeterReadings(SettlingMeterType.RmsLevel,
                                                                                         SettlingMeterType.ThdNRatio);

                //Get the settled readings for the RMS Level meter
                ISettledResult levelResult = results[SettlingMeterType.RmsLevel];
                
                //get the double values
                double[] levelValues = levelResult.GetValues("Vrms");
                //update the display
                textBoxLevelCh1.Text = levelValues[0].ToString();
                //check to see if the channel did not settle
                UpdateTimeout(levelResult, 0, textBoxLevelCh1);
                //update the display
                textBoxLevelCh2.Text = levelValues[1].ToString();
                //check to see if the channel did not settle
                UpdateTimeout(levelResult, 1, textBoxLevelCh2);

                //Get the settled readings for the THD+N ratio meter
                ISettledResult thdNResult = results[SettlingMeterType.ThdNRatio];
                double[] thdNValues = thdNResult.GetValues("dB");
                //update the display
                textBoxThdNCh1.Text = thdNValues[0].ToString();
                //check to see if the channel did not settle
                UpdateTimeout(thdNResult, 0, textBoxThdNCh1);
                //update the display
                textBoxThdNCh2.Text = thdNValues[1].ToString();
                //check to see if the channel did not settle
                UpdateTimeout(thdNResult, 0, textBoxThdNCh2);
            }
            catch (Exception ex)
            {
                //An error occurred such as Digital Unlock.  Report the error to the user
                MessageBox.Show(ex.Message);
            }
        }

        void UpdateTimeout(ISettledResult result, int ch, TextBox textBox)
        {
            //The settling may have timed out
            if (result.TimedOutOnChannel(ch))
                errorProvider1.SetError(textBox, "Timed Out");
            else
                errorProvider1.SetError(textBox, string.Empty);
        }

        private void buttonStartFft_Click(object sender, EventArgs e)
        {
            //Select the FFT measurement
            APx.BenchMode.Measurements.Fft.Show();
            IFftAnalyzer fft = APx.BenchMode.Measurements.Fft;
            try
            {
                //Start the FFT measurement
                fft.Start();
                while (fft.IsStarted)
                {
                    //Wait for it to finish
                    System.Threading.Thread.Sleep(100);
                }

                IXYGraph fftSpectrum = fft.FFTSpectrum;
                
                // Traverse each channel and fill the grid with X,Y pairs for the graph data
                for (int ch = 0; ch <= fftSpectrum.ChannelCount - 1; ch++)
                {
                    // add X and Y columns for this channel
                    string channelName = string.Format("Channel{0}", ch + 1);
                    DataGridView1.Columns.Add(channelName + " X", channelName + " X (" + fftSpectrum.XAxis.Unit + ")");
                    DataGridView1.Columns.Add(channelName + " Y", channelName + " Y (" + fftSpectrum.LeftAxis.Unit + ")");

                    // Get the X and Y values for this channel
                    double[] xValues = fftSpectrum.GetXValues(ch);
                    double[] yValues = fftSpectrum.GetYValues(ch);

                    //for the first channel RowCount will be zero.
                    if (DataGridView1.RowCount == 0 && xValues.Length > 0)
                    {
                        //add all the rows that will be needed.
                        DataGridView1.Rows.Add(xValues.Length);
                    }

                    for (int i = 0; i <= xValues.Length - 1; i++)
                    {
                        // add the x,y pairs to the grid
                        DataGridView1.Rows[i].Cells[ch * 2].Value = xValues[i];
                        DataGridView1.Rows[i].Cells[(ch * 2) + 1].Value = yValues[i];
                    }
                }
            }
            catch (Exception ex)
            {
                //An error occurred.  Report it to the user
                MessageBox.Show(ex.Message);
            }
        }
    }
}
