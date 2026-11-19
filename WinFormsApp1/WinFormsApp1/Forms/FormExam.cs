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

        public FormExam(IExamRepository examRepository, IStudentRepository studentRepository, IDisciplineRepository disciplineRepository)
        {
            InitializeComponent();
            _examRepository = examRepository ?? throw new ArgumentNullException(nameof(examRepository));

            //  ComboBox Студентов
            comboBoxStudent.DataSource = studentRepository.ReadStudents().ToList();
            comboBoxStudent.DisplayMember = "FullName"; 
            comboBoxStudent.ValueMember = "Id";         

            //  ComboBox Дисциплин
            comboBoxDiscipline.DataSource = disciplineRepository.ReadDisciplines().ToList();
            comboBoxDiscipline.DisplayMember = "Name";  
            comboBoxDiscipline.ValueMember = "Id";

            //  ComboBox Оценок
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
                    comboBoxDiscipline.Text, 
                    "Преподаватель", 
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