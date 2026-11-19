using System;
using System.Windows.Forms;
using WinFormsApp1.Entities;
using WinFormsApp1.Repositories;
using System.Collections.Generic;

namespace WinFormsApp1.Forms
{
    public partial class FormGroup : Form
    {
        private readonly IGroupRepository _repository;
        private int? _groupId;

        public FormGroup(IGroupRepository repository)
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
                    var group = _repository.ReadGroupById(value);
                    if (group == null) throw new Exception("Запись не найдена");
                    textBoxNumber.Text = group.Number;
                    numericUpDownDepartmentId.Value = group.DepartmentId;
                    _groupId = value;
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxNumber.Text)) throw new Exception("Номер не может быть пустым!");
                int depId = (int)numericUpDownDepartmentId.Value;
                if (depId <= 0) throw new Exception("ID кафедры должен быть > 0!");

                if (_groupId.HasValue)
                    _repository.UpdateGroup(Group.CreateEntity(_groupId.Value, textBoxNumber.Text, depId));
                else
                    _repository.CreateGroup(Group.CreateEntity(0, textBoxNumber.Text, depId));
                Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void buttonCancel_Click(object sender, EventArgs e) => Close();
    }
}