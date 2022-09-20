using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CPU_Memory_Monitor
{
    public partial class Form1 : Form
    {
        private System.Timers.Timer _timer;
        bool startflag = false;

        public Form1()
        {
            InitializeComponent();
            _timer = new System.Timers.Timer();
            _timer.Interval = 3000;
            _timer.Elapsed += OntimedEvent;
            _timer.AutoReset = true;

        }
        private void OntimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

            // We will monitor and get the values of the cpu and memory
            int cpuValue = GetCpuValue();
            int memValue = GetMemValue();
            // -----------------------------------------------------------------------------
            if (progressBarCPU.InvokeRequired)
            {
                progressBarCPU.Invoke(new Action(() => progressBarCPU.Value = cpuValue));
            }
            else
            {
                progressBarCPU.Value = cpuValue;
            }
            // -----------------------------------------------------------------------------
            if (lblCpu.InvokeRequired)
            {
                lblCpu.Invoke(new Action(() => lblCpu.Text = cpuValue.ToString() + " % "));
            }
            else
            {
                lblCpu.Text = cpuValue.ToString() + " % ";
            }
            // -----------------------------------------------------------------------------
            if (progressBarMEM.InvokeRequired)
            {
                progressBarMEM.Invoke(new Action(() => progressBarMEM.Value = memValue));
            }
            else
            {
                progressBarMEM.Value = memValue;
            }
            // -----------------------------------------------------------------------------
            if (lblMem.InvokeRequired)
            {
                lblMem.Invoke(new Action(() => lblMem.Text = memValue.ToString() + " % "));
            }
            else
            {
                lblMem.Text = memValue.ToString() + " % ";
            }
            // -----------------------------------------------------------------------------
            progressBarCPU.Value = cpuValue;
            progressBarMEM.Value = memValue;
        }
        private static int GetCpuValue()
        {
            var CpuCounter = new PerformanceCounter("Processor", " % Processor Time", "_Total");
            CpuCounter.NextValue();
            System.Threading.Thread.Sleep(1000);
            int returnvalue = (int)CpuCounter.NextValue();
            return returnvalue;
        }
        private static int GetMemValue()
        {
            var MemCounter = new PerformanceCounter("Processor", " % Processor Time", "_Total");
            int returnvalue = (int)MemCounter.NextValue();
            return returnvalue;

            //var MemCounter = new PerformanceCounter("Memory", "% Commited Bytes in Use");
            //int returnvalue = (int)MemCounter.NextValue();
            ///return returnvalue;
        }
        // przycisk 
        private void btn_Start_Click(object sender, EventArgs e)
        {
            if (startflag == false)
            {
                startflag = true;
                _timer.Enabled = true;
                btn_Start.Text = "STOP";
            }
            else
            {
                startflag = false;
                _timer.Enabled = false;
                btn_Start.Text = "START";
            }
        }
    }
}
