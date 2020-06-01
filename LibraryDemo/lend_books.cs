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
    public partial class lend_books : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-A5NPQGU\SQLEXPRESS;Initial Catalog=ProjectDB;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapter;
        int Id = 0;
        public lend_books()
        {
            InitializeComponent();
            DisplayData();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ClearData()
        {
            txt_bk_title.Text = "";
            cmb_bk_category.Text = "";
            txt_bk_author.Text = "";
            Id = 0;
        }

        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapter = new SqlDataAdapter("select id,title,author,category from book_info where no_of_copies>0", con);
            adapter.Fill(dt);
            dgv_books_shelf.DataSource = dt;
            con.Close();
        }

        private void btn_search_title_Click(object sender, EventArgs e)
        {
            string bk_title = txt_bk_title.Text;
            cmb_bk_category.Text = "";
            txt_bk_author.Text = "";
            string query = "select title,author,category from book_info where title= '"+bk_title+"' ";
            SqlDataAdapter sda = new SqlDataAdapter(query,con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgv_books_shelf.DataSource = dt;
            con.Close();
        }

        private void btn_search_category_Click(object sender, EventArgs e)
        {
            string bk_category = cmb_bk_category.Text;
            txt_bk_title.Text = "";
            txt_bk_author.Text = "";
            string query = "select title,author,category from book_info where category= '" + bk_category + "' ";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgv_books_shelf.DataSource = dt;
            con.Close();
        }

        private void btn_search_author_Click(object sender, EventArgs e)
        {
            string bk_author = txt_bk_author.Text;
            txt_bk_title.Text = "";
            cmb_bk_category.Text = "";
            string query = "select title,author,category from book_info where author= '" + bk_author + "' ";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgv_books_shelf.DataSource = dt;
            con.Close();
        }

        private void btn_view_all_Click(object sender, EventArgs e)
        {
            ClearData();
            DisplayData();
        }

        private void dgv_books_shelf_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgv_books_shelf.Rows[e.RowIndex];
            Id = Convert.ToInt32(row.Cells[0].Value.ToString());
            txt_bk_title.Text = row.Cells[1].Value.ToString();
            cmb_bk_category.Text = row.Cells[3].Value.ToString();
            txt_bk_author.Text = row.Cells[2].Value.ToString();
        }

        private void btn_borrow_Click(object sender, EventArgs e)
        {
            
            cmd = new SqlCommand("update book_info set no_of_copies = no_of_copies -1 where id=@id", con);
            con.Open();
            cmd.Parameters.AddWithValue("@id", Id);
            cmd.ExecuteNonQuery();
            con.Close();

            cmd = new SqlCommand("insert into transaction_info(student,book,date_of_issue,due_date) values(@student,@book,@date_of_issue,@due_date)", con);
            con.Open();
            cmd.Parameters.AddWithValue("@student", Globals.user_name);
            cmd.Parameters.AddWithValue("@book", txt_bk_title.Text);
            cmd.Parameters.AddWithValue("@date_of_issue", DateTime.Today);
            cmd.Parameters.AddWithValue("@due_date", DateTime.Today.AddDays(7));
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Success");
        }
    }
}
