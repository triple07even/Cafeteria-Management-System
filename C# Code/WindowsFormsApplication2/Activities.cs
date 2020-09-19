using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication2
{
    public partial class Activities : UserControl
    {

        SqlConnection conn;       
        public Activities()
        {
            InitializeComponent();
            display();
            conn.Open();
            //string sql = @"DELETE FROM Activities;";
            //SqlCommand cmd = new SqlCommand(sql, conn);
            //cmd.ExecuteNonQuery();
            //conn.Close();
        }

        private void activitydataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void display()
        {
            try
            {
                conn = new SqlConnection(Form1.query);
                conn.Open();
                string sqlSelectQuery = "SELECT * FROM Activities";
                SqlDataAdapter SDA = new SqlDataAdapter(sqlSelectQuery, Form1.query);
                DataTable dt = new DataTable();
                SDA.Fill(dt);
                activitydataGridView.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
               Console.WriteLine(ex.Message);
            }
        }

        private void sort_date_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlDataAdapter adapt = new SqlDataAdapter("select * from Activities where Date like '" + dateTimePicker1.Text + "%'", conn);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                activitydataGridView.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if(conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                SqlDataAdapter adapt = new SqlDataAdapter("select * from Activities where SchoolID like '" + textBox1.Text + "%'", conn);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                activitydataGridView.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
    }
}
