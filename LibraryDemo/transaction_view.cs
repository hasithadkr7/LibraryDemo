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
    public partial class transaction_view : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-A5NPQGU\SQLEXPRESS;Initial Catalog=ProjectDB;Integrated Security=True");
        SqlDataAdapter adapter;
        public transaction_view()
        {
            InitializeComponent();
            transaction_view_Display();
        }

        private void transaction_view_Display()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapter = new SqlDataAdapter("select * from transaction_info", con);
            adapter.Fill(dt);
            dgv_transaction_view.DataSource = dt;
            con.Close();
        }

        private void btn_trn_view_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
