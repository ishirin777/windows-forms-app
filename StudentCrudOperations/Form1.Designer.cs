namespace StudentCrudOperations
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
            this.loadStudentsBtn = new System.Windows.Forms.Button();
            this.addStudentBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.studentNameBox = new System.Windows.Forms.TextBox();
            this.studentSurnameBox = new System.Windows.Forms.TextBox();
            this.studentNameLabel = new System.Windows.Forms.Label();
            this.studentSurnameLabel = new System.Windows.Forms.Label();
            this.birthLabel = new System.Windows.Forms.Label();
            this.loadCoursesBtn = new System.Windows.Forms.Button();
            this.coursesInProgressBtn = new System.Windows.Forms.Button();
            this.createNewCourseBtn = new System.Windows.Forms.Button();
            this.courseNameBox = new System.Windows.Forms.TextBox();
            this.teacherNameBox = new System.Windows.Forms.TextBox();
            this.courseNameLabel = new System.Windows.Forms.Label();
            this.teacherNameLabel = new System.Windows.Forms.Label();
            this.courseStartingDateLabel = new System.Windows.Forms.Label();
            this.courseStartingDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.studentBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.teacherSurnameBox = new System.Windows.Forms.TextBox();
            this.teacherSurnameLabel = new System.Windows.Forms.Label();
            this.teacherList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cTBtn = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.clearAllFieldsBtn = new System.Windows.Forms.Button();
            this.checkedCoursesListBox = new System.Windows.Forms.CheckedListBox();
            this.chooseCourses = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(496, 190);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick_1);
            // 
            // loadStudentsBtn
            // 
            this.loadStudentsBtn.Location = new System.Drawing.Point(558, 278);
            this.loadStudentsBtn.Name = "loadStudentsBtn";
            this.loadStudentsBtn.Size = new System.Drawing.Size(96, 39);
            this.loadStudentsBtn.TabIndex = 2;
            this.loadStudentsBtn.Text = "Load students";
            this.loadStudentsBtn.UseVisualStyleBackColor = true;
            this.loadStudentsBtn.Click += new System.EventHandler(this.LoadStudentsBtn_Click);
            // 
            // addStudentBtn
            // 
            this.addStudentBtn.Location = new System.Drawing.Point(676, 278);
            this.addStudentBtn.Name = "addStudentBtn";
            this.addStudentBtn.Size = new System.Drawing.Size(96, 39);
            this.addStudentBtn.TabIndex = 3;
            this.addStudentBtn.Text = "Add Student";
            this.addStudentBtn.UseVisualStyleBackColor = true;
            this.addStudentBtn.Click += new System.EventHandler(this.AddStudentBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(558, 332);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(96, 38);
            this.updateBtn.TabIndex = 4;
            this.updateBtn.Text = "Update Student";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.UpdateStudentBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(676, 332);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(96, 38);
            this.deleteBtn.TabIndex = 5;
            this.deleteBtn.Text = "Delete Student";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.DeleteStudentBtn_Click);
            // 
            // studentNameBox
            // 
            this.studentNameBox.Location = new System.Drawing.Point(558, 42);
            this.studentNameBox.Name = "studentNameBox";
            this.studentNameBox.Size = new System.Drawing.Size(175, 20);
            this.studentNameBox.TabIndex = 6;
            // 
            // studentSurnameBox
            // 
            this.studentSurnameBox.Location = new System.Drawing.Point(558, 93);
            this.studentSurnameBox.Name = "studentSurnameBox";
            this.studentSurnameBox.Size = new System.Drawing.Size(175, 20);
            this.studentSurnameBox.TabIndex = 7;
            // 
            // studentNameLabel
            // 
            this.studentNameLabel.AutoSize = true;
            this.studentNameLabel.Location = new System.Drawing.Point(555, 20);
            this.studentNameLabel.Name = "studentNameLabel";
            this.studentNameLabel.Size = new System.Drawing.Size(75, 13);
            this.studentNameLabel.TabIndex = 9;
            this.studentNameLabel.Text = "Student Name";
            // 
            // studentSurnameLabel
            // 
            this.studentSurnameLabel.AutoSize = true;
            this.studentSurnameLabel.Location = new System.Drawing.Point(555, 77);
            this.studentSurnameLabel.Name = "studentSurnameLabel";
            this.studentSurnameLabel.Size = new System.Drawing.Size(89, 13);
            this.studentSurnameLabel.TabIndex = 10;
            this.studentSurnameLabel.Text = "Student Surname";
            // 
            // birthLabel
            // 
            this.birthLabel.AutoSize = true;
            this.birthLabel.Location = new System.Drawing.Point(555, 133);
            this.birthLabel.Name = "birthLabel";
            this.birthLabel.Size = new System.Drawing.Size(94, 13);
            this.birthLabel.TabIndex = 11;
            this.birthLabel.Text = "Student Birth Date";
            // 
            // loadCoursesBtn
            // 
            this.loadCoursesBtn.Location = new System.Drawing.Point(15, 316);
            this.loadCoursesBtn.Name = "loadCoursesBtn";
            this.loadCoursesBtn.Size = new System.Drawing.Size(100, 38);
            this.loadCoursesBtn.TabIndex = 13;
            this.loadCoursesBtn.Text = "Load Courses";
            this.loadCoursesBtn.UseVisualStyleBackColor = true;
            this.loadCoursesBtn.Click += new System.EventHandler(this.LoadCoursesBtn_Click);
            // 
            // coursesInProgressBtn
            // 
            this.coursesInProgressBtn.Location = new System.Drawing.Point(140, 316);
            this.coursesInProgressBtn.Name = "coursesInProgressBtn";
            this.coursesInProgressBtn.Size = new System.Drawing.Size(100, 38);
            this.coursesInProgressBtn.TabIndex = 14;
            this.coursesInProgressBtn.Text = "Courses in Progress";
            this.coursesInProgressBtn.UseVisualStyleBackColor = true;
            this.coursesInProgressBtn.Click += new System.EventHandler(this.CoursesInProgressBtn_Click);
            // 
            // createNewCourseBtn
            // 
            this.createNewCourseBtn.Location = new System.Drawing.Point(266, 316);
            this.createNewCourseBtn.Name = "createNewCourseBtn";
            this.createNewCourseBtn.Size = new System.Drawing.Size(264, 38);
            this.createNewCourseBtn.TabIndex = 15;
            this.createNewCourseBtn.Text = "Create New Course";
            this.createNewCourseBtn.UseVisualStyleBackColor = true;
            this.createNewCourseBtn.Click += new System.EventHandler(this.createNewCourseBtn_Click);
            // 
            // courseNameBox
            // 
            this.courseNameBox.Location = new System.Drawing.Point(15, 260);
            this.courseNameBox.Name = "courseNameBox";
            this.courseNameBox.Size = new System.Drawing.Size(100, 20);
            this.courseNameBox.TabIndex = 16;
            // 
            // teacherNameBox
            // 
            this.teacherNameBox.Location = new System.Drawing.Point(15, 396);
            this.teacherNameBox.Name = "teacherNameBox";
            this.teacherNameBox.Size = new System.Drawing.Size(100, 20);
            this.teacherNameBox.TabIndex = 17;
            // 
            // courseNameLabel
            // 
            this.courseNameLabel.AutoSize = true;
            this.courseNameLabel.Location = new System.Drawing.Point(12, 232);
            this.courseNameLabel.Name = "courseNameLabel";
            this.courseNameLabel.Size = new System.Drawing.Size(71, 13);
            this.courseNameLabel.TabIndex = 19;
            this.courseNameLabel.Text = "Course Name";
            // 
            // teacherNameLabel
            // 
            this.teacherNameLabel.AutoSize = true;
            this.teacherNameLabel.Location = new System.Drawing.Point(12, 374);
            this.teacherNameLabel.Name = "teacherNameLabel";
            this.teacherNameLabel.Size = new System.Drawing.Size(78, 13);
            this.teacherNameLabel.TabIndex = 20;
            this.teacherNameLabel.Text = "Teacher Name";
            // 
            // courseStartingDateLabel
            // 
            this.courseStartingDateLabel.AutoSize = true;
            this.courseStartingDateLabel.Location = new System.Drawing.Point(375, 232);
            this.courseStartingDateLabel.Name = "courseStartingDateLabel";
            this.courseStartingDateLabel.Size = new System.Drawing.Size(105, 13);
            this.courseStartingDateLabel.TabIndex = 21;
            this.courseStartingDateLabel.Text = "Course Starting Date";
            // 
            // courseStartingDateTimePicker
            // 
            this.courseStartingDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.courseStartingDateTimePicker.Location = new System.Drawing.Point(378, 260);
            this.courseStartingDateTimePicker.Name = "courseStartingDateTimePicker";
            this.courseStartingDateTimePicker.Size = new System.Drawing.Size(140, 20);
            this.courseStartingDateTimePicker.TabIndex = 22;
            this.courseStartingDateTimePicker.ValueChanged += new System.EventHandler(this.courseStartingDateTimePicker_ValueChanged);
            // 
            // studentBirthDateTimePicker
            // 
            this.studentBirthDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.studentBirthDateTimePicker.Location = new System.Drawing.Point(558, 149);
            this.studentBirthDateTimePicker.Name = "studentBirthDateTimePicker";
            this.studentBirthDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.studentBirthDateTimePicker.TabIndex = 23;
            this.studentBirthDateTimePicker.ValueChanged += new System.EventHandler(this.studentBirthDateTimePicker_ValueChanged);
            // 
            // teacherSurnameBox
            // 
            this.teacherSurnameBox.Location = new System.Drawing.Point(140, 396);
            this.teacherSurnameBox.Name = "teacherSurnameBox";
            this.teacherSurnameBox.Size = new System.Drawing.Size(100, 20);
            this.teacherSurnameBox.TabIndex = 24;
            // 
            // teacherSurnameLabel
            // 
            this.teacherSurnameLabel.AutoSize = true;
            this.teacherSurnameLabel.Location = new System.Drawing.Point(137, 374);
            this.teacherSurnameLabel.Name = "teacherSurnameLabel";
            this.teacherSurnameLabel.Size = new System.Drawing.Size(92, 13);
            this.teacherSurnameLabel.TabIndex = 25;
            this.teacherSurnameLabel.Text = "Teacher Surname";
            // 
            // teacherList
            // 
            this.teacherList.FormattingEnabled = true;
            this.teacherList.Location = new System.Drawing.Point(140, 259);
            this.teacherList.Name = "teacherList";
            this.teacherList.Size = new System.Drawing.Size(121, 21);
            this.teacherList.TabIndex = 26;
            this.teacherList.DropDown += new System.EventHandler(this.teacherList_DropDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Teachers";
            // 
            // cTBtn
            // 
            this.cTBtn.Location = new System.Drawing.Point(266, 385);
            this.cTBtn.Name = "cTBtn";
            this.cTBtn.Size = new System.Drawing.Size(112, 31);
            this.cTBtn.TabIndex = 28;
            this.cTBtn.Text = "Create teacher";
            this.cTBtn.UseVisualStyleBackColor = true;
            this.cTBtn.Click += new System.EventHandler(this.CreateNewTeacherBtn_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(277, 262);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(67, 17);
            this.checkBox1.TabIndex = 29;
            this.checkBox1.Text = "Progress";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // clearAllFieldsBtn
            // 
            this.clearAllFieldsBtn.Location = new System.Drawing.Point(558, 385);
            this.clearAllFieldsBtn.Name = "clearAllFieldsBtn";
            this.clearAllFieldsBtn.Size = new System.Drawing.Size(214, 34);
            this.clearAllFieldsBtn.TabIndex = 30;
            this.clearAllFieldsBtn.Text = "Clear All Fields";
            this.clearAllFieldsBtn.UseVisualStyleBackColor = true;
            this.clearAllFieldsBtn.Click += new System.EventHandler(this.clearAllFieldsBtn_Click);
            // 
            // checkedCoursesListBox
            // 
            this.checkedCoursesListBox.FormattingEnabled = true;
            this.checkedCoursesListBox.Location = new System.Drawing.Point(558, 213);
            this.checkedCoursesListBox.Name = "checkedCoursesListBox";
            this.checkedCoursesListBox.Size = new System.Drawing.Size(214, 49);
            this.checkedCoursesListBox.TabIndex = 31;
            // 
            // chooseCourses
            // 
            this.chooseCourses.AutoSize = true;
            this.chooseCourses.Location = new System.Drawing.Point(555, 188);
            this.chooseCourses.Name = "chooseCourses";
            this.chooseCourses.Size = new System.Drawing.Size(84, 13);
            this.chooseCourses.TabIndex = 32;
            this.chooseCourses.Text = "Choose Courses";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 438);
            this.Controls.Add(this.chooseCourses);
            this.Controls.Add(this.checkedCoursesListBox);
            this.Controls.Add(this.clearAllFieldsBtn);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.cTBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.teacherList);
            this.Controls.Add(this.teacherSurnameLabel);
            this.Controls.Add(this.teacherSurnameBox);
            this.Controls.Add(this.studentBirthDateTimePicker);
            this.Controls.Add(this.courseStartingDateTimePicker);
            this.Controls.Add(this.courseStartingDateLabel);
            this.Controls.Add(this.teacherNameLabel);
            this.Controls.Add(this.courseNameLabel);
            this.Controls.Add(this.teacherNameBox);
            this.Controls.Add(this.courseNameBox);
            this.Controls.Add(this.createNewCourseBtn);
            this.Controls.Add(this.coursesInProgressBtn);
            this.Controls.Add(this.loadCoursesBtn);
            this.Controls.Add(this.birthLabel);
            this.Controls.Add(this.studentSurnameLabel);
            this.Controls.Add(this.studentNameLabel);
            this.Controls.Add(this.studentSurnameBox);
            this.Controls.Add(this.studentNameBox);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.addStudentBtn);
            this.Controls.Add(this.loadStudentsBtn);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Student Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button loadStudentsBtn;
        private System.Windows.Forms.Button addStudentBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.TextBox studentNameBox;
        private System.Windows.Forms.TextBox studentSurnameBox;
        private System.Windows.Forms.Label studentNameLabel;
        private System.Windows.Forms.Label studentSurnameLabel;
        private System.Windows.Forms.Label birthLabel;
        private System.Windows.Forms.Button loadCoursesBtn;
        private System.Windows.Forms.Button coursesInProgressBtn;
        private System.Windows.Forms.Button createNewCourseBtn;
        private System.Windows.Forms.TextBox courseNameBox;
        private System.Windows.Forms.TextBox teacherNameBox;
        private System.Windows.Forms.Label courseNameLabel;
        private System.Windows.Forms.Label teacherNameLabel;
        private System.Windows.Forms.Label courseStartingDateLabel;
        private System.Windows.Forms.DateTimePicker courseStartingDateTimePicker;
        private System.Windows.Forms.DateTimePicker studentBirthDateTimePicker;
        private System.Windows.Forms.TextBox teacherSurnameBox;
        private System.Windows.Forms.Label teacherSurnameLabel;
        private System.Windows.Forms.ComboBox teacherList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cTBtn;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button clearAllFieldsBtn;
        private System.Windows.Forms.CheckedListBox checkedCoursesListBox;
        private System.Windows.Forms.Label chooseCourses;
    }
}

