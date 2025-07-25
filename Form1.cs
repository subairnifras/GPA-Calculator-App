using System;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=result;Integrated Security=True"))
                {
                    string query = @"INSERT INTO [dbo].[result]
                                    ([Index], [Student_name], [Ict], [Mathematics], [Science], [History], [English])
                                    VALUES (@Index, @StudentName, @Ict, @Mathematics, @Science, @History, @English)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Index", txtIndex.Text);
                        cmd.Parameters.AddWithValue("@StudentName", txtName.Text);
                        cmd.Parameters.AddWithValue("@Ict", txtIct.Text);
                        cmd.Parameters.AddWithValue("@Mathematics", txtMaths.Text);
                        cmd.Parameters.AddWithValue("@Science", txtSci.Text);
                        cmd.Parameters.AddWithValue("@History", txtHis.Text);
                        cmd.Parameters.AddWithValue("@English", txtEng.Text);

                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                double ict = double.Parse(txtIct.Text);
                double mathematics = double.Parse(txtMaths.Text);
                double science = double.Parse(txtSci.Text);
                double history = double.Parse(txtHis.Text);
                double english = double.Parse(txtEng.Text);

                double total = ict + mathematics + science + history + english;
                txtTot.Text = total.ToString();

                double average = total / 5;
                txtAvg.Text = average.ToString();

                string grade;
                if (average >= 75)
                {
                    grade = "A";
                }
                else if (average >= 65)
                {
                    grade = "B";
                }
                else if (average >= 55)
                {
                    grade = "C";
                }
                else if (average >= 45)
                {
                    grade = "S";
                }
                else
                {
                    grade = "F";
                }

                txtGrd.Text = grade;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}