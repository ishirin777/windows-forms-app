using System;
using System.Linq;
using System.Windows.Forms;

namespace StudentCrudOperations
{
    public partial class Form1 : Form
    {
        private int ID = 0;
        private bool isLoadStudentsBtnClicked = false;
        private bool isStudentPresent = false;

        private StudentDbManager studentDbManager = new StudentDbManager();
        private TeacherDbManager teacherDbManager = new TeacherDbManager();
        private Student student = new Student();
        private Teacher teacher = new Teacher();
        private Course course = new Course();

        public Form1()
        {
            InitializeComponent();
            teacherDbManager.InitializeComboBox();

            var checkedList = teacherDbManager.LoadCourses();
            checkedCoursesListBox.DataSource = checkedList;
            checkedCoursesListBox.DisplayMember = "Name";
            checkedCoursesListBox.ValueMember = "ID";

            courseStartingDateTimePicker.ShowCheckBox = true;
            courseStartingDateTimePicker.Checked = false;

            studentBirthDateTimePicker.ShowCheckBox = true;
            studentBirthDateTimePicker.Checked = false;

            if (!studentBirthDateTimePicker.Checked)
            {
                studentBirthDateTimePicker.CustomFormat = " ";
                studentBirthDateTimePicker.Format = DateTimePickerFormat.Custom;
            }

            if (!courseStartingDateTimePicker.Checked)
            {
                courseStartingDateTimePicker.CustomFormat = " ";
                courseStartingDateTimePicker.Format = DateTimePickerFormat.Custom;
            }
        }

        private void LoadStudentsBtn_Click(object sender, EventArgs e)
        {
            isLoadStudentsBtnClicked = true;
            var loadStudents = studentDbManager.LoadStudents();
            dataGridView1.DataSource = loadStudents;
        }

        private void AddStudentBtn_Click(object sender, EventArgs e)
        {
            student.Name = studentNameBox.Text;
            student.Surname = studentSurnameBox.Text;
            student.BirthDate = studentBirthDateTimePicker.Value;

            if (student.Name != "" && student.Surname != "" && student.BirthDate.ToString() != "" && checkedCoursesListBox.CheckedItems.Count != 0)
            {
                studentDbManager.AddStudent(student);

                foreach (Course item in checkedCoursesListBox.CheckedItems)
                {
                    studentDbManager.JoinCourses(student, item.ID);
                }

                MessageBox.Show("New student is added.");
                LoadStudentsBtn_Click(sender, e);

            }
            else
            {
                MessageBox.Show("Not all fields are included.");
            }

            ClearFields.clearAllFields(this);
        }

        private void UpdateStudentBtn_Click(object sender, EventArgs e)
        {
            student.ID = ID;
            student.Name = studentNameBox.Text;
            student.Surname = studentSurnameBox.Text;
            student.BirthDate = studentBirthDateTimePicker.Value;

            if (student.ID != 0 && student.Name != "" && student.Surname != "" && student.BirthDate.ToString() != "")
            {
                studentDbManager.updateStudent(student);
                MessageBox.Show("Student is updated.");
                LoadStudentsBtn_Click(sender, e);
            }

            else
            {
                MessageBox.Show("Please choose a student to update.");
            }

            ClearFields.clearAllFields(this);
        }

        private void DeleteStudentBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Delete student", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                student.ID = ID;

                if (student.ID != 0)
                {
                    studentDbManager.DeleteStudent(student);
                    MessageBox.Show("Student is deleted.");
                    LoadStudentsBtn_Click(sender, e);
                    ID = 0;
                }

                else
                {
                    MessageBox.Show("Student is not selected.");
                }

                ClearFields.clearAllFields(this);
            }
        }

        private void dataGridView1_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (isLoadStudentsBtnClicked == true)
            {
                studentBirthDateTimePicker.Checked = true;
                try
                {
                    ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    studentNameBox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    studentSurnameBox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    studentBirthDateTimePicker.Format = DateTimePickerFormat.Short;
                    studentBirthDateTimePicker.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void LoadCoursesBtn_Click(object sender, EventArgs e)
        {
            isLoadStudentsBtnClicked = false;
            isStudentPresent = false;

            var loadCourses = teacherDbManager.LoadCourses();
            dataGridView1.DataSource = loadCourses;

            ClearFields.clearAllFields(this);
        }

        private void CoursesInProgressBtn_Click(object sender, EventArgs e)
        {
            isLoadStudentsBtnClicked = false;
            isStudentPresent = true;

            var loadCoursesInProgress = teacherDbManager.LoadCoursesInProgress();
            dataGridView1.DataSource = loadCoursesInProgress;

            ClearFields.clearAllFields(this);
        }

        private void createNewCourseBtn_Click(object sender, EventArgs e)
        {
            course.ID = ID;
            course.Name = courseNameBox.Text;
            course.StartingDate = courseStartingDateTimePicker.Value;

            if (course.Name != "" && teacherList.Text != "" && checkBox1.Checked && course.StartingDate.ToString() != "")
            {

                teacherDbManager.CreateNewCourse(course, teacherList.SelectedValue);
                MessageBox.Show("New course is added.");
                LoadCoursesBtn_Click(sender, e);
            }

            else
            {
                MessageBox.Show("Not all fields are included.");
            }
            ClearFields.clearAllFields(this);
        }

        private void CreateNewTeacherBtn_Click(object sender, EventArgs e)
        {
            teacher.Name = teacherNameBox.Text;
            teacher.Surname = teacherSurnameBox.Text;

            if (teacher.Name != "" && teacher.Surname != "")
            {
                teacherDbManager.CreateNewTeacher(teacher);
                MessageBox.Show("New teacher is added.");
                teacherDbManager.InitializeComboBox();
            }

            else
            {
                MessageBox.Show("Not all fields are included.");
            }

            ClearFields.clearAllFields(this);
        }

        private void clearAllFieldsBtn_Click(object sender, EventArgs e)
        {
            ClearFields.clearAllFields(this);
        }

        private void studentBirthDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (studentBirthDateTimePicker.Checked)
            {
                studentBirthDateTimePicker.Format = DateTimePickerFormat.Short;
            }
            else
            {
                studentBirthDateTimePicker.CustomFormat = " ";
                studentBirthDateTimePicker.Format = DateTimePickerFormat.Custom;
            }
        }

        private void courseStartingDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (courseStartingDateTimePicker.Checked)
            {
                courseStartingDateTimePicker.Format = DateTimePickerFormat.Short;
            }
            else
            {
                courseStartingDateTimePicker.CustomFormat = " ";
                courseStartingDateTimePicker.Format = DateTimePickerFormat.Custom;
            }
        }

        private void teacherList_DropDown(object sender, EventArgs e)
        {
            var initComboBox = teacherDbManager.InitializeComboBox();
            teacherList.DataSource = initComboBox;
            teacherList.DisplayMember = "FullName";
            teacherList.ValueMember = "ID";
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Name"].Index && isStudentPresent == true)
            {
                course.ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                var studentsTakingCourses = studentDbManager.StudentsTakingCourses(course);
                dataGridView1.DataSource = studentsTakingCourses;
            }
        }
    }
}