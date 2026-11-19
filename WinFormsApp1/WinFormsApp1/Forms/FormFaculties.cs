using System;
using System.Linq;
using System.Windows.Forms;
using Unity;
using WinFormsApp1.Repositories; 
using System.Collections.Generic;

namespace WinFormsApp1.Forms
{
    public partial class FormFaculties : Form
    {
        // Объявляем поля класса ( хранится контейнер и репозиторий)
        private readonly IUnityContainer _container;
        private readonly IFacultyRepository _repository;

        // внедрение зависимостей
        public FormFaculties(IUnityContainer container, IFacultyRepository repository)
        {
            InitializeComponent();
            _container = container ?? throw new ArgumentNullException(nameof(container));
            //защита от нул
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        private void FormFaculties_Load(object sender, EventArgs e)
        {
            LoadList();
        }

        private void LoadList()
        {
            dataGridViewData.DataSource = null;
            //использование репозитория
            dataGridViewData.DataSource = _repository.ReadFaculties().ToList();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _container.Resolve<FormFaculty>().ShowDialog();
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
                var form = _container.Resolve<FormFaculty>();
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
                    _repository.DeleteFaculty(id);
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