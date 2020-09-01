using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace StudentCrudOperations
{
    class TeacherDbManager
    {
        private DbConfig dbConfig = new DbConfig();
        private MySqlCommand command;

        public void CreateNewTeacher(Teacher teacher)
        {
            dbConfig.connection().Open();
            command = new MySqlCommand("insert into teachers (teacher_name, teacher_surname) values (@teacherName, @teacherSurname)", dbConfig.connection());
            command.Parameters.AddWithValue("@teacherName", teacher.Name);
            command.Parameters.AddWithValue("@teacherSurname", teacher.Surname);
            command.ExecuteNonQuery();
            dbConfig.connection().Close();
        }

        public void CreateNewCourse(Course course, object teacher)
        {   
            dbConfig.connection().Open();
            command = new MySqlCommand("insert into courses (course_name, teacher_id, isInProgress, starting_date) values (@courseName, @teacherId, @checkBox, @startingDate)", dbConfig.connection());
            command.Parameters.AddWithValue("@courseName", course.Name);
            command.Parameters.AddWithValue("@teacherId", teacher);
            command.Parameters.AddWithValue("@checkBox", true);
            command.Parameters.Add("@startingDate", MySqlDbType.Date).Value = course.StartingDate;
            command.ExecuteNonQuery();
            dbConfig.connection().Close();
        }

        public List<Teacher> InitializeComboBox()
        {
            var teacherList = new List<Teacher>();

            dbConfig.connection().Open();

            using (command = new MySqlCommand("select * from teachers", dbConfig.connection()))
            {
                using (var dr = command.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            teacherList.Add(new Teacher
                            {
                                ID = (int)dr[0],
                                Name = dr[1].ToString(),
                                Surname = dr[2].ToString()
                            });
                        }
                    }
                }

                dbConfig.connection().Close();
            }
            return teacherList;
        }

        public List<Course> LoadCourses()
        {
            var courseslist = new List<Course>();

            dbConfig.connection().Open();

            using (command = new MySqlCommand("select course_id, course_name, starting_date, teacher_name, teacher_surname from courses t1 inner join teachers t2 on t1.teacher_id = t2.teacher_id", dbConfig.connection()))
            {
                using (var dr = command.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            courseslist.Add(new Course
                            {
                                ID = (int)dr["course_id"],
                                Name = dr["course_name"].ToString(),
                                StartingDate = Convert.ToDateTime(dr["starting_date"]),
                                TeacherName = dr["teacher_name"].ToString(),
                                TeacherSurname = dr["teacher_surname"].ToString()
                            });
                        }
                    }

                }
                dbConfig.connection().Close();
            }
            return courseslist;
        }

        public List<Course> LoadCoursesInProgress()
        {
            var coursesInProgressList = new List<Course>();

            dbConfig.connection().Open();

            using (command = new MySqlCommand("select course_id, course_name, starting_date, teacher_name, teacher_surname from courses t1 inner join teachers t2 on t1.teacher_id = t2.teacher_id where t1.isInProgress = 1", dbConfig.connection()))
            {
                using (var dr = command.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            coursesInProgressList.Add(new Course
                            {
                                ID = (int)dr["course_id"],
                                Name = dr["course_name"].ToString(),
                                StartingDate = Convert.ToDateTime(dr["starting_date"]),
                                TeacherName = dr["teacher_name"].ToString(),
                                TeacherSurname = dr["teacher_surname"].ToString()
                            });
                        }
                    }
                }
                dbConfig.connection().Close();
            }
            return coursesInProgressList;
        }
    }
}
