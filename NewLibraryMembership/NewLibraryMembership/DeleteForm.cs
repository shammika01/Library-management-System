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
    public partial class DeleteForm : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ToString());

        protected void FillComboBox()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT member_id FROM Member", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbDelete.DataSource = dt;
            cmbDelete.DisplayMember = "member_id";
            cmbDelete.ValueMember = "member_id";
        }

        public DeleteForm()
        {
            InitializeComponent();

            FillComboBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                DialogResult r = MessageBox.Show("Do you need to delete this record", "Library Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (r == DialogResult.Yes)
                {
                    string sql = "DELETE FROM Member WHERE member_id=" + Convert.ToInt32(cmbDelete.SelectedValue.ToString());
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Successfully deleted", "Library Management System", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
