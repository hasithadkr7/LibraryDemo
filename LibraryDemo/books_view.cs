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
    public partial class books_view : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-A5NPQGU\SQLEXPRESS;Initial Catalog=ProjectDB;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapter;
        int Id = 0;
        public books_view()
        {
            InitializeComponent();
            DisplayData();
        }

        /*private void books_view_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'admin_book_view.book_info' table. You can move, or remove it, as needed.
            this.book_infoTableAdapter.Fill(this.admin_book_view.book_info);

        }*/

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_book_title.Text != "" && txt_book_author.Text != "" && cmb_book_category.Text != "" )
            {
                cmd = new SqlCommand("insert into book_info(title,author,category,no_of_copies) values(@title,@author,@category,@copies)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@title", txt_book_title.Text);
                cmd.Parameters.AddWithValue("@author", txt_book_author.Text);
                cmd.Parameters.AddWithValue("@category", cmb_book_category.Text);
                cmd.Parameters.AddWithValue("@copies", no_copies.Value);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Inserted Successfully");
                DisplayData();
                ClearData();
            }
        }

        private void ClearData()
        {
            txt_book_title.Text = "";
            txt_book_author.Text = "";
            cmb_book_category.Text = "";
            no_copies.Value = 0;
            Id = 0;
        }

        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapter = new SqlDataAdapter("select id,title,author,category,no_of_copies from book_info", con);
            adapter.Fill(dt);
            dgv_book_view.DataSource = dt;
            con.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (Id != 0)
            {
                MessageBox.Show("Id : " + Id);
                cmd = new SqlCommand("delete book_info where id=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", Id);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }

        private void dgv_book_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = e.RowIndex;
            DataGridViewRow row = dgv_book_view.Rows[Id];
            Id = Convert.ToInt32(row.Cells[0].Value.ToString());
            txt_book_title.Text = row.Cells[1].Value.ToString();
            //MessageBox.Show("title "+row.Cells[0].Value.ToString());
            //MessageBox.Show("author " + row.Cells[1].Value.ToString());
            //MessageBox.Show("category " + row.Cells[2].Value.ToString());
            //MessageBox.Show("no copies " + row.Cells[3].Value.ToString());
            //MessageBox.Show("dunno " + row.Cells[4].Value.ToString());
            txt_book_author.Text = row.Cells[2].Value.ToString();
            cmb_book_category.Text = row.Cells[3].Value.ToString();
            no_copies.Value =  Convert.ToInt32(row.Cells[4].Value.ToString());
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txt_book_title.Text != "" && txt_book_author.Text != "" && cmb_book_category.Text != "")
            {
                MessageBox.Show("Id : "+Id);
                cmd = new SqlCommand("update book_info set title=@bk_title,author=@bk_author,category=@bk_category,no_of_copies=@copies where id=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", Id);
                cmd.Parameters.AddWithValue("@bk_title", txt_book_title.Text);
                cmd.Parameters.AddWithValue("@bk_author", txt_book_author.Text);
                cmd.Parameters.AddWithValue("@bk_category", cmb_book_category.Text);
                cmd.Parameters.AddWithValue("@copies", no_copies.Value);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Updated Successfully");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }
    }
}
