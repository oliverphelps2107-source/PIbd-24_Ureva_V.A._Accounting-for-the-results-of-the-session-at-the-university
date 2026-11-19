using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Entities
{
    public class SessionResult
    {
        public int Id { get; private set; }
        public int StudentId { get; private set; }
        public double AverageGrade { get; private set; }
        public decimal Scholarship { get; private set; }

        public static SessionResult CreateOperation(int id, int studentId, double averageGrade, decimal scholarship)
        {
            return new SessionResult
            {
                Id = id,
                StudentId = studentId,
                AverageGrade = averageGrade,
                Scholarship = scholarship
            };
        }
    }
}
