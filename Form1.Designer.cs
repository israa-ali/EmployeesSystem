namespace EmployeesSystem
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.save_emp = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtBirth = new System.Windows.Forms.TextBox();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.department = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(215, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(619, 233);
            this.dataGridView1.TabIndex = 33;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // save_emp
            // 
            this.save_emp.Location = new System.Drawing.Point(76, 303);
            this.save_emp.Name = "save_emp";
            this.save_emp.Size = new System.Drawing.Size(121, 23);
            this.save_emp.TabIndex = 32;
            this.save_emp.Text = "Save";
            this.save_emp.UseVisualStyleBackColor = true;
            this.save_emp.Click += new System.EventHandler(this.Add_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(434, 309);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 31;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(76, 183);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(121, 20);
            this.txtAddress.TabIndex = 30;
            // 
            // txtBirth
            // 
            this.txtBirth.Location = new System.Drawing.Point(76, 223);
            this.txtBirth.Name = "txtBirth";
            this.txtBirth.Size = new System.Drawing.Size(121, 20);
            this.txtBirth.TabIndex = 29;
            // 
            // txtLast
            // 
            this.txtLast.Location = new System.Drawing.Point(76, 148);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(121, 20);
            this.txtLast.TabIndex = 28;
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(76, 108);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(121, 20);
            this.txtFirst.TabIndex = 27;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(76, 69);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(121, 20);
            this.txtId.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Birth Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Department";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "First name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Emp ID";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(328, 311);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(255, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Employee ID";
            // 
            // department
            // 
            this.department.FormattingEnabled = true;
            this.department.Items.AddRange(new object[] {
            "control",
            "computer",
            "communication"});
            this.department.Location = new System.Drawing.Point(76, 264);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(121, 21);
            this.department.TabIndex = 38;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 450);
            this.Controls.Add(this.department);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.save_emp);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtBirth);
            this.Controls.Add(this.txtLast);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button save_emp;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtBirth;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox department;
    }
}

