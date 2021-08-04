using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace Clutt4
{
    public partial class system32 : Form
    {
        private SoundPlayer _soundplayer;

        string msg1 = "5X554Ži2×";
        string msg2 = "Ô+!ÓÔšŐ";
        string msg3 = "DQń2!§JQ”jYî";
        string msg4 = "Aú	(Ań2Q67";
        string msg5 = "ĎµdĆÝ™¤ÇyqĹë";
        string msg6 = "ŔwýuQ>´‰SeČp";
        string msg7 = "đB«ĹßZ";
        string msg8 = "oąŔş¤źŽ6qý%žV";
        string msg9 = "Ômšv±§=";
        string msg10 = "b03f5f7f11d50a3aPADPADPBj";
        string msg11 = "€ľâĆe  0FÜx";
        string msg12 = "hdżxriŤő`Ű`ËĎ‘ J";
        string msg13 = "pmŔ;qşw›_oĐćŽ";
        string msg14 = "Ć]uÎâŹ %ÉwĚű";
        string msg15 = "ÉŃ¨±ľî€";
        string msg16 = "0Fy ĐWy ĐWśţ";
        string msg17 = "?ĎŇx?ŕ`8'˝çţ<0ĎoÁ";
        string msg18 = "0Śd&†xxm:;ěµpX@&†|řęŐ9Ź3A";
        string msg19 = "d}ąČśő×6ĂµĎ?ű8";
        string msg20 = "č+ÖN2  Ł< č+ÖŽ3  #Vs";
        public system32()
        {
            InitializeComponent();
            TopMost = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void system32_Load(object sender, EventArgs e)
        {
            wtf_msg.Start();
            _soundplayer = new SoundPlayer(@"C:\Windows\Media\Windows Critical Stop.wav");
            _soundplayer.Play();

        }

        private void wtf_msg_Tick(object sender, EventArgs e)
        {
            Random r;
            r = new Random();
            wtf_msg.Stop();

            int random_string = r.Next(21);
            if(random_string == 1)
            {
                label1.Text = msg1;
                Text = msg1;
            }
            if (random_string == 2)
            {
                label1.Text = msg2;
                Text = msg2;
            }
            if (random_string == 3)
            {
                label1.Text = msg3;
                Text = msg3;
            }
            if (random_string == 4)
            {
                label1.Text = msg4;
                Text = msg4;
            }
            if (random_string == 5)
            {
                label1.Text = msg5;
                Text = msg5;
            }
            if (random_string == 6)
            {
                label1.Text = msg6;
                Text = msg6;
            }
            if (random_string == 7)
            {
                label1.Text = msg7;
                Text = msg7;
            }
            if (random_string == 8)
            {
                label1.Text = msg8;
                Text = msg8;
            }
            if (random_string == 9)
            {
                label1.Text = msg9;
                Text = msg9;
            }
            if (random_string == 10)
            {
                label1.Text = msg10;
                Text = msg10;
            }
            if (random_string == 11)
            {
                label1.Text = msg11;
                Text = msg11;
            }
            if (random_string == 12)
            {
                label1.Text = msg12;
                Text = msg12;
            }
            if (random_string == 13)
            {
                label1.Text = msg13;
                Text = msg13;
            }
            if (random_string == 14)
            {
                label1.Text = msg14;
                Text = msg14;
            }
            if (random_string == 15)
            {
                label1.Text = msg15;
                Text = msg15;
            }
            if (random_string == 16)
            {
                label1.Text = msg16;
                Text = msg16;
            }
            if (random_string == 17)
            {
                label1.Text = msg17;
                Text = msg17;
            }
            if (random_string == 18)
            {
                label1.Text = msg18;
                Text = msg18;
            }
            if (random_string == 19)
            {
                label1.Text = msg19;
                Text = msg19;
            }
            if (random_string == 20)
            {
                label1.Text = msg20;
                Text = msg20;
            }
            wtf_msg.Start();
        }

        private void system32_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
