using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SchoolMangementSystem
{
    public partial class AddSubjectForm : UserControl
    {
        SqlConnection connect = new SqlConnection(
            @"Data Source=DESKTOP-QUI2HH8\SQLEXPRESS;Initial Catalog=school;Integrated Security=True;");

        SqlTransaction transaction;

        public AddSubjectForm()
        {
            InitializeComponent();
            displaySubjectData();
        }

        // Display Data
        public void displaySubjectData()
        {
            AddSubjectData sData = new AddSubjectData();
            subject_dataGridView.DataSource = sData.subjectData();
        }

        // Add Subject
        private void subject_addBtn_Click(object sender, EventArgs e)
        {
            if (subject_id.Text == ""
                || subject_name.Text == ""
                || subject_grade.Text == ""
                || subject_description.Text == ""
                || subject_status.Text == "")
            {
                MessageBox.Show("Please fill all blank fields",
                    "Error Message",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();
                        transaction = connect.BeginTransaction();

                        // Check Subject ID
                        string checkSubjectID =
                            "SELECT COUNT(*) FROM subjects WHERE subject_id = @subjectID";

                        using (SqlCommand checkSID =
                            new SqlCommand(checkSubjectID, connect, transaction))
                        {
                            checkSID.Parameters.AddWithValue("@subjectID",
                                subject_id.Text.Trim());

                            int count = (int)checkSID.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show("Subject ID already exists",
                                    "Error Message",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);

                                transaction.Rollback();
                                return;
                            }
                        }

                        DateTime today = DateTime.Today;

                        string insertData =
                            "INSERT INTO subjects " +
                            "(subject_id, subject_name, subject_grade, " +
                            "subject_description, status, date_insert) " +
                            "VALUES (@subjectID, @subjectName, @subjectGrade, " +
                            "@subjectDescription, @status, @dateInsert)";

                        using (SqlCommand cmd =
                            new SqlCommand(insertData, connect, transaction))
                        {
                            cmd.Parameters.AddWithValue("@subjectID",
                                subject_id.Text.Trim());

                            cmd.Parameters.AddWithValue("@subjectName",
                                subject_name.Text.Trim());

                            cmd.Parameters.AddWithValue("@subjectGrade",
                                subject_grade.Text.Trim());

                            cmd.Parameters.AddWithValue("@subjectDescription",
                                subject_description.Text.Trim());

                            cmd.Parameters.AddWithValue("@status",
                                subject_status.Text.Trim());

                            cmd.Parameters.AddWithValue("@dateInsert",
                                today.ToString());

                            cmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        displaySubjectData();

                        MessageBox.Show("Added successfully!",
                            "Information Message",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        clearFields();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();

                        MessageBox.Show("Error: " + ex,
                            "Error Message",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        // Update Subject
        private void subject_updateBtn_Click(object sender, EventArgs e)
        {
            if (subject_id.Text == "")
            {
                MessageBox.Show("Please select item first",
                    "Error Message",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();
                        transaction = connect.BeginTransaction();

                        DialogResult check = MessageBox.Show(
                            "Are you sure you want to update Subject ID: "
                            + subject_id.Text.Trim() + "?",
                            "Confirmation Message",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);

                        if (check == DialogResult.Yes)
                        {
                            DateTime today = DateTime.Today;

                            string updateData =
                                "UPDATE subjects SET " +
                                "subject_name = @subjectName, " +
                                "subject_grade = @subjectGrade, " +
                                "subject_description = @subjectDescription, " +
                                "status = @status, " +
                                "date_update = @dateUpdate " +
                                "WHERE subject_id = @subjectID";

                            using (SqlCommand cmd =
                                new SqlCommand(updateData, connect, transaction))
                            {
                                cmd.Parameters.AddWithValue("@subjectName",
                                    subject_name.Text.Trim());

                                cmd.Parameters.AddWithValue("@subjectGrade",
                                    subject_grade.Text.Trim());

                                cmd.Parameters.AddWithValue("@subjectDescription",
                                    subject_description.Text.Trim());

                                cmd.Parameters.AddWithValue("@status",
                                    subject_status.Text.Trim());

                                cmd.Parameters.AddWithValue("@dateUpdate",
                                    today.ToString());

                                cmd.Parameters.AddWithValue("@subjectID",
                                    subject_id.Text.Trim());

                                cmd.ExecuteNonQuery();
                            }

                            transaction.Commit();

                            displaySubjectData();

                            MessageBox.Show("Updated successfully!",
                                "Information Message",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            clearFields();
                        }
                        else
                        {
                            MessageBox.Show("Cancelled.",
                                "Information Message",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();

                        MessageBox.Show("Error: " + ex,
                            "Error Message",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        // Delete Subject
        private void subject_deleteBtn_Click(object sender, EventArgs e)
        {
            if (subject_id.Text == "")
            {
                MessageBox.Show("Please select item first",
                    "Error Message",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show(
                    "Are you sure you want to delete Subject ID: "
                    + subject_id.Text.Trim() + "?",
                    "Confirmation Message",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();

                        DateTime today = DateTime.Today;

                        string deleteData =
                            "UPDATE subjects SET date_delete = @dateDelete " +
                            "WHERE subject_id = @subjectID";

                        using (SqlCommand cmd =
                            new SqlCommand(deleteData, connect))
                        {
                            cmd.Parameters.AddWithValue("@dateDelete",
                                today.ToString());

                            cmd.Parameters.AddWithValue("@subjectID",
                                subject_id.Text.Trim());

                            cmd.ExecuteNonQuery();

                            displaySubjectData();

                            MessageBox.Show("Deleted successfully!",
                                "Information Message",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            clearFields();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex,
                            "Error Message",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        // DataGridView Click
        private void subject_dataGridView_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row =
                    subject_dataGridView.Rows[e.RowIndex];

                subject_id.Text = row.Cells[1].Value.ToString();
                subject_name.Text = row.Cells[2].Value.ToString();
                subject_grade.Text = row.Cells[3].Value.ToString();
                subject_description.Text = row.Cells[4].Value.ToString();
                subject_status.Text = row.Cells[5].Value.ToString();
            }
        }
        // Clear Fields
        public void clearFields()
        {
            subject_id.Text = "";
            subject_name.Text = "";
            subject_grade.SelectedIndex = -1;
            subject_description.Text = "";
            subject_status.SelectedIndex = -1;
        }

        private void subject_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }
    }
}