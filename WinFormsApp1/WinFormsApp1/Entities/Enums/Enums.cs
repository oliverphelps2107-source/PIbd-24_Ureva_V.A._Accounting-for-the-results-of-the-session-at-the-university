using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Entities.Enums
{
    //обычное перечисление(оценки)
    public enum ExamGrade
    {
        Bad = 2,
        Satisfactory = 3,
        Good = 4,
        Excellent = 5
    }
    // флаговое перечисление(статус студента,можно выбрать несколько знач. одновременно)
    [Flags]
    public enum StudentStatus
    {
        None = 0,
        IsMarried = 1,
        LivesInDorm = 2
    }
}