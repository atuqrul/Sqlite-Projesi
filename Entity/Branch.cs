using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Branch
    {
        int id, studentId;string name,studentName;

        public int Id { get => id; set => id = value; }
        public int StudentId { get => studentId; set => studentId = value; }
        public string Name { get => name; set => name = value; }
        public string StudentName { get => studentName; set => studentName = value; }

        public Branch(int id, int studentId, string name,string studentName)
        {
            this.id = id;
            this.studentId = studentId;
            this.name = name;
            this.studentName = studentName;
        }
    }
}
