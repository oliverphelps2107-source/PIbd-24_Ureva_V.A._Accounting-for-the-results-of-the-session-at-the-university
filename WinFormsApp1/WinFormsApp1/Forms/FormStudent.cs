using System;
using System.Windows.Forms;
using WinFormsApp1.Entities;
using WinFormsApp1.Entities.Enums;
using WinFormsApp1.Repositories;

namespace WinFormsApp1.Forms
{
    public partial class FormStudent : Form
    {
        private readonly IStudentRepository _repository;

        public FormStudent(IStudentRepository repository)
        {
            InitializeComponent();
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));

            // Заполняем CheckedListBox значениями из флагового перечисления
            foreach (var status in Enum.GetValues(typeof(StudentStatus)))
            {
                // Не добавляем "None" в список, чтобы не путать пользователя
                if ((StudentStatus)status != StudentStatus.None)
                {
                    checkedListBoxStatus.Items.Add(status);
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxFullName.Text))
                    throw new Exception("ФИО не может быть пустым!");

                if (numericUpDownGroupId.Value <= 0)
                    throw new Exception("ID Группы должен быть больше нуля!");

                // Собираем выбранные галочки обратно в один флаг
                StudentStatus status = StudentStatus.None;
                foreach (var item in checkedListBoxStatus.CheckedItems)
                {
                    status |= (StudentStatus)item;
                }

                var student = Student.CreateEntity(0, textBoxFullName.Text, status, (int)numericUpDownGroupId.Value);
                _repository.CreateStudent(student);

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e) => Close();
    }
}