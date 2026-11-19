using System;
using System.Windows.Forms;
using Unity;
using WinFormsApp1.Repositories;
using System.Linq;

namespace WinFormsApp1.Forms
{
    public partial class FormSessionResults : Form
    {
        private readonly IUnityContainer _container;
        private readonly ISessionResultRepository _repository;

        public FormSessionResults(IUnityContainer container, ISessionResultRepository repository)
        {
            InitializeComponent();
            _container = container ?? throw new ArgumentNullException(nameof(container));
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        private void FormSessionResults_Load(object sender, EventArgs e) => LoadList();

        private void LoadList()
        {
            dataGridViewData.DataSource = null;
            dataGridViewData.DataSource = _repository.ReadSessionResults().ToList();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            _container.Resolve<FormSessionResult>().ShowDialog();
            LoadList();
        }
    }
}