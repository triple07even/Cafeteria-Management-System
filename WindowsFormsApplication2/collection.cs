using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO.Ports;
using System.IO;
using System.Data.SqlClient;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace WindowsFormsApplication2
{
    public partial class collection : UserControl
    {
        public collection()
        {
            InitializeComponent();
            display();
           // popScreen("Welcome", "In partial fullfilment for something great", "Info");

            Console.WriteLine(DateTime.Today);
            Console.WriteLine(Environment.MachineName);
            date = DateTime.Today.ToLongDateString();
            Serial1Init(); Serial5Init();
            Serial2Init(); Serial6Init();
            Serial3Init(); Serial7Init();
            Serial4Init(); Serial8Init();
            txtOther.Enabled = false;
            Console.WriteLine(@"C:\Users\" + Environment.UserName + @"\Desktop\.pdf");
           startTime = DateTime.Now.ToLongTimeString();
        }
        SqlConnection conn; foodCollectionQuery ffd;
        SerialPort outlet1, outlet2, outlet3, outlet4, outlet5, outlet6, outlet7, outlet8;
        int c1 = 0, c2 = 0, c3 = 0, c4 = 0, c5 = 0, c6 = 0, c7 = 0, c8 = 0;
        string in1, in2, in3, in4, in5, in6, in7, in8;
        public string date, startTime, MainData = "MainDataBase";

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            try
            {
                conn.Open();
                SqlDataAdapter adapt = new SqlDataAdapter("select * from " + MainData + " where SchoolId like '" + searchBox.Text + "%'", conn);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                popScreen("Database Error", ex.Message, "Warn");
            }
        }

        private void Serial1Init()
        {
            outlet1 = new SerialPort();
            outlet1.BaudRate = 9600;
            outlet1.DataBits = 8;
            outlet1.StopBits = StopBits.One;
            portBox1.Items.AddRange(SerialPort.GetPortNames());
            outlet1.DataReceived += outlet1_DataReceived;
        }

        private void Serial2Init()
        {
            outlet2 = new SerialPort();
            outlet2.BaudRate = 9600;
            outlet2.DataBits = 8;
            outlet2.StopBits = StopBits.One;
            portBox2.Items.AddRange(SerialPort.GetPortNames());
            outlet2.DataReceived += outlet2_DataReceived;
        }

        private void Serial3Init()
        {
            outlet3 = new SerialPort();
            outlet3.BaudRate = 9600;
            outlet3.DataBits = 8;
            outlet3.StopBits = StopBits.One;
            portBox3.Items.AddRange(SerialPort.GetPortNames());
            outlet3.DataReceived += outlet3_DataReceived;
        }

        private void Serial4Init()
        {
            outlet4 = new SerialPort();
            outlet4.BaudRate = 9600;
            outlet4.DataBits = 8;
            outlet4.StopBits = StopBits.One;
            portBox4.Items.AddRange(SerialPort.GetPortNames());
            outlet4.DataReceived += outlet4_DataReceived;
        }

        /// <summary>
        /// 5 to 8
        /// </summary>

        private void Serial5Init()
        {
            outlet5 = new SerialPort();
            outlet5.BaudRate = 9600;
            outlet5.DataBits = 8;
            outlet5.StopBits = StopBits.One;
            portBox5.Items.AddRange(SerialPort.GetPortNames());
            outlet5.DataReceived += outlet5_DataReceived;
        }

        private void Serial6Init()
        {
            outlet6 = new SerialPort();
            outlet6.BaudRate = 9600;
            outlet6.DataBits = 8;
            outlet6.StopBits = StopBits.One;
            portBox6.Items.AddRange(SerialPort.GetPortNames());
            outlet6.DataReceived += outlet6_DataReceived;
        }

        private void Serial7Init()
        {
            outlet7 = new SerialPort();
            outlet7.BaudRate = 9600;
            outlet7.DataBits = 8;
            outlet7.StopBits = StopBits.One;
            portBox7.Items.AddRange(SerialPort.GetPortNames());
            outlet7.DataReceived += outlet7_DataReceived;
        }

        private void Serial8Init()
        {
            outlet8 = new SerialPort();
            outlet8.BaudRate = 9600;
            outlet8.DataBits = 8;
            outlet8.StopBits = StopBits.One;
            portBox8.Items.AddRange(SerialPort.GetPortNames());
            outlet8.DataReceived += outlet8_DataReceived;
        }


        bool insearch1 = false, insearch2 = false,insearch3 = false, insearch4 = false, insearch5 = false, insearch6 = false, insearch7 = false, insearch8 = false;
        private void outlet1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (insearch1) return;
            in1 = outlet1.ReadLine(); Console.WriteLine(in1);
            this.Invoke(new EventHandler(outlet1Check));
        }

        private void outlet2_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (insearch2) return;
            in2 = outlet2.ReadLine(); //Console.WriteLine(incoming2); return;
            this.Invoke(new EventHandler(outlet2Check));
        }
        private void outlet3_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (insearch3) return;
            in3 = outlet3.ReadLine(); Console.WriteLine(in3);
            this.Invoke(new EventHandler(outlet3Check));
        }

        private void outlet4_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (insearch4) return;
            in4 = outlet4.ReadLine(); Console.WriteLine(in1);
            this.Invoke(new EventHandler(outlet4Check));
        }

        /// <summary>
        /// 5 to 8
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void outlet5_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (insearch5) return;
            in5 = outlet5.ReadLine(); Console.WriteLine(in6);
            this.Invoke(new EventHandler(outlet5Check));
        }

        private void outlet6_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (insearch6) return;

            in6 = outlet6.ReadLine(); //Console.WriteLine(incoming2); return;
            this.Invoke(new EventHandler(outlet6Check));
        }

        private void outlet7_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (insearch7) return;
            in7 = outlet7.ReadLine(); Console.WriteLine(in3);
            this.Invoke(new EventHandler(outlet7Check));
        }

        private void outlet8_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (insearch8) return;
            in8 = outlet8.ReadLine(); Console.WriteLine(in8);
            this.Invoke(new EventHandler(outlet8Check));
        }

        private void t1_btn_Click(object sender, EventArgs e)
        {
            try {
                outlet1.WriteLine("mf5");
            }
            catch { }
        }
        private void t2_btn_Click(object sender, EventArgs e)
        {
            try
            {
                outlet2.WriteLine("mf5");
            }
            catch { }
        }
        private void t3_btn_Click(object sender, EventArgs e)
        {
            try
            {
                outlet3.WriteLine("mf5");
            }
            catch { }
        }
        private void t4_btn_Click(object sender, EventArgs e)
        {
            try
            {
                outlet4.WriteLine("mf5");
            }
            catch { }
        }
        private void t5_btn_Click(object sender, EventArgs e)
        {
            try
            {
                outlet5.WriteLine("mf5");
            }
            catch { }
        }
        private void t6_btn_Click(object sender, EventArgs e)
        {
            try
            {
                outlet6.WriteLine("mf5");
            }
            catch { }
        }
        private void t7_btn_Click(object sender, EventArgs e)
        {
            try
            {
                outlet7.WriteLine("mf5");
            }
            catch { }
        }
        private void t8_btn_Click(object sender, EventArgs e)
        {
            try
            {
                outlet8.WriteLine("mf5");
            }
            catch { }
        }


        private void outlet1Check(object sender, EventArgs e)
        {
            insearch1 = true;
            uidOutlet1.Text = in1.TrimEnd(System.Environment.NewLine.ToCharArray());
            if (OutSelect1.Text == "")
            {
                popScreen("Attention", "Enter Server One name", "Warn");
                return;
            }
            foodCollectionQuery fc1 = new foodCollectionQuery();
           fc1.call(uidOutlet1.Text, "1 : "+ OutSelect1.Text, Form1.query);
            IdLabel1.Text = fc1.IdLabel;
            nameLabel1.Text = fc1.nameLabel;
            statusLabel1.Text = fc1.statusLabel;
            outlet1.WriteLine(fc1.state);
            
           if (fc1.picData) {
                try
                {
                    MemoryStream mem = new MemoryStream(fc1.picDatamain);
                    pictureBox1.Image = System.Drawing.Image.FromStream(mem);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                pictureBox1.Image = null;
            }
        
        if (fc1.statsCount)
            {
                c1++;
                count1.Text = "Count: " + c1.ToString();
            }
            if (fc1.errorCheck)
            {
                popScreen("Attention", fc1.error, "Error");         
            }
            insearch1 = false;
            display();
            return;
        }
        private void outlet2Check(object sender, EventArgs e)
        {
            insearch2 = true;
            uidOutlet2.Text = in2.TrimEnd(System.Environment.NewLine.ToCharArray());
          
            foodCollectionQuery fc1 = new foodCollectionQuery();
            fc1.call(uidOutlet2.Text, "2 : " + OutSelect2.Text, Form1.query);
            IdLabel2.Text = fc1.IdLabel;
            nameLabel2.Text = fc1.nameLabel;
            statusLabel2.Text = fc1.statusLabel;
            outlet2.WriteLine(fc1.state);
            if (fc1.picData)
            {
                try
                {
                    MemoryStream mem = new MemoryStream(fc1.picDatamain);
                    pictureBox2.Image = System.Drawing.Image.FromStream(mem);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                pictureBox2.Image = null;
            }
            if (fc1.statsCount)
            {
                c2++;
                count2.Text = "Count: " + c2.ToString();
            }
            if (fc1.errorCheck)
            {
                popScreen("Attention", fc1.error, "Error");
            }

            insearch2 = false;
            display();
            return;
        }

        private void outlet3Check(object sender, EventArgs e)
        {
            insearch3 = true;
            uidOutlet3.Text = in3.TrimEnd(System.Environment.NewLine.ToCharArray());
            foodCollectionQuery fc = new foodCollectionQuery();
            fc.call(uidOutlet3.Text, "3: " + OutSelect3.Text, Form1.query);
            IdLabel3.Text = fc.IdLabel;
            nameLabel3.Text = fc.nameLabel;
            statusLabel3.Text = fc.statusLabel;
            outlet3.WriteLine(fc.state);
            if (fc.picData)
            {
                try
                {
                    MemoryStream mem = new MemoryStream(fc.picDatamain);
                    pictureBox3.Image = System.Drawing.Image.FromStream(mem);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                pictureBox3.Image = null;
            }

            if (fc.statsCount)
            {
                c3++;
                count3.Text = "Count: " + c3.ToString();
            }
            if (fc.errorCheck)
            {
                popScreen("Attention", fc.error, "Error");

            }
            insearch3 = false;
            display();
        }


        private void outlet4Check(object sender, EventArgs e)
        {
            insearch4 = true;
            uidOutlet4.Text = in4.TrimEnd(System.Environment.NewLine.ToCharArray());
            if (OutSelect4.Text == "")
            {
                popScreen("Attention", "Enter Server Four name", "Warn");
                return;
            }
            foodCollectionQuery fc = new foodCollectionQuery();
            fc.call(uidOutlet4.Text, "4 : " + OutSelect1.Text, Form1.query);
            IdLabel4.Text = fc.IdLabel;
            nameLabel4.Text = fc.nameLabel;
            statusLabel4.Text = fc.statusLabel;
            outlet4.WriteLine(fc.state);

            if (fc.picData)
            {
                try
                {
                    MemoryStream mem = new MemoryStream(fc.picDatamain);
                    pictureBox4.Image = System.Drawing.Image.FromStream(mem);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                pictureBox4.Image = null;
            }

            if (fc.statsCount)
            {
                c4++;
                count4.Text = "Count: " + c4.ToString();
            }
            if (fc.errorCheck)
            {
                popScreen("Attention", fc.error, "Error");
            }
            insearch4 = false;
            display();
            return;
        }

        /// <summary> This is for outlet 2 </summary>
        /// 

        private void outlet5Check(object sender, EventArgs e)
        {
            insearch5 = true;
            uidOutlet5.Text = in5.TrimEnd(System.Environment.NewLine.ToCharArray());
            if (OutSelect5.Text == "")
            {
                popScreen("Attention", "Enter Server 5 name", "Warn");
                return;
            }
            foodCollectionQuery fc = new foodCollectionQuery();
            fc.call(uidOutlet5.Text,"5 : "+ OutSelect5.Text, Form1.query);
            IdLabel5.Text = fc.IdLabel;
            nameLabel5.Text = fc.nameLabel;
            statusLabel5.Text = fc.statusLabel;
            outlet5.WriteLine(fc.state);

            if (fc.picData)
            {
                try
                {
                    MemoryStream mem = new MemoryStream(fc.picDatamain);
                    pictureBox5.Image = System.Drawing.Image.FromStream(mem);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                pictureBox5.Image = null;
            }

            if (fc.statsCount)
            {
                c5++;
                count5.Text = "Count: " + c5.ToString();
            }
            if (fc.errorCheck)
            {
                popScreen("Attention", fc.error, "Error");
            }
            insearch5 = false;
            display();
            return;
        }
        private void outlet6Check(object sender, EventArgs e)
        {
            insearch6 = true;
            uidOutlet6.Text = in6.TrimEnd(System.Environment.NewLine.ToCharArray());
            foodCollectionQuery fc1 = new foodCollectionQuery();
            fc1.call(uidOutlet6.Text, "6 : " + OutSelect6.Text, Form1.query);
            IdLabel6.Text = fc1.IdLabel;
            nameLabel6.Text = fc1.nameLabel;
            statusLabel6.Text = fc1.statusLabel;
            outlet6.WriteLine(fc1.state);
            if (fc1.picData)
            {
                try
                {
                    MemoryStream mem = new MemoryStream(fc1.picDatamain);
                    pictureBox6.Image = System.Drawing.Image.FromStream(mem);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                pictureBox6.Image = null;
            }
            if (fc1.statsCount)
            {
                c6++;
                count6.Text = "Count: " + c6.ToString();
            }
            if (fc1.errorCheck)
            {
                popScreen("Attention", fc1.error, "Error");
            }

            insearch6 = false;
            display();
            return;
        }

        private void outlet7Check(object sender, EventArgs e)
        {
            insearch7 = true;
            uidOutlet7.Text = in7.TrimEnd(System.Environment.NewLine.ToCharArray());
            if (OutSelect7.Text == "")
            {
                popScreen("Attention", "Enter Server 7 name", "Warn");
                return;
            }
            foodCollectionQuery fc1 = new foodCollectionQuery();
            fc1.call(uidOutlet7.Text, "7 : " + OutSelect7.Text, Form1.query);
            IdLabel7.Text = fc1.IdLabel;
            nameLabel7.Text = fc1.nameLabel;
            statusLabel7.Text = fc1.statusLabel;
            outlet7.WriteLine(fc1.state);

            if (fc1.picData)
            {
                try
                {
                    MemoryStream mem = new MemoryStream(fc1.picDatamain);
                    pictureBox7.Image = System.Drawing.Image.FromStream(mem);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                pictureBox7.Image = null;
            }

            if (fc1.statsCount)
            {
                c7++;
                count7.Text = "Count: " + c7.ToString();
            }
            if (fc1.errorCheck)
            {
                popScreen("Attention", fc1.error, "Error");
            }
            insearch7 = false;
            display();
            return;
        }
        private void outlet8Check(object sender, EventArgs e)
        {
            insearch8 = true;
            uidOutlet8.Text = in8.TrimEnd(System.Environment.NewLine.ToCharArray());
            if (OutSelect8.Text == "")
            {
                popScreen("Attention", "Enter Server 8 name", "Warn");
                return;
            }
            foodCollectionQuery fc = new foodCollectionQuery();
            fc.call(uidOutlet8.Text, "8 : " + OutSelect8.Text, Form1.query);
            IdLabel8.Text = fc.IdLabel;
            nameLabel8.Text = fc.nameLabel;
            statusLabel8.Text = fc.statusLabel;
            outlet8.WriteLine(fc.state);

            if (fc.picData)
            {
                try
                {
                    MemoryStream mem = new MemoryStream(fc.picDatamain);
                    pictureBox8.Image = System.Drawing.Image.FromStream(mem);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                pictureBox8.Image = null;
            }

            if (fc.statsCount)
            {
                c8++;
                count8.Text = "Count: " + c8.ToString();
            }
            if (fc.errorCheck)
            {
                popScreen("Attention", fc.error, "Error");
            }
            insearch8 = false;
            display();
            return;
        }

        bool connectO1 = false, connectO2 = false, connectO3 = false, connectO4 = false, connectO5 = false, connectO6 = false, connectO7 = false, connectO8 = false;
        public void portRefreash()
        {
            portBox1.Items.AddRange(SerialPort.GetPortNames());
            portBox2.Items.AddRange(SerialPort.GetPortNames());
            portBox3.Items.AddRange(SerialPort.GetPortNames());
            portBox4.Items.AddRange(SerialPort.GetPortNames());
            portBox5.Items.AddRange(SerialPort.GetPortNames());
            portBox6.Items.AddRange(SerialPort.GetPortNames());
            portBox7.Items.AddRange(SerialPort.GetPortNames());
            portBox8.Items.AddRange(SerialPort.GetPortNames());
        }

        private void connectOne_Click(object sender, EventArgs e)
        {
            if (OutSelect1.Text == "")
            {
                popScreen("Attention", "Enter Server One name", "Warn");
                return;
            }
            if (connectO1)
            {
                try
                {
                    outlet1.Close();
                    Console.WriteLine("Outlet One Disconnected");
                    connectO1 = false;
                    connectOne.Text = "Connect";
                }
                catch (Exception ex)
                {
                    popScreen("outlet1 Error", ex.Message, "Error");
                }

            }
            else
            {
                try
                {
                    outlet1.PortName = portBox1.Text;
                    outlet1.Open();
                    Console.WriteLine("Outlet One Ready");
                    connectO1 = true;
                    connectOne.Text = "Disconnect";
                }
                catch (Exception ex)
                {
                    popScreen("Outlet 1 Connection Error", ex.Message, "Error");
                }
            }
        }
        
        private void connectTwo_Click(object sender, EventArgs e)
        {
            if (OutSelect2.Text == "")
            {
                popScreen("Attention", "Enter Server Two name", "Warn");
                return;
            }
            if (connectO2)
            {
                try
                {
                    outlet2.Close();
                    Console.WriteLine("Outlet Two Disconnected");
                    connectO2 = false;
                    connectTwo.Text = "Connect";
                }
                catch (Exception ex)
                {
                    popScreen("Outlet 2 Connection Error", ex.Message, "Error");
                }
            }
            else
            {
                try
                {
                    outlet2.PortName = portBox2.Text;
                    outlet2.Open();
                    Console.WriteLine("Outlet Two Ready");
                    connectO2 = true;
                    connectTwo.Text = "Disconnect";
                }
                catch (Exception ex)
                {
                   popScreen("Outlet 2 Connection Error", ex.Message, "Error");
                }
            }
        }
        
        private void connectThree_Click(object sender, EventArgs e)
        {
            if (OutSelect3.Text == "")
            {
                popScreen("Attention", "Enter Server Three name", "Warn");
                return;
            }
            if (connectO3)
            {
                try
                {
                    outlet3.Close();
                    Console.WriteLine("Outlet 3 Disconnected");
                    connectO3 = false;
                    connectThree.Text = "Connect";
                }
                catch (Exception ex)
                {
                    popScreen("Outlet 3 Connection Error", ex.Message, "Error");
                }
            }
            else
            {
                try
                {
                    outlet3.PortName = portBox3.Text;
                    outlet3.Open();
                    Console.WriteLine("Outlet Three Ready");
                    connectO3 = true;
                    connectThree.Text = "Disconnect";
                }
                catch (Exception ex)
                {
                    popScreen("Outlet 3 Connection Error", ex.Message, "Error");
                }
            }
        }

        
        private void connectFour_Click(object sender, EventArgs e)
        {
            if (OutSelect4.Text == "")
            {
                popScreen("Attention", "Enter Server Four name", "Warn");
                return;
            }
            if (connectO4)
            {
                try
                {
                    outlet4.Close();
                    Console.WriteLine("Outlet Four Disconnected");
                    connectO4 = false;
                    connectFour.Text = "Connect";
                }
                catch (Exception ex)
                {
                    popScreen("Outlet 4 Connection Error", ex.Message, "Error");
                }
            }
            else
            {
                try
                {
                    outlet4.PortName = portBox4.Text;
                    outlet4.Open();
                    Console.WriteLine("Outlet Four Ready");
                    connectO4 = true;
                    connectFour.Text = "Disconnect";
                }
                catch (Exception ex)
                {
                    popScreen("Outlet 4 Connection Error", ex.Message, "Error");
                }
            }
        }


        /// <summary>
        /// Port 5 to 8
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 

        private void connectFive_Click(object sender, EventArgs e)
        {
            if (OutSelect5.Text == "")
            {
                popScreen("Attention", "Enter Server Five name", "Warn");
                return;
            }
            if (connectO5)
            {
                try
                {
                    outlet5.Close();
                    Console.WriteLine("Outlet Five Disconnected");
                    connectO5 = false;
                    connectFive.Text = "Connect";
                }
                catch (Exception ex)
                {
                    popScreen("outlet5 Error", ex.Message, "Error");
                }

            }
            else
            {
                try
                {
                    outlet5.PortName = portBox5.Text;
                    outlet5.Open();
                    Console.WriteLine("Outlet Five Ready");
                    connectO5 = true;
                    connectFive.Text = "Disconnect";
                }
                catch (Exception ex)
                {
                    popScreen("Outlet 5 Connection Error", ex.Message, "Error");
                }
            }
        }

        private void connectSix_Click(object sender, EventArgs e)
        {
            if (OutSelect6.Text == "")
            {
                popScreen("Attention", "Enter Server Six name", "Warn");
                return;
            }
            if (connectO6)
            {
                try
                {
                    outlet6.Close();
                    Console.WriteLine("Outlet Six Disconnected");
                    connectO6 = false;
                    connectSix.Text = "Connect";
                }
                catch (Exception ex)
                {
                    popScreen("Outlet 6 Connection Error", ex.Message, "Error");
                }
            }
            else
            {
                try
                {
                    outlet6.PortName = portBox6.Text;
                    outlet6.Open();
                    Console.WriteLine("Outlet Six Ready");
                    connectO6 = true;
                    connectSix.Text = "Disconnect";
                }
                catch (Exception ex)
                {
                    popScreen("Outlet 6 Connection Error", ex.Message, "Error");
                }
            }
        }

        private void connectSeven_Click(object sender, EventArgs e)
        {
            if (OutSelect7.Text == "")
            {
                popScreen("Attention", "Enter Server Seven name", "Warn");
                return;
            }
            if (connectO7)
            {
                try
                {
                    outlet7.Close();
                    Console.WriteLine("Outlet Seven Disconnected");
                    connectO7 = false;
                    connectSeven.Text = "Connect";
                }
                catch (Exception ex)
                {
                    popScreen("Outlet 7 Connection Error", ex.Message, "Error");
                }
            }
            else
            {
                try
                {
                    outlet7.PortName = portBox7.Text;
                    outlet7.Open();
                    Console.WriteLine("Outlet Seven Ready");
                    connectO7 = true;
                    connectSeven.Text = "Disconnect";
                }
                catch (Exception ex)
                {
                    popScreen("Outlet 7 Connection Error", ex.Message, "Error");
                }
            }
        }


        private void connectEight_Click(object sender, EventArgs e)
        {
            if (OutSelect8.Text == "")
            {
                popScreen("Attention", "Enter Server Eight name", "Warn");
                return;
            }
            if (connectO8)
            {
                try
                {
                    outlet8.Close();
                    Console.WriteLine("Outlet Eight Disconnected");
                    connectO8 = false;
                    connectEight.Text = "Connect";
                }
                catch (Exception ex)
                {
                    popScreen("Outlet 8 Connection Error", ex.Message, "Error");
                }
            }
            else
            {
                try
                {
                    outlet8.PortName = portBox8.Text;
                    outlet8.Open();
                    Console.WriteLine("Outlet Eight Ready");
                    connectO8 = true;
                    connectEight.Text = "Disconnect";
                }
                catch (Exception ex)
                {
                    popScreen("Outlet 8 Connection Error", ex.Message, "Error");
                }
            }
        }


        private void display()
        {
            try
            {
                conn = new SqlConnection(Form1.query);
                conn.Open();
                string sqlSelectQuery = "SELECT * FROM PrintDB";
                SqlDataAdapter SDA = new SqlDataAdapter(sqlSelectQuery, Form1.query);
                DataTable dt = new DataTable();
                SDA.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                popScreen("Error", ex.Message, "Error");
            }
        }

        private void popScreen(string title, string context, string icon)
        {
            Form1.title = title;
            Form1.context = context;
            Form1.icon = icon;
            Form1.showdialoG = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioOther.Checked)
            {
                txtOther.Enabled = true;
            }
            else
            {
                txtOther.Enabled = false;
            }
        }

        public bool select()
        {
            if (!radiobreakfast.Checked && !radiolaunch.Checked && !radiosupper.Checked && !radioOther.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        ///<summary> Closing and Exporting</summary>
        public void Collection_FormClosing()
        {
            if (!checkBox1.Checked)
                return;
            try {
                SqlConnection conn = new SqlConnection(Form1.query);
                Console.WriteLine("Closing");
                // return;
                string mealBox = null;
                if (radiobreakfast.Checked)
                    mealBox = "Breakfast";
                if (radiolaunch.Checked)
                    mealBox = "Launch";
                if (radiosupper.Checked)
                    mealBox = "Supper";
                if(radioOther.Checked)
                    mealBox = txtOther.Text;
                string Loc2 = @"C:\Users\" + Environment.UserName + @"\Documents\Food-Manager";
                if (!Directory.Exists(Loc2))
                {
                    Directory.CreateDirectory(Loc2);
                }
               string loc2 = @"C:\Users\" + Environment.UserName + @"\Documents\Food-Manager\" + mealBox + " " + date + ".pdf";
                Console.WriteLine(loc2);
                ExportDataTableToPdf(loc2, "Adeleke University Ventures \n\n", "Cafeteria Department", mealBox);
                conn.Open();
                string sql = @"DELETE FROM PrintDB;";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                conn.Open();
                ffd = new foodCollectionQuery();
                ffd.actSQL("Food Collection", DateTime.Now.ToLongTimeString(), date, "Student food Collection | Total: " + checkCount());
                 // System.Diagnostics.Process.Start(loc);
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if(conn.State == ConnectionState.Open)
                {
                    conn.Open();
                }
            }
            //this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }
        public bool dntClose2()
        {
            if ((radiobreakfast.Checked) | (radiolaunch.Checked) | (radiosupper.Checked) | (radioOther.Checked))
                return false;

            else
                return true;
        }

        public bool dntClose()
        {
            if(connectO1 | connectO2 | connectO3 | connectO4 | connectO5 | connectO6 | connectO7 | connectO8)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void ExportDataTableToPdf(String strPdfPath, string strHeader, string strHeader2, string mealTime)
        {
        //return;
                                              
            string imageURL = @"C:\Users\" + Environment.UserName + @"\Documents\Food-Manager\Extras\LOGO.jpg";
            //if (!File.Exists(imageURL))
            //{
            //   imageURL = Form1.logo;
            //}
            System.IO.FileStream fs = new FileStream(strPdfPath, FileMode.Create, FileAccess.Write, FileShare.None);
            Document document = new Document();
            document.SetPageSize(iTextSharp.text.PageSize.A4);
            PdfWriter writer = PdfWriter.GetInstance(document, fs);
            document.Open();

            //logo
            iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance(imageURL);
            jpg.ScaleToFit(70f, 50f);
            jpg.Alignment = Element.ALIGN_LEFT;
            jpg.SetAbsolutePosition(document.PageSize.Width - 550f - 30f, document.PageSize.Height - 50f - 30f);
            document.Add(jpg);

            //Report Header
            BaseFont bfntHead = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font fntHead = new Font(bfntHead, 16, 1, Color.BLACK);
            Font fntHead2 = new Font(bfntHead, 16, 1, Color.GRAY);
            Paragraph prgHeading = new Paragraph();
            prgHeading.Alignment = Element.ALIGN_CENTER;
            prgHeading.Add(new Chunk(strHeader.ToUpper(), fntHead));
            prgHeading.Add(new Chunk(strHeader2.ToUpper(), fntHead2));
            document.Add(prgHeading);

            //Time
            Paragraph prgAuthor = new Paragraph();
            BaseFont btnAuthor = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font fntAuthor = new Font(btnAuthor, 8, 2, Color.GRAY);
            prgAuthor.Alignment = Element.ALIGN_RIGHT;
            prgAuthor.Add(new Chunk("Meal: " + mealTime, fntAuthor));
            prgAuthor.Add(new Chunk("\nStart Time: " +  startTime, fntAuthor));
            prgAuthor.Add(new Chunk("\nStop Time : " + DateTime.Now.ToLongTimeString(), fntAuthor));
            prgAuthor.Add(new Chunk("\nDate: " + startTime, fntAuthor));
            prgAuthor.Add(new Chunk("\nTotal: " + checkCount(),fntAuthor));
            document.Add(prgAuthor);

            //Add a line seperation
            Paragraph p = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, Color.BLACK, Element.ALIGN_LEFT, 1)));
            document.Add(p);

            //Add line break
            document.Add(new Chunk("\n", fntHead));

            //Write the table
            PdfPTable table = new PdfPTable(dataGridView1.Columns.Count);
            //Table header
            BaseFont btnColumnHeader = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);

            for (int h = 0; h < dataGridView1.Columns.Count; h++)
            {
                table.AddCell(new Phrase(dataGridView1.Columns[h].HeaderText));

            }
            //table Data
            table.HeaderRows = 1;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    if (dataGridView1[j, i].Value != null)
                    {
                        table.AddCell(new Phrase(dataGridView1[j, i].Value.ToString()));
                    }
                }
            }

            document.Add(table);
            document.Close();
            writer.Close();
            fs.Close();
            popScreen("Attention", "Report data has been exported successfully", "Info");
        }
        int cout = 0;
        private int checkCount()
        {
            conn = new SqlConnection(Form1.query);
            conn.Open();
            string sqlSelectQuery = string.Format("SELECT * FROM PrintDB");
            try
            {
                SqlDataAdapter SDA = new SqlDataAdapter(sqlSelectQuery, Form1.query);
                DataTable dt = new DataTable();
                SDA.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    cout++;
                }
            }
            catch { }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return cout;
        }
    }
}
