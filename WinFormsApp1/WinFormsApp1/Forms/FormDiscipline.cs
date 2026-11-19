using System;
using System.Windows.Forms;
using WinFormsApp1.Entities;
using WinFormsApp1.Repositories;
using System.Collections.Generic;

namespace WinFormsApp1.Forms
{
    public partial class FormDiscipline : Form
    {
        private readonly IDisciplineRepository _repository;
        private int? _disciplineId;

        public FormDiscipline(IDisciplineRepository repository)
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
                    var disc = _repository.ReadDisciplineById(value);
                    if (disc == null) throw new Exception("Запись не найдена");
                    textBoxName.Text = disc.Name;
                    textBoxTeacher.Text = disc.Teacher;
                    _disciplineId = value;
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxName.Text) || string.IsNullOrWhiteSpace(textBoxTeacher.Text))
                    throw new Exception("Заполните все поля!");

                if (_disciplineId.HasValue)
                    _repository.UpdateDiscipline(Discipline.CreateEntity(_disciplineId.Value, textBoxName.Text, textBoxTeacher.Text));
                else
                    _repository.CreateDiscipline(Discipline.CreateEntity(0, textBoxName.Text, textBoxTeacher.Text));
                Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void buttonCancel_Click(object sender, EventArgs e) => Close();
    }
}