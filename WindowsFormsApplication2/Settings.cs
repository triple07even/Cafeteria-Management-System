using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Settings : UserControl
    {

        public Settings()
        {
            InitializeComponent();
            radioButton1.Checked = true;
            radioButton6.Checked = true;
            foodTicket = days_enrolled_txtbox.Text;
            Image_string = imageTxt.Text;
        }
        private static string Image_string = null;
        private static string foodTicket = null;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                conText.Enabled = false;
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                collegeText.Enabled = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_nwString.Checked)
            {
                conText.Enabled = true;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_collegeText.Checked)
            {
                collegeText.Enabled = true;
            }
        }

        private void btnImgChange_Click(object sender, EventArgs e)
        {
            try
            {
                FileDialog fldlg = new OpenFileDialog();
                //specify your own initial directory
                fldlg.InitialDirectory = @":D\";
                //this will allow only those file extensions to be added
                fldlg.Filter = "Image File (*.jpg;*.bmp;*.gif;*.png; | *.jpg;*.bmp;*.gif;*.png; ";
                if (fldlg.ShowDialog() == DialogResult.OK)
                {
                    imageTxt.Text = fldlg.FileName;
                }
                fldlg = null;
            }
            catch (System.ArgumentException ae)
            {
                MessageBox.Show(ae.Message.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            Image_string = imageTxt.Text;
            if (rb_nwString.Checked)
            {
                Form1.query = conText.Text;
            }
            else
            {
                Form1.query = @"Data Source = .\SQLSERVER;Initial Catalog = FoodManager; Integrated Security = True";
            }

            if (rb_collegeText.Checked)
            {
                Form1.schoolName = collegeText.Text;
            }
            else
            {
                Form1.schoolName = "Adeleke University";
            }
            foodTicket = days_enrolled_txtbox.Text;
            popScreen("Database Alert", "Settings Saved", "Error");
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }
        public static string meals
        {
            get
            {
                return foodTicket;
            }
        }

        public static string image
        {
            get
            {
                return Image_string;
            }
        }
        public void popScreen(string title, string context, string icon)
        {
            Form1.title = title;
            Form1.context = context;
            Form1.icon = icon;
            Form1.showdialoG = true;
        }
    }
}
