using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Entities.Enums
{
    public enum ExamGrade
    {
        Bad = 2,
        Satisfactory = 3,
        Good = 4,
        Excellent = 5
    }

    [Flags]
    public enum StudentStatus
    {
        None = 0,
        IsMarried = 1,
        LivesInDorm = 2
    }
}