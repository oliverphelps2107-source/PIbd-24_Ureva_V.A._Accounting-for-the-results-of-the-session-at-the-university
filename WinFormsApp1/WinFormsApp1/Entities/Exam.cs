using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Entities.Enums;

namespace WinFormsApp1.Entities
{
    public class Exam
    {
        public int Id { get; private set; }
        public int StudentId { get; private set; } //ссылка на студента( связь М:М)
        public string DisciplineName { get; private set; } = string.Empty; //ссылка на дисциплину
        public string TeacherName { get; private set; } = string.Empty;
        public ExamGrade Grade { get; private set; }

        public static Exam CreateOperation(int id, int studentId, string disciplineName, string teacherName, ExamGrade grade)
        {
            return new Exam
            {
                Id = id,
                StudentId = studentId,
                DisciplineName = disciplineName ?? string.Empty,
                TeacherName = teacherName ?? string.Empty,
                Grade = grade
            };
        }
    }
}