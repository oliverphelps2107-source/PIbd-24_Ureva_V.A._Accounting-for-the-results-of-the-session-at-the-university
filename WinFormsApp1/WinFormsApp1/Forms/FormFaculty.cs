using System;
using System.Windows.Forms;
using WinFormsApp1.Entities;
using WinFormsApp1.Repositories;
using System.Collections.Generic;

namespace WinFormsApp1.Forms
{
    public partial class FormFaculty : Form
    {
        private readonly IFacultyRepository _repository;
        private int? _facultyId; // null, если создаем новую запись

        // Конструктор с внедрением зависимости
        public FormFaculty(IFacultyRepository repository)
        {
            InitializeComponent();
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        // Это свойство мы будем вызывать из формы списка, когда нажмем "Изменить"
        public int Id
        {
            set
            {
                try
                {
                    var faculty = _repository.ReadFacultyById(value);
                    if (faculty == null) throw new Exception("Запись не найдена");

                    textBoxName.Text = faculty.Name;
                    _facultyId = value; // запоминаем, что мы редактируем
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Проверка на пустоту
                if (string.IsNullOrWhiteSpace(textBoxName.Text))
                    throw new Exception("Название не может быть пустым!");

                // Если _facultyId не null, значит мы редактируем существующую запись
                if (_facultyId.HasValue)
                {
                    _repository.UpdateFaculty(Faculty.CreateEntity(_facultyId.Value, textBoxName.Text));
                }
                else
                {
                    // Если null - создаем новую (Id = 0)
                    _repository.CreateFaculty(Faculty.CreateEntity(0, textBoxName.Text));
                }

                Close(); // Закрываем форму после сохранения
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e) => Close();
    }
}