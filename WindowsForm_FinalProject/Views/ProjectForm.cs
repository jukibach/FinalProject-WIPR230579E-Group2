using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using WindowsForm_FinalProject.Controllers;
using WindowsForm_FinalProject.Models;

namespace WindowsForm_FinalProject.Views
{
    public partial class ProjectForm : Form
    {
        public int ID = 0;
        private List<Project> lstProject;
        private List<Student> listStudents;
        public ProjectForm(ref List<Project> Projects, List<Student> Students)
        {
            InitializeComponent();
            //this.cBegin.DataPropertyName = nameof(Project.PBegin);
            //this.cEnd.DataPropertyName = nameof(Project.PEnd);
            //this.cPName.DataPropertyName = nameof(Project.PName);
            //this.cType.DataPropertyName = nameof(Project.PType);
            //this.cContent.DataPropertyName = nameof(Project.PContent);
            //this.cID.DataPropertyName = nameof(Project.Students); // ID
            lstProject = Projects;
            listStudents = Students;
            DisplayToListView();
            
        }
        private void showHeader()
        {
            this.listViewProject.Columns.Add("ID", 30, HorizontalAlignment.Center);
            this.listViewProject.Columns.Add("Project Name", 150, HorizontalAlignment.Center);
            this.listViewProject.Columns.Add("Content", 100, HorizontalAlignment.Left);
            this.listViewProject.Columns.Add("Type", 100, HorizontalAlignment.Left);
            this.listViewProject.Columns.Add("Begin", 100, HorizontalAlignment.Left);
            this.listViewProject.Columns.Add("End", 100, HorizontalAlignment.Left);
            this.listViewProject.Columns.Add("ID Students", 200, HorizontalAlignment.Left);
        }
        private void DisplayToListView()
        {
            List<Project> lstProject = ProjectController.getAllProject();
            string displayIDStudents;
            this.listViewProject.Items.Clear();
            foreach (Project project in lstProject)
            {
                displayIDStudents = "";
                foreach (Student s in project.Students)
                {
                    displayIDStudents = displayIDStudents + s + " ";
                }
               
                ListViewItem eVent = new ListViewItem(project.PID.ToString());
                eVent.SubItems.Add(new ListViewItem.ListViewSubItem(eVent, project.PName));
                eVent.SubItems.Add(new ListViewItem.ListViewSubItem(eVent, project.PContent));
                eVent.SubItems.Add(new ListViewItem.ListViewSubItem(eVent, project.PType));
                eVent.SubItems.Add(new ListViewItem.ListViewSubItem(eVent, project.PBegin.HasValue ? project.PBegin.GetValueOrDefault().ToString("dd/MM/yyyy"): "NULL"));
                eVent.SubItems.Add(new ListViewItem.ListViewSubItem(eVent, project.PEnd.HasValue ? project.PEnd.GetValueOrDefault().ToString("dd/MM/yyyy") : "NULL"));
                eVent.SubItems.Add(new ListViewItem.ListViewSubItem(eVent, displayIDStudents));
                this.listViewProject.Items.Add(eVent);
            }
        }
        private void btnAddP_Click(object sender, EventArgs e)
        {
            Project NProject = new Project();
            NProject.PID = ProjectController.getIDfromDB();
            NProject.PName = this.txtPName.Text;
            NProject.PContent = this.txtContent.Text;
            NProject.PType = this.ccbType.Text.Trim();
            NProject.PBegin = this.dateBegin.Value; //dd/MM/YYYY
            NProject.PEnd = this.dateEnd.Value; //dd/MM/YYYY

            NProject.Students = new List<Student>(); 
            string displayIDStudents = "";

            for (int i = 0; i < lstIDs.Items.Count; i++)
            {
                //displayIDStudents = displayIDStudents + this.lstIDs.Items[i].ToString() + "  ";
                NProject.Students.Add(this.lstIDs.Items[i] as Student); //ID
            }


            if (checkbegin(NProject) && checkend(NProject) && checkname(NProject))
            {
                MessageBox.Show("This Project has already exist");
                return;
            }
            if (NProject.PEnd <= NProject.PBegin)
            {
                MessageBox.Show("Project's deadline must be greater than its begin");
                return;
            }


            if (ProjectController.AddProject(NProject) == false)
            {
                MessageBox.Show("Error in adding a new project", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.DisplayToListView();



            //BindingSource source = new BindingSource();
            //source.DataSource = ProjectController.getAllProject();
            //this.dataProject.DataSource = source;
        }
        private bool checkbegin(Project project)
        {
            var u =lstProject.Where(x => x.PBegin == project.PBegin).Count();
            return (u > 0);
        }
        private bool checkend(Project project)
        {
            var u = lstProject.Where(x => x.PEnd == project.PEnd).Count();
            return (u > 0);
        }
        private bool checkname(Project project)
        {
            var u = lstProject.Where(x => x.PName == project.PName).Count();
            return (u > 0);
        }
        private void btnDeleteP_Click(object sender, EventArgs e)
        {
            if (this.listViewProject.SelectedItems.Count <= 0)
            {
                return;
            }

            int idproject = int.Parse(this.listViewProject.SelectedItems[0].SubItems[0].Text);
            if (ProjectController.DeleteProject(idproject) == false)
            {
                MessageBox.Show("Cannot delete user!!!");
            }
            else
            {
                MessageBox.Show("Delete success", "Note", MessageBoxButtons.OK);
                this.DisplayToListView();
            }
        }
        private void txtSearchIDS_TextChanged(object sender, EventArgs e)
        {
            this.lstSearchIDS.Items.Clear();
            List<Student> searchUsers = StudentController.getAllStudents(this.txtSearchIDS.Text.Trim());
            if (searchUsers.Count > 0)
            {
                this.lstSearchIDS.Visible = true;
            }
            else this.lstSearchIDS.Visible = false;
            if(this.txtSearchIDS.Text == "")
                this.lstSearchIDS.Items.Clear();
            for (int i = 0; i < searchUsers.Count; i++)
            {
                this.lstSearchIDS.Items.Add(searchUsers[i]);
            }
        }
        private void lstSearchIDS_DoubleClick(object sender, EventArgs e)
        {
            if (this.lstSearchIDS.SelectedIndex >= 0)
            {
                if (!lstIDs.Items.Contains(this.lstSearchIDS.SelectedItem))
                {
                    lstIDs.Items.Add(this.lstSearchIDS.SelectedItem);
                }
                else
                {
                    MessageBox.Show("This value is present!");
                }

            }
        }
        //List<string> eventsFired = new List<string>();
        //public bool IsEventFired(string eventName)
        //{
           
        //    return eventsFired.Contains(eventName);
        //}
        private void lstIDs_DoubleClick(object sender, EventArgs e)
        {
            if (this.lstIDs.SelectedIndex < 0)
                return;
            this.lstIDs.Items.RemoveAt(this.lstIDs.SelectedIndex);
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.listViewProject.SelectedItems[0].SubItems[1].Text = this.txtPName.Text;
            this.listViewProject.SelectedItems[0].SubItems[2].Text = this.txtContent.Text;
            this.listViewProject.SelectedItems[0].SubItems[3].Text = this.ccbType.Text;
            this.listViewProject.SelectedItems[0].SubItems[4].Text = this.dateBegin.Value.ToString("dd/MM/yyyy");
            this.listViewProject.SelectedItems[0].SubItems[5].Text = this.dateEnd.Value.ToString("dd/MM/yyyy");
            this.listViewProject.SelectedItems[0].SubItems[6].Text = this.lstIDs.Text;

            Project project = new Project();
            project.PID = int.Parse(this.listViewProject.SelectedItems[0].SubItems[0].Text.Trim());
            if (project.PID <= 0)
                return;

            if (this.listViewProject.SelectedItems[0].SubItems[1].Text is null)
            {
                this.listViewProject.SelectedItems[0].SubItems[1].Text = "";
            }
            project.PName = this.txtPName.Text;
            if (this.listViewProject.SelectedItems[0].SubItems[2].Text is null)
            {
                this.listViewProject.SelectedItems[0].SubItems[2].Text = "";
            }
            project.PContent = this.txtContent.Text;
            if (this.listViewProject.SelectedItems[0].SubItems[3].Text is null)
            {
                this.listViewProject.SelectedItems[0].SubItems[3].Text = "";
            }
            project.PType = this.ccbType.Text.Trim();
            if (this.listViewProject.SelectedItems[0].SubItems[4].Text is null)
            {
                this.listViewProject.SelectedItems[0].SubItems[4].Text = DateTime.Now.ToString();
            }
            project.PBegin = this.dateBegin.Value;
            if (this.listViewProject.SelectedItems[0].SubItems[5].Text is null)
            {
                this.listViewProject.SelectedItems[0].SubItems[5].Text = DateTime.Now.ToString();
            }
            project.PEnd = this.dateEnd.Value;
            if (this.listViewProject.SelectedItems[0].SubItems[6].Text is null)
            {
                this.listViewProject.SelectedItems[0].SubItems[6].Text = " ";
            }
            //else // Can not update ID
            //{
            //    project.Students.Clear();
            //    //bool IsListIDClicked = IsEventFired(lstIDs_DoubleClick);
            //    for (int i = 0; i < lstIDs.Items.Count; i++)
            //    {
            //        project.Students.Add(this.lstIDs.Items[i] as Student); //ID
            //    }
            //    //this.lstIDs.DoubleClick += delegate { Is = true; };

            //}

            if (ProjectController.UpdateProject(project, lstIDs) == false)
            {
                MessageBox.Show("Cannot update!!!");
            }
            else
            {
                MessageBox.Show("Update success", "Note", MessageBoxButtons.OK);
            }



            //string displayusers = "";
            //for (int i = 0; i < this.listViewProject.Items.Count; i++)
            //{
            //    if (this.lstProject[i].PID == int.Parse(this.listViewProject.SelectedItems[0].SubItems[0].Text))
            //    {
            //        this.lstProject[i].PName = this.txtPName.Text;
            //        this.lstProject[i].PContent = this.txtContent.Text;
            //        this.lstProject[i].PBegin = this.dateBegin.Value;
            //        this.lstProject[i].PEnd = this.dateEnd.Value;

            //        this.lstProject[i].Students.Clear();
            //        for (int j = 0; i < lstIDs.Items.Count; i++)
            //        {
            //            displayusers = displayusers + this.lstIDs.Items[i].ToString() + "  ";
            //            this.lstProject[i].Students.Add(this.lstIDs.Items[i] as Student); //ID
            //        }
            //    }
            //}
            //this.listViewProject.SelectedItems[0].SubItems[1].Text = this.txtPName.Text;
            //this.listViewProject.SelectedItems[0].SubItems[2].Text = this.txtContent.Text;
            //this.listViewProject.SelectedItems[0].SubItems[3].Text = this.ccbType.Text;
            //this.listViewProject.SelectedItems[0].SubItems[4].Text = this.dateBegin.Value.ToString("dd/MM/yyyy");
            //this.listViewProject.SelectedItems[0].SubItems[5].Text = this.dateEnd.Value.ToString("dd/MM/yyyy");
            //this.listViewProject.SelectedItems[0].SubItems[6].Text = displayusers;



            //if (this.dateBegin.Value.Date == this.dateEnd.Value.Date)
            //{
            //    if (this.dateBegin.Value.TimeOfDay.Hours == this.dateEnd.Value.TimeOfDay.Hours)
            //    {
            //        this.chonDHM.Text = "Minute";
            //    }
            //    else
            //    {
            //        this.chonDHM.Text = "Hour";
            //    }
            //}
            //else this.chonDHM.Text = "Day";
        }
        //private void nutUpdate_Click(object sender, EventArgs e)
        //{
        //    string displayusers = "";
        //    for (int i = 0; i < this.listTasks.Count; i++)
        //    {
        //        if (this.listTasks[i].ID == int.Parse(this.listView1.SelectedItems[0].SubItems[0].Text))
        //        {
        //            this.listTasks[i].title = this.eventBox.Text;
        //            this.listTasks[i].description = this.DescripBox.Text;
        //            this.listTasks[i].fromdate = this.FromDate.Value;
        //            this.listTasks[i].todate = this.ToDate.Value;
        //            this.listTasks[i].listusers.Clear();
        //            for (int j = 0; j < this.lstUser.Items.Count; j++)
        //            {
        //                displayusers = displayusers + this.lstUser.Items[j] + "  ";
        //                this.listTasks[i].listusers.Add(this.lstUser.Items[j] as User);
        //            }
        //        }
        //    }
        //    this.listView1.SelectedItems[0].SubItems[1].Text = this.eventBox.Text;
        //    this.listView1.SelectedItems[0].SubItems[2].Text = this.DescripBox.Text;
        //    this.listView1.SelectedItems[0].SubItems[3].Text = this.FromDate.Value.ToString();
        //    this.listView1.SelectedItems[0].SubItems[4].Text = this.ToDate.Value.ToString();
        //    this.listView1.SelectedItems[0].SubItems[5].Text = displayusers;
        //    if (this.FromDate.Value.Date == this.ToDate.Value.Date)
        //    {
        //        if (this.FromDate.Value.TimeOfDay.Hours == this.ToDate.Value.TimeOfDay.Hours)
        //        {
        //            this.chonDHM.Text = "Minute";
        //        }
        //        else
        //        {
        //            this.chonDHM.Text = "Hour";
        //        }
        //    }
        //    else this.chonDHM.Text = "Day";
        //}
        private void listViewProject_Click(object sender, EventArgs e)
        {
           
            this.lstIDs.Items.Clear();
            //string id_event = this.listViewProject.SelectedItems[0].SubItems[0].Text.Trim();
            this.txtPName.Text = this.listViewProject.SelectedItems[0].SubItems[1].Text;
            this.txtContent.Text = this.listViewProject.SelectedItems[0].SubItems[2].Text;

            this.ccbType.Text = this.listViewProject.SelectedItems[0].SubItems[3].Text;
               

            this.dateBegin.Value = DateTime.Parse(this.listViewProject.SelectedItems[0].SubItems[4].Text);
            this.dateEnd.Value = DateTime.Parse(this.listViewProject.SelectedItems[0].SubItems[5].Text);


            string student = this.listViewProject.SelectedItems[0].SubItems[6].Text;
            string[] spearator = { " " };
            string[] stringlist = student.Split(spearator, StringSplitOptions.RemoveEmptyEntries);

            foreach (string s in stringlist)
            {
                this.lstIDs.Items.Add(s);
            }


        }

        private void listViewProject_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ProjectForm_Load(object sender, EventArgs e)
        {
            showHeader();
        }
    }
}
