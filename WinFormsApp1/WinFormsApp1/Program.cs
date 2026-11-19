using System;
using System.Windows.Forms;
using Unity;
using Unity.Lifetime;
using WinFormsApp1.Repositories;
using WinFormsApp1.Repositories.Implementations;

namespace WinFormsApp1
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Создаем контейнер и делегируем ему создание главной формы
            Application.Run(CreateContainer().Resolve<MainForm>());
        }

        // Тот самый метод, который требует Задание №5
        private static IUnityContainer CreateContainer()
        {
            // 1. Создаем экземпляр контейнера
            var container = new UnityContainer();

            // 2. Регистрируем все зависимости (Интерфейс -> Реализация)
            // Справочники
            container.RegisterType<IFacultyRepository, FacultyRepository>(new TransientLifetimeManager());
            container.RegisterType<IDepartmentRepository, DepartmentRepository>(new TransientLifetimeManager());
            container.RegisterType<IGroupRepository, GroupRepository>(new TransientLifetimeManager());
            container.RegisterType<IDisciplineRepository, DisciplineRepository>(new TransientLifetimeManager());

            // Операции
            container.RegisterType<IStudentRepository, StudentRepository>(new TransientLifetimeManager());
            container.RegisterType<IExamRepository, ExamRepository>(new TransientLifetimeManager());
            container.RegisterType<ISessionResultRepository, SessionResultRepository>(new TransientLifetimeManager());

            // 3. Возвращаем готовый контейнер
            return container;
        }
    }
}