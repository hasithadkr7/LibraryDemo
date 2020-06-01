namespace LibraryDemo
{
    partial class book_return
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_book_title = new System.Windows.Forms.TextBox();
            this.txt_student_name = new System.Windows.Forms.TextBox();
            this.btn_bk_return = new System.Windows.Forms.Button();
            this.btn_book_return_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student Name";
            // 
            // txt_book_title
            // 
            this.txt_book_title.Location = new System.Drawing.Point(186, 46);
            this.txt_book_title.Name = "txt_book_title";
            this.txt_book_title.Size = new System.Drawing.Size(189, 20);
            this.txt_book_title.TabIndex = 2;
            // 
            // txt_student_name
            // 
            this.txt_student_name.Location = new System.Drawing.Point(186, 91);
            this.txt_student_name.Name = "txt_student_name";
            this.txt_student_name.Size = new System.Drawing.Size(189, 20);
            this.txt_student_name.TabIndex = 3;
            // 
            // btn_bk_return
            // 
            this.btn_bk_return.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bk_return.Location = new System.Drawing.Point(257, 168);
            this.btn_bk_return.Name = "btn_bk_return";
            this.btn_bk_return.Size = new System.Drawing.Size(117, 23);
            this.btn_bk_return.TabIndex = 4;
            this.btn_bk_return.Text = "Return Book";
            this.btn_bk_return.UseVisualStyleBackColor = true;
            this.btn_bk_return.Click += new System.EventHandler(this.btn_bk_return_Click);
            // 
            // btn_book_return_exit
            // 
            this.btn_book_return_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_book_return_exit.Location = new System.Drawing.Point(46, 168);
            this.btn_book_return_exit.Name = "btn_book_return_exit";
            this.btn_book_return_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_book_return_exit.TabIndex = 5;
            this.btn_book_return_exit.Text = "Exit";
            this.btn_book_return_exit.UseVisualStyleBackColor = true;
            this.btn_book_return_exit.Click += new System.EventHandler(this.btn_book_return_exit_Click);
            // 
            // book_return
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 218);
            this.Controls.Add(this.btn_book_return_exit);
            this.Controls.Add(this.btn_bk_return);
            this.Controls.Add(this.txt_student_name);
            this.Controls.Add(this.txt_book_title);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "book_return";
            this.Text = "book_return";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_book_title;
        private System.Windows.Forms.TextBox txt_student_name;
        private System.Windows.Forms.Button btn_bk_return;
        private System.Windows.Forms.Button btn_book_return_exit;
    }
}