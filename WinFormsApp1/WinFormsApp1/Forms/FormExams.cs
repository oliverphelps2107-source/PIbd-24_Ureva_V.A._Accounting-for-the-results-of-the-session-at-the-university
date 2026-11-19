using System;
using System.Windows.Forms;
using Unity;
using WinFormsApp1.Repositories;
using System.Linq;

namespace WinFormsApp1.Forms
{
    public partial class FormExams : Form
    {
        private readonly IUnityContainer _container;
        private readonly IExamRepository _repository;

        public FormExams(IUnityContainer container, IExamRepository repository)
        {
            InitializeComponent();
            _container = container ?? throw new ArgumentNullException(nameof(container));
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        private void FormExams_Load(object sender, EventArgs e) => LoadList();

        private void LoadList()
        {
            dataGridViewData.DataSource = null;
            dataGridViewData.DataSource = _repository.ReadExams().ToList();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            _container.Resolve<FormExam>().ShowDialog();
            LoadList();
        }
    }
}