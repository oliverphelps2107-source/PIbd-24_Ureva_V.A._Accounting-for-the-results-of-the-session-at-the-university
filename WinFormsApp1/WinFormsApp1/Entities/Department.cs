using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Entities
{
    public class Department
    {
        public int Id { get; private set; }
        public string Name { get; private set; } = string.Empty;
        public int FacultyId { get; private set; }

        public static Department CreateEntity(int id, string name, int facultyId)
        {
            return new Department
            {
                Id = id,
                Name = name ?? string.Empty,
                FacultyId = facultyId
            };
        }
    }
}