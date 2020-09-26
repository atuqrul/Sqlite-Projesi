using DataAccess.Abstract;
using DataAccess.Concrete;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class StudentManager
    {
        static StudentManager studentManager;
        StudentDAL studentDAL;
        public StudentManager()
        {
            studentDAL = StudentDAL.GetInstance();
        }
        public string Add(Student entity)
        {
            try
            {
                string controlText = IsStudentComplete(entity);
                if (controlText != "")
                {
                    return controlText;
                }
                return studentDAL.Add(entity);
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
                if (id < 1)
                {
                    return "Geçerli Bir Öğrenci Seçiniz";
                }
                return studentDAL.Delete(id);
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
                if (id < 1)
                {
                    return null;
                }
                return studentDAL.Get(id);
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
                return studentDAL.GetList();
            }
            catch
            {
                return new List<Student>();
            }
        }

        public string Update(Student entity, string oldName)
        {
            try
            {
                if (entity.Id < 1)
                {
                    return "Geçerli Bir Öğrenci Seçiniz";
                }
                string controlText = IsStudentComplete(entity);
                if (controlText != "")
                {
                    return controlText;
                }
                return studentDAL.Update(entity, oldName);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        string IsStudentComplete(Student student)
        {
            if (string.IsNullOrEmpty(student.Name) || string.IsNullOrEmpty(student.Lesson) || student.Note1 < 0 || student.Note2 < 0)
            {
                return "Öğrenci Bilgilerini Tam Giriniz";
            }
            return "";
        }

        public static StudentManager GetInstance()
        {
            if (studentManager == null)
            {
                studentManager = new StudentManager();
            }
            return studentManager;
        }

        string GetStudentNameById(int id)
        {
            try
            {
                return studentDAL.GetStudentNameById(id);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Branch> GetBranchList()
        {
            try
            {
                return studentDAL.GetBranchList();
            }
            catch
            {
                return new List<Branch>();
            }
        }
    }
}
