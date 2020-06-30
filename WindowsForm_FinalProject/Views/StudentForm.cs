using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForm_FinalProject.Controllers;
using WindowsForm_FinalProject.Models;

namespace WindowsForm_FinalProject.Views
{
    public partial class StudentForm : Form
    {
        DateTimePicker dtp;
        private List<Student> listStudents;
        ComboBox cbb;
        StudentController studentController = new StudentController();

        public StudentForm(ref List<Student> students)
        {
            InitializeComponent();
            //this.cName.DataPropertyName = nameof(Student.Name);
            this.cFullname.DataPropertyName = nameof(Student.Fullname);
            this.cID.DataPropertyName = nameof(Student.ID);
            this.cBirthday.DataPropertyName = nameof(Student.Birthday);
            this.cGender.DataPropertyName = nameof(Student.Gender);
            this.cClasss.DataPropertyName = nameof(Student.Class);
            this.cEmail.DataPropertyName = nameof(Student.Email);
            this.cPhone.DataPropertyName = nameof(Student.Phone);
          

            BindingSource source = new BindingSource();
            source.DataSource = StudentController.getAllStudents(); ;
            this.dataStudent.DataSource = source;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private bool checkID(Student student)
        {
            var u = listStudents.Where(x => x.ID == student.ID).Count();
            return (u > 0);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.txtFullname.Text.Trim().Length <= 0)
            {
                erFullname.SetError(this.txtFullname, "Please enter fullname");
            }

            if (this.txtID.Text.Trim().Length <= 0)
            {
                erID.SetError(this.txtID, "Please enter ID");
            }
            else
            {
                if (StudentController.checkExistStudentName(this.txtID.Text.Trim()) == true)
                {
                    erID.SetError(this.txtID, "This ID is available in database");
                    return;
                }
            }


            Student nStudent = new Student();
            nStudent.Fullname = this.txtFullname.Text.Trim();
            nStudent.ID = this.txtID.Text.Trim();
            nStudent.Birthday = this.dtpBirthday.Value;
            nStudent.Gender = this.txtGender.Text.Trim();
            nStudent.Class = this.txtClass.Text.Trim();
            nStudent.Email = this.txtEmail.Text.Trim();
            nStudent.Phone = this.txtPhone.Text.Trim();


            if (StudentController.AddStudents(nStudent) == false)
            {
                MessageBox.Show("Error in adding a new user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            BindingSource source = new BindingSource();
            source.DataSource = StudentController.getAllStudents(); ;
            this.dataStudent.DataSource = source;
            ClearText();
            
        }
        private void ClearText()
        {
            this.txtFullname.Text = string.Empty;
            this.txtID.Text = string.Empty;
            this.txtGender.Text = string.Empty;
            this.txtClass.Text = string.Empty;
            this.txtEmail.Text = string.Empty;
            this.txtPhone.Text = string.Empty;
        }
        private void dataStudent_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                return;
            }
            int index = e.RowIndex;
            Student nStudent = new Student();

            //nStudent.ID = this.dataStudent.CurrentRow.Cells[0].Value.ToString();
            //if (nStudent.ID.Length <= 0)
            //{
            //    return;
            //}

            ////ID
            if (this.dataStudent.CurrentRow.Cells[0].Value is null)
            {
                this.dataStudent.CurrentRow.Cells[0].Value = "";
            }
            else nStudent.ID = this.dataStudent.CurrentRow.Cells[0].Value.ToString();
            //FullName
            if (this.dataStudent.CurrentRow.Cells[1].Value is null)
            {
                this.dataStudent.CurrentRow.Cells[1].Value = "";
            }
            else nStudent.Fullname = this.dataStudent.CurrentRow.Cells[1].Value.ToString();

            //Birthday
            if (this.dataStudent.CurrentRow.Cells[2].Value is null)
            {
                this.dataStudent.CurrentRow.Cells[2].Value = DateTime.Now.Date;
            }
            else nStudent.Birthday = DateTime.ParseExact(this.dataStudent.CurrentRow.Cells[2].Value.ToString(), "dd-MMM-yy hh:mm:ss tt", CultureInfo.InvariantCulture).Date;
            //Gender
            if (this.dataStudent.CurrentRow.Cells[3].Value is null)
            {
                this.dataStudent.CurrentRow.Cells[3].Value = "";
            }
            else nStudent.Gender = this.dataStudent.CurrentRow.Cells[3].Value.ToString();
            //Class
            if (this.dataStudent.CurrentRow.Cells[4].Value is null)
            {
                this.dataStudent.CurrentRow.Cells[4].Value = "";
            }
            else nStudent.Class = this.dataStudent.CurrentRow.Cells[4].Value.ToString();
            //Email
            if (this.dataStudent.CurrentRow.Cells[5].Value is null)
            {
                this.dataStudent.CurrentRow.Cells[5].Value = "";
            }
            else nStudent.Email = this.dataStudent.CurrentRow.Cells[5].Value.ToString();

            //Phone
            if (this.dataStudent.CurrentRow.Cells[6].Value is null)
            {
                this.dataStudent.CurrentRow.Cells[6].Value = "";
            }
            else nStudent.Phone = this.dataStudent.CurrentRow.Cells[6].Value.ToString();

            if (StudentController.UpdateStudent(nStudent) == false)
            {
                MessageBox.Show("Cannot update!");
            }
            /////////////////////////////
            //int count = listStudents.Where(x => x.ID == nStudent.ID).Count();

            //if (count == 0)
            //{
            //    listStudents.Add(nStudent);
            //}
            //else if (count == 1 && this.dataStudent.Rows.Count == (listStudents.Count() + 1))
            //{
            //    int listindex = this.listStudents.FindIndex(x => x.ID == nStudent.ID);
            //    if (index != e.RowIndex)
            //    {
            //        MessageBox.Show("Same existed ID!");
            //        this.dataStudent.Rows[index].Cells[cGender.Index].Value = listStudents[e.RowIndex].Gender;
            //        this.dataStudent.Rows[index].Cells[cFullname.Index].Value = listStudents[e.RowIndex].Fullname;
            //        this.dataStudent.Rows[index].Cells[cBirthday.Index].Value = listStudents[e.RowIndex].Birthday;
            //        this.dataStudent.Rows[index].Cells[cEmail.Index].Value = listStudents[e.RowIndex].Email;
            //        this.dataStudent.Rows[index].Cells[cPhone.Index].Value = listStudents[e.RowIndex].Phone;
            //        this.dataStudent.Rows[index].Cells[cClasss.Index].Value = listStudents[e.RowIndex].Class;
            //        this.dataStudent.Rows[index].Cells[cID.Index].Value = listStudents[e.RowIndex].ID;
            //        return;
            //    }
            //    listStudents[index] = nStudent;
            //}
            //else if (count == 1 && this.dataStudent.Rows.Count != listStudents.Count())
            //{
            //    MessageBox.Show("Same existed ID!");

            //    return;
            //}
            //else if (count > 1)
            //{
            //    MessageBox.Show("Same existed ID!");
            //    return;
            //}


        }

        private void dataStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (this.dataStudent.Columns[e.ColumnIndex].DataPropertyName == nameof(Student.Birthday))
                {

                    dtp = new DateTimePicker();
                    dtp.Visible = true;
                    dtp.Format = DateTimePickerFormat.Custom;

                    Rectangle rtg = this.dataStudent.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                    dtp.Size = new Size(rtg.Width, rtg.Height);
                    dtp.Location = new Point(rtg.X, rtg.Y);
                    try
                    {
                        dtp.Value = DateTime.ParseExact(this.dataStudent.CurrentRow.Cells[2].Value.ToString(), "dd-MM-yyyy HH:mm:ss tt", CultureInfo.CreateSpecificCulture("hu-HU")).Date;

                    }
                    catch
                    {
                        dtp.Value = DateTime.Now;
                        dtp.Visible = false;
                        dtp.Dispose();
                    }
                    dtp.CloseUp += Dtp_CloseUp;
                    dtp.TextChanged += Dtp_TextChanged;

                }
                this.dataStudent.Controls.Add(dtp);

                if (this.dataStudent.Columns[e.ColumnIndex].DataPropertyName == nameof(Student.Gender))
                {
                    cbb = new ComboBox();
                    cbb.Visible = true;
                    Rectangle rect = this.dataStudent.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                    cbb.Size = new Size(rect.Width, rect.Height);
                    cbb.Location = new Point(rect.X, rect.Y);
                    cbb.Items.Add("Male");
                    cbb.Items.Add("Female");

                    cbb.DropDownClosed += Cbb_DropDownClosed;
                    cbb.TextChanged += Cbb_TextChanged;

                }
                this.dataStudent.Controls.Add(cbb);
            }
            catch
            {
                return;
            }

        }

        private void Cbb_TextChanged(object sender, EventArgs e)
        {

            this.dataStudent.CurrentRow.Cells[3].Value = cbb.SelectedItem.ToString();

            Student student = StudentController.getExistStudentName(
                this.dataStudent.CurrentRow.Cells[0].Value.ToString());
            student.Gender = cbb.SelectedItem.ToString();
            if (StudentController.UpdateStudent(student) == false)
            {
                MessageBox.Show("Cannot update!");
            }

        }

        private void Cbb_DropDownClosed(object sender, EventArgs e)
        {
            cbb.Visible = false;
        }

        private void Dtp_TextChanged(object sender, EventArgs e)
        {
            this.dataStudent.CurrentRow.Cells[2].Value = this.dtp.Value.Date.ToString("dd/MM/yyyy");

            Student student = StudentController.getExistStudentName(
                this.dataStudent.CurrentRow.Cells[1].Value.ToString());
            student.Birthday = DateTime.Parse(this.dataStudent.CurrentRow.Cells[2].Value.ToString()).Date;
            if (StudentController.UpdateStudent(student) == false)
            {
                MessageBox.Show("Cannot update!");
            }
        }

        private void Dtp_CloseUp(object sender, EventArgs e)
        {
            dtp.Visible = false;
            dtp.Dispose();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.dataStudent.SelectedRows.Count <= 0)
            {
                return;
            }
            string ID = this.dataStudent.SelectedRows[0].Cells[0].Value.ToString();
            if (StudentController.DeleteStudent(ID) == false)
            {
                MessageBox.Show("Cannot delete student");
            }
            else
            {
                BindingSource source = new BindingSource(); // add an empty row.
                source.DataSource = StudentController.getAllStudents();
                this.dataStudent.DataSource = source;

            }
        }

        private void dataStudent_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach(DataGridViewRow row in dataStudent.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.Azure;
                row.DefaultCellStyle.ForeColor = Color.Red;
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            DataTable dt = studentController.getInformationStudent(this.txtID.Text);
            this.dataStudent.DataSource = dt;
        }
    }
}
