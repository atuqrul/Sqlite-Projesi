using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Student
    {
        int id, note1, note2; string name, lesson;

        public int Id { get => id; set => id = value; }
        public int Note1 { get => note1; set => note1 = value; }
        public int Note2 { get => note2; set => note2 = value; }
        public string Name { get => name; set => name = value; }
        public string Lesson { get => lesson; set => lesson = value; }

        public Student(int note1, int note2, string name, string lesson)
        {
            this.note1 = note1;
            this.note2 = note2;
            this.name = name;
            this.lesson = lesson;
        }

        public Student(int id, int note1, int note2, string name, string lesson)
        {
            this.id = id;
            this.note1 = note1;
            this.note2 = note2;
            this.name = name;
            this.lesson = lesson;
        }
    }
}
