using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

using System.IO.Ports;
using System.IO;
using System.Data.SqlClient;

namespace WindowsFormsApplication2
{
    public partial class SignUp : UserControl
    {
        public SignUp()
        {
            InitializeComponent();
            display2();
            checkPhill();
            SerialSignUp();
            radioFalse.Select();
            date = DateTime.Today.ToLongDateString();
           // timer1.Start();
            //conn.Open();
            //string sql = @"DELETE FROM MainDataBase;";
            //SqlCommand cmd = new SqlCommand(sql, conn);
            //cmd.ExecuteNonQuery();
            //conn.Close();
            //  potRefresh();
        }

        private void signUpRefresh()
        {
            signUpBox.Items.AddRange(SerialPort.GetPortNames());
        }

        SqlConnection conn;
        foodCollectionQuery ffd;
        SerialPort signUp;
        SqlParameter picture = new SqlParameter("@Image", SqlDbType.Image);
        string MainData = "MainDataBase", signupUID = "";
        string imgLoc, date;
      
        public void display2()
        {
            try {
                conn = new SqlConnection(Form1.query);
                conn.Open();
                string sqlSelectQuery = string.Format("SELECT * FROM {0} ", MainData);
                SqlDataAdapter SDA = new SqlDataAdapter(sqlSelectQuery, Form1.query);
                DataTable dt = new DataTable();
                SDA.Fill(dt);
                maindataGridView.DataSource = dt;
                DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
                imgCol = (DataGridViewImageColumn)maindataGridView.Columns[2];
                imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
                maindataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dt.Dispose();
                conn.Close();
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                     if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private int returnTicket()
        {
            int ticket = 0;
            try
            {
                int aa = 0;
                if (boxPayment.Text == "Half")
                {
                    if (rb_2meals.Checked)
                        aa = Convert.ToInt16(days_enrolled_txtbox.Text) * 2;
                    if (rb_3meals.Checked)
                        aa = Convert.ToInt16(days_enrolled_txtbox.Text) * 3;
                }
                else if (boxPayment.Text == "Full")
                {
                    if (rb_2meals.Checked)
                        aa = Convert.ToInt16(days_enrolled_txtbox.Text) * 4;
                    if (rb_3meals.Checked)
                        aa = Convert.ToInt16(days_enrolled_txtbox.Text) * 6;
                }

                ticket = aa;
            }
            catch (Exception ex)
            {
                popScreen("Input Error", ex.Message, "Info");
            }

            return ticket;
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {           
            string hunt = null;
            string aa = null;
            if (boxPayment.Text == "Full" || boxPayment.Text == "Half")
            {
                aa = returnTicket().ToString();
            }

            else
            {
                return;
            }

            if (radioFalse.Checked)
                hunt = "False";
            if (radioTrue.Checked)
                hunt = "True";
           try {
                if (checkDB())
                {
                    popScreen("Database Alert", "Student informantion already exist", "Info");
                    return;
                }
                if (checkUID())
                {
                    popScreen("Database Alert", "Card information already exist", "Info");
                    return;
                }


                Image img = pictureBox1.Image;
                MemoryStream ms = new MemoryStream();
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] bytes = ms.ToArray();
               string sqlSelectQuery3 = "INSERT INTO "+ MainData + " VALUES (@SName, @OName, @Image, @Course, @UID, @Payment, @SchoolId, @IDMain, @Sex, @ManHuntP, @phili, @PhiliTicket);";
                using (SqlCommand Command = new SqlCommand(sqlSelectQuery3, conn))
                {
                    Command.Parameters.Add("@SName", SqlDbType.NVarChar, 50).Value = txtName.Text;
                    Command.Parameters.Add("@OName", SqlDbType.NVarChar, 50).Value = txtOtherNames.Text;
                    Command.Parameters.Add("@Image", SqlDbType.Image,bytes.Length).Value = bytes;
                    Command.Parameters.Add("@Course", SqlDbType.NVarChar,50).Value = boxDepartment.Text;
                    Command.Parameters.Add("@UID", SqlDbType.NVarChar, 50).Value = txtUID.Text;
                    Command.Parameters.Add("@Payment", SqlDbType.NVarChar, 10).Value = boxPayment.Text;
                    Command.Parameters.Add("@SchoolId", SqlDbType.NVarChar, 10).Value = txtMatricNumber.Text;
                    Command.Parameters.Add("@IDMain", SqlDbType.NVarChar, 10).Value = aa;
                    Command.Parameters.Add("@Sex", SqlDbType.NVarChar, 10).Value = bxSex.Text;
                    Command.Parameters.Add("@ManHuntP", SqlDbType.NVarChar, 10).Value = hunt;
                    Command.Parameters.Add("@phili", SqlDbType.NVarChar, 50).Value = "None";
                    Command.Parameters.Add("@PhiliTicket", SqlDbType.NVarChar, 10).Value = "0";
                    if (conn.State == ConnectionState.Closed)
                     conn.Open();

                    Command.ExecuteNonQuery();
                    conn.Close();
                    display2();
                    ffd = new foodCollectionQuery();
                    ffd.actSQL("New Registration", DateTime.Now.ToLongTimeString(), date, "Student registeration of Name: " + txtName.Text + " School ID:  " + txtMatricNumber.Text);
                    clearAll();
                    
                    popScreen("Database Alert", "Data has been entered Successful", "Info");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                popScreen("Database Error", ex.Message, "Warn");
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        public void popScreen(string title, string context, string icon)
        {
            Form1.title = title;
            Form1.context = context;
            Form1.icon = icon;
            Form1.showdialoG = true;
        }

        private void SerialSignUp()
        {
            signUp = new SerialPort();
            signUp.BaudRate = 9600;
            signUp.DataBits = 8;
            signUp.StopBits = StopBits.One;
            signUpBox.Items.AddRange(SerialPort.GetPortNames());
            signUp.DataReceived += signUp_DataReceived;
        }

        private void signUp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            signupUID = signUp.ReadLine();
           this.Invoke(new EventHandler(signup));
        }

        private void signup(object sender, EventArgs e)
        {
            txtUID.Text = signupUID.TrimEnd(System.Environment.NewLine.ToCharArray());
            
            }
        
        private void clearAll()
        {
            txtName.Clear();
            txtOtherNames.Clear();
            txtMatricNumber.Clear();
            txtUID.Clear();
            txtMatricNumber.Clear();
            boxDepartment.Text = "";
            radioFalse.Select();
            txtUID.Text = "";
            bxSex.Text = "";
            txtSearch.Text = "";
            boxPayment.Text = "";
            addTicket.Checked = false;
            ToTxt.Clear();
            fromTxt.Clear();
            sendTicket.Clear();
            textMass.Clear();
            pictureBox1.Image=null;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {        
            try {
                conn.Open();
                SqlDataAdapter adapt = new SqlDataAdapter("select * from "+ MainData +" where Name like '" + txtSearch.Text + "%'", conn);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                maindataGridView.DataSource = dt;
                DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
                imgCol = (DataGridViewImageColumn)maindataGridView.Columns[2];
                imgCol.ImageLayout = DataGridViewImageCellLayout.Normal;
                maindataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                conn.Close();
            }
            catch (Exception ex)
            {
                popScreen("Database Error", ex.Message, "Warn");
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                conn.Close();
            }
        }


        private void upGrade_Click(object sender, EventArgs e)
        {
            string varOld = null; int varNew = 0; int varUpdate = 0;
            try
            {
                conn = new SqlConnection(Form1.query);
                if (conn.State == ConnectionState.Closed)
                conn.Open();

                string sqlSelectQuery1 = string.Format("SELECT * FROM {0}", MainData);
                SqlDataAdapter SDA = new SqlDataAdapter(sqlSelectQuery1, Form1.query);
                DataTable dt = new DataTable();
                SDA.Fill(dt);
               
                foreach (DataRow dr in dt.Rows)
                {
                    varOld = (dr["IDMain"].ToString());
                    varNew = Convert.ToInt32(varOld);
                    try
                    {
                        varUpdate = Convert.ToInt32(textMass.Text);
                    }
                    catch (Exception ex)
                    {
                        popScreen("Database Alert", ex.Message, "Error");
                        return;
                    }
                    varNew = varNew + varUpdate;
                    string sqlquery = string.Format("Update {0} SET IDMain = '" + varNew.ToString() + "' where SchoolId = '" + (dr["SchoolId"].ToString()) + "'", MainData);
                    conn.Close();
                    SqlCommand cmd3 = new SqlCommand(sqlquery, conn);
                    conn.Open();
                    cmd3.CommandType = CommandType.Text;
                    cmd3.ExecuteNonQuery();
                }
                conn.Close();
                display2();
                popScreen("Database Alert", "Data has been deleted Successful", "Info");
                ffd = new foodCollectionQuery();
                ffd.actSQL("Mass Ticket Upgrade", DateTime.Now.ToLongTimeString(), date, "Mass Ticket update of " + textMass.Text );
                textMass.Text = "";
            }
            catch (Exception ex)
            {
                popScreen("Database Error", ex.Message, "Warn");
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private bool checkDB()
        {
            string sqlSelectQuery1 = string.Format("SELECT * FROM {0}", MainData);
            SqlDataAdapter SDA = new SqlDataAdapter(sqlSelectQuery1, Form1.query);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                if(txtName.Text.Equals((dr["SchoolId"].ToString())) && boxDepartment.Text.Equals((dr["Course"].ToString()))){
                    return true;
                }
                if ((txtName.Text.Equals((dr["Sname"].ToString())) && txtOtherNames.Text.Equals((dr["Oname"].ToString()))))
                    return true;

            }
            return false;
        }

        private bool checkUID()
        {
            string sqlSelectQuery1 = string.Format("SELECT * FROM {0}", MainData);
            SqlDataAdapter SDA = new SqlDataAdapter(sqlSelectQuery1, Form1.query);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                if (txtUID.Text.Equals((dr["UID"].ToString())))
                    return true;                
            }
            return false;
        }

        private void downGrade_Click_1(object sender, EventArgs e)
        { 
            string varOld = null; int varNew = 0, varC = 0; int varUpdate = 0;
            try {
                conn = new SqlConnection(Form1.query);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                string sqlSelectQuery1 = string.Format("SELECT * FROM {0}", MainData);
                SqlDataAdapter SDA = new SqlDataAdapter(sqlSelectQuery1, Form1.query);
                DataTable dt = new DataTable();
                SDA.Fill(dt);
                foreach(DataRow dr in dt.Rows)
                {
                    varC = Convert.ToInt32((dr["IDMain"].ToString()));
                    try
                    {
                        varUpdate = Convert.ToInt32(textMass.Text);
                        varC = varC - varUpdate;
                        if(varC > 0)
                        {
                            popScreen("Database Alert", "Invalid downgrade value, input is negative", "Warn");
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        popScreen("Database Alert", ex.Message, "Error");
                        return;
                    }
                }
                foreach (DataRow dr in dt.Rows)
                {
                    varOld = (dr["IDMain"].ToString());
                    varNew = Convert.ToInt32(varOld);
                    try
                    {
                        varUpdate = Convert.ToInt32(textMass.Text);
                    }
                    catch (Exception ex)
                    {
                        popScreen("Database Alert", ex.Message, "Error");
                        return;
                    }
                    varNew = varNew - varUpdate;
                    string sqlquery = string.Format("Update {0} SET IDMain = '" + varNew.ToString() + "' where SchoolId = '" + (dr["SchoolId"].ToString()) + "'", "MainDataBase");
                    conn.Close();
                    SqlCommand cmd3 = new SqlCommand(sqlquery, conn);
                    conn.Open();
                    cmd3.CommandType = CommandType.Text;
                    cmd3.ExecuteNonQuery();
                }
                conn.Close();
                display2();
                ffd = new foodCollectionQuery();
                ffd.actSQL("Mass Ticket Downgrade", DateTime.Now.ToLongTimeString(), date, "Ticket upgrade from" + textMass.Text);
                textMass.Text = "";
                popScreen("Database Alert", "Data has been Updated Successful", "Info");
            }
            catch (Exception ex)
            {
                popScreen("Database Error", ex.Message, "Warn");
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //if (conn.State == ConnectionState.Open)
            //    conn.Close();
            try
            {
                if (maindataGridView.SelectedRows.Count > 0) // make sure user select at least 1 row 
                {
                    txtName.Text = maindataGridView.SelectedRows[0].Cells[0].Value + string.Empty;
                    txtOtherNames.Text = maindataGridView.SelectedRows[0].Cells[1].Value + string.Empty;
                    boxDepartment.Text = maindataGridView.SelectedRows[0].Cells[3].Value + string.Empty;
                     txtUID.Text = maindataGridView.SelectedRows[0].Cells[4].Value + string.Empty;
                     boxPayment.Text = maindataGridView.SelectedRows[0].Cells[5].Value + string.Empty;
                     txtMatricNumber.Text = maindataGridView.SelectedRows[0].Cells[6].Value + string.Empty;
                     bxSex.Text   = maindataGridView.SelectedRows[0].Cells[8].Value + string.Empty;
                    string hunt = maindataGridView.SelectedRows[0].Cells[9].Value + string.Empty;
                    if (hunt.Equals("False"))
                        radioFalse.Select();
                    if (hunt.Equals("True"))
                        radioTrue.Select();
            Byte[] img = (Byte[])maindataGridView.CurrentRow.Cells[2].Value;
            MemoryStream ms = new MemoryStream(img);
             pictureBox1.Image = System.Drawing.Image.FromStream(ms);

                }
            }
            catch (Exception ex)
            {
                popScreen("Database Error", ex.Message, "Warn");
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
       }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Image img = pictureBox1.Image;
                MemoryStream ms = new MemoryStream();
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] bytes = ms.ToArray();

                if (conn.State == ConnectionState.Open)
                    conn.Close();

                if (txtName.Text.Equals(""))
                    return;
                string aa = "0", idTemp = "", ab = ""; bool upda = false;
                try
                {
                    string paymentQuery = null, hunt = null;
                    if (radioFalse.Checked)
                        hunt = "False";
                    if (radioTrue.Checked)
                        hunt = "True";
                    conn = new SqlConnection(Form1.query);
                    if (boxPayment.Text == "Full" && addTicket.Checked)
                    {
                        conn.Open();

                        paymentQuery = string.Format("select * from " + MainData + " where SchoolId like '" + txtMatricNumber.Text + "%'");
                        SqlCommand cmd = new SqlCommand(paymentQuery, conn);
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            int a = 0;
                            idTemp = (dr["IDMain"].ToString());
                            ab = (dr["Payment"].ToString());
                            a = Convert.ToInt32(idTemp);

                            if (ab == "Half")
                            {
                                conn.Close();
                                a = a + 4;
                                aa = a.ToString();

                                string sqlSelectQuery3 = "UPDATE " + MainData + " SET SName=@SName, OName=@OName, Image=@Image, Course=@Course, UID=@UID, Payment=@Payment, SchoolId=@SchoolId, IDMain=@IDMain, Sex=@Sex, ManHuntP=@ManHuntP WHERE SchoolId = @SchoolId";
                                using (SqlCommand Command = new SqlCommand(sqlSelectQuery3, conn))
                                {
                                    Command.Parameters.Add("@SName", SqlDbType.NVarChar, 50).Value = txtName.Text;
                                    Command.Parameters.Add("@OName", SqlDbType.NVarChar, 50).Value = txtOtherNames.Text;
                                    Command.Parameters.Add("@Image", SqlDbType.Image, bytes.Length).Value = bytes;
                                    Command.Parameters.Add("@Course", SqlDbType.NVarChar, 50).Value = boxDepartment.Text;
                                    Command.Parameters.Add("@UID", SqlDbType.NVarChar, 50).Value = txtUID.Text;
                                    Command.Parameters.Add("@Payment", SqlDbType.NVarChar, 10).Value = boxPayment.Text;
                                    Command.Parameters.Add("@SchoolId", SqlDbType.NVarChar, 10).Value = txtMatricNumber.Text;
                                    Command.Parameters.Add("@IDMain", SqlDbType.NVarChar, 10).Value = aa;
                                    Command.Parameters.Add("@Sex", SqlDbType.NVarChar, 10).Value = bxSex.Text;
                                    Command.Parameters.Add("@ManHuntP", SqlDbType.NVarChar, 10).Value = hunt;
                                    conn.Open();
                                    Command.ExecuteNonQuery();
                                    conn.Close();
                                }
                                clearAll();
                                Console.WriteLine("Half");
                                upda = true;
                            }
                        }
                    }

                    else if (boxPayment.Text == "Half" && addTicket.Checked)
                    {
                        conn.Open();
                        paymentQuery = string.Format("select * from " + MainData + " where SchoolId like '" + txtOtherNames.Text + "%'");
                        SqlCommand cmd = new SqlCommand(paymentQuery, conn);
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            int a = 0;
                            idTemp = (dr["IDMain"].ToString());
                            ab = (dr["Payment"].ToString());
                            a = Convert.ToInt32(idTemp);

                            if (ab == "Full")
                            {
                                conn.Close();
                                a = a + 8;
                                aa = a.ToString();
                                string sqlSelectQuery3 = "UPDATE " + MainData + " SET SName=@SName,OName=@OName, Image=@Image, Course=@Course, UID=@UID, Payment=@Payment, SchoolId=@SchoolId, IDMain=@IDMain, Sex=@Sex, ManHuntP=@ManHuntP WHERE SchoolId = @SchoolId";
                                using (SqlCommand Command = new SqlCommand(sqlSelectQuery3, conn))
                                {
                                    Command.Parameters.Add("@SName", SqlDbType.NVarChar, 50).Value = txtName.Text;
                                    Command.Parameters.Add("@OName", SqlDbType.NVarChar, 50).Value = txtOtherNames.Text;
                                    Command.Parameters.Add("@Image", SqlDbType.Image, bytes.Length).Value = bytes;
                                    Command.Parameters.Add("@Course", SqlDbType.NVarChar, 50).Value = boxDepartment.Text;
                                    Command.Parameters.Add("@UID", SqlDbType.NVarChar, 50).Value = txtUID.Text;
                                    Command.Parameters.Add("@Payment", SqlDbType.NVarChar, 10).Value = boxPayment.Text;
                                    Command.Parameters.Add("@SchoolId", SqlDbType.NVarChar, 10).Value = txtMatricNumber.Text;
                                    Command.Parameters.Add("@IDMain", SqlDbType.NVarChar, 10).Value = aa;
                                    Command.Parameters.Add("@Sex", SqlDbType.NVarChar, 10).Value = bxSex.Text;
                                    Command.Parameters.Add("@ManHuntP", SqlDbType.NVarChar, 10).Value = hunt;
                                    conn.Open();
                                    Command.ExecuteNonQuery();
                                    conn.Close();
                                }
                                clearAll();
                                Console.WriteLine("Full");
                                upda = true;
                            }
                        }
                    }
                    else
                    {

                        string sqlquery = string.Format("Update {0} SET Name = '" + txtName.Text + "', Image = '" + bytes + "', UID='" + txtUID.Text + "' , SchoolId='" + txtMatricNumber.Text + "', Course='" + boxDepartment.Text + "', ManHuntP='" + hunt + "', Sex='" + bxSex.Text + "' where Name = '" + txtName.Text + "'", MainData);
                        string sqlSelectQuery3 = "UPDATE " + MainData + " SET SName=@SName, OName=@OName, Image=@Image, Course=@Course, UID=@UID, SchoolId=@SchoolId, Sex=@Sex, ManHuntP=@ManHuntP WHERE SchoolId = @SchoolId";

                        using (SqlCommand Command = new SqlCommand(sqlSelectQuery3, conn))
                        {
                            Command.Parameters.Add("@SName", SqlDbType.NVarChar, 50).Value = txtName.Text;
                            Command.Parameters.Add("@OName", SqlDbType.NVarChar, 50).Value = txtOtherNames.Text;
                            Command.Parameters.Add("@Image", SqlDbType.Image, bytes.Length).Value = bytes;
                            Command.Parameters.Add("@Course", SqlDbType.NVarChar, 50).Value = boxDepartment.Text;
                            Command.Parameters.Add("@UID", SqlDbType.NVarChar, 50).Value = txtUID.Text;
                            Command.Parameters.Add("@SchoolId", SqlDbType.NVarChar, 10).Value = txtMatricNumber.Text;
                            Command.Parameters.Add("@Sex", SqlDbType.NVarChar, 10).Value = bxSex.Text;
                            Command.Parameters.Add("@ManHuntP", SqlDbType.NVarChar, 10).Value = hunt;
                            conn.Open();
                            Command.ExecuteNonQuery();
                            conn.Close();
                        }
                        upda = true;
                    }
                    display2();
                }
                catch (Exception ex)
                {
                    popScreen("Database Error", ex.Message, "Warn");
                }
                if (upda)
                {
                    popScreen("Database Alert", "Database has been updated Successful", "Info");
                    ffd = new foodCollectionQuery();
                    ffd.actSQL(txtMatricNumber.Text, DateTime.Now.ToLongTimeString(), date, "Student updated bio data");
                    clearAll();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            }

        private void btnNew_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            try
            {
                if (MessageBox.Show("Are you sure", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // mainDataBaseBindingSource.RemoveCurrent();
                    if (maindataGridView.SelectedRows.Count > 0) // make sure user select at least 1 row 
                    {
                        string name = maindataGridView.SelectedRows[6].Cells[0].Value + string.Empty;
                        conn.Open();
                        string sqlquery = string.Format("delete " + MainData + " where SchoolId = '" + name + "'");
                        SqlCommand cmd = new SqlCommand(sqlquery, conn);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        //clearAll();
                        display2();
                        popScreen("Database Alert", "Data has been deleted Successful", "Info");
                        ffd = new foodCollectionQuery();
                        ffd.actSQL("Delected Data", DateTime.Now.ToLongTimeString(), date, name);
                    }
                }
            }
            catch (Exception ex)
            {
                popScreen("Database Error", ex.Message, "Warn");

            }
        }


        private void maindataGridView_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            try {
                if (e.KeyChar == (char)13)
                {
                    if (MessageBox.Show("Are you sure", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (maindataGridView.SelectedRows.Count > 0) // make sure user select at least 1 row 
                        {
                            string name = maindataGridView.SelectedRows[6].Cells[0].Value + string.Empty;
                            conn.Open();
                            string sqlquery = string.Format("delete  " + MainData + "  where SchoolId = '" + name + "'");
                            SqlCommand cmd = new SqlCommand(sqlquery, conn);
                            cmd.ExecuteNonQuery();
                            conn.Close();
                            //clearAll();
                            display2();
                            popScreen("Database Alert", "Data has been deleted Successful", "Info");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                popScreen("Database Error", ex.Message, "Warn");
            }
        }

        private void fromTxt_TextChanged(object sender, EventArgs e)
        {
          
            if (conn.State == ConnectionState.Open)
                conn.Close();
            try
            {
                conn.Open();
                SqlDataAdapter adapt = new SqlDataAdapter("select * from " + MainData + " where SchoolId like '" + fromTxt.Text + "%'", conn);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                maindataGridView.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                popScreen("Database Error", ex.Message, "Warn");
            }
        }

        private void ToTxt_TextChanged(object sender, EventArgs e)
        {          
            if (conn.State == ConnectionState.Open)
                conn.Close();
            try
            {
                conn.Open();
                SqlDataAdapter adapt = new SqlDataAdapter("select * from "+ MainData+" where SchoolId like '" + ToTxt.Text + "%'", conn);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                maindataGridView.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                popScreen("Database Error", ex.Message, "Warn");
            }
        }

        private void transferBtn_Click(object sender, EventArgs e)
        {
            int senda = 0, tranfer = 0, NewReciever = 0, NewSenda = 0;
            string snd = null;
            int reciever = 0;
            try
            {
                try
                {
                    tranfer = Int32.Parse(sendTicket.Text);
                }
                catch (Exception ex)
                {
                    popScreen("Transfer Error", "Invalid Number \n" + ex.Message, "Warn");
                    return;
                }
                conn.Open();
                string sqlSelectQuery1 = string.Format("SELECT * FROM {0} WHERE SchoolId = '" + fromTxt.Text + "'", MainData);
                SqlCommand cmd = new SqlCommand(sqlSelectQuery1, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    senda = Int32.Parse((dr["IDMain"].ToString()));
                    snd = (dr["SchoolId"].ToString());
                    conn.Close();

                    if (senda == 0 || senda <= tranfer)
                    {
                        popScreen("Transfer Error", " Not enongh ticket from Philanthrophist \n Please Verify School ID", "Warn");
                        return;
                    }
                    conn.Open();
                    string sqlSelectQuery2 = string.Format("SELECT * FROM {0} WHERE SchoolId = '" + ToTxt.Text + "'", MainData);
                    SqlCommand cmd2 = new SqlCommand(sqlSelectQuery2, conn);
                    SqlDataReader dr2 = cmd2.ExecuteReader();
                    if (dr2.Read())
                    {
                        reciever = Int32.Parse((dr2["PhiliTicket"].ToString()));
                       
                    }
                    else
                    {
                        popScreen("Transfer Error", "Invalid Receiver \n Please Verify School ID", "Warn");
                        conn.Close();
                        return;
                    }
                    conn.Close();
                    NewReciever = reciever + tranfer;
                    NewSenda = senda - tranfer;
                    conn.Open();
                    string sqlquery = string.Format("Update {0} SET PhiliTicket ='" + NewReciever.ToString() + "', Phili = '"+snd+"'  where SchoolId = '" + ToTxt.Text + "'", "MainDataBase");
                    SqlDataAdapter adapt = new SqlDataAdapter(string.Format("select * from " + MainData + " where SchoolId like '" + ToTxt.Text + "%'"), conn);
                    cmd = new SqlCommand(sqlquery, conn);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    conn.Open();
                    string sqlquery3 = string.Format("Update {0} SET IDMain ='" + NewSenda.ToString() + "'  where SchoolId = '" + fromTxt.Text + "'", "MainDataBase");
                    SqlDataAdapter adapt2 = new SqlDataAdapter(string.Format("select * from " + MainData + " where SchoolId like '" + fromTxt.Text + "%'"), conn);
                    cmd2 = new SqlCommand(sqlquery3, conn);
                    cmd2.CommandType = CommandType.Text;
                    cmd2.ExecuteNonQuery();
                    conn.Close();
                }
                else
                {
                    popScreen("Transfer Error", "Invalid Philanthrophist \n Please Verify School ID", "Warn");
                    return;
                }
                Console.WriteLine("Updated");
                popScreen("Database Alert", "Database has been updated Successful", "Info");
                ffd = new foodCollectionQuery();
                ffd.actSQL("Ticket Transfer", DateTime.Now.ToLongTimeString(), date, "Ticket transfer from " + fromTxt.Text + " to " + ToTxt.Text);
                clearAll();
                display2();
            }
            catch(Exception ex)
                {
                popScreen("Transfer Error",  ex.Message, "Warn");
                return;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private void checkPhill()
        {
         //   return;
           int varNew ; int varUpdate = 0; string phillName = "", id;
            try
            {
                conn = new SqlConnection(Form1.query);
                conn.Open();
                string sqlSelectQuery = string.Format("SELECT * FROM {0}", MainData);
                SqlDataAdapter SDA = new SqlDataAdapter(sqlSelectQuery, Form1.query);
                DataTable dt = new DataTable();
                SDA.Fill(dt);
                 foreach (DataRow dr in dt.Rows)
                {
                    varNew = 0;
                    try
                    {
                        phillName = (dr["Phili"].ToString());
                        varNew = Convert.ToInt32((dr["PhiliTicket"].ToString()));
                        id = (dr["SchoolId"].ToString());
                    }
                    catch {
                        return;
                    }

                    if (varNew == 0)
                    {
                        if(!phillName.Equals("None"))
                    {
                            conn.Close();
                            conn.Open();
                        string sqlquery = string.Format("Update MainDataBase SET Phili = '" + "None" + "' where SchoolId = '" + id + "'");
                        SqlCommand cmd3 = new SqlCommand(sqlquery, conn);
                        cmd3.CommandType = CommandType.Text;
                        cmd3.ExecuteNonQuery();
                        varUpdate++;
                    }
                  }
                    if (varUpdate == 1)
                        popScreen("Database Alert", "Only " + varUpdate + " student data has been updated Successfully", "Info");

                    if (varUpdate > 1)
                        popScreen("Database Alert", varUpdate + " students data has been updated Successfully", "Info");
                   // Console.WriteLine("Check");
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                popScreen("Database Alert", ex.Message, "Info");
                return;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
        private void camCapture_Click(object sender, EventArgs e)
        {
         try
            {
                FileDialog fldlg = new OpenFileDialog();
                //specify your own initial directory
                fldlg.InitialDirectory = @":D\";
                //this will allow only those file extensions to be added
                fldlg.Filter = "Image File (*.jpg;*.bmp;*.gif;*.png)|*.jpg;*.bmp;*.gif;*.png";
                fldlg.Title = "Select Student Image";
                if (fldlg.ShowDialog() == DialogResult.OK)
                {
                    imgLoc = fldlg.FileName.ToString();
                    pictureBox1.ImageLocation = imgLoc;
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

        bool connectO1 = false;

        private void txtUID_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
           
        }

        private void signUpBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void SignUp_Enter(object sender, EventArgs e)
        {
            Console.WriteLine("Starting");
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            signUpBox.Items.AddRange(SerialPort.GetPortNames());
        }

        private void uidSignup_Click(object sender, EventArgs e)
        {
            if (connectO1)
            {
                try
                {
                    signUp.Close();
                    Console.WriteLine("Outlet One Disconnected");
                    connectO1 = false;
                    uidSignup.Text = "Scan";
                }
                catch (Exception ex)
                {
                    popScreen("Sign Up Error", ex.Message, "Error");
                }
            }
            else
            {
                try
                {
                    signUp.PortName = signUpBox.Text;
                    signUp.Open();
                    Console.WriteLine("Outlet One Ready");
                    connectO1 = true;
                    uidSignup.Text = "Disconnect";
                }
                catch (Exception ex)
                {
                    popScreen("UID Connection Error", ex.Message, "Error");
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
