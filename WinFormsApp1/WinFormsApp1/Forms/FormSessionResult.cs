using System;
using System.Windows.Forms;
using WinFormsApp1.Entities;
using WinFormsApp1.Repositories;
using System.Linq;

namespace WinFormsApp1.Forms
{
    public partial class FormSessionResult : Form
    {
        private readonly ISessionResultRepository _repository;

        public FormSessionResult(ISessionResultRepository repository, IStudentRepository studentRepository)
        {
            InitializeComponent();
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));

            comboBoxStudent.DataSource = studentRepository.ReadStudents().ToList();
            comboBoxStudent.DisplayMember = "FullName";
            comboBoxStudent.ValueMember = "Id";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxStudent.SelectedIndex < 0)
                    throw new Exception("Выберите студента!");

                var result = SessionResult.CreateOperation(
                    0,
                    (int)comboBoxStudent.SelectedValue,
                    (double)numericUpDownAverageGrade.Value,
                    numericUpDownScholarship.Value
                );

                _repository.CreateSessionResult(result);
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