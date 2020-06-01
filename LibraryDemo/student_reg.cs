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
    public partial class student_reg : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-A5NPQGU\SQLEXPRESS;Initial Catalog=ProjectDB;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapter;
        int Id = 0;
        public student_reg()
        {
            InitializeComponent();
            DisplayStudentInfo();
        }

        private void btn_student_reg_cancel_Click(object sender, EventArgs e)
        {
            ClearData();
            this.Close();
        }

        private void btn_student_reg_save_Click(object sender, EventArgs e)
        {
            if (tx_student_reg_user.Text != "" && tx_student_reg_password.Text != ""
                && tx_student_reg_name.Text != "" && tx_student_reg_class.Text != "")
            {
                cmd = new SqlCommand("insert into student_info(user_name,password,name,grade,class,registered_date) values(@user,@password,@name,@grade,@class,@reg_date)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@user",tx_student_reg_user.Text);
                cmd.Parameters.AddWithValue("@password",tx_student_reg_password.Text);
                cmd.Parameters.AddWithValue("@name",tx_student_reg_name.Text);
                cmd.Parameters.AddWithValue("@grade",num_student_reg_grade.Value);
                cmd.Parameters.AddWithValue("@class",tx_student_reg_class.Text);
                cmd.Parameters.AddWithValue("@reg_date",DateTime.Today);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Inserted Successfully");
                DisplayStudentInfo();
                ClearData();
            }
        }

        private void ClearData()
        {
            tx_student_reg_user.Text = "";
            tx_student_reg_password.Text = "";
            tx_student_reg_name.Text = "";
            num_student_reg_grade.Value = 1;
            tx_student_reg_class.Text = "";
            Id = 0;
        }

        private void DisplayStudentInfo()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapter = new SqlDataAdapter("select id,user_name,password,name,grade,class,registered_date from student_info", con);
            adapter.Fill(dt);
            dgv_students.DataSource = dt;
            con.Close();
        }

        /*private void dgv_students_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Id = Convert.ToInt32(dgv_students.Rows[e.RowIndex].Cells[0].Value.ToString());
            tx_student_reg_user.Text = dgv_students.Rows[e.RowIndex].Cells[0].Value.ToString();
            tx_student_reg_password.Text = dgv_students.Rows[e.RowIndex].Cells[0].Value.ToString();
            tx_student_reg_name.Text = dgv_students.Rows[e.RowIndex].Cells[0].Value.ToString();
            num_student_reg_grade.Value = Convert.ToInt32(dgv_students.Rows[e.RowIndex].Cells[0].Value.ToString());
            tx_student_reg_class.Text = dgv_students.Rows[e.RowIndex].Cells[0].Value.ToString();
        }*/

        private void btn_student_reg_update_Click(object sender, EventArgs e)
        {
            if (tx_student_reg_user.Text != "" && tx_student_reg_password.Text != ""
                && tx_student_reg_name.Text != "" && tx_student_reg_class.Text != "")
            {
                cmd = new SqlCommand("update student_info set user_name=@user,password=@password,name=@name,grade=@grade,class=@class where id=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", Id);
                cmd.Parameters.AddWithValue("@user", tx_student_reg_user.Text);
                cmd.Parameters.AddWithValue("@password", tx_student_reg_password.Text);
                cmd.Parameters.AddWithValue("@name", tx_student_reg_name.Text);
                cmd.Parameters.AddWithValue("@grade", num_student_reg_grade.Value);
                cmd.Parameters.AddWithValue("@class", tx_student_reg_class.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Updated Successfully");
                DisplayStudentInfo();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }

        private void btn_student_reg_delete_Click(object sender, EventArgs e)
        {
            if (Id != 0)
            {
                cmd = new SqlCommand("delete student_info where id=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", Id);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully");
                DisplayStudentInfo();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }

        private void dgv_students_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgv_students.Rows[e.RowIndex];
            Id = Convert.ToInt32(row.Cells[0].Value.ToString());
            tx_student_reg_user.Text = row.Cells[1].Value.ToString();
            tx_student_reg_password.Text = row.Cells[2].Value.ToString();
            tx_student_reg_name.Text = row.Cells[3].Value.ToString();
            num_student_reg_grade.Value = Convert.ToInt32(row.Cells[4].Value.ToString());
            tx_student_reg_class.Text = row.Cells[5].Value.ToString();

        }

    }
}
