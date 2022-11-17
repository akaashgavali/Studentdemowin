using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Xml.Linq;


namespace Studentdemowin
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        public Form1()
        {
            InitializeComponent();
            string str = ConfigurationManager.ConnectionStrings["defaultConnection"].ConnectionString;
            con = new SqlConnection(str);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "update student set StudentName=@nm , City=@ct ,Percentage=@pr where Rollno=@rl";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@nm", textName.Text);
                cmd.Parameters.AddWithValue("@ct", textCity.Text);
                cmd.Parameters.AddWithValue("@pr", Convert.ToDecimal(textPercentage.Text));
                cmd.Parameters.AddWithValue("@rl", Convert.ToInt32(textRollNo.Text));
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Record updated");
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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "insert into student values(@nm,@ct,@pr)";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@nm", textName.Text);
                cmd.Parameters.AddWithValue("@ct", textCity.Text);
                cmd.Parameters.AddWithValue("@pr", Convert.ToDouble(textPercentage.Text));
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Record inserted");
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

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "delete from student where Rollno=@rl";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@rl", Convert.ToInt32(textRollNo.Text));
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Record deleted");
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
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select * from student where Rollno=@rl";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@rl", Convert.ToInt32(textRollNo.Text));
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        textName.Text = dr["StudentName"].ToString();
                        textCity.Text = dr["City"].ToString();
                        textPercentage.Text = dr["Percentage"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Record not found");
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
        }

        private void btnReadAllStudentData_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select * from student";
                cmd = new SqlCommand(qry, con);
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable table = new DataTable();
                    table.Load(dr);
                    dataGridView1.DataSource = table;
                }
                else
                {
                    MessageBox.Show("Record not found");
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
        }
    }
}
