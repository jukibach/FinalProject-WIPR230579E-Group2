using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsForm_FinalProject.Models;
using WindowsForm_FinalProject.Controllers;
using System.Globalization;

namespace WindowsForm_FinalProject.Views
{
    public partial class SearchForm : Form
    {
        StudentProjectController studentProjectController = new StudentProjectController();
        StudentController studentController = new StudentController();
        Score score = new Score();
        public SearchForm(ref List<Student> students, List<Project> projects)
        {
            InitializeComponent();
            this.cPID.DataPropertyName = nameof(Project.PID);
            this.cPBegin.DataPropertyName = nameof(Project.PBegin);
            this.cEnd.DataPropertyName = nameof(Project.PEnd);
            this.cPName.DataPropertyName = nameof(Project.PName);
            this.cPType.DataPropertyName = nameof(Project.PType);
            this.cPContent.DataPropertyName = nameof(Project.PContent);
            this.cScore.DataPropertyName = nameof(Project.Score);
            this.cComment.DataPropertyName = nameof(Project.Comment);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            Score score = new Score();
            if (score.createScoreTable() == false)
            {
                DataTable dt = studentProjectController.getproject(this.txtID.Text);
                bs.DataSource = dt;
                this.dataSearchID.DataSource = bs;

                dt = studentController.getInformationStudent(this.txtID.Text);

                foreach (DataRow row in dt.Rows)
                {
                    this.label5.Text = "Name:  " + row[1].ToString();
                    this.label6.Text = "Email: " + row[2].ToString();
                    this.label7.Text = "Phone: " + row[3].ToString();
                    this.label8.Text = "Gender: " + row[4].ToString();
                    this.label9.Text = "BirthDay: " + DateTime.ParseExact(row[5].ToString(), "dd-MMM-yy hh:mm:ss tt", CultureInfo.InvariantCulture).ToString("dd-MM-yyyy"); //"dd-MM-yyyy"
                    this.label10.Text = "Class: " + row[6].ToString();
                }
                this.cbbCourse.DisplayMember = "PName";
                this.cbbCourse.ValueMember = "PID";
                this.cbbCourse.DataSource = studentProjectController.getInfoProjectName(this.txtID.Text);
            };
            
        }

        private void dataSearchID_Click(object sender, EventArgs e)
        {
            txtID.Text = dataSearchID.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnAssess_Click(object sender, EventArgs e)
        {
            //    Project project = new Project();
            //    project.Score = this.txtScore.Text;
            //    project.Comment = this.txtComment.Text;
            //    //if (project.AddStudents(nStudent) == false)
            //    //{
            //    //    MessageBox.Show("Error in adding a new user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    //}

            //    BindingSource source = new BindingSource();
            //    //source.DataSource = ProjectController.getExistProject();
            //    this.dataSearchID.DataSource = source;
            //}
            StudentController studentController = new StudentController();

            try 
            {

                string ID = this.txtID.Text;
                int courseID = Convert.ToInt32(cbbCourse.SelectedValue);
                //https://stackoverflow.com/questions/9429139/unable-to-cast-object-of-type-system-data-datarowview-to-type-system-iconvert
                double scoreValue = Convert.ToDouble(txtScore.Text);
                string comment =this.txtComment.Text;
                if (score.insertScore(ID, courseID, scoreValue, comment))
                {
                    MessageBox.Show("Student Score Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Student Score Not Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                //if(cbbCourse.SelectedValue == this.dataSearchID.SelectedRows[0])
                //{
                //    double scoreValue = Convert.ToDouble(txtScore.Text);
                //    string comment = this.txtComment.Text;
                //}
                BindingSource bs = new BindingSource();
                DataTable dt = studentProjectController.getproject(this.txtID.Text);
                bs.DataSource = dt;
                this.dataSearchID.DataSource = bs;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void dataSearchID_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                return;
            }
            int index = e.RowIndex;
            Project project = new Project();
            if (this.dataSearchID.CurrentRow.Cells[0].Value is null)
            {
                this.dataSearchID.CurrentRow.Cells[0].Value = "";
            }
            else project.PID = int.Parse(this.dataSearchID.CurrentRow.Cells[0].Value.ToString());

            if (this.dataSearchID.CurrentRow.Cells[1].Value is null)
            {
                this.dataSearchID.CurrentRow.Cells[1].Value = "";
            }
            else project.PName =this.dataSearchID.CurrentRow.Cells[1].Value.ToString();

            if (this.dataSearchID.CurrentRow.Cells[2].Value is null)
            {
                this.dataSearchID.CurrentRow.Cells[2].Value = "";
            }
            else project.PContent = this.dataSearchID.CurrentRow.Cells[2].Value.ToString();

            if (this.dataSearchID.CurrentRow.Cells[3].Value is null)
            {
                this.dataSearchID.CurrentRow.Cells[3].Value = "";
            }
            else project.PType = this.dataSearchID.CurrentRow.Cells[3].Value.ToString();

            if (this.dataSearchID.CurrentRow.Cells[4].Value is null)
            {
                this.dataSearchID.CurrentRow.Cells[4].Value = "";
            }
            else project.PBegin = DateTime.ParseExact(this.dataSearchID.CurrentRow.Cells[4].Value.ToString(), "dd-MMM-yy hh:mm:ss tt", CultureInfo.InvariantCulture).Date;

            if (this.dataSearchID.CurrentRow.Cells[5].Value is null)
            {
                this.dataSearchID.CurrentRow.Cells[5].Value = "";
            }
            else project.PEnd = DateTime.ParseExact(this.dataSearchID.CurrentRow.Cells[5].Value.ToString(), "dd-MMM-yy hh:mm:ss tt", CultureInfo.InvariantCulture).Date;

            if (this.dataSearchID.CurrentRow.Cells[6].Value is null)
            {
                this.dataSearchID.CurrentRow.Cells[6].Value = "";
            }
            else project.Score = this.dataSearchID.CurrentRow.Cells[6].Value.ToString();
            //FullName
            if (this.dataSearchID.CurrentRow.Cells[7].Value is null)
            {
                this.dataSearchID.CurrentRow.Cells[7].Value = "";
            }
            else project.Comment = this.dataSearchID.CurrentRow.Cells[7].Value.ToString();
            if(project.Score == "")
            {
                project.Score = "0.0";
            }
             if (ProjectController.UpdateScore(project, this.txtID.Text) == false)
            {
                MessageBox.Show("Cannot update!");
            }
            else
            {
                MessageBox.Show("update sucessfully!");

            }
        }
            
    }
}
