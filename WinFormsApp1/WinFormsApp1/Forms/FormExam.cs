using System;
using System.Windows.Forms;
using WinFormsApp1.Entities;
using WinFormsApp1.Entities.Enums;
using WinFormsApp1.Repositories;
using System.Linq;

namespace WinFormsApp1.Forms
{
    public partial class FormExam : Form
    {
        private readonly IExamRepository _examRepository;

        // Внедряем сразу 3 репозитория через конструктор
        public FormExam(IExamRepository examRepository, IStudentRepository studentRepository, IDisciplineRepository disciplineRepository)
        {
            InitializeComponent();
            _examRepository = examRepository ?? throw new ArgumentNullException(nameof(examRepository));

            // Заполняем ComboBox Студентов
            comboBoxStudent.DataSource = studentRepository.ReadStudents().ToList();
            comboBoxStudent.DisplayMember = "FullName"; // Показываем ФИО
            comboBoxStudent.ValueMember = "Id";         // Значение - ID

            // Заполняем ComboBox Дисциплин
            comboBoxDiscipline.DataSource = disciplineRepository.ReadDisciplines().ToList();
            comboBoxDiscipline.DisplayMember = "Name";  // Показываем Название
            comboBoxDiscipline.ValueMember = "Id";

            // Заполняем ComboBox Оценок
            comboBoxGrade.DataSource = Enum.GetValues(typeof(ExamGrade));
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxStudent.SelectedIndex < 0 || comboBoxDiscipline.SelectedIndex < 0 || comboBoxGrade.SelectedIndex < 0)
                    throw new Exception("Выберите все значения!");

                var exam = Exam.CreateOperation(
                    0,
                    (int)comboBoxStudent.SelectedValue,
                    comboBoxDiscipline.Text, // Берем текст (Название дисциплины)
                    "Преподаватель", // Для упрощения, можно тоже вытащить из репозитория
                    (ExamGrade)comboBoxGrade.SelectedItem
                );

                _examRepository.CreateExam(exam);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e) => Close();
    }
}