using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private async void button1_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            while (true)
            {
                label1.Text = DateTime.Now.ToString();
                await Task.Run(() =>
                {
                    stopwatch.Start();
                    Thread.Sleep(100);
                    stopwatch.Stop();

                    label2.Invoke((MethodInvoker) (() =>
                    {
                        label2.Text = stopwatch.ElapsedMilliseconds.ToString();
                    }));

                    if (stopwatch.ElapsedMilliseconds % 2 == 0)
                    {
                        label1.ForeColor = Color.Chartreuse;
                    }
                    else
                    {
                        label1.ForeColor = Color.Blue;
                    }
                });
            }
        }
    }
}
