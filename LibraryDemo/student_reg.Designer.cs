namespace LibraryDemo
{
    partial class student_reg
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tx_student_reg_user = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tx_student_reg_password = new System.Windows.Forms.TextBox();
            this.tx_student_reg_name = new System.Windows.Forms.TextBox();
            this.tx_student_reg_class = new System.Windows.Forms.TextBox();
            this.btn_student_reg_cancel = new System.Windows.Forms.Button();
            this.btn_student_reg_save = new System.Windows.Forms.Button();
            this.num_student_reg_grade = new System.Windows.Forms.NumericUpDown();
            this.dgv_students = new System.Windows.Forms.DataGridView();
            this.btn_student_reg_update = new System.Windows.Forms.Button();
            this.btn_student_reg_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_student_reg_grade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_students)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Student Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Grade";
            // 
            // tx_student_reg_user
            // 
            this.tx_student_reg_user.Location = new System.Drawing.Point(181, 23);
            this.tx_student_reg_user.Name = "tx_student_reg_user";
            this.tx_student_reg_user.Size = new System.Drawing.Size(181, 20);
            this.tx_student_reg_user.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Class";
            // 
            // tx_student_reg_password
            // 
            this.tx_student_reg_password.Location = new System.Drawing.Point(181, 66);
            this.tx_student_reg_password.Name = "tx_student_reg_password";
            this.tx_student_reg_password.PasswordChar = '*';
            this.tx_student_reg_password.Size = new System.Drawing.Size(181, 20);
            this.tx_student_reg_password.TabIndex = 6;
            // 
            // tx_student_reg_name
            // 
            this.tx_student_reg_name.Location = new System.Drawing.Point(181, 111);
            this.tx_student_reg_name.Name = "tx_student_reg_name";
            this.tx_student_reg_name.Size = new System.Drawing.Size(181, 20);
            this.tx_student_reg_name.TabIndex = 7;
            // 
            // tx_student_reg_class
            // 
            this.tx_student_reg_class.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tx_student_reg_class.Location = new System.Drawing.Point(181, 206);
            this.tx_student_reg_class.MaxLength = 1;
            this.tx_student_reg_class.Name = "tx_student_reg_class";
            this.tx_student_reg_class.Size = new System.Drawing.Size(181, 20);
            this.tx_student_reg_class.TabIndex = 9;
            // 
            // btn_student_reg_cancel
            // 
            this.btn_student_reg_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_student_reg_cancel.Location = new System.Drawing.Point(23, 261);
            this.btn_student_reg_cancel.Name = "btn_student_reg_cancel";
            this.btn_student_reg_cancel.Size = new System.Drawing.Size(75, 31);
            this.btn_student_reg_cancel.TabIndex = 10;
            this.btn_student_reg_cancel.Text = "Cancel";
            this.btn_student_reg_cancel.UseVisualStyleBackColor = true;
            this.btn_student_reg_cancel.Click += new System.EventHandler(this.btn_student_reg_cancel_Click);
            // 
            // btn_student_reg_save
            // 
            this.btn_student_reg_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_student_reg_save.Location = new System.Drawing.Point(287, 261);
            this.btn_student_reg_save.Name = "btn_student_reg_save";
            this.btn_student_reg_save.Size = new System.Drawing.Size(75, 31);
            this.btn_student_reg_save.TabIndex = 11;
            this.btn_student_reg_save.Text = "Save";
            this.btn_student_reg_save.UseVisualStyleBackColor = true;
            this.btn_student_reg_save.Click += new System.EventHandler(this.btn_student_reg_save_Click);
            // 
            // num_student_reg_grade
            // 
            this.num_student_reg_grade.Location = new System.Drawing.Point(181, 157);
            this.num_student_reg_grade.Maximum = new decimal(new int[] {
            13,
            0,
            0,
            0});
            this.num_student_reg_grade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_student_reg_grade.Name = "num_student_reg_grade";
            this.num_student_reg_grade.Size = new System.Drawing.Size(181, 20);
            this.num_student_reg_grade.TabIndex = 12;
            this.num_student_reg_grade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dgv_students
            // 
            this.dgv_students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_students.Location = new System.Drawing.Point(23, 317);
            this.dgv_students.Name = "dgv_students";
            this.dgv_students.Size = new System.Drawing.Size(339, 175);
            this.dgv_students.TabIndex = 13;
            this.dgv_students.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_students_CellContentClick);
            // 
            // btn_student_reg_update
            // 
            this.btn_student_reg_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_student_reg_update.Location = new System.Drawing.Point(200, 261);
            this.btn_student_reg_update.Name = "btn_student_reg_update";
            this.btn_student_reg_update.Size = new System.Drawing.Size(75, 31);
            this.btn_student_reg_update.TabIndex = 14;
            this.btn_student_reg_update.Text = "Update";
            this.btn_student_reg_update.UseVisualStyleBackColor = true;
            this.btn_student_reg_update.Click += new System.EventHandler(this.btn_student_reg_update_Click);
            // 
            // btn_student_reg_delete
            // 
            this.btn_student_reg_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_student_reg_delete.Location = new System.Drawing.Point(113, 261);
            this.btn_student_reg_delete.Name = "btn_student_reg_delete";
            this.btn_student_reg_delete.Size = new System.Drawing.Size(75, 31);
            this.btn_student_reg_delete.TabIndex = 15;
            this.btn_student_reg_delete.Text = "Delete";
            this.btn_student_reg_delete.UseVisualStyleBackColor = true;
            this.btn_student_reg_delete.Click += new System.EventHandler(this.btn_student_reg_delete_Click);
            // 
            // student_reg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 519);
            this.Controls.Add(this.btn_student_reg_delete);
            this.Controls.Add(this.btn_student_reg_update);
            this.Controls.Add(this.dgv_students);
            this.Controls.Add(this.num_student_reg_grade);
            this.Controls.Add(this.btn_student_reg_save);
            this.Controls.Add(this.btn_student_reg_cancel);
            this.Controls.Add(this.tx_student_reg_class);
            this.Controls.Add(this.tx_student_reg_name);
            this.Controls.Add(this.tx_student_reg_password);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tx_student_reg_user);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "student_reg";
            this.Text = "student_reg";
            ((System.ComponentModel.ISupportInitialize)(this.num_student_reg_grade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_students)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tx_student_reg_user;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tx_student_reg_name;
        private System.Windows.Forms.TextBox tx_student_reg_class;
        private System.Windows.Forms.Button btn_student_reg_cancel;
        private System.Windows.Forms.Button btn_student_reg_save;
        protected System.Windows.Forms.TextBox tx_student_reg_password;
        private System.Windows.Forms.NumericUpDown num_student_reg_grade;
        private System.Windows.Forms.DataGridView dgv_students;
        private System.Windows.Forms.Button btn_student_reg_update;
        private System.Windows.Forms.Button btn_student_reg_delete;
    }
}