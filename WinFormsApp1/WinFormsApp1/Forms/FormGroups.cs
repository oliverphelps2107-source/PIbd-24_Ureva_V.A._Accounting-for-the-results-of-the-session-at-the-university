using System;
using System.Linq;
using System.Windows.Forms;
using Unity;
using WinFormsApp1.Repositories;
using System.Collections.Generic;

namespace WinFormsApp1.Forms
{
    public partial class FormGroups : Form
    {
        private readonly IUnityContainer _container;
        private readonly IGroupRepository _repository; // <-- Исправлено на IGroupRepository

        public FormGroups(IUnityContainer container, IGroupRepository repository) // <-- Исправлено
        {
            InitializeComponent();
            _container = container ?? throw new ArgumentNullException(nameof(container));
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        // Переименовал метод, чтобы было логично. Не забудь привязать его к событию Load в дизайнере!
        private void FormGroups_Load(object sender, EventArgs e)
        {
            LoadList();
        }

        private void LoadList()
        {
            dataGridViewData.DataSource = null;
            dataGridViewData.DataSource = _repository.ReadGroups().ToList(); // <-- Теперь работает
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _container.Resolve<FormGroup>().ShowDialog(); // <-- Исправлено на FormGroup
                LoadList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при добавлении", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (!TryGetId(out int id)) return;

            try
            {
                var form = _container.Resolve<FormGroup>(); // <-- Исправлено на FormGroup
                form.Id = id;
                form.ShowDialog();
                LoadList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при изменении", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (!TryGetId(out int id)) return;

            if (MessageBox.Show("Вы уверены, что хотите удалить запись?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    _repository.DeleteGroup(id); // <-- Исправлено на DeleteGroup
                    LoadList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка при удалении", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool TryGetId(out int id)
        {
            id = 0;
            if (dataGridViewData.SelectedRows.Count < 1)
            {
                MessageBox.Show("Сначала выберите строку в таблице.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            id = Convert.ToInt32(dataGridViewData.SelectedRows[0].Cells["Id"].Value);
            return true;
        }
    }
}