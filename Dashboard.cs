using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace IMSR
{
    public partial class Dashboard : Form
    {
        private readonly object _Elapsed;

        public Dashboard()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            //System.Timers.Timer timer1 = new System.Timers.Timer();
            //timer1.Interval = 1000;
            //timer1.Elapsed += timer1 _Elapsed;
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckInForm checkInForm = new CheckInForm();
            checkInForm.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CheckOutForm checkOutForm = new CheckOutForm();
            checkOutForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CartonInfo cartonInfo = new CartonInfo();
            cartonInfo.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ledger ledger = new Ledger();
            ledger.ShowDialog();
        }
    }
}
