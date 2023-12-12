using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Dashboard
{
    public partial class GateUI : Form
    {
        string dbcon = "localhost";
        string mysqluser = "root";
        string mysqlpassword = "";
        string dbname = "studentdb";

        public GateUI()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CurrentTime.Text = DateTime.Now.ToLongTimeString();
            CurrentDate.Text = DateTime.Now.ToShortDateString();
            this.IDInput1.Enter += new EventHandler(IDInput1_Enter);
            this.IDInput1.Leave += new EventHandler(IDInput1_Leave);
            this.IDInput2.Enter += new EventHandler(IDInput2_Enter);
            this.IDInput2.Leave += new EventHandler(IDInput2_Leave);
            IDInput1_SetText();
            IDInput2_SetText();

        }

        protected void IDInput1_SetText()
        {
            this.IDInput1.Text = "Enter Student ID";
            IDInput1.ForeColor = Color.Gray;
        }

        private void IDInput1_Enter(object sender, EventArgs e)
        {
            if (IDInput1.ForeColor == Color.Black)
                return;
            IDInput1.Text = "";
            IDInput1.ForeColor = Color.Black;
        }
        private void IDInput1_Leave(object sender, EventArgs e)
        {
            if (IDInput1.Text.Trim() == "")
                IDInput1_SetText();
        }
        protected void IDInput2_SetText()
        {
            this.IDInput2.Text = "Enter Student ID";
            IDInput2.ForeColor = Color.Gray;
        }

        private void IDInput2_Enter(object sender, EventArgs e)
        {
            if (IDInput2.ForeColor == Color.Black)
                return;
            IDInput2.Text = "";
            IDInput2.ForeColor = Color.Black;
        }
        private void IDInput2_Leave(object sender, EventArgs e)
        {
            if (IDInput2.Text.Trim() == "")
                IDInput2_SetText();
        }

        private void ConnectDB_Click(object sender, EventArgs e)
        {
            string conString = "server=" + dbcon + ";uid=" + mysqluser + ";pwd=" + mysqlpassword + ";database=" + dbname;
            MySqlConnection con = new MySqlConnection(conString);
            try
            {
                con.Open();
                MessageBox.Show("Connection Open!");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot open connection!");
            }
        }

        private void CurrentTime_Click(object sender, EventArgs e)
        {
            ClockTimer.Start();
        }

        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            CurrentTime.Text = DateTime.Now.ToLongTimeString();
            CurrentDate.Text = DateTime.Now.ToShortDateString();
            ClockTimer.Start();
        }

        private void CurrentDate_Click(object sender, EventArgs e)
        {
            ClockTimer.Start();
        }

        private void IDInput1_TextChanged(object sender, EventArgs e)
        {

        }

        private void IDInput2_TextChanged(object sender, EventArgs e)
        {

        }

        private void OKInput1_Click(object sender, EventArgs e)
        {
            string conString = "server=" + dbcon + ";uid=" + mysqluser + ";pwd=" + mysqlpassword + ";database=" + dbname;
            MySqlConnection con = new MySqlConnection(conString);
            con.Open();
            try
            {
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT FirstName,LastName,SID,studentimage FROM students WHERE SID = " + IDInput1.Text;
                MySqlDataReader reader = cmd.ExecuteReader();
                if (!reader.HasRows)
                {
                    MessageBox.Show("No records found.");
                }
                while (reader.Read())
                {
                    StudentName1.Text = "Name: " + reader.GetString(0) + " " + reader.GetString(1);
                    StudentID1.Text = "Student ID: " + reader.GetString(2);
                    byte[] imageBytes = Convert.FromBase64String(reader.GetString(3));
                    using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
                    {
                        StudentImage1.Image = Image.FromStream(ms, true);
                        StudentImage1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

            CreateTimeIn(IDInput1.Text);
        }

        private void CreateTimeIn(string studentID)
        {
            string conString = "server=" + dbcon + ";uid=" + mysqluser + ";pwd=" + mysqlpassword + ";database=" + dbname;
            MySqlConnection con = new MySqlConnection(conString);

            try
            {
                con.Open();

                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "INSERT INTO attendance (sid) VALUES(@studentId)";
                cmd.Parameters.AddWithValue("@studentId", studentID);
                cmd.ExecuteReader();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error!");
            }
            finally
            {
                con.Close();
            }
        }

        private void OKInput2_Click(object sender, EventArgs e)
        {

            {
                string conString = "server=" + dbcon + ";uid=" + mysqluser + ";pwd=" + mysqlpassword + ";database=" + dbname;
                MySqlConnection con = new MySqlConnection(conString);
                con.Open();
                try
                {
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "SELECT FirstName,LastName,SID,studentimage FROM students WHERE SID = " + IDInput2.Text;
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (!reader.HasRows)
                    {
                        MessageBox.Show("No records found.");
                    }
                    while (reader.Read())
                    {
                        StudentName2.Text = "Name: " + reader.GetString(0) + " " + reader.GetString(1);
                        StudentID2.Text = "Student ID: " + reader.GetString(2);
                        byte[] imageBytes = Convert.FromBase64String(reader.GetString(3));
                        using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
                        {
                            StudentImage2.Image = Image.FromStream(ms, true);
                            StudentImage2.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
                CreateTimeIn(IDInput2.Text);

            }
        }

        private void Violations_SelectedIndexChanged(object sender, EventArgs e)
        {
            CreateViolation(Violations.Text, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), IDInput1.Text);
        }
        private void CreateViolation(string violationName, string dateTime, string studentID)
        {
            string conString = "server=" + dbcon + ";uid=" + mysqluser + ";pwd=" + mysqlpassword + ";database=" + dbname;
            MySqlConnection con = new MySqlConnection(conString);

            try
            {
                if (violationName == "(None)") return;

                con.Open();

                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "INSERT INTO violations (violation_name, timestamp, sid) VALUES( @violationName, @timeStamp, @studentId)";
                cmd.Parameters.AddWithValue("@violationName", violationName);
                cmd.Parameters.AddWithValue("@timeStamp", dateTime);
                cmd.Parameters.AddWithValue("@studentId", studentID);
                cmd.ExecuteReader();
                MessageBox.Show("Violation Added!");
            }
            catch (Exception e)
            {
                MessageBox.Show("Invalid Input!");
            }
            finally
            {
                con.Close();
            }
        }

        private void ViolationBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            CreateViolation(Violations.Text, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), IDInput2.Text);
        }
    }
}
