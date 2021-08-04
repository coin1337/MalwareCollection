namespace Clutt4
{
    partial class Payload_start
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payload_start));
            this.er1 = new System.Windows.Forms.PictureBox();
            this.er_shield = new System.Windows.Forms.PictureBox();
            this.war1 = new System.Windows.Forms.PictureBox();
            this.uac1 = new System.Windows.Forms.PictureBox();
            this.url = new System.Windows.Forms.Timer(this.components);
            this.wtf_msg = new System.Windows.Forms.Timer(this.components);
            this.invert_blink = new System.Windows.Forms.Timer(this.components);
            this.start_blink_invert = new System.Windows.Forms.Timer(this.components);
            this.mouse_draw_ikon = new System.Windows.Forms.Timer(this.components);
            this.time_to_rnd_icons = new System.Windows.Forms.Timer(this.components);
            this.rectangles = new System.Windows.Forms.Timer(this.components);
            this.beep_glitch = new System.Windows.Forms.Timer(this.components);
            this.normal_shake = new System.Windows.Forms.Timer(this.components);
            this.shake_invert = new System.Windows.Forms.Timer(this.components);
            this.dark_invert = new System.Windows.Forms.Timer(this.components);
            this.final_shake = new System.Windows.Forms.Timer(this.components);
            this.bsod_time = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.er1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_shield)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.war1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uac1)).BeginInit();
            this.SuspendLayout();
            // 
            // er1
            // 
            this.er1.Image = ((System.Drawing.Image)(resources.GetObject("er1.Image")));
            this.er1.Location = new System.Drawing.Point(2, 1);
            this.er1.Name = "er1";
            this.er1.Size = new System.Drawing.Size(30, 30);
            this.er1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.er1.TabIndex = 0;
            this.er1.TabStop = false;
            this.er1.Visible = false;
            // 
            // er_shield
            // 
            this.er_shield.Image = ((System.Drawing.Image)(resources.GetObject("er_shield.Image")));
            this.er_shield.Location = new System.Drawing.Point(38, 1);
            this.er_shield.Name = "er_shield";
            this.er_shield.Size = new System.Drawing.Size(30, 30);
            this.er_shield.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.er_shield.TabIndex = 1;
            this.er_shield.TabStop = false;
            this.er_shield.Visible = false;
            this.er_shield.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // war1
            // 
            this.war1.Image = ((System.Drawing.Image)(resources.GetObject("war1.Image")));
            this.war1.Location = new System.Drawing.Point(74, 1);
            this.war1.Name = "war1";
            this.war1.Size = new System.Drawing.Size(30, 30);
            this.war1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.war1.TabIndex = 2;
            this.war1.TabStop = false;
            this.war1.Visible = false;
            // 
            // uac1
            // 
            this.uac1.Image = ((System.Drawing.Image)(resources.GetObject("uac1.Image")));
            this.uac1.Location = new System.Drawing.Point(110, 1);
            this.uac1.Name = "uac1";
            this.uac1.Size = new System.Drawing.Size(30, 30);
            this.uac1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.uac1.TabIndex = 3;
            this.uac1.TabStop = false;
            this.uac1.Visible = false;
            // 
            // url
            // 
            this.url.Interval = 15000;
            this.url.Tick += new System.EventHandler(this.url_Tick);
            // 
            // wtf_msg
            // 
            this.wtf_msg.Interval = 300;
            this.wtf_msg.Tick += new System.EventHandler(this.wtf_msg_Tick);
            // 
            // invert_blink
            // 
            this.invert_blink.Interval = 3000;
            this.invert_blink.Tick += new System.EventHandler(this.invert_blink_Tick);
            // 
            // start_blink_invert
            // 
            this.start_blink_invert.Interval = 15000;
            this.start_blink_invert.Tick += new System.EventHandler(this.start_blink_invert_Tick);
            // 
            // mouse_draw_ikon
            // 
            this.mouse_draw_ikon.Tick += new System.EventHandler(this.mouse_draw_ikon_Tick);
            // 
            // time_to_rnd_icons
            // 
            this.time_to_rnd_icons.Interval = 15000;
            this.time_to_rnd_icons.Tick += new System.EventHandler(this.time_to_rnd_icons_Tick);
            // 
            // rectangles
            // 
            this.rectangles.Interval = 20000;
            this.rectangles.Tick += new System.EventHandler(this.rectangles_Tick);
            // 
            // beep_glitch
            // 
            this.beep_glitch.Interval = 500;
            this.beep_glitch.Tick += new System.EventHandler(this.beep_glitch_Tick);
            // 
            // normal_shake
            // 
            this.normal_shake.Interval = 30000;
            this.normal_shake.Tick += new System.EventHandler(this.normal_shake_Tick);
            // 
            // shake_invert
            // 
            this.shake_invert.Interval = 60000;
            this.shake_invert.Tick += new System.EventHandler(this.shake_invert_Tick);
            // 
            // dark_invert
            // 
            this.dark_invert.Interval = 60000;
            this.dark_invert.Tick += new System.EventHandler(this.dark_invert_Tick);
            // 
            // final_shake
            // 
            this.final_shake.Interval = 60000;
            this.final_shake.Tick += new System.EventHandler(this.final_shake_Tick);
            // 
            // bsod_time
            // 
            this.bsod_time.Interval = 80000;
            this.bsod_time.Tick += new System.EventHandler(this.bsod_time_Tick);
            // 
            // Payload_start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(151, 49);
            this.Controls.Add(this.uac1);
            this.Controls.Add(this.war1);
            this.Controls.Add(this.er_shield);
            this.Controls.Add(this.er1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Payload_start";
            this.Opacity = 0.01D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CLUTT4";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Payload_start_Load);
            ((System.ComponentModel.ISupportInitialize)(this.er1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.er_shield)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.war1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uac1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox er1;
        private System.Windows.Forms.PictureBox er_shield;
        private System.Windows.Forms.PictureBox war1;
        private System.Windows.Forms.PictureBox uac1;
        private System.Windows.Forms.Timer url;
        private System.Windows.Forms.Timer wtf_msg;
        private System.Windows.Forms.Timer invert_blink;
        private System.Windows.Forms.Timer start_blink_invert;
        private System.Windows.Forms.Timer mouse_draw_ikon;
        private System.Windows.Forms.Timer time_to_rnd_icons;
        private System.Windows.Forms.Timer rectangles;
        private System.Windows.Forms.Timer beep_glitch;
        private System.Windows.Forms.Timer normal_shake;
        private System.Windows.Forms.Timer shake_invert;
        private System.Windows.Forms.Timer dark_invert;
        private System.Windows.Forms.Timer final_shake;
        private System.Windows.Forms.Timer bsod_time;
    }
}