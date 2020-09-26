using DataAccess.Abstract;
using Entity;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class StudentDAL : IRepository<Student>
    {
        static StudentDAL studentDAL;
        SqliteService sqliteService;
        SqliteDataReader dataReader;

        public StudentDAL()
        {
            sqliteService = SqliteService.GetInstance();
        }

        public string Add(Student entity)
        {
            try
            {
                dataReader = sqliteService.Reader("select NAME from STUDENTS where NAME=@name", new SqliteParameter("@name", entity.Name));
                if (dataReader.Read())
                {
                    return entity.Name + " Daha Önce Eklenmiş";
                }
                sqliteService.Execute("insert into STUDENTS (NAME,LESSON,NOTE1,NOTE2) values (@name,@lesson,@note1,@note2)", new SqliteParameter("@name", entity.Name), new SqliteParameter("@lesson", entity.Lesson), new SqliteParameter("@note1", entity.Note1), new SqliteParameter("@note2", entity.Note2));
                return entity.Name + " Öğrencisi Başarıyla Eklendi";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Delete(int id)
        {
            try
            {
                sqliteService.Execute("delete from STUDENTS where ID=@id", new SqliteParameter("@id", id));
                return GetStudentNameById(id) + " Öğrencisi Başarıyla Silindi";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public Student Get(int id)
        {
            try
            {
                Student student = null;
                dataReader = sqliteService.Reader("select * from STUDENTS where ID=@id", new SqliteParameter("@id", id));
                if (dataReader.Read())
                {
                    student = new Student(dataReader["ID"].ConInt(), dataReader["NOTE1"].ConInt(), dataReader["NOTE2"].ConInt(), dataReader["NAME"].ToString(), dataReader["LESSON"].ToString());
                }
                dataReader.Close();
                return student;
            }
            catch
            {
                return null;
            }
        }

        public List<Student> GetList()
        {
            try
            {
                List<Student> students = new List<Student>();
                dataReader = sqliteService.Reader("select * from STUDENTS");
                while (dataReader.Read())
                {
                    Student student = new Student(dataReader["ID"].ConInt(), dataReader["NOTE1"].ConInt(), dataReader["NOTE2"].ConInt(), dataReader["NAME"].ToString(), dataReader["LESSON"].ToString());
                    students.Add(student);
                }
                dataReader.Close();
                return students;
            }
            catch (Exception ex)
            {
                return new List<Student>();
            }
        }

        public string Update(Student entity, string oldName)
        {
            try
            {
                dataReader = sqliteService.Reader("select NAME from STUDENTS where NAME=@name and NAME!=@oldName", new SqliteParameter("@name", entity.Name), new SqliteParameter("@oldName", oldName));
                if (dataReader.Read())
                {
                    return entity.Name + " İsmiyle Kayıtlı Başka Bir Öğrenci Bulunuyor";
                }

                sqliteService.Execute("update STUDENTS set NAME=@name,LESSON=@lesson,NOTE1=@note1,NOTE2=@note2 where ID=@id", new SqliteParameter("@name", entity.Name), new SqliteParameter("@lesson", entity.Lesson), new SqliteParameter("@note1", entity.Note1), new SqliteParameter("@note2", entity.Note2), new SqliteParameter("@id", entity.Id));
                return entity.Name + " Öğrencisi Başarıyla Güncellendi";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string GetStudentNameById(int id)
        {
            try
            {
                string name = "";
                dataReader = sqliteService.Reader("select NAME from STUDENTS where ID=@id", new SqliteParameter("@id", id));
                if (dataReader.Read())
                {
                    name = dataReader["NAME"].ToString();
                }
                dataReader.Close();
                return name;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public static StudentDAL GetInstance()
        {
            if (studentDAL == null)
            {
                studentDAL = new StudentDAL();
            }
            return studentDAL;
        }

        public List<Branch> GetBranchList()
        {
            try
            {
                List<Branch> branches = new List<Branch>();
                dataReader = sqliteService.Reader("select B.*,S.NAME AS STUDENT_NAME from BRANCHES B inner join STUDENTS S on B.STUDENT_ID=S.ID");
                while (dataReader.Read())
                {
                    Branch branch = new Branch(dataReader["ID"].ConInt(), dataReader["STUDENT_ID"].ConInt(), dataReader["NAME"].ToString(), dataReader["STUDENT_NAME"].ToString());
                    branches.Add(branch);
                }
                dataReader.Close();
                return branches;
            }
            catch (Exception ex)
            {
                return new List<Branch>();
            }
        }
    }
}
