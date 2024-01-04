using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace NewLibraryMembership
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ToString());
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string regdate = dtpRegistration.Value.ToString("yyyy-MM-dd");
                //assigning the date from the date time picker
                string memtype = cmbMemType.Text; //assigning the member type

                string sql = "INSERT INTO Member (member_id, member_name, member_address, member_telno, member_regdate, member_type) VALUES('" + txtID.Text + "', ' " + txtName.Text + "', '" + adBox.Text + "',"+ tPNRegistration.Text + ",'" + regdate + "','" + memtype + "')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Member Registration Successful ", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Library Management System",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
