namespace LibraryDemo
{
    partial class lend_books
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_books_shelf = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_bk_title = new System.Windows.Forms.TextBox();
            this.txt_bk_author = new System.Windows.Forms.TextBox();
            this.cmb_bk_category = new System.Windows.Forms.ComboBox();
            this.btn_search_title = new System.Windows.Forms.Button();
            this.btn_search_category = new System.Windows.Forms.Button();
            this.btn_search_author = new System.Windows.Forms.Button();
            this.btn_borrow = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_view_all = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_books_shelf)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_books_shelf
            // 
            this.dgv_books_shelf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_books_shelf.Location = new System.Drawing.Point(21, 222);
            this.dgv_books_shelf.Name = "dgv_books_shelf";
            this.dgv_books_shelf.Size = new System.Drawing.Size(460, 195);
            this.dgv_books_shelf.TabIndex = 0;
            this.dgv_books_shelf.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_books_shelf_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search Books";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Author";
            // 
            // txt_bk_title
            // 
            this.txt_bk_title.Location = new System.Drawing.Point(95, 62);
            this.txt_bk_title.Name = "txt_bk_title";
            this.txt_bk_title.Size = new System.Drawing.Size(204, 20);
            this.txt_bk_title.TabIndex = 5;
            // 
            // txt_bk_author
            // 
            this.txt_bk_author.Location = new System.Drawing.Point(95, 140);
            this.txt_bk_author.Name = "txt_bk_author";
            this.txt_bk_author.Size = new System.Drawing.Size(204, 20);
            this.txt_bk_author.TabIndex = 7;
            // 
            // cmb_bk_category
            // 
            this.cmb_bk_category.FormattingEnabled = true;
            this.cmb_bk_category.Items.AddRange(new object[] {
            "Novel",
            "Science Fiction",
            "Comic",
            "History"});
            this.cmb_bk_category.Location = new System.Drawing.Point(95, 99);
            this.cmb_bk_category.Name = "cmb_bk_category";
            this.cmb_bk_category.Size = new System.Drawing.Size(121, 21);
            this.cmb_bk_category.TabIndex = 8;
            // 
            // btn_search_title
            // 
            this.btn_search_title.Location = new System.Drawing.Point(331, 60);
            this.btn_search_title.Name = "btn_search_title";
            this.btn_search_title.Size = new System.Drawing.Size(111, 23);
            this.btn_search_title.TabIndex = 9;
            this.btn_search_title.Text = "Search by Title";
            this.btn_search_title.UseVisualStyleBackColor = true;
            this.btn_search_title.Click += new System.EventHandler(this.btn_search_title_Click);
            // 
            // btn_search_category
            // 
            this.btn_search_category.Location = new System.Drawing.Point(331, 99);
            this.btn_search_category.Name = "btn_search_category";
            this.btn_search_category.Size = new System.Drawing.Size(111, 23);
            this.btn_search_category.TabIndex = 10;
            this.btn_search_category.Text = "Search by Category";
            this.btn_search_category.UseVisualStyleBackColor = true;
            this.btn_search_category.Click += new System.EventHandler(this.btn_search_category_Click);
            // 
            // btn_search_author
            // 
            this.btn_search_author.Location = new System.Drawing.Point(331, 140);
            this.btn_search_author.Name = "btn_search_author";
            this.btn_search_author.Size = new System.Drawing.Size(111, 23);
            this.btn_search_author.TabIndex = 11;
            this.btn_search_author.Text = "Search by Author";
            this.btn_search_author.UseVisualStyleBackColor = true;
            this.btn_search_author.Click += new System.EventHandler(this.btn_search_author_Click);
            // 
            // btn_borrow
            // 
            this.btn_borrow.Location = new System.Drawing.Point(313, 448);
            this.btn_borrow.Name = "btn_borrow";
            this.btn_borrow.Size = new System.Drawing.Size(168, 28);
            this.btn_borrow.TabIndex = 12;
            this.btn_borrow.Text = "Borrow Selected Book";
            this.btn_borrow.UseVisualStyleBackColor = true;
            this.btn_borrow.Click += new System.EventHandler(this.btn_borrow_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(21, 444);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 28);
            this.btn_exit.TabIndex = 13;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_view_all
            // 
            this.btn_view_all.Location = new System.Drawing.Point(331, 182);
            this.btn_view_all.Name = "btn_view_all";
            this.btn_view_all.Size = new System.Drawing.Size(111, 23);
            this.btn_view_all.TabIndex = 14;
            this.btn_view_all.Text = "View All";
            this.btn_view_all.UseVisualStyleBackColor = true;
            this.btn_view_all.Click += new System.EventHandler(this.btn_view_all_Click);
            // 
            // lend_books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 502);
            this.Controls.Add(this.btn_view_all);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_borrow);
            this.Controls.Add(this.btn_search_author);
            this.Controls.Add(this.btn_search_category);
            this.Controls.Add(this.btn_search_title);
            this.Controls.Add(this.cmb_bk_category);
            this.Controls.Add(this.txt_bk_author);
            this.Controls.Add(this.txt_bk_title);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_books_shelf);
            this.Name = "lend_books";
            this.Text = "lend_books";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_books_shelf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_books_shelf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_bk_title;
        private System.Windows.Forms.TextBox txt_bk_author;
        private System.Windows.Forms.ComboBox cmb_bk_category;
        private System.Windows.Forms.Button btn_search_title;
        private System.Windows.Forms.Button btn_search_category;
        private System.Windows.Forms.Button btn_search_author;
        private System.Windows.Forms.Button btn_borrow;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_view_all;
    }
}