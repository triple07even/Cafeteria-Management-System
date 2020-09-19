using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;



namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public static int a = 0;
        public static string title, context, icon;
        public static bool showdialoG = false;
        Thread tt;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form1()
        {
            InitializeComponent();
            sidePanel.Height = homeBtn.Height;
            sidePanel.Top = homeBtn.Top;
            collection1.BringToFront();
            lockPanel();
            //txtPassword.Focus();
            tr();


        }
        public static string query = @"Data Source = .\SQLEXPRESS;Initial Catalog = FoodManager; Integrated Security = True";  // string MainData = "";
        public static string schoolName = "Adeleke University";                              //  @"Data Source = .\SQLSERVER;Initial Catalog = FoodManagerMain; Integrated Security = True";
        

        private void button3_Click(object sender, EventArgs e)
        {
            sidePanel.Height = homeBtn.Height;
            sidePanel.Top = homeBtn.Top;
            collection1.BringToFront();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sidePanel.Height = signupBtn.Height;
            sidePanel.Top = signupBtn.Top;
            signUp1.BringToFront();
            signUp1.display2();
        }

        private void manageBtn_Click(object sender, EventArgs e)
        {
            sidePanel.Height = manageBtn.Height;
            sidePanel.Top = manageBtn.Top;
            manage1.BringToFront();
            manage1.display();
        }

        private void settingBtn_Click(object sender, EventArgs e)
        {
            sidePanel.Height = settingBtn.Height;
            sidePanel.Top = settingBtn.Top;
            settings1.BringToFront();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (collection1.dntClose()) // | collection1.dntClose2())
            {
                e.Cancel = true;
                title = "Exiting Error";
                context = "Please ensure all port are closed before exiting";
                icon = "Warn";
                showdialoG = true;
                return;
            }
            tt.Abort();
            collection1.Collection_FormClosing();
            notifyIcon.Visible = false;
            notifyIcon.Icon = null;
            notifyIcon.Dispose();

        }

        private void unlock_btn_Click(object sender, EventArgs e)
        {
            lockPanel();
        }
        private void unlock()
        {
            //panel7.Hide();
            settingBtn.Enabled = true;
            homeBtn.Enabled = true;
            manageBtn.Enabled = true;
            signupBtn.Enabled = true;
            lock_btn.Enabled = true;
        }

        private void lockPanel()
        {
            //panel7.Show();
            settingBtn.Enabled = false;
            homeBtn.Enabled = false;
            manageBtn.Enabled = false;
            signupBtn.Enabled = false;
            lock_btn.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            //if (txtPassword.Text.Equals("15/0371"))
            //{
            //    unlock();
            //    txtPassword.Text = "";
            //    return;
            //}
            //else
            //{
            //    title = "Access Error";
            //    context = "Invalid Password";
            //    icon = "Warn";
            //    showdialoG = true;
            //}

        }

        private void btn_Close(object sender, EventArgs e)
        {

            Application.Exit();
        }

        int loop;
        private void Form1_SizeChanged(object sender, System.EventArgs e)
        {
            if (this.loop >= 2)
            {
                if (Form1.ActiveForm.WindowState != System.Windows.Forms.FormWindowState.Minimized)
                {
                    Form1.ActiveForm.WindowState = System.Windows.Forms.FormWindowState.Normal;
                }
            }
            else
                ++this.loop;

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void tr()
        {
            tt = new Thread(t =>
            {
                while (true)
                {
                    if (showdialoG)
                    {
                        if (icon.Equals("Info"))
                            notifyIcon.ShowBalloonTip(100, title, context, ToolTipIcon.Info);
                        if (icon.Equals("Warn"))
                            notifyIcon.ShowBalloonTip(100, title, context, ToolTipIcon.Warning);
                        if (icon.Equals("Error"))
                            notifyIcon.ShowBalloonTip(100, title, context, ToolTipIcon.Error);
                        showdialoG = false;
                    }
                }
            })
            { IsBackground = true };
            tt.Start();
        }
    }
}
