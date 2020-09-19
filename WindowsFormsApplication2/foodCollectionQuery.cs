using System;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApplication2
{
    class foodCollectionQuery
    {
        SqlConnection conn;
        public string nameLabel, IdLabel, statusLabel, error, state;
        public byte[] picDatamain;
        public bool statsCount, errorCheck;
        string name, SchoolId, ticket, WBA, phili; int idCheck, philiT;
        public bool picData;

        public void call(string UID, string OutSelect, string query)
        {
            state = "";
            statsCount = false; errorCheck = false; picData = false;
            conn = new SqlConnection(Form1.query);
            try
            {
                conn.Open();
                string sqlSelectQuery1 = "SELECT * FROM MainDataBase WHERE UID = '" + UID.TrimEnd(System.Environment.NewLine.ToCharArray()) + "'";
                SqlCommand cmd = new SqlCommand(sqlSelectQuery1, conn);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    name = (dr["SName"].ToString()) + " " + (dr["OName"].ToString());
                    SchoolId = (dr["SchoolId"].ToString());
                    ticket = (dr["IDMain"].ToString());
                    WBA = (dr["ManHuntP"].ToString());
                    picDatamain = (byte[])dr["Image"];
                    philiT = Convert.ToInt32((dr["PhiliTicket"].ToString()));
                    phili = (dr["Phili"].ToString());
                    conn.Close();
                    string time = DateTime.Now.ToLongTimeString();
                    idCheck = Convert.ToInt32(ticket);
                    if (philiT >= 1)
                    {
                        conn.Open();
                        string sqlSelectQuery22 = "SELECT * FROM PrintDB WHERE Name = '" + SchoolId + "'";
                        SqlCommand cmd22 = new SqlCommand(sqlSelectQuery22, conn);
                        SqlDataReader dr22 = cmd22.ExecuteReader();
                        if (dr22.Read())
                        {
                            nameLabel = name;
                            IdLabel = SchoolId;
                            statusLabel = "Already Served";
                            Console.WriteLine(picData.ToString());
                            state = SchoolId + "mf3";
                            picData = true;
                            conn.Close();
                            return;
                        }
                        else
                        {
                            conn.Close();
                            conn.Open();
                            string sqlSelectQuery3 = "INSERT INTO PrintDB (Name, Time, Phili, ServerOut) VALUES ('" + SchoolId + "', '" + time + "' , '" + phili + "', '" + OutSelect + "')";
                            SqlDataAdapter SDA = new SqlDataAdapter(sqlSelectQuery3, conn);
                            SDA.SelectCommand.ExecuteNonQuery();
                            nameLabel = name;
                            IdLabel = SchoolId;
                            statusLabel = " Accepted";
                            state = SchoolId + "mf4";
                            picData = true;
                            statsCount = true;
                            conn.Close();
                            philiT--;
                            string sqlquery = string.Format("Update {0} SET PhiliTicket = '" + philiT.ToString() + "' where SchoolId = '" + SchoolId + "'", "MainDataBase");
                            SqlCommand cmd3 = new SqlCommand(sqlquery, conn);
                            conn.Open();
                            //cmd3.CommandType = CommandType.Text;
                            cmd3.ExecuteNonQuery();
                            conn.Close();
                            return;
                        }
                    }


                    if (idCheck <= 0)
                    {
                        nameLabel = name;
                        IdLabel = SchoolId;
                        statusLabel = "Out of ticket Please Register";
                        state = SchoolId + "mf1";
                        picData = true;
                        return;
                    }
                    if (WBA == "True")
                    {
                        nameLabel = name;
                        IdLabel = SchoolId;
                        statusLabel = "Wanted by Admin";
                        state = SchoolId + "mf2";
                        picData = true;
                        return;
                    }

                    conn.Open();
                    string sqlSelectQuery2 = "SELECT * FROM PrintDB WHERE Name = '" + SchoolId + "'";
                    SqlCommand cmd2 = new SqlCommand(sqlSelectQuery2, conn);
                    SqlDataReader dr2 = cmd2.ExecuteReader();
                    if (dr2.Read())
                    {
                        nameLabel = name;
                        IdLabel = SchoolId;
                        statusLabel = "Already Served";
                        Console.WriteLine(picData.ToString());
                        state = SchoolId + "mf3";
                        picData = true;
                        conn.Close();
                        return;
                    }
                    else
                    {
                        conn.Close();
                        conn.Open();
                        string sqlSelectQuery3 = "INSERT INTO PrintDB (Name, Time, Phili, ServerOut) VALUES ('" + SchoolId + "', '" + time + "' , '" + phili + "', '" + OutSelect + "')";
                        SqlDataAdapter SDA = new SqlDataAdapter(sqlSelectQuery3, conn);
                        SDA.SelectCommand.ExecuteNonQuery();
                        nameLabel = name;
                        IdLabel = SchoolId;
                        statusLabel = " Accepted";
                        state = SchoolId + "mf4";
                        picData = true;
                        statsCount = true;
                        conn.Close();
                        idCheck--;
                        string sqlquery = string.Format("Update {0} SET IDMain = '" + idCheck.ToString() + "' where SchoolId = '" + SchoolId + "'", "MainDataBase");
                        SqlCommand cmd3 = new SqlCommand(sqlquery, conn);
                        conn.Open();
                        //cmd3.CommandType = CommandType.Text;
                        cmd3.ExecuteNonQuery();
                        conn.Close();
                    }
                }
                else
                {
                    nameLabel = "- - - -";
                    IdLabel = "- - - -";
                    statusLabel = "Not in record";
                    state = "mf0";
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                errorCheck = true;
                error = ex.Message;
                Console.WriteLine(ex.Message);
                return;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
        public void actSQL(string id, string time, string date, string des)
        {
            try
            {
                conn = new SqlConnection(Form1.query);
                conn.Open();
                string sqlActivity = @"INSERT INTO Activities (SchoolId, Time, Date, Description) VALUES ('" + id + "','" + time + "','" + date + "','" + des + "')";
                SqlDataAdapter sd = new SqlDataAdapter(sqlActivity, conn);
                sd.SelectCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}

