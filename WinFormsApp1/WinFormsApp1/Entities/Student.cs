using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Entities.Enums;

namespace WinFormsApp1.Entities
{
    public class Student
    {
        // приватные сеттеры,нельзя изменить извне
        public int Id { get; private set; }
        public string FullName { get; private set; } = string.Empty;
        public StudentStatus Status { get; private set; }
        public int GroupId { get; private set; }

        //статич.метод для создания обьекта
        public static Student CreateEntity(int id, string fullName, StudentStatus status, int groupId)
        {
            return new Student
            {
                Id = id,
                FullName = fullName ?? string.Empty, //защита от нул
                Status = status,
                GroupId = groupId
            };
        }
    }
}