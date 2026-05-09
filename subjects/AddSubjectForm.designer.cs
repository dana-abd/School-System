namespace SchoolMangementSystem
{
    partial class AddSubjectForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 =
                new System.Windows.Forms.DataGridViewCellStyle();

            this.panel1 = new System.Windows.Forms.Panel();
            this.subject_subjectData = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();

            this.panel2 = new System.Windows.Forms.Panel();

            this.subject_id = new System.Windows.Forms.TextBox();
            this.subject_name = new System.Windows.Forms.TextBox();
            this.subject_teacher = new System.Windows.Forms.TextBox();
            this.subject_description = new System.Windows.Forms.TextBox();

            this.subject_grade = new System.Windows.Forms.ComboBox();
            this.subject_status = new System.Windows.Forms.ComboBox();

            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();

            this.subject_addBtn = new System.Windows.Forms.Button();
            this.subject_updateBtn = new System.Windows.Forms.Button();
            this.subject_deleteBtn = new System.Windows.Forms.Button();
            this.subject_clearBtn = new System.Windows.Forms.Button();

            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subject_subjectData)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();

            // panel1
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.subject_subjectData);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(851, 290);

            // label1
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Text = "Subject's Data";

            // subject_subjectData
            this.subject_subjectData.AllowUserToAddRows = false;
            this.subject_subjectData.AllowUserToDeleteRows = false;
            this.subject_subjectData.BackgroundColor = System.Drawing.SystemColors.ButtonFace;

            dataGridViewCellStyle1.Alignment =
                System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;

            dataGridViewCellStyle1.BackColor =
                System.Drawing.Color.FromArgb(4, 87, 122);

            dataGridViewCellStyle1.ForeColor =
                System.Drawing.Color.White;

            this.subject_subjectData.ColumnHeadersDefaultCellStyle =
                dataGridViewCellStyle1;

            this.subject_subjectData.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subject_subjectData.EnableHeadersVisualStyles = false;
            this.subject_subjectData.Location = new System.Drawing.Point(20, 47);
            this.subject_subjectData.Name = "subject_subjectData";
            this.subject_subjectData.ReadOnly = true;
            this.subject_subjectData.RowHeadersVisible = false;
            this.subject_subjectData.Size = new System.Drawing.Size(810, 224);

            this.subject_subjectData.CellClick +=
                new System.Windows.Forms.DataGridViewCellEventHandler(
                    this.subject_subjectData_CellClick);

            // panel2
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.subject_id);
            this.panel2.Controls.Add(this.subject_name);
            this.panel2.Controls.Add(this.subject_teacher);
            this.panel2.Controls.Add(this.subject_description);
            this.panel2.Controls.Add(this.subject_grade);
            this.panel2.Controls.Add(this.subject_status);

            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);

            this.panel2.Controls.Add(this.subject_addBtn);
            this.panel2.Controls.Add(this.subject_updateBtn);
            this.panel2.Controls.Add(this.subject_deleteBtn);
            this.panel2.Controls.Add(this.subject_clearBtn);

            this.panel2.Location = new System.Drawing.Point(12, 320);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(851, 229);

            // subject_id
            this.subject_id.Location = new System.Drawing.Point(120, 20);
            this.subject_id.Multiline = true;
            this.subject_id.Size = new System.Drawing.Size(150, 25);

            // subject_name
            this.subject_name.Location = new System.Drawing.Point(120, 65);
            this.subject_name.Multiline = true;
            this.subject_name.Size = new System.Drawing.Size(150, 25);

            // subject_teacher
            this.subject_teacher.Location = new System.Drawing.Point(120, 110);
            this.subject_teacher.Multiline = true;
            this.subject_teacher.Size = new System.Drawing.Size(150, 25);

            // subject_grade
            this.subject_grade.FormattingEnabled = true;
            this.subject_grade.Items.AddRange(new object[] {
            "Grade 1",
            "Grade 2",
            "Grade 3",
            "Grade 4",
            "Grade 5",
            "Grade 6"});
            this.subject_grade.Location = new System.Drawing.Point(420, 20);
            this.subject_grade.Size = new System.Drawing.Size(150, 21);

            // subject_description
            this.subject_description.Location = new System.Drawing.Point(420, 65);
            this.subject_description.Multiline = true;
            this.subject_description.Size = new System.Drawing.Size(200, 60);

            // subject_status
            this.subject_status.FormattingEnabled = true;
            this.subject_status.Items.AddRange(new object[] {
            "Available",
            "Unavailable"});
            this.subject_status.Location = new System.Drawing.Point(700, 20);
            this.subject_status.Size = new System.Drawing.Size(120, 21);

            // labels
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 25);
            this.label2.Text = "Subject ID:";

            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 70);
            this.label3.Text = "Subject Name:";

            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 115);
            this.label4.Text = "Teacher:";
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(365, 25);
            this.label5.Text = "Grade:";

            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(345, 70);
            this.label6.Text = "Description:";

            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(650, 25);
            this.label7.Text = "Status:";

            // Add Button
            this.subject_addBtn.BackColor = System.Drawing.Color.Green;
            this.subject_addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subject_addBtn.ForeColor = System.Drawing.Color.White;
            this.subject_addBtn.Location = new System.Drawing.Point(180, 170);
            this.subject_addBtn.Size = new System.Drawing.Size(100, 35);
            this.subject_addBtn.Text = "Add";

            // Update Button
            this.subject_updateBtn.BackColor =
                System.Drawing.Color.FromArgb(255, 128, 0);

            this.subject_updateBtn.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.subject_updateBtn.ForeColor =
                System.Drawing.Color.White;

            this.subject_updateBtn.Location =
                new System.Drawing.Point(300, 170);

            this.subject_updateBtn.Size =
                new System.Drawing.Size(100, 35);

            this.subject_updateBtn.Text = "Update";

            // Delete Button
            this.subject_deleteBtn.BackColor = System.Drawing.Color.Red;
            this.subject_deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subject_deleteBtn.ForeColor = System.Drawing.Color.White;
            this.subject_deleteBtn.Location = new System.Drawing.Point(420, 170);
            this.subject_deleteBtn.Size = new System.Drawing.Size(100, 35);
            this.subject_deleteBtn.Text = "Delete";

            // Clear Button
            this.subject_clearBtn.BackColor = System.Drawing.Color.Gray;
            this.subject_clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subject_clearBtn.ForeColor = System.Drawing.Color.White;
            this.subject_clearBtn.Location = new System.Drawing.Point(540, 170);
            this.subject_clearBtn.Size = new System.Drawing.Size(100, 35);
            this.subject_clearBtn.Text = "Clear";

            // AddSubjectForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.BackColor =
                System.Drawing.Color.FromArgb(255, 224, 192);

            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);

            this.Name = "AddSubjectForm";
            this.Size = new System.Drawing.Size(875, 575);

            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();

            ((System.ComponentModel.ISupportInitialize)
                (this.subject_subjectData)).EndInit();

            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();

            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;

        private System.Windows.Forms.DataGridView subject_subjectData;

        private System.Windows.Forms.TextBox subject_id;
        private System.Windows.Forms.TextBox subject_name;
        private System.Windows.Forms.TextBox subject_teacher;
        private System.Windows.Forms.TextBox subject_description;

        private System.Windows.Forms.ComboBox subject_grade;
        private System.Windows.Forms.ComboBox subject_status;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.Button subject_addBtn;
        private System.Windows.Forms.Button subject_updateBtn;
        private System.Windows.Forms.Button subject_deleteBtn;
        private System.Windows.Forms.Button subject_clearBtn;
    }
}