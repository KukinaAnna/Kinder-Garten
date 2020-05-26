using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using KinderGarten.Data.Entities;
using KinderGarten.Data.Services;
using MaterialSkin.Controls;
using Unity;
using Unity.Resolution;

namespace KinderGarten.Views
{
    public partial class GroupsForm : MaterialForm
    {
        //сервис для доступа к данным в БД
        private readonly IDataService _dataService;
        //Валидатор для проверки значений в контролах
        private Validator _validator;
        //Флаг - идет ли редактирование
        private bool _isEdit;
        //Данные для формы
        private IEnumerable<Group> _data;

        //Конструктор, который принимает абстракцию сервиса к доступу к данным
        public GroupsForm(IDataService dataService)
        {
            _dataService = dataService;
            InitializeComponent();
            //Оформление DataGridView
            //и контекстного меню под стиль Material Design
            MaterialSkinInitializer.DataGridViewDesign(dgv);
            MaterialSkinInitializer.DataGridViewDesign(dataGridView1, false);
            MaterialSkinInitializer.ContextMenuDesign(contextMenu);
            //Инициализация валидатора
            _validator = new Validator();
            //Подписываемся на событие валидации
            _validator.ValidationStateChanged += ValidationStateChanged;
            //добавляем в валидатор нужные контролы
            _validator.AddValue(text_txbx, _validator.RequiredValidation, "Название обязательно");
            _validator.AddValue(year_txbx, _validator.RequiredValidation, "Год рождения обязателен");
            _validator.AddValue(year_txbx, _validator.PositiveValidation, "Год рождения должен быть положительным числом");
            DisableControls();
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
        //вкл. контролы
        void EnableControls()
        {
            year_txbx.Enabled =
            save_btn.Enabled = text_txbx.Enabled = true;
        }
        //выкл. контролы
        void DisableControls()
        {
            _validator.ClearValidateState();
            year_txbx.Enabled =
            save_btn.Enabled = text_txbx.Enabled = false;
            add_btn.Enabled = edit_btn.Enabled = true;
            _isEdit = false;
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
                    _data = await _dataService.GetEntitiesAsync<Group>();
                    dgv.DataSource = _data;
                }
                else
                {
                    //иначе только то что удв. условиям
                    _data = await _dataService.GetEntitiesAsync<Group>(x => x.Title
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

            dgv.SelectionChanged += DataGridSelectionChanged;
            DataGridSelectionChanged(dgv, EventArgs.Empty);
        }

        //при загрузке формы загружаем все данные
        private void GroupsFormLoad(object sender, EventArgs e)
        {
            LoadData(null);
        }
        //Нажатие на кнопку добавить
        private void AddBtnClick(object sender, EventArgs e)
        {
            //вкл. контролы и очищаем содержимое
            EnableControls();

            text_txbx.Text = string.Empty;
            year_txbx.Text = string.Empty;

            _isEdit = false;
            edit_btn.Enabled = false;
            text_txbx.Text = string.Empty;

        }
        //Кнопка редактировать
        private void EditBtnClick(object sender, EventArgs e)
        {
            //вкл. контролы
            EnableControls();
            _isEdit = true;
            add_btn.Enabled = false;
        }

        //Кнопка сохранить
        private async void SaveBtnClick(object sender, EventArgs e)
        {
            bool result = false; // флаг успешности операции с БД
            //Валидация, если все ок идем дальше
            if (_validator.CheckAll())
            {
                if (_isEdit) // если вкл. редактирование
                {
                    if (dgv.SelectedRows.Count <= 0) return;
                    if (dgv.SelectedRows[0].DataBoundItem is Group item) // получаем выбранные элемент
                    {
                        item.Title = text_txbx.Text; // изменяем его содержимое
                        item.Year = int.Parse(year_txbx.Text);
                        try
                        {
                            //обновление данных в БД
                            result = await _dataService.UpdateEntityAsync(item);
                        }
                        catch (Exception exception)
                        {
                            MessageBox.Show(exception.Message, @"Ошибка",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                }
                else // если идет создание нового обьекта
                {
                    var item = new Group() // создаем обьект и заполняем данными
                    {
                        Title = text_txbx.Text,
                        Year = int.Parse(year_txbx.Text)
                    };
                    try
                    {
                        DisableControls(); //выкл контролы
                        //пытаемся добавить в БД
                        result = await _dataService.AddEntityAsync(item);
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        LoadData(null);
                    }
                }
                //Если все было ок, перезагружаем данные из БД
                if (result)
                {
                    _validator.ClearValidateState();
                    LoadData(null);
                }
            }
            else
            {
                return; // если валидация провалена то выходим из метода
            }
            DisableControls();
        }

        //закрыть форму
        private void ExitBtnClick(object sender, EventArgs e)
        {
            Close();
        }

        //событие переключение строки в DataGridView
        private void DataGridSelectionChanged(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count <= 0) return;
            if (dgv.SelectedRows[0].DataBoundItem is Group item)
            {
                text_txbx.Text = item.Title; // Заполняем контролы данными из обьекта
                year_txbx.Text = item.Year.ToString();



                Task.Run(() => LoadData(item.GroupId));


            }
            DisableControls();
        }
        void LoadData(int groupId)
        {
            var data = _dataService.GetEntitiesAsync<Children>(x => x.GroupId == groupId).Result;

            SetData(data);
        }

        private void SetData(Children[] data)
        {
            Action act = () => { dataGridView1.DataSource = data; };
            Invoke(act);
        }

        // поиск 
        private void SearchKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadData(search_txbx.Text);
            }
        }

        //удаление 
        private async void DeleteBtnClick(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count <= 0) return; //если ни одна строка не выбрана - выходим
            if (dgv.SelectedRows[0].DataBoundItem is Group item) //получем обьект из выбранной строки
            {
                await _dataService.DeleteEntityAsync(item); // удаляем из БД
                LoadData(null); // загружаем актуальные данные из БД
            }
            DisableControls();
        }

        //Перезагружаем данные в БД
        private void RefreshItemClick(object sender, EventArgs e)
        {
            LoadData(null);
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dataGridView1.Columns["GroupStr"] != null)
                dataGridView1.Columns["GroupStr"].Visible = false;
            if (dataGridView1.Columns["StatusStr"] != null)
                dataGridView1.Columns["StatusStr"].Visible = false;
            if (dataGridView1.Columns["StatusId"] != null)
                dataGridView1.Columns["StatusId"].Visible = false;
            if (dataGridView1.Columns["GroupId"] != null)
                dataGridView1.Columns["GroupId"].Visible = false;
            if (dataGridView1.Columns["NationalityId"] != null)
                dataGridView1.Columns["NationalityId"].Visible = false;
            if (dataGridView1.Columns["ChildrenId"] != null)
                dataGridView1.Columns["ChildrenId"].Visible = false;
            if (dataGridView1.Columns["Nationality"] != null)
                dataGridView1.Columns["Nationality"].Visible = false;
            if (dataGridView1.Columns["DocumentOfBirth"] != null)
                dataGridView1.Columns["DocumentOfBirth"].Visible = false;
            if (dataGridView1.Columns["DateOfRequest"] != null)
                dataGridView1.Columns["DateOfRequest"].Visible = false;
            if (dataGridView1.Columns["Group"] != null)
                dataGridView1.Columns["Group"].Visible = false;
            if (dataGridView1.Columns["EnteredDate"] != null)
                dataGridView1.Columns["EnteredDate"].Visible = false;
            if (dataGridView1.Columns["GraduatedDate"] != null)
                dataGridView1.Columns["GraduatedDate"].Visible = false;
            if (dataGridView1.Columns["Referral"] != null)
                dataGridView1.Columns["Referral"].Visible = false;
            if (dataGridView1.Columns["ReferralDate"] != null)
                dataGridView1.Columns["ReferralDate"].Visible = false;
            if (dataGridView1.Columns["Parents"] != null)
                dataGridView1.Columns["Parents"].Visible = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = SkinManager.ROBOTO_MEDIUM_10;
            dataGridView1.ColumnHeadersHeight = 40;
            foreach (DataGridViewColumn c in dataGridView1.Columns)
            {
                c.HeaderText = c.HeaderText.ToUpper();
            }
        }

        private async void resizebleMaterialRaisedButton1_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count <= 0) return;
            if (dgv.SelectedRows[0].DataBoundItem is Group item)
            {
                var data = await _dataService.GetEntitiesAsync<Children>(x => x.GroupId == item.GroupId);
                Visible = false;
                ReportForm rf = UnityContainerIoC.Container.Resolve<ReportForm>(new ParameterOverride(typeof(string),
                    "ChildReport"), new ParameterOverride(typeof(object), data));
                rf.ShowDialog();
                Visible = true;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >=0 && dataGridView1.Rows[e.RowIndex].DataBoundItem is Children children)
            {
                Visible = false;
                var form = UnityContainerIoC.Container.Resolve<AddEditChildForm>
                    (new ParameterOverride(typeof(Children), children));
                form.ShowDialog();
                Visible = true;
            }
        }
    }
}
