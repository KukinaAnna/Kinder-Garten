using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using KinderGarten.Data.Entities;
using KinderGarten.Data.Services;
using MaterialSkin.Controls;
using Unity;
using Unity.Resolution;

namespace KinderGarten.Views
{
    public partial class ChildForm : MaterialForm
    {
        //сервис для доступа к данным в БД
        private readonly IDataService _dataService;
        //Валидатор для проверки значений в контролах
        //Флаг - идет ли редактирование
        private bool _isEdit;
        //Данные для формы
        private IEnumerable<Children> _data;
        Validator searchValidator = new Validator();
        public ChildForm(IDataService dataService)
        {
            _dataService = dataService;
            InitializeComponent();
            //Оформление DataGridView
            //и контекстного меню под стиль Material Design
            MaterialSkinInitializer.DataGridViewDesign(dgv);
            MaterialSkinInitializer.ContextMenuDesign(contextMenu);
            //Инициализация валидатора
            new Validator();

            dgv.ColumnHeadersHeight = 45;
        }



        /// <summary>
        /// Загрузка данных в форму
        /// </summary>
        /// <param name="param"></param>
        private async void LoadData(string param)
        {
            try
            {
                //если строка поиска пустая, загружаем все
                if (string.IsNullOrWhiteSpace(param))
                {
                    _data = await _dataService.GetEntitiesAsync<Children>();
                    dgv.DataSource = _data;
                }
                else
                {
                    //иначе только то что удв. условиям
                    _data = await _dataService.GetEntitiesAsync<Children>(x => x.LastName
                                                                                    .ToLower()
                                                                                    .Trim()
                                                                                    .Contains(param.ToLower()
                                                                                        .Trim())
                                                                                || x.FirstName
                                                                                    .ToLower()
                                                                                    .Trim()
                                                                                    .Contains(param.ToLower()
                                                                                        .Trim())
                                                                               || x.Patronymic
                                                                                   .ToLower()
                                                                                   .Trim().Contains(param.ToLower()
                                                                                       .Trim()) 
                                                                                || x.DocumentOfBirth.Trim()
                                                                                    .ToLower()
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

        //при загрузке формы загружаем все данные
        private async void ChildFormLoad(object sender, EventArgs e)
        {
            group_cmbx.DataSource = await _dataService.GetEntitiesAsync<Group>();
            status_cmbx.DataSource = await _dataService.GetEntitiesAsync<Status>();

            group_cmbx.SelectedItem = status_cmbx.SelectedItem = null;

            LoadData(null);
        }
        //Нажатие на кнопку добавить
        private void AddBtnClick(object sender, EventArgs e)
        {
            Visible = false;
            var form = UnityContainerIoC.Container.Resolve<AddEditChildForm>(new ParameterOverride(typeof(Children), null));
            form.ShowDialog();
            Visible = true;

            LoadData(null);
        }
        //Кнопка редактировать
        private void EditBtnClick(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count <= 0) return;
            if (dgv.SelectedRows[0].DataBoundItem is Children item)
            {
                Visible = false;
                var form = UnityContainerIoC.Container.Resolve<AddEditChildForm>
                    (new ParameterOverride(typeof(Children), item));
                form.ShowDialog();
                Visible = true;

                LoadData(null);
            }
        }



        //закрыть форму
        private void ExitBtnClick(object sender, EventArgs e)
        {
            Close();
        }

        //удаление 
        private async void DeleteBtnClick(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count <= 0) return; //если ни одна строка не выбрана - выходим
            if (dgv.SelectedRows[0].DataBoundItem is Children item) //получем обьект из выбранной строки
            {
                await _dataService.DeleteEntityAsync(item); // удаляем из БД
                LoadData(null); // загружаем актуальные данные из БД
            }
        }

        //Перезагружаем данные в БД
        private void RefreshItemClick(object sender, EventArgs e)
        {
            LoadData(null);
        }

        private async void filter_btn_Click(object sender, EventArgs e)
        {
            searchValidator.ClearValidateState();
            searchValidator = new Validator();

            if (dob_chbx.Checked)
            {
                searchValidator.AddValue(dobStart_txbx, searchValidator.IsDateValidation, "");
                searchValidator.AddValue(dobEnd_txbx, searchValidator.IsDateValidation, "");
            }
            if (req_chbx.Checked)
            {
                searchValidator.AddValue(reqStart_txbx, searchValidator.IsDateValidation, "");
                searchValidator.AddValue(reqEnd_txbx, searchValidator.IsDateValidation, "");
            }
            if (enter_chbx.Checked)
            {
                searchValidator.AddValue(enterStart_txbx, searchValidator.IsDateValidation, "");
                searchValidator.AddValue(enterEnd_txbx, searchValidator.IsDateValidation, "");
            }
            if (group_chbx.Checked)
            {
                searchValidator.AddValue(group_cmbx, searchValidator.RequiredValidation, "");
            }
            if (status_chbx.Checked)
            {
                searchValidator.AddValue(status_cmbx, searchValidator.RequiredValidation, "");
            }

            if (searchValidator.CheckAll())
            {
                var ci = new CultureInfo("ru-ru");
                var data = (await _dataService.GetEntitiesAsync<Children>()).AsEnumerable();
                if (dob_chbx.Checked)
                {
                    data = data.Where(x => x.DateOfBirth >= DateTime.Parse(dobStart_txbx.Text, ci) &&
                                           x.DateOfBirth <= DateTime.Parse(dobEnd_txbx.Text, ci));
                }
                if (req_chbx.Checked)
                {
                    data = data.Where(x => x.DateOfRequest >= DateTime.Parse(reqStart_txbx.Text, ci) &&
                                           x.DateOfRequest <= DateTime.Parse(reqEnd_txbx.Text, ci));
                }
                if (enter_chbx.Checked)
                {
                    data = data.Where(x => x.EnteredDate >= DateTime.Parse(enterStart_txbx.Text, ci) &&
                                           x.EnteredDate <= DateTime.Parse(enterEnd_txbx.Text, ci));
                }
                if (group_chbx.Checked && group_cmbx.SelectedItem is Group group)
                {
                    data = data.Where(x => x.GroupId == group.GroupId);
                }
                if (status_chbx.Checked && status_cmbx.SelectedItem is Status status)
                {
                    data = data.Where(x => x.StatusId == status.StatusId);
                }
                _data = data.ToArray();
                dgv.DataSource = _data;
            }
        }

        private void search_txbx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadData(search_txbx.Text);
            }
        }

        private void agreement_btn_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count <= 0) return;
            if (dgv.SelectedRows[0].DataBoundItem is Children item)
            {
                var reportSource = item.Parents.Select(x=>x.Parent).ToArray();
                if (reportSource.Length==0)
                {
                    MessageBox.Show("Необходимо добавить родителей для воспитанника, составление договора возможно при наличии" +
                                    "родителей или опекунов у воспитанника.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Visible = false;
                ReportForm rf = UnityContainerIoC.Container.Resolve<ReportForm>(new ParameterOverride(typeof(string),
                    "AgreementReport"), new ParameterOverride(typeof(object),
                    reportSource));
                rf.ShowDialog();
                Visible = true;
            }
        }

        private void resizebleMaterialRaisedButton1_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count <= 0) return;
            if (dgv.SelectedRows[0].DataBoundItem is Children item)
            {
             
                Visible = false;
                ReportForm rf = UnityContainerIoC.Container.Resolve<ReportForm>(new ParameterOverride(typeof(string),
                    "EnteredReport"), new ParameterOverride(typeof(object),
                    item));
                rf.ShowDialog();
                Visible = true;
            }
        }

        private void resizebleMaterialRaisedButton2_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count <= 0) return;
            if (dgv.SelectedRows[0].DataBoundItem is Children item)
            {

                Visible = false;
                ReportForm rf = UnityContainerIoC.Container.Resolve<ReportForm>(new ParameterOverride(typeof(string),
                    "TransferReport"), new ParameterOverride(typeof(object),
                    item));
                rf.ShowDialog();
                Visible = true;
            }
        }

        private void resizebleMaterialRaisedButton3_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count <= 0) return;
            if (dgv.SelectedRows[0].DataBoundItem is Children item)
            {

                Visible = false;
                ReportForm rf = UnityContainerIoC.Container.Resolve<ReportForm>(new ParameterOverride(typeof(string),
                    "LeaveReport"), new ParameterOverride(typeof(object),
                    item));
                rf.ShowDialog();
                Visible = true;
            }
        }

        private void resizebleMaterialRaisedButton4_Click(object sender, EventArgs e)
        {
            if (_data != null && _data.Any())
            {

                ReportForm rf = UnityContainerIoC.Container.Resolve<ReportForm>(new ParameterOverride(typeof(string),
                    "ChildrenListReport"), new ParameterOverride(typeof(object), _data));
                rf.ShowDialog();
            }
        }
    }
}
