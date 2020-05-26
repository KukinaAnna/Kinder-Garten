using System;
using System.Collections.Generic;
using System.Drawing;
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
    public partial class VisitForm : MaterialForm
    {
        //сервис для доступа к данным в БД
        private readonly IDataService _dataService;
        //Валидатор для проверки значений в контролах
        private Validator _validator;
        //Флаг - идет ли редактирование
        private bool _isEdit;
        //Данные для формы
        private IEnumerable<Visit> _data;
        private CultureInfo CultureInfo = new CultureInfo("ru-ru");

        private Validator _validatorSearching;

        //Конструктор, который принимает абстракцию сервиса к доступу к данным
        public VisitForm(IDataService dataService)
        {
            _dataService = dataService;
            InitializeComponent();
            //Оформление DataGridView
            //и контекстного меню под стиль Material Design
            MaterialSkinInitializer.DataGridViewDesign(dgv, false);
            MaterialSkinInitializer.ContextMenuDesign(contextMenu);
            //Инициализация валидатора
            _validator = new Validator();
            //Подписываемся на событие валидации
            _validator.ValidationStateChanged += ValidationStateChanged;
        }


        //Обработка изменения состояния валидации
        //Выводим ошибку на экран
        private void ValidationStateChanged(IEnumerable<string> errors)
        {
            var enumerable = errors as string[] ?? errors.ToArray();
            if (enumerable.Count() != 0)
            {
                errorsLbl.ForeColor = Color.Crimson;
                errorsLbl.Text = @" • " + string.Join($"{Environment.NewLine} • ", enumerable);
            }

            else errorsLbl.Text = string.Empty;
        }
        

        private async void FillComboBoxes()
        {
            var data = await _dataService.GetEntitiesAsync<Children>();
            child_cmbx.DataSource = data;
            status_cmbx.DataSource =
                await _dataService.GetEntitiesAsync<VisitStatus>();


            child_cmbx.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            child_cmbx.AutoCompleteCustomSource = new AutoCompleteStringCollection();
            foreach (var ch in data)
            {
                child_cmbx.AutoCompleteCustomSource.Add(ch.ToString());
            }
            status_cmbx.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        //закрыть форму
        private void ExitBtnClick(object sender, EventArgs e)
        {
            Close();
        }


        private void printBtn_Click(object sender, EventArgs e)
        {
            if (_data!= null &&_data.Any())
            {
                
                ReportForm rf = UnityContainerIoC.Container.Resolve<ReportForm>(new ParameterOverride(typeof(string),
                    "VisitFilterReport"), new ParameterOverride(typeof(object), _data));
                rf.ShowDialog();
            }
        }

        private void VisitFormLoad(object sender, EventArgs e)
        {
            FillComboBoxes();
        }

        private void start_chbx_CheckedChanged(object sender, EventArgs e)
        {
            if (start_chbx.Checked)
            {
                _validator.AddValue(start_txbx, _validator.IsDateValidation, "Дата начала обязательна");
            }
            else
            {
                _validator.ClearValidateState();
                _validator.RemoveValue(start_txbx);
            }
        }

        private async void save_btn_Click(object sender, EventArgs e)
        {
            if (_validator.CheckAll())
            {
                var data = (await _dataService.GetEntitiesAsync<Visit>())
                    .AsEnumerable();

                if (start_chbx.Checked)
                {
                    data = data.Where(x => x.Date >= DateTime.Parse(start_txbx.Text, new CultureInfo("ru-ru")));
                }
                if (end_chbx.Checked)
                {
                    data = data.Where(x => x.Date <= DateTime.Parse(end_txbx.Text, new CultureInfo("ru-ru")));
                }
                if (child_chbx.Checked && child_cmbx.SelectedItem is Children child)
                {
                    data = data.Where(x => x.ChildrenId == child.ChildrenId);
                }
                if (status_chbx.Checked && status_cmbx.SelectedItem is VisitStatus status)
                {
                    data = data.Where(x => x.StatusId == status.VisitStatusId);
                }

                _data = data.OrderBy(x => x.Date).ToArray();
                dgv.DataSource = _data;
            }
        }

        private void end_chbx_CheckedChanged(object sender, EventArgs e)
        {
            if (end_chbx.Checked)
            {
                _validator.AddValue(end_txbx, _validator.IsDateValidation, "Дата окончания обязательна");
            }
            else
            {
                _validator.ClearValidateState();
                _validator.RemoveValue(end_txbx);
            }
        }

        private void child_chbx_CheckedChanged(object sender, EventArgs e)
        {
            if (child_chbx.Checked)
            {
                _validator.AddValue(child_cmbx, _validator.RequiredValidation, "Указание воспитанника обязательно");
            }
            else
            {
                _validator.ClearValidateState();
                _validator.RemoveValue(child_cmbx);
            }
        }

        private void status_chbx_CheckedChanged(object sender, EventArgs e)
        {
            if (status_chbx.Checked)
            {
                _validator.AddValue(status_cmbx, _validator.RequiredValidation, "Указание статуса обязательно");
            }
            else
            {
                _validator.ClearValidateState();
                _validator.RemoveValue(status_cmbx);
            }
        }

        private void dgv_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dgv.Columns["StatusStr"] != null)
                dgv.Columns["StatusStr"].Visible = false;
            if (dgv.Columns["ChildrenStr"] != null)
                dgv.Columns["ChildrenStr"].Visible = false;
            if (dgv.Columns["VisitId"] != null)
                dgv.Columns["VisitId"].Visible = false;
            if (dgv.Columns["StatusId"] != null)
                dgv.Columns["StatusId"].Visible = false;
            if (dgv.Columns["ChildrenId"] != null)
                dgv.Columns["ChildrenId"].Visible = false;
            if (dgv.Columns["Children"] != null)
                dgv.Columns["Children"].HeaderText = "Воспитанник";

            dgv.ColumnHeadersDefaultCellStyle.Font = SkinManager.ROBOTO_MEDIUM_10;
            dgv.ColumnHeadersHeight = 40;
            foreach (DataGridViewColumn c in dgv.Columns)
            {
                c.HeaderText = c.HeaderText.ToUpper();
            }
        }
    }
}
