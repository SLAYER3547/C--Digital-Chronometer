using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Digitale_Chronometer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
           

        }
        int hour, minute, second, sls;

        private void yuvarlakButon3_Click(object sender, EventArgs e)
        {
            sls = 0;
            second = 0;
            minute = 0;
            hour = 0;
            label1.Text = "00:";
            label2.Text = "00:";
            label3.Text = "00 ,";
            label4.Text = "00";
            timer1.Stop();
        }



    

        private void yuvarlakButon4_Click(object sender, EventArgs e)
        {
            
         
            ListViewItem lvi = new ListViewItem();


            lvi.SubItems.Add(hour.ToString());
            lvi.SubItems.Add(minute.ToString());
            lvi.SubItems.Add(second.ToString());
           
            listView1.Items.Add(lvi);

        }

        private void yuvarlakButon2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sls++;
            label4.Text = sls.ToString();
            if (sls == 9)
            {
                sls = 0;
                second++;
                label3.Text = second.ToString();
            }
            if (second == 60)
            {
                second = 0;
                label3.Text = second.ToString();
                minute++;
                label2.Text = minute.ToString();

            }
            if (minute == 60)
            {
                minute = 0;
                label2.Text = minute.ToString();
                hour++;
                label1.Text = hour.ToString();
            }
        }

        private void yuvarlakButon1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }
    }
    
}
