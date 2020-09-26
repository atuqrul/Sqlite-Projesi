using Business;
using DataAccess.Concrete;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class FrmStudents : Form
    {
        StudentManager studentManager;
        List<Student> students;
        Student chosenStudent;
        string oldName;

        public FrmStudents()
        {
            InitializeComponent();
            studentManager = StudentManager.GetInstance();
        }

        private void FrmStudents_Load(object sender, EventArgs e)
        {
            StudentList();
            tmrList.Start();
        }

        void StudentList()
        {
            chosenStudent = null;
            DtgStudents.Rows.Clear();
            students = studentManager.GetList();
            foreach (Student item in students)
            {
                DtgStudents.Rows.Add();
                int lastRow = DtgStudents.RowCount - 1;
                DtgStudents.Rows[lastRow].Cells["ID"].Value = item.Id;
                DtgStudents.Rows[lastRow].Cells["Name_"].Value = item.Name;
                DtgStudents.Rows[lastRow].Cells["Lesson"].Value = item.Lesson;
                int note1 = item.Note1, note2 = item.Note2;
                DtgStudents.Rows[lastRow].Cells["Note1"].Value = note1;
                DtgStudents.Rows[lastRow].Cells["Note2"].Value = note2;

                double result = (note1 * 0.4) + (note2 * 0.6);
                DtgStudents.Rows[lastRow].Cells["State"].Value = result >= 50;

                /* if (result>=50)
                 {
                     DtgStudents.Rows[lastRow].Cells["State"].Value = true;
                 }
                 else
                 {
                     DtgStudents.Rows[lastRow].Cells["State"].Value = false;
                 }*/

            }
            Clear();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(TxtName.Text + " Öğrencisini Kaydetmek İstiyor Musunuz ?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                Student student = new Student(MskNote1.Text.ConInt(), MskNote2.Text.ConInt(), TxtName.Text, TxtLesson.Text);
                MessageBox.Show(studentManager.Add(student));
                StudentList();
            }
        }

        private void DtgStudents_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (DtgStudents.CurrentRow == null)
            {
                MessageBox.Show("Öncelikle Listeden Personel Seçiniz");
                return;
            }

            DataGridViewRow row = DtgStudents.CurrentRow;

            chosenStudent = new Student(
                row.Cells["ID"].Value.ConInt(),
                row.Cells["Note1"].Value.ConInt(),
                row.Cells["Note2"].Value.ConInt(),
                row.Cells["Name_"].Value.ToString(),
                row.Cells["Lesson"].Value.ToString()
                );

            oldName = chosenStudent.Name;
            TxtName.Text = oldName;
            TxtLesson.Text = chosenStudent.Lesson;
            MskNote1.Text = chosenStudent.Note1.ToString();
            MskNote2.Text = chosenStudent.Note2.ToString();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (chosenStudent == null)
            {
                MessageBox.Show("Öncelikle Listeden Personel Seçiniz");
                return;
            }

            DialogResult dr = MessageBox.Show(TxtName.Text + " Öğrencisini Güncellemek İstiyor Musunuz ?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                chosenStudent.Name = TxtName.Text;
                chosenStudent.Lesson = TxtLesson.Text;
                chosenStudent.Note1 = MskNote1.Text.ConInt();
                chosenStudent.Note2 = MskNote2.Text.ConInt();
                MessageBox.Show(studentManager.Update(chosenStudent, oldName));
                StudentList();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (chosenStudent == null)
            {
                MessageBox.Show("Öncelikle Listeden Personel Seçiniz");
                return;
            }
            DialogResult dr = MessageBox.Show(TxtName.Text + " Öğrencisini Silmek İstiyor Musunuz ?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                MessageBox.Show(studentManager.Delete(chosenStudent.Id));
                StudentList();
            }
        }

        private void tmrList_Tick(object sender, EventArgs e)
        {
            StudentList();
            //MessageBox.Show("Liste Yenilendi");
        }


        void Clear()
        {
            TxtName.Text = ""; TxtLesson.Text = ""; MskNote1.Text = ""; MskNote2.Text = "";
        }

        private void BtnBranch_Click(object sender, EventArgs e)
        {
            new FrmBranches().ShowDialog();
        }
    }
}
