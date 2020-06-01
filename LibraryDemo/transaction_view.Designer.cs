namespace LibraryDemo
{
    partial class transaction_view
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
            this.transactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectDBDataSet = new LibraryDemo.ProjectDBDataSet();
            this.transactionTableAdapter = new LibraryDemo.ProjectDBDataSetTableAdapters.transactionTableAdapter();
            this.btn_trn_view_exit = new System.Windows.Forms.Button();
            this.dgv_transaction_view = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_transaction_view)).BeginInit();
            this.SuspendLayout();
            // 
            // transactionBindingSource
            // 
            this.transactionBindingSource.DataMember = "transaction";
            this.transactionBindingSource.DataSource = this.projectDBDataSet;
            // 
            // projectDBDataSet
            // 
            this.projectDBDataSet.DataSetName = "ProjectDBDataSet";
            this.projectDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transactionTableAdapter
            // 
            this.transactionTableAdapter.ClearBeforeFill = true;
            // 
            // btn_trn_view_exit
            // 
            this.btn_trn_view_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_trn_view_exit.Location = new System.Drawing.Point(582, 293);
            this.btn_trn_view_exit.Name = "btn_trn_view_exit";
            this.btn_trn_view_exit.Size = new System.Drawing.Size(75, 29);
            this.btn_trn_view_exit.TabIndex = 3;
            this.btn_trn_view_exit.Text = "Exit";
            this.btn_trn_view_exit.UseVisualStyleBackColor = true;
            this.btn_trn_view_exit.Click += new System.EventHandler(this.btn_trn_view_exit_Click);
            // 
            // dgv_transaction_view
            // 
            this.dgv_transaction_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_transaction_view.Location = new System.Drawing.Point(15, 12);
            this.dgv_transaction_view.Name = "dgv_transaction_view";
            this.dgv_transaction_view.Size = new System.Drawing.Size(642, 262);
            this.dgv_transaction_view.TabIndex = 4;
            // 
            // transaction_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 334);
            this.Controls.Add(this.dgv_transaction_view);
            this.Controls.Add(this.btn_trn_view_exit);
            this.Name = "transaction_view";
            this.Text = "transaction_view";
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_transaction_view)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ProjectDBDataSet projectDBDataSet;
        private System.Windows.Forms.BindingSource transactionBindingSource;
        private ProjectDBDataSetTableAdapters.transactionTableAdapter transactionTableAdapter;
        private System.Windows.Forms.Button btn_trn_view_exit;
        private System.Windows.Forms.DataGridView dgv_transaction_view;
    }
}