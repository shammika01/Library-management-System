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
    public partial class NewUpdateForm : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ToString());
        public NewUpdateForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT * FROM Member where member_id=" +
                Convert.ToInt32(txtID.Text) + "";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtName.Text = dr["member_name"].ToString();
                    adBox.Text = dr["member_address"].ToString();
                    tPNRegistration.Text = dr["member_telno"].ToString();
                }
                else
                {
                    MessageBox.Show("Invalid ID", "Library Management System",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {


            try
            {
                string sql = "UPDATE Member SET member_name='" + txtName.Text +
               "', member_address='" + adBox.Text + "' , member_telno='" + tPNRegistration.Text
               + "'WHERE member_id="+ Convert.ToInt32(txtID.Text);
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Successfully updated", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
