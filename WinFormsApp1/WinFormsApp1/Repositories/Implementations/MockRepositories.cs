using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Entities;
using WinFormsApp1.Entities.Enums;

namespace WinFormsApp1.Repositories.Implementations
{
    // заглушки справочников

    internal class FacultyRepository : IFacultyRepository
    {
        public void CreateFaculty(Faculty faculty) { }
        public void DeleteFaculty(int id) { }
        public Faculty ReadFacultyById(int id) => Faculty.CreateEntity(0, string.Empty);
        public IEnumerable<Faculty> ReadFaculties() => [];
        public void UpdateFaculty(Faculty faculty) { }
    }

    internal class DepartmentRepository : IDepartmentRepository
    {
        public void CreateDepartment(Department department) { }
        public void DeleteDepartment(int id) { }
        public Department ReadDepartmentById(int id) => Department.CreateEntity(0, string.Empty, 0);
        public IEnumerable<Department> ReadDepartments() => [];
        public void UpdateDepartment(Department department) { }
    }

    internal class GroupRepository : IGroupRepository
    {
        public void CreateGroup(Group group) { }
        public void DeleteGroup(int id) { }
        public Group ReadGroupById(int id) => Group.CreateEntity(0, string.Empty, 0);
        public IEnumerable<Group> ReadGroups() => [];
        public void UpdateGroup(Group group) { }
    }

    internal class DisciplineRepository : IDisciplineRepository
    {
        public void CreateDiscipline(Discipline discipline) { }
        public void DeleteDiscipline(int id) { }
        public Discipline ReadDisciplineById(int id) => Discipline.CreateEntity(0, string.Empty, string.Empty);
        public IEnumerable<Discipline> ReadDisciplines() => [];
        public void UpdateDiscipline(Discipline discipline) { }
    }

    // --- ЗАГЛУШКИ ОПЕРАЦИЙ ---

    internal class StudentRepository : IStudentRepository
    {
        public void CreateStudent(Student student) { }
        public Student ReadStudentById(int id) => Student.CreateEntity(0, string.Empty, StudentStatus.None, 0);
        public IEnumerable<Student> ReadStudents() => [];
    }

    internal class ExamRepository : IExamRepository
    {
        public void CreateExam(Exam exam) { }
        public IEnumerable<Exam> ReadExams() => [];
    }

    internal class SessionResultRepository : ISessionResultRepository
    {
        public void CreateSessionResult(SessionResult result) { }
        public IEnumerable<SessionResult> ReadSessionResults() => [];
    }
}