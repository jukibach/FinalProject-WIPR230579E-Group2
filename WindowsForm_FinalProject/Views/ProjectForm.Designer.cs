namespace WindowsForm_FinalProject.Views
{
    partial class ProjectForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listViewProject = new System.Windows.Forms.ListView();
            this.form = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lstIDs = new System.Windows.Forms.ListBox();
            this.lstSearchIDS = new System.Windows.Forms.ListBox();
            this.txtSearchIDS = new System.Windows.Forms.TextBox();
            this.idStudent = new System.Windows.Forms.Label();
            this.btnDeleteP = new System.Windows.Forms.Button();
            this.btnAddP = new System.Windows.Forms.Button();
            this.ccbType = new System.Windows.Forms.ComboBox();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.dateBegin = new System.Windows.Forms.DateTimePicker();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.form.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.26568F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.73432F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.form, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1180, 530);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listViewProject);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(513, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(664, 524);
            this.panel1.TabIndex = 0;
            // 
            // listViewProject
            // 
            this.listViewProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.listViewProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewProject.ForeColor = System.Drawing.SystemColors.Info;
            this.listViewProject.GridLines = true;
            this.listViewProject.HideSelection = false;
            this.listViewProject.Location = new System.Drawing.Point(0, 0);
            this.listViewProject.Name = "listViewProject";
            this.listViewProject.Size = new System.Drawing.Size(664, 524);
            this.listViewProject.TabIndex = 0;
            this.listViewProject.UseCompatibleStateImageBehavior = false;
            this.listViewProject.View = System.Windows.Forms.View.Details;
            this.listViewProject.SelectedIndexChanged += new System.EventHandler(this.listViewProject_SelectedIndexChanged);
            this.listViewProject.Click += new System.EventHandler(this.listViewProject_Click);
            // 
            // form
            // 
            this.form.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.form.Controls.Add(this.btnUpdate);
            this.form.Controls.Add(this.lstIDs);
            this.form.Controls.Add(this.lstSearchIDS);
            this.form.Controls.Add(this.txtSearchIDS);
            this.form.Controls.Add(this.idStudent);
            this.form.Controls.Add(this.btnDeleteP);
            this.form.Controls.Add(this.btnAddP);
            this.form.Controls.Add(this.ccbType);
            this.form.Controls.Add(this.dateEnd);
            this.form.Controls.Add(this.dateBegin);
            this.form.Controls.Add(this.txtContent);
            this.form.Controls.Add(this.txtPName);
            this.form.Controls.Add(this.label5);
            this.form.Controls.Add(this.label4);
            this.form.Controls.Add(this.label3);
            this.form.Controls.Add(this.label2);
            this.form.Controls.Add(this.label1);
            this.form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.form.Location = new System.Drawing.Point(3, 3);
            this.form.Name = "form";
            this.form.Size = new System.Drawing.Size(504, 524);
            this.form.TabIndex = 1;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Red;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(189, 378);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(127, 69);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lstIDs
            // 
            this.lstIDs.FormattingEnabled = true;
            this.lstIDs.ItemHeight = 16;
            this.lstIDs.Location = new System.Drawing.Point(311, 286);
            this.lstIDs.Name = "lstIDs";
            this.lstIDs.Size = new System.Drawing.Size(176, 52);
            this.lstIDs.TabIndex = 16;
            this.lstIDs.DoubleClick += new System.EventHandler(this.lstIDs_DoubleClick);
            // 
            // lstSearchIDS
            // 
            this.lstSearchIDS.FormattingEnabled = true;
            this.lstSearchIDS.ItemHeight = 16;
            this.lstSearchIDS.Location = new System.Drawing.Point(125, 286);
            this.lstSearchIDS.Name = "lstSearchIDS";
            this.lstSearchIDS.Size = new System.Drawing.Size(153, 52);
            this.lstSearchIDS.TabIndex = 15;
            this.lstSearchIDS.DoubleClick += new System.EventHandler(this.lstSearchIDS_DoubleClick);
            // 
            // txtSearchIDS
            // 
            this.txtSearchIDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchIDS.Location = new System.Drawing.Point(125, 219);
            this.txtSearchIDS.Multiline = true;
            this.txtSearchIDS.Name = "txtSearchIDS";
            this.txtSearchIDS.Size = new System.Drawing.Size(362, 51);
            this.txtSearchIDS.TabIndex = 14;
            this.txtSearchIDS.TextChanged += new System.EventHandler(this.txtSearchIDS_TextChanged);
            // 
            // idStudent
            // 
            this.idStudent.AutoSize = true;
            this.idStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idStudent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.idStudent.Location = new System.Drawing.Point(13, 231);
            this.idStudent.Name = "idStudent";
            this.idStudent.Size = new System.Drawing.Size(106, 20);
            this.idStudent.TabIndex = 13;
            this.idStudent.Text = "ID students";
            // 
            // btnDeleteP
            // 
            this.btnDeleteP.BackColor = System.Drawing.Color.Lime;
            this.btnDeleteP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteP.Location = new System.Drawing.Point(346, 378);
            this.btnDeleteP.Name = "btnDeleteP";
            this.btnDeleteP.Size = new System.Drawing.Size(141, 69);
            this.btnDeleteP.TabIndex = 11;
            this.btnDeleteP.Text = "Delete";
            this.btnDeleteP.UseVisualStyleBackColor = false;
            this.btnDeleteP.Click += new System.EventHandler(this.btnDeleteP_Click);
            // 
            // btnAddP
            // 
            this.btnAddP.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAddP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddP.Location = new System.Drawing.Point(36, 378);
            this.btnAddP.Name = "btnAddP";
            this.btnAddP.Size = new System.Drawing.Size(131, 69);
            this.btnAddP.TabIndex = 10;
            this.btnAddP.Text = "Add";
            this.btnAddP.UseVisualStyleBackColor = false;
            this.btnAddP.Click += new System.EventHandler(this.btnAddP_Click);
            // 
            // ccbType
            // 
            this.ccbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccbType.FormattingEnabled = true;
            this.ccbType.Items.AddRange(new object[] {
            "Course",
            "Graduation"});
            this.ccbType.Location = new System.Drawing.Point(143, 97);
            this.ccbType.Name = "ccbType";
            this.ccbType.Size = new System.Drawing.Size(109, 28);
            this.ccbType.TabIndex = 9;
            // 
            // dateEnd
            // 
            this.dateEnd.CustomFormat = "dd/MM/yyyy";
            this.dateEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateEnd.Location = new System.Drawing.Point(378, 152);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(109, 26);
            this.dateEnd.TabIndex = 8;
            this.dateEnd.Value = new System.DateTime(2020, 6, 12, 0, 0, 0, 0);
            // 
            // dateBegin
            // 
            this.dateBegin.CustomFormat = "dd/MM/yyyy";
            this.dateBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateBegin.Location = new System.Drawing.Point(143, 152);
            this.dateBegin.Name = "dateBegin";
            this.dateBegin.Size = new System.Drawing.Size(109, 26);
            this.dateBegin.TabIndex = 7;
            this.dateBegin.Value = new System.DateTime(2020, 6, 12, 0, 0, 0, 0);
            // 
            // txtContent
            // 
            this.txtContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContent.Location = new System.Drawing.Point(378, 40);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(109, 26);
            this.txtContent.TabIndex = 6;
            // 
            // txtPName
            // 
            this.txtPName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPName.Location = new System.Drawing.Point(143, 40);
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(109, 26);
            this.txtPName.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(39, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(32, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Begin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(307, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "End";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(283, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Content";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(14, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project Name";
            // 
            // ProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 530);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ProjectForm";
            this.Text = "Project";
            this.Load += new System.EventHandler(this.ProjectForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.form.ResumeLayout(false);
            this.form.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel form;
        private System.Windows.Forms.ComboBox ccbType;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.DateTimePicker dateBegin;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteP;
        private System.Windows.Forms.Button btnAddP;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.TextBox txtSearchIDS;
        private System.Windows.Forms.Label idStudent;
        private System.Windows.Forms.ListBox lstSearchIDS;
        private System.Windows.Forms.ListBox lstIDs;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ListView listViewProject;
    }
}