namespace employeData
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            groupBox1 = new GroupBox();
            btnReset = new Button();
            btnView = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnInsert = new Button();
            cmbDesig = new ComboBox();
            ageField = new NumericUpDown();
            txtSalary = new TextBox();
            txtName = new TextBox();
            txtid = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            label8 = new Label();
            btnSearch = new Button();
            txtSearch = new TextBox();
            label7 = new Label();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ageField).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(423, 9);
            label1.Name = "label1";
            label1.Size = new Size(405, 36);
            label1.TabIndex = 0;
            label1.Text = "Employees Registration Form";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnReset);
            groupBox1.Controls.Add(btnView);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnInsert);
            groupBox1.Controls.Add(cmbDesig);
            groupBox1.Controls.Add(ageField);
            groupBox1.Controls.Add(txtSalary);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(txtid);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(35, 61);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(619, 285);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(447, 231);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(99, 36);
            btnReset.TabIndex = 11;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnView
            // 
            btnView.Location = new Point(447, 176);
            btnView.Name = "btnView";
            btnView.Size = new Size(99, 36);
            btnView.TabIndex = 10;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(447, 128);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(99, 36);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(447, 75);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(99, 36);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(447, 30);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(99, 36);
            btnInsert.TabIndex = 7;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // cmbDesig
            // 
            cmbDesig.FormattingEnabled = true;
            cmbDesig.Items.AddRange(new object[] { "SDE 1", "Manager", "SDE 2", "Clerk", "CEO" });
            cmbDesig.Location = new Point(199, 125);
            cmbDesig.Name = "cmbDesig";
            cmbDesig.Size = new Size(193, 36);
            cmbDesig.TabIndex = 3;
            cmbDesig.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // ageField
            // 
            ageField.Location = new Point(199, 229);
            ageField.Maximum = new decimal(new int[] { 70, 0, 0, 0 });
            ageField.Minimum = new decimal(new int[] { 22, 0, 0, 0 });
            ageField.Name = "ageField";
            ageField.Size = new Size(193, 34);
            ageField.TabIndex = 5;
            ageField.Value = new decimal(new int[] { 22, 0, 0, 0 });
            ageField.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(199, 177);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(193, 34);
            txtSalary.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Location = new Point(199, 75);
            txtName.Name = "txtName";
            txtName.Size = new Size(193, 34);
            txtName.TabIndex = 2;
            // 
            // txtid
            // 
            txtid.Location = new Point(199, 30);
            txtid.Name = "txtid";
            txtid.Size = new Size(193, 34);
            txtid.TabIndex = 1;
            txtid.TextChanged += txtid_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 235);
            label6.Name = "label6";
            label6.Size = new Size(47, 28);
            label6.TabIndex = 4;
            label6.Text = "Age";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 177);
            label5.Name = "label5";
            label5.Size = new Size(65, 28);
            label5.TabIndex = 3;
            label5.Text = "Salary";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 75);
            label4.Name = "label4";
            label4.Size = new Size(64, 28);
            label4.TabIndex = 2;
            label4.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 128);
            label3.Name = "label3";
            label3.Size = new Size(117, 28);
            label3.TabIndex = 1;
            label3.Text = "Designation";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 30);
            label2.Name = "label2";
            label2.Size = new Size(122, 28);
            label2.TabIndex = 0;
            label2.Text = "Employee ID";
            label2.Click += label2_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(btnSearch);
            groupBox2.Controls.Add(txtSearch);
            groupBox2.Controls.Add(label7);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(35, 370);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(619, 64);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(28, 21);
            label8.Name = "label8";
            label8.Size = new Size(70, 28);
            label8.TabIndex = 21;
            label8.Text = "Search";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(447, 17);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(99, 36);
            btnSearch.TabIndex = 13;
            btnSearch.Text = "Go";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(199, 15);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(193, 34);
            txtSearch.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(-74, 7);
            label7.Name = "label7";
            label7.Size = new Size(65, 28);
            label7.TabIndex = 18;
            label7.Text = "Salary";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(35, 490);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(724, 188);
            dataGridView1.TabIndex = 3;
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
            // 
            // Form1
            // 
            AccessibleName = "";
            AccessibleRole = AccessibleRole.ScrollBar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1173, 700);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ageField).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnInsert;
        private ComboBox cmbDesig;
        private NumericUpDown ageField;
        private TextBox txtSalary;
        private TextBox txtName;
        private TextBox txtid;
        private Button btnReset;
        private Button btnView;
        private Button btnDelete;
        private Button btnUpdate;
        private GroupBox groupBox2;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label label7;
        private Label label8;
        private DataGridView dataGridView1;
    }
}