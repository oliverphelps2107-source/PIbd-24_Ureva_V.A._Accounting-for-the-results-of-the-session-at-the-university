using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Entities
{
    public class Group
    {
        public int Id { get; private set; }
        public string Number { get; private set; } = string.Empty;
        public int DepartmentId { get; private set; }

        public static Group CreateEntity(int id, string number, int departmentId)
        {
            return new Group
            {
                Id = id,
                Number = number ?? string.Empty,
                DepartmentId = departmentId
            };
        }
    }
}