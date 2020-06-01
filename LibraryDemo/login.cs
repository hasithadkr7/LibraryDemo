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

namespace LibraryDemo
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        string con_str = @"Data Source=DESKTOP-A5NPQGU\SQLEXPRESS;Initial Catalog=ProjectDB;Integrated Security=True";

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_user_name.Text == "" || txt_password.Text == "")
            {
                MessageBox.Show("Please provide User name and Password");
                return;
            }
            if (radio_btn_admin.Checked != true && radio_btn_student.Checked != true)
            {
                MessageBox.Show("Please pick your login category");
                return;
            }
            try
            {
                SqlConnection con = new SqlConnection(con_str);
                SqlCommand cmd = null;
                if (radio_btn_admin.Checked)
                {
                    cmd = new SqlCommand("select password from admin_info where user_name=@username and password=@password", con);
                }
                else if (radio_btn_student.Checked)
                {
                    cmd = new SqlCommand("select password from student_info where user_name=@username and password=@password", con);
                }
                cmd.Parameters.AddWithValue("@username", txt_user_name.Text);
                cmd.Parameters.AddWithValue("@password", txt_password.Text);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();
                int count = ds.Tables[0].Rows.Count;
                if (count == 1)
                {
                    Globals.user_name = txt_user_name.Text;
                    //MessageBox.Show("Login Successfull!");
                    this.Hide();
                    if (radio_btn_admin.Checked)
                    {
                        admin adm = new admin();
                        adm.Show();
                    }
                    else
                    {
                        lend_books lend_bk = new lend_books();
                        lend_bk.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Login Failed!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_login_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    static class Globals
    {
        // global int
        public static String user_name;
    }
}
