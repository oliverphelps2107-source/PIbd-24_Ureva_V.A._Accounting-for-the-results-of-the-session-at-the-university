using System;
using System.Linq;
using System.Windows.Forms;
using Unity;
using WinFormsApp1.Repositories;
using System.Collections.Generic;

namespace WinFormsApp1.Forms
{
    public partial class FormDisciplines : Form
    {
        private readonly IUnityContainer _container;
        private readonly IDisciplineRepository _repository;

        public FormDisciplines(IUnityContainer container, IDisciplineRepository repository)
        {
            InitializeComponent();
            _container = container ?? throw new ArgumentNullException(nameof(container));
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        private void FormDisciplines_Load(object sender, EventArgs e) => LoadList();

        private void LoadList()
        {
            dataGridViewData.DataSource = null;
            dataGridViewData.DataSource = _repository.ReadDisciplines().ToList();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            _container.Resolve<FormDiscipline>().ShowDialog();
            LoadList();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (!TryGetId(out int id)) return;
            var form = _container.Resolve<FormDiscipline>();
            form.Id = id;
            form.ShowDialog();
            LoadList();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (!TryGetId(out int id)) return;
            if (MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _repository.DeleteDiscipline(id);
                LoadList();
            }
        }

        private bool TryGetId(out int id)
        {
            id = 0;
            if (dataGridViewData.SelectedRows.Count < 1)
            {
                MessageBox.Show("Выберите строку!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            id = Convert.ToInt32(dataGridViewData.SelectedRows[0].Cells["Id"].Value);
            return true;
        }
    }
}