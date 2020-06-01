namespace LibraryDemo
{
    partial class books_view
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
            this.components = new System.ComponentModel.Container();
            this.bookinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.admin_book_view = new LibraryDemo.admin_book_view();
            this.book_infoTableAdapter = new LibraryDemo.admin_book_viewTableAdapters.book_infoTableAdapter();
            this.dgv_book_view = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_book_title = new System.Windows.Forms.TextBox();
            this.txt_book_author = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.no_copies = new System.Windows.Forms.NumericUpDown();
            this.cmb_book_category = new System.Windows.Forms.ComboBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bookinfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admin_book_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_book_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.no_copies)).BeginInit();
            this.SuspendLayout();
            // 
            // bookinfoBindingSource
            // 
            this.bookinfoBindingSource.DataMember = "book_info";
            this.bookinfoBindingSource.DataSource = this.admin_book_view;
            // 
            // admin_book_view
            // 
            this.admin_book_view.DataSetName = "admin_book_view";
            this.admin_book_view.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // book_infoTableAdapter
            // 
            this.book_infoTableAdapter.ClearBeforeFill = true;
            // 
            // dgv_book_view
            // 
            this.dgv_book_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_book_view.Location = new System.Drawing.Point(12, 253);
            this.dgv_book_view.Name = "dgv_book_view";
            this.dgv_book_view.Size = new System.Drawing.Size(359, 150);
            this.dgv_book_view.TabIndex = 0;
            this.dgv_book_view.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_book_view_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title";
            // 
            // txt_book_title
            // 
            this.txt_book_title.Location = new System.Drawing.Point(179, 26);
            this.txt_book_title.Name = "txt_book_title";
            this.txt_book_title.Size = new System.Drawing.Size(192, 20);
            this.txt_book_title.TabIndex = 2;
            // 
            // txt_book_author
            // 
            this.txt_book_author.Location = new System.Drawing.Point(179, 65);
            this.txt_book_author.Name = "txt_book_author";
            this.txt_book_author.Size = new System.Drawing.Size(192, 20);
            this.txt_book_author.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Author";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "No. of Copies";
            // 
            // no_copies
            // 
            this.no_copies.Location = new System.Drawing.Point(179, 147);
            this.no_copies.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.no_copies.Name = "no_copies";
            this.no_copies.Size = new System.Drawing.Size(120, 20);
            this.no_copies.TabIndex = 8;
            // 
            // cmb_book_category
            // 
            this.cmb_book_category.FormattingEnabled = true;
            this.cmb_book_category.Items.AddRange(new object[] {
            "Novel",
            "History",
            "Science Fiction",
            "Comic"});
            this.cmb_book_category.Location = new System.Drawing.Point(179, 102);
            this.cmb_book_category.Name = "cmb_book_category";
            this.cmb_book_category.Size = new System.Drawing.Size(121, 21);
            this.cmb_book_category.TabIndex = 9;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(295, 197);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 10;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(203, 197);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 11;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(108, 197);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 12;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(13, 197);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 13;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // books_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 415);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.cmb_book_category);
            this.Controls.Add(this.no_copies);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_book_author);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_book_title);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_book_view);
            this.Name = "books_view";
            this.Text = "books_view";
            //this.Load += new System.EventHandler(this.books_view_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookinfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admin_book_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_book_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.no_copies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private admin_book_view admin_book_view;
        private System.Windows.Forms.BindingSource bookinfoBindingSource;
        private admin_book_viewTableAdapters.book_infoTableAdapter book_infoTableAdapter;
        private System.Windows.Forms.DataGridView dgv_book_view;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_book_title;
        private System.Windows.Forms.TextBox txt_book_author;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown no_copies;
        private System.Windows.Forms.ComboBox cmb_book_category;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_cancel;
    }
}