using System;
using System.Linq;
using System.Windows.Forms;
using KinderGarten.Data.Entities;
using KinderGarten.Data.Services;
using MaterialSkin.Controls;

namespace KinderGarten.Views
{
    public partial class TeachersPropertiesForm : MaterialForm
    {
        private readonly IDataService _dataService;
        private readonly Teacher _teacher;
        private Validator _validator;
        public TeachersPropertiesForm(IDataService dataService, Teacher teacher = null)
        {
            _dataService = dataService;
            _teacher = teacher;
            InitializeComponent();
            MaterialSkinInitializer.DataGridViewDesign(dgv);
            MaterialSkinInitializer.DataGridViewDesign(propdgv);
            _validator = new Validator(); 
            _validator.AddValue(prop_cmbx, _validator.RequiredValidation, "Значение обязательно");
            _validator.AddValue(text_txbx, _validator.RequiredValidation, "Значение обязательно");

            if (_teacher !=null)
            {
                search_txbx.Visible = false;
            }
        }

        private void DgvSelectionChanged(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count != 0 && dgv.SelectedRows[0].DataBoundItem is Teacher Teacher)
            {
                propdgv.DataSource = Teacher.Properties.ToList();
            }
            else propdgv.DataSource = null;
        }

        private void TeachersPropertiesFormLoad(object sender, EventArgs e)
        {
            LoadData(_teacher?.ToString());
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
                    dgv.DataSource = await _dataService.GetEntitiesAsync<Teacher>();
                }
                else
                {
                    prop_cmbx.DataSource = await _dataService.GetEntitiesAsync<Property>();
                    if (_teacher == null)
                    {
                        //иначе только то что удв. условиям
                        dgv.DataSource = await _dataService.GetEntitiesAsync<Teacher>(x =>
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
                                    .Trim()));
                    }

                    if (_teacher != null)
                    {
                        dgv.DataSource =
                            await _dataService.GetEntitiesAsync<Teacher>(x => x.TeacherId == _teacher.TeacherId);
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
            if (dgv.SelectedRows.Count != 0 && dgv.SelectedRows[0].DataBoundItem is Teacher teacher)
            {
                if (_validator.CheckAll() && prop_cmbx.SelectedItem is Property property)
                {
                    var item = new TeacherProperty()
                    {
                        TeacherId = teacher.TeacherId,
                        PropertyId = property.PropertyId,
                        Value = text_txbx.Text
                    };
                    if (teacher.Properties.Any(x => x.PropertyId == property.PropertyId))
                    {
                        var chproperty = teacher.Properties
                            .FirstOrDefault(x => x.PropertyId == property.PropertyId &&
                                                 x.TeacherId == teacher.TeacherId);
                        if (chproperty != null)
                        {
                            chproperty.Value = text_txbx.Text;
                            chproperty.Property = null;
                            chproperty.Teacher = null;
                            await _dataService.UpdateEntityAsync(chproperty);
                        }

                        teacher.Properties =
                            await _dataService.GetEntitiesAsync<TeacherProperty>(x => x.TeacherId == teacher.TeacherId);
                        propdgv.DataSource = teacher.Properties;
                    }
                    else
                    {
                        await _dataService.AddEntityAsync(item);
                        teacher.Properties =
                            await _dataService.GetEntitiesAsync<TeacherProperty>(x => x.TeacherId == teacher.TeacherId);
                        propdgv.DataSource = teacher.Properties;
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
                && propdgv.SelectedRows[0].DataBoundItem is TeacherProperty property)
            {
                if (dgv.SelectedRows.Count != 0 && dgv.SelectedRows[0].DataBoundItem is Teacher Teacher)
                {
                    await _dataService.DeleteEntityAsync(property);
                    Teacher.Properties =
                        await _dataService.GetEntitiesAsync<TeacherProperty>(x => x.TeacherId == Teacher.TeacherId);
                    propdgv.DataSource = Teacher.Properties;
                }
            }
        }

        private void search_txbx_Click(object sender, EventArgs e)
        {

        }
    }
}
