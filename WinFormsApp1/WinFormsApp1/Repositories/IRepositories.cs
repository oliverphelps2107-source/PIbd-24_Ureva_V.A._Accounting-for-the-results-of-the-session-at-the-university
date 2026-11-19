using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using WinFormsApp1.Entities;

namespace WinFormsApp1.Repositories
{
    // справочники

    public interface IFacultyRepository
    {
        IEnumerable<Faculty> ReadFaculties();
        Faculty ReadFacultyById(int id);
        void CreateFaculty(Faculty faculty);
        void UpdateFaculty(Faculty faculty);
        void DeleteFaculty(int id);
    }

    public interface IDepartmentRepository
    {
        IEnumerable<Department> ReadDepartments();
        Department ReadDepartmentById(int id);
        void CreateDepartment(Department department);
        void UpdateDepartment(Department department);
        void DeleteDepartment(int id);
    }

    public interface IGroupRepository
    {
        IEnumerable<Group> ReadGroups();
        Group ReadGroupById(int id);
        void CreateGroup(Group group);
        void UpdateGroup(Group group);
        void DeleteGroup(int id);
    }

    public interface IDisciplineRepository
    {
        IEnumerable<Discipline> ReadDisciplines();
        Discipline ReadDisciplineById(int id);
        void CreateDiscipline(Discipline discipline);
        void UpdateDiscipline(Discipline discipline);
        void DeleteDiscipline(int id);
    }

    // сущности-операции

    public interface IStudentRepository
    {
        IEnumerable<Student> ReadStudents();
        Student ReadStudentById(int id);
        void CreateStudent(Student student);
    }

    public interface IExamRepository
    {
        IEnumerable<Exam> ReadExams();
        void CreateExam(Exam exam);
    }

    public interface ISessionResultRepository
    {
        IEnumerable<SessionResult> ReadSessionResults();
        void CreateSessionResult(SessionResult result);
    }
}