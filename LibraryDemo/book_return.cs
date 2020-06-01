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
    public partial class book_return : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-A5NPQGU\SQLEXPRESS;Initial Catalog=ProjectDB;Integrated Security=True");
        SqlCommand cmd;
        public book_return()
        {
            InitializeComponent();
        }

        private void btn_book_return_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_bk_return_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select id from transaction_info where student=@student and book=@book", con);
            cmd.Parameters.AddWithValue("@book", txt_book_title.Text);
            cmd.Parameters.AddWithValue("@student", txt_student_name.Text);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            int record_id = 0;
            while (reader.Read())
            {
                MessageBox.Show(reader["id"].ToString());
                record_id = (int)reader["id"];
            }
            reader.Close();
            cmd = new SqlCommand("update transaction_info set return_date = @return_date where id=@id", con);
            cmd.Parameters.AddWithValue("@id", record_id);
            cmd.Parameters.AddWithValue("@return_date", DateTime.Today);
            cmd.ExecuteNonQuery();

            cmd = new SqlCommand("select id from book_info where title=@title", con);
            cmd.Parameters.AddWithValue("@title", txt_book_title.Text);
            SqlDataReader bk_reader = cmd.ExecuteReader();
            int bk_id = 0;
            while (bk_reader.Read())
            {
                MessageBox.Show(bk_reader["id"].ToString());
                bk_id = (int)bk_reader["id"];
            }
            bk_reader.Close();

            cmd = new SqlCommand("update book_info set no_of_copies = no_of_copies +1 where id=@id", con);
            cmd.Parameters.AddWithValue("@id", bk_id);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
