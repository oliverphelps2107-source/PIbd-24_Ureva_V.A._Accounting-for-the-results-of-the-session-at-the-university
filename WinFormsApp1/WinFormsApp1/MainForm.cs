using System;
using System.Windows.Forms;
using Unity;

using System;
using System.Windows.Forms;
using Unity;
using WinFormsApp1.Forms; // Папка с формами

namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        // Контейнер для внедрения зависимостей
        private readonly IUnityContainer _container;

        public MainForm(IUnityContainer container)
        {
            InitializeComponent();
            _container = container ?? throw new ArgumentNullException(nameof(container));
        }

        // ==========================================
        // ОБРАБОТЧИКИ ДЛЯ ПУНКТОВ МЕНЮ "СПРАВОЧНИКИ"
        // ==========================================

        // ВАЖНО: Пока мы не создали сами формы (FormFaculties и т.д.), 
        // этот код будет подчеркиваться красным. Как только создашь формы - ошибка исчезнет.

        private void facultyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _container.Resolve<FormFaculties>().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при открытии", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void departmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _container.Resolve<FormDepartments>().ShowDialog(); // <-- Вот эта строчка
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _container.Resolve<FormGroups>().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void disciplineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _container.Resolve<FormDisciplines>().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==========================================
        // ОБРАБОТЧИКИ ДЛЯ ПУНКТОВ МЕНЮ "ОПЕРАЦИИ"
        // ==========================================

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _container.Resolve<FormStudents>().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void examToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _container.Resolve<FormExams>().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sessionResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                _container.Resolve<FormSessionResults>().ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}