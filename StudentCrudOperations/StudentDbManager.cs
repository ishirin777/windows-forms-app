using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentCrudOperations
{
    class StudentDbManager
    {
        private DbConfig dbConfig = new DbConfig();
        private MySqlCommand command;

        public List<Student> LoadStudents()
        {
            var loadStudentlist = new List<Student>();
            dbConfig.connection().Open();

            using (command = new MySqlCommand("select * from students", dbConfig.connection()))
            {
                using (var dr = command.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            loadStudentlist.Add(new Student
                            {
                                ID = (int)dr[0],
                                Name = dr[1].ToString(),
                                Surname = dr[2].ToString(),
                                BirthDate = Convert.ToDateTime(dr[3])
                            });
                        }
                    }
                }
                dbConfig.connection().Close();
            }
            return loadStudentlist;
        }

        public void AddStudent(Student student)
        {
            dbConfig.connection().Open();
            command = new MySqlCommand("insert into students(student_name, student_surname, student_birth) values(@name, @surname, @birth)", dbConfig.connection());
            command.Parameters.AddWithValue("@name", student.Name);
            command.Parameters.AddWithValue("@surname", student.Surname);
            command.Parameters.Add("@birth", MySqlDbType.Date).Value = student.BirthDate;
            command.ExecuteNonQuery();
            dbConfig.connection().Close();
        }

        public void JoinCourses(Student student, object course)
        {
            foreach (var item in StudentIDList(student))
            {
                student.ID = item;
            }

            dbConfig.connection().Open();
            command = new MySqlCommand("insert into students_courses(student_id, course_id) values(@studentID, @courseID)", dbConfig.connection());
            command.Parameters.AddWithValue("@studentID", student.ID);
            command.Parameters.AddWithValue("@courseID", course);
            command.ExecuteNonQuery();
            dbConfig.connection().Close();
        }

        public List<int> StudentIDList(Student student)
        {
            var studentIDList = new List<int>();
            dbConfig.connection().Open();

            using (command = new MySqlCommand("select student_id from students", dbConfig.connection()))
            {
                using (var dr = command.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            studentIDList.Add(
                                student.ID = (int)dr[0]
                            );
                        }
                    }
                }
                dbConfig.connection().Close();
            }
            return studentIDList;
        }

        public void updateStudent(Student student)
        {
            dbConfig.connection().Open();
            command = new MySqlCommand("update students set student_name = @name, student_surname = @surname, student_birth = @birth where student_id = @ID", dbConfig.connection());
            command.Parameters.AddWithValue("@ID", student.ID);
            command.Parameters.AddWithValue("@name", student.Name);
            command.Parameters.AddWithValue("@surname", student.Surname);
            command.Parameters.Add("@birth", MySqlDbType.Date).Value = student.BirthDate;
            command.ExecuteNonQuery();
            dbConfig.connection().Close();
        }

        public void DeleteStudent(Student student)
        {
            dbConfig.connection().Open();
            command = new MySqlCommand("delete from students where student_id = @ID", dbConfig.connection());
            command.Parameters.AddWithValue("@ID", student.ID);
            command.ExecuteNonQuery();
            dbConfig.connection().Close();
        }

        public List<Student> StudentsTakingCourses(Course course)
        {
            var studentsTakingCoursesList = new List<Student>();
            dbConfig.connection().Open();

            using (command = new MySqlCommand("select t1.student_id, student_name, student_surname, student_birth from students t1 inner join students_courses t2 on t1.student_id = t2.student_id where t2.course_id = @ID", dbConfig.connection()))
            {
                command.Parameters.AddWithValue("@ID", course.ID);
                using (var dr = command.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            studentsTakingCoursesList.Add(new Student
                            {
                                ID = (int)dr["student_id"],
                                Name = dr["student_name"].ToString(),
                                Surname = dr["student_surname"].ToString(),
                                BirthDate = Convert.ToDateTime(dr["student_birth"])
                            });
                        }
                    }
                }
                dbConfig.connection().Close();
            }
            return studentsTakingCoursesList;
        }
    }
}
