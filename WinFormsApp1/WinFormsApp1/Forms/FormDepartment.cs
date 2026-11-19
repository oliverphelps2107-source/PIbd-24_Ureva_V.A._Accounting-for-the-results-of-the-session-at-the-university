using System;
using System.Windows.Forms;
using WinFormsApp1.Entities;
using WinFormsApp1.Repositories;
using System.Collections.Generic;

namespace WinFormsApp1.Forms
{
    public partial class FormDepartment : Form
    {
        private readonly IDepartmentRepository _repository;
        private int? _departmentId;

        public FormDepartment(IDepartmentRepository repository)
        {
            InitializeComponent();
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public int Id
        {
            set
            {
                try
                {
                    var dep = _repository.ReadDepartmentById(value);
                    if (dep == null) throw new Exception("Запись не найдена");

                    textBoxName.Text = dep.Name;
                    numericUpDownFacultyId.Value = dep.FacultyId;
                    _departmentId = value;
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
                if (string.IsNullOrWhiteSpace(textBoxName.Text))
                    throw new Exception("Название не может быть пустым!");

                int facultyId = (int)numericUpDownFacultyId.Value;
                if (facultyId <= 0)
                    throw new Exception("ID факультета должен быть больше нуля!");

                if (_departmentId.HasValue)
                    _repository.UpdateDepartment(Department.CreateEntity(_departmentId.Value, textBoxName.Text, facultyId));
                else
                    _repository.CreateDepartment(Department.CreateEntity(0, textBoxName.Text, facultyId));

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