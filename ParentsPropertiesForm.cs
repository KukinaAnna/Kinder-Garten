using System;
using System.Linq;
using System.Windows.Forms;
using KinderGarten.Data.Entities;
using KinderGarten.Data.Services;
using MaterialSkin.Controls;

namespace KinderGarten.Views
{
    public partial class ParentsPropertiesForm : MaterialForm
    {
        private readonly IDataService _dataService;
        private readonly Parent _parent;
        private Validator _validator;
        public ParentsPropertiesForm(IDataService dataService, Parent parent)
        {
            _dataService = dataService;
            _parent = parent;
            InitializeComponent();
            MaterialSkinInitializer.DataGridViewDesign(dgv);
            MaterialSkinInitializer.DataGridViewDesign(propdgv);
            _validator = new Validator();
            _validator.AddValue(prop_cmbx, _validator.RequiredValidation, "Значение обязательно");
            _validator.AddValue(text_txbx, _validator.RequiredValidation, "Значение обязательно");

            if (_parent != null)
            {
                search_txbx.Visible = false;
            }

        }

        private void DgvSelectionChanged(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count != 0 && dgv.SelectedRows[0].DataBoundItem is Parent parent)
            {
                propdgv.DataSource = parent.Properties.ToList();
            }
            else propdgv.DataSource = null;
        }

        private void ParentsPropertiesFormLoad(object sender, EventArgs e)
        {
            LoadData(_parent?.ToString());
            prop_cmbx.Font = SkinManager.ROBOTO_MEDIUM_10;
        }

        private async void LoadData(string param)
        {
            try
            {
                //если строка поиска пустая, загружаем все
                if (string.IsNullOrWhiteSpace(param))
                {
                    prop_cmbx.DataSource = await _dataService.GetEntitiesAsync<Property>();
                    dgv.DataSource = await _dataService.GetEntitiesAsync<Parent>();
                }
                else
                {
                    prop_cmbx.DataSource = await _dataService.GetEntitiesAsync<Property>();
                    //иначе только то что удв. условиям
                    if (_parent==null)
                    {
                        dgv.DataSource = await _dataService.GetEntitiesAsync<Parent>(x =>
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
                    }
                    if (_parent != null)
                    {
                        dgv.DataSource =
                            await _dataService.GetEntitiesAsync<Parent>(x => x.ParentId == _parent.ParentId);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, @"Ошибка"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
            }
        }

        private void SearchKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadData(search_txbx.Text);
            }
        }

        private void ExitBtnClick(object sender, EventArgs e)
        {
            Close();
        }

        private async void AddBtnClick(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count != 0 && dgv.SelectedRows[0].DataBoundItem is Parent parent)
            {
                if (_validator.CheckAll() && prop_cmbx.SelectedItem is Property property)
                {
                    var item = new ParentProperty()
                    {
                        ParentId = parent.ParentId,
                        PropertyId = property.PropertyId,
                        Value = text_txbx.Text
                    };
                    if (parent.Properties.Any(x => x.PropertyId == property.PropertyId))
                    {
                        var chproperty = parent.Properties
                            .FirstOrDefault(x => x.PropertyId == property.PropertyId &&
                                                 x.ParentId == parent.ParentId);
                        if (chproperty != null)
                        {
                            chproperty.Value = text_txbx.Text;
                            chproperty.Property = null;
                            chproperty.Parent = null;
                            await _dataService.UpdateEntityAsync(chproperty);
                        }

                        parent.Properties =
                            await _dataService.GetEntitiesAsync<ParentProperty>(x => x.ParentId == parent.ParentId);
                        propdgv.DataSource = parent.Properties;
                    }
                    else
                    {
                        await _dataService.AddEntityAsync(item);
                        parent.Properties =
                            await _dataService.GetEntitiesAsync<ParentProperty>(x => x.ParentId == parent.ParentId);
                        propdgv.DataSource = parent.Properties;
                    }

                    prop_cmbx.SelectedItem = null;
                    text_txbx.Text = string.Empty;
                }
            }
            else MessageBox.Show(@"Родитель не выбран!",
                @"Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private async void DeleteToolStripMenuItemClick(object sender, EventArgs e)
        {
            if (propdgv.SelectedRows.Count != 0 
                && propdgv.SelectedRows[0].DataBoundItem is ParentProperty property)
            {
                if (dgv.SelectedRows.Count != 0 && dgv.SelectedRows[0].DataBoundItem is Parent parent)
                {
                    await _dataService.DeleteEntityAsync(property);
                    parent.Properties =
                        await _dataService.GetEntitiesAsync<ParentProperty>(x => x.ParentId == parent.ParentId);
                    propdgv.DataSource = parent.Properties;
                }
            }
        }
    }
}
