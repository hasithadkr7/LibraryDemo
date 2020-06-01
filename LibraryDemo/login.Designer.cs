namespace LibraryDemo
{
    partial class login
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
            this.txt_user_name = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_login_exit = new System.Windows.Forms.Button();
            this.radio_btn_student = new System.Windows.Forms.RadioButton();
            this.radio_btn_admin = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txt_user_name
            // 
            this.txt_user_name.Location = new System.Drawing.Point(154, 71);
            this.txt_user_name.Name = "txt_user_name";
            this.txt_user_name.Size = new System.Drawing.Size(179, 20);
            this.txt_user_name.TabIndex = 0;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(154, 146);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(179, 20);
            this.txt_password.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(258, 282);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 29);
            this.btn_login.TabIndex = 6;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_login_exit
            // 
            this.btn_login_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login_exit.Location = new System.Drawing.Point(44, 282);
            this.btn_login_exit.Name = "btn_login_exit";
            this.btn_login_exit.Size = new System.Drawing.Size(75, 29);
            this.btn_login_exit.TabIndex = 7;
            this.btn_login_exit.Text = "Exit";
            this.btn_login_exit.UseVisualStyleBackColor = true;
            this.btn_login_exit.Click += new System.EventHandler(this.btn_login_exit_Click);
            // 
            // radio_btn_student
            // 
            this.radio_btn_student.AutoSize = true;
            this.radio_btn_student.Checked = true;
            this.radio_btn_student.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_btn_student.Location = new System.Drawing.Point(43, 217);
            this.radio_btn_student.Name = "radio_btn_student";
            this.radio_btn_student.Size = new System.Drawing.Size(82, 21);
            this.radio_btn_student.TabIndex = 8;
            this.radio_btn_student.TabStop = true;
            this.radio_btn_student.Text = "Student";
            this.radio_btn_student.UseVisualStyleBackColor = true;
            // 
            // radio_btn_admin
            // 
            this.radio_btn_admin.AutoSize = true;
            this.radio_btn_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_btn_admin.Location = new System.Drawing.Point(154, 217);
            this.radio_btn_admin.Name = "radio_btn_admin";
            this.radio_btn_admin.Size = new System.Drawing.Size(70, 21);
            this.radio_btn_admin.TabIndex = 9;
            this.radio_btn_admin.TabStop = true;
            this.radio_btn_admin.Text = "Admin";
            this.radio_btn_admin.UseVisualStyleBackColor = true;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 349);
            this.Controls.Add(this.radio_btn_admin);
            this.Controls.Add(this.radio_btn_student);
            this.Controls.Add(this.btn_login_exit);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_user_name);
            this.Name = "login";
            this.Text = "login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_user_name;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_login_exit;
        private System.Windows.Forms.RadioButton radio_btn_student;
        private System.Windows.Forms.RadioButton radio_btn_admin;
    }
}

