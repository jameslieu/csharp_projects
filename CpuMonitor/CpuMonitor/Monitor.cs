using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CpuMonitor
{
    public partial class Monitor : MetroFramework.Forms.MetroForm
    {
        public Monitor()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            float formCPU = pCPU.NextValue();
            float formRam = pRAM.NextValue();

            metroProgressBarCPU.Value = (int)formCPU;
            metroProgressBarRAM.Value = (int)formRam;

            lblCPU.Text = string.Format("{0:0.00}%", formCPU);
            lblRAM.Text = string.Format("{0:0.00}%", formRam);

            chart1.Series["CPU"].Points.AddY(formCPU);
            chart1.Series["RAM"].Points.AddY(formRam);
        }

        private void Monitor_Load(object sender, EventArgs e)
        {
            timer.Start();
        }
    }
}
