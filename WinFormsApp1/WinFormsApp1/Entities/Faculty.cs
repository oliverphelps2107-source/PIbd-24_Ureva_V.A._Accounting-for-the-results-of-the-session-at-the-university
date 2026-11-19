using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Entities
{
    public class Faculty
    {
        public int Id { get; private set; }
        public string Name { get; private set; } = string.Empty;

        public static Faculty CreateEntity(int id, string name)
        {
            return new Faculty
            {
                Id = id,
                Name = name ?? string.Empty
            };
        }
    }
}