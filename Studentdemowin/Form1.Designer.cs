namespace Studentdemowin
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
            this.txtStudentRollNo = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.Label();
            this.txtStudentCity = new System.Windows.Forms.Label();
            this.txtPercentage = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textRollNo = new System.Windows.Forms.TextBox();
            this.textCity = new System.Windows.Forms.TextBox();
            this.textPercentage = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnReadAllStudentData = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtStudentRollNo
            // 
            this.txtStudentRollNo.AutoSize = true;
            this.txtStudentRollNo.Location = new System.Drawing.Point(57, 64);
            this.txtStudentRollNo.Name = "txtStudentRollNo";
            this.txtStudentRollNo.Size = new System.Drawing.Size(97, 16);
            this.txtStudentRollNo.TabIndex = 0;
            this.txtStudentRollNo.Text = "Student RollNo";
            // 
            // txtStudentName
            // 
            this.txtStudentName.AutoSize = true;
            this.txtStudentName.Location = new System.Drawing.Point(57, 106);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(92, 16);
            this.txtStudentName.TabIndex = 1;
            this.txtStudentName.Text = "Student Name";
            this.txtStudentName.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtStudentCity
            // 
            this.txtStudentCity.AutoSize = true;
            this.txtStudentCity.Location = new System.Drawing.Point(57, 168);
            this.txtStudentCity.Name = "txtStudentCity";
            this.txtStudentCity.Size = new System.Drawing.Size(77, 16);
            this.txtStudentCity.TabIndex = 2;
            this.txtStudentCity.Text = "Student City";
            // 
            // txtPercentage
            // 
            this.txtPercentage.AutoSize = true;
            this.txtPercentage.Location = new System.Drawing.Point(57, 224);
            this.txtPercentage.Name = "txtPercentage";
            this.txtPercentage.Size = new System.Drawing.Size(77, 16);
            this.txtPercentage.TabIndex = 3;
            this.txtPercentage.Text = "Percentage";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(203, 106);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(100, 22);
            this.textName.TabIndex = 4;
            // 
            // textRollNo
            // 
            this.textRollNo.Location = new System.Drawing.Point(203, 64);
            this.textRollNo.Name = "textRollNo";
            this.textRollNo.Size = new System.Drawing.Size(100, 22);
            this.textRollNo.TabIndex = 5;
            // 
            // textCity
            // 
            this.textCity.Location = new System.Drawing.Point(203, 162);
            this.textCity.Name = "textCity";
            this.textCity.Size = new System.Drawing.Size(100, 22);
            this.textCity.TabIndex = 6;
            // 
            // textPercentage
            // 
            this.textPercentage.Location = new System.Drawing.Point(203, 221);
            this.textPercentage.Name = "textPercentage";
            this.textPercentage.Size = new System.Drawing.Size(100, 22);
            this.textPercentage.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(24, 289);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(164, 289);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(307, 289);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(468, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(287, 153);
            this.dataGridView1.TabIndex = 11;
            // 
            // btnReadAllStudentData
            // 
            this.btnReadAllStudentData.Location = new System.Drawing.Point(524, 289);
            this.btnReadAllStudentData.Name = "btnReadAllStudentData";
            this.btnReadAllStudentData.Size = new System.Drawing.Size(198, 23);
            this.btnReadAllStudentData.TabIndex = 12;
            this.btnReadAllStudentData.Text = "Read All Student Data";
            this.btnReadAllStudentData.UseVisualStyleBackColor = true;
            this.btnReadAllStudentData.Click += new System.EventHandler(this.btnReadAllStudentData_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(340, 64);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnReadAllStudentData);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textPercentage);
            this.Controls.Add(this.textCity);
            this.Controls.Add(this.textRollNo);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.txtPercentage);
            this.Controls.Add(this.txtStudentCity);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.txtStudentRollNo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtStudentRollNo;
        private System.Windows.Forms.Label txtStudentName;
        private System.Windows.Forms.Label txtStudentCity;
        private System.Windows.Forms.Label txtPercentage;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textRollNo;
        private System.Windows.Forms.TextBox textCity;
        private System.Windows.Forms.TextBox textPercentage;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnReadAllStudentData;
        private System.Windows.Forms.Button btnSearch;
    }
}

