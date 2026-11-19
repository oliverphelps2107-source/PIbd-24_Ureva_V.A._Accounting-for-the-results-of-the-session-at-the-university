using System;
using System.Linq;
using System.Windows.Forms;
using Unity;
using WinFormsApp1.Repositories;

namespace WinFormsApp1.Forms
{
    public partial class FormStudents : Form
    {
        private readonly IUnityContainer _container;
        private readonly IStudentRepository _repository;

        public FormStudents(IUnityContainer container, IStudentRepository repository)
        {
            InitializeComponent();
            _container = container ?? throw new ArgumentNullException(nameof(container));
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        private void FormStudents_Load(object sender, EventArgs e) => LoadList();

        private void LoadList()
        {
            dataGridViewData.DataSource = null;
            dataGridViewData.DataSource = _repository.ReadStudents().ToList();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            _container.Resolve<FormStudent>().ShowDialog();
            LoadList();
        }
    }
}