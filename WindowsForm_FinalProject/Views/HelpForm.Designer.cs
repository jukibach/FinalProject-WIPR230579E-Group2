namespace WindowsForm_FinalProject.Views
{
    partial class HelpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabStudent = new System.Windows.Forms.TabPage();
            this.TabSearch = new System.Windows.Forms.TabPage();
            this.TabProject = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.TabStudent.SuspendLayout();
            this.TabSearch.SuspendLayout();
            this.TabProject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabStudent);
            this.tabControl1.Controls.Add(this.TabSearch);
            this.tabControl1.Controls.Add(this.TabProject);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(961, 522);
            this.tabControl1.TabIndex = 0;
            // 
            // TabStudent
            // 
            this.TabStudent.Controls.Add(this.pictureBox1);
            this.TabStudent.Location = new System.Drawing.Point(4, 25);
            this.TabStudent.Name = "TabStudent";
            this.TabStudent.Padding = new System.Windows.Forms.Padding(3);
            this.TabStudent.Size = new System.Drawing.Size(953, 493);
            this.TabStudent.TabIndex = 0;
            this.TabStudent.Text = "StudentForm";
            this.TabStudent.UseVisualStyleBackColor = true;
            // 
            // TabSearch
            // 
            this.TabSearch.Controls.Add(this.pictureBox2);
            this.TabSearch.Location = new System.Drawing.Point(4, 25);
            this.TabSearch.Name = "TabSearch";
            this.TabSearch.Padding = new System.Windows.Forms.Padding(3);
            this.TabSearch.Size = new System.Drawing.Size(953, 493);
            this.TabSearch.TabIndex = 1;
            this.TabSearch.Text = "SearchForm";
            this.TabSearch.UseVisualStyleBackColor = true;
            // 
            // TabProject
            // 
            this.TabProject.Controls.Add(this.pictureBox3);
            this.TabProject.Location = new System.Drawing.Point(4, 25);
            this.TabProject.Name = "TabProject";
            this.TabProject.Padding = new System.Windows.Forms.Padding(3);
            this.TabProject.Size = new System.Drawing.Size(953, 493);
            this.TabProject.TabIndex = 2;
            this.TabProject.Text = "ProjectForm";
            this.TabProject.UseVisualStyleBackColor = true;
            this.TabProject.Click += new System.EventHandler(this.TabProject_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(947, 487);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(947, 487);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(3, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(947, 487);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 522);
            this.Controls.Add(this.tabControl1);
            this.Name = "HelpForm";
            this.Text = "HelpForm";
            this.tabControl1.ResumeLayout(false);
            this.TabStudent.ResumeLayout(false);
            this.TabSearch.ResumeLayout(false);
            this.TabProject.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabStudent;
        private System.Windows.Forms.TabPage TabSearch;
        private System.Windows.Forms.TabPage TabProject;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}