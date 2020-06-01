using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryDemo
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void btn_admin_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_admin_student_add_Click(object sender, EventArgs e)
        {
            student_reg student_add = new student_reg();
            student_add.Show();
        }

        private void btn_admin_tran_view_Click(object sender, EventArgs e)
        {
            transaction_view trn_view = new transaction_view();
            trn_view.Show();
        }

        private void btn_admin_books_add_Click(object sender, EventArgs e)
        {
            books_view book_add = new books_view();
            book_add.Show();
        }

        private void btn_admin_books_update_Click(object sender, EventArgs e)
        {
            books_view book_add = new books_view();
            book_add.Show();
        }

        private void btn_admin_books_remove_Click(object sender, EventArgs e)
        {
            books_view book_add = new books_view();
            book_add.Show();
        }

        private void btn_admin_student_update_Click(object sender, EventArgs e)
        {
            student_reg student_add = new student_reg();
            student_add.Show();
        }

        private void btn_admin_student_delete_Click(object sender, EventArgs e)
        {
            student_reg student_add = new student_reg();
            student_add.Show();
        }

        private void btn_bk_return_Click(object sender, EventArgs e)
        {
            book_return return_view = new book_return();
            return_view.Show();
        }
    }
}
