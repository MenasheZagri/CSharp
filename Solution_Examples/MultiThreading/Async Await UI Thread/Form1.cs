using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Method 1 - On the UI thread itself, release the thread using await
        private async void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 1000; i++)
            {
                label1.Text = i.ToString();
                await Task.Run(() => { Thread.Sleep(2); });
            }
        }

        //Method 2 - Calling a different thread using BeginInvoke
        private void button2_Click(object sender, EventArgs e)
        {
            Task.Run(() => { DoWork(); });
        }

        private void DoWork()
        {
            for (int i = 0; i <= 1000; i++)
            {
                Action action = () => { label2.Text = i.ToString(); };
                label2.BeginInvoke(action);
                Thread.Sleep(2);
            }
        }
    }
}
