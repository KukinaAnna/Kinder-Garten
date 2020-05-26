using System;
using System.Windows.Forms;
using KinderGarten.Data.Entities;
using KinderGarten.Data.Services;
using MaterialSkin.Controls;

namespace KinderGarten.Views
{
    public partial class SelectParentForm : MaterialForm
    {
        private readonly IDataService _dataService;
        private Parent[] _data;
        public Parent SelectedParent { get; set; }
        public SelectParentForm(IDataService dataService)
        {
            _dataService = dataService;
            InitializeComponent();
            MaterialSkinInitializer.DataGridViewDesign(dgv);
        }

        private async void SelectParentFormLoad(object sender, System.EventArgs e)
        {
            LoadData(null);
        }

         private void SearchKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadData(search_txbx.Text);
            }
        }

        private async void LoadData(string param)
        {
            try
            {
                //если строка поиска пустая, загружаем все
                if (string.IsNullOrWhiteSpace(param))
                {
                    _data = await _dataService.GetEntitiesAsync<Parent>();
                    dgv.DataSource = _data;
                }
                else
                {
                    //иначе только то что удв. условиям
                    _data = await _dataService.GetEntitiesAsync<Parent>(x =>
                        (x.LastName
                             .ToLower()
                             .Trim()
                             .Contains(param.ToLower()
                                 .Trim())
                         || x.FirstName
                             .ToLower()
                             .Trim()
                             .Contains(param.ToLower()
                                 .Trim()))
                        || x.Patronymic
                            .ToLower()
                            .Trim()
                            .Contains(param.ToLower()
                                .Trim())
                        || x.PhoneNumber
                            .ToLower()
                            .Trim()
                            .Contains(param.ToLower()
                                .Trim())
                        || x.PassportNum
                            .ToLower()
                            .Trim()
                            .Contains(param.ToLower()
                                .Trim()));
                    dgv.DataSource = _data;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, @"Ошибка"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
            }
        }

        private void ExitBtnClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count!=0 
                && dgv.SelectedRows[0].DataBoundItem is Parent parent)
            {
                SelectedParent = parent;
                DialogResult = DialogResult.Yes;
            }
        }
    }
}
