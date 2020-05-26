using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using KinderGarten.Data.Entities;
using KinderGarten.Data.Services;
using MaterialSkin.Controls;
using Unity;
using Unity.Resolution;

namespace KinderGarten.Views
{
    public partial class ParentsForm : MaterialForm
    {
        //сервис для доступа к данным в БД
        private readonly IDataService _dataService;
        //Валидатор для проверки значений в контролах
        private Validator _validator;
        //Флаг - идет ли редактирование
        private bool _isEdit;
        //Данные для формы
        private IEnumerable<Parent> _data;

        //Конструктор, который принимает абстракцию сервиса к доступу к данным
        public ParentsForm(IDataService dataService)
        {
            _dataService = dataService;
            InitializeComponent();
            //Оформление DataGridView
            //и контекстного меню под стиль Material Design
            MaterialSkinInitializer.DataGridViewDesign(dgv);
            MaterialSkinInitializer.ContextMenuDesign(contextMenu);
            //Инициализация валидатора
            _validator = new Validator();
            //Подписываемся на событие валидации
            _validator.ValidationStateChanged += ValidationStateChanged;
            //добавляем в валидатор нужные контролы
            _validator.AddValue(lname_txbx, _validator.RequiredValidation, "Фамилия обязательна");
            _validator.AddValue(fname_txbx, _validator.RequiredValidation, "Имя обязателено");
            _validator.AddValue(passport_txbx, _validator.RequiredValidation, "Номер паспорта обязателен");
            _validator.AddValue(issue_txbx, _validator.RequiredValidation, "Данные паспорта обязательны");
            _validator.AddValue(phone_txbx, _validator.PhoneValidator, "Телефон обязателен и должен иметь числовой формат");
            _validator.AddValue(address_txbx, _validator.RequiredValidation, "Адрес обязателен");

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
            patronymic_txbx.Enabled =
            passport_txbx.Enabled =
                issue_txbx.Enabled =
                    phone_txbx.Enabled =
                        address_txbx.Enabled =
            fname_txbx.Enabled =
            save_btn.Enabled = lname_txbx.Enabled = true;
        }
        //выкл. контролы
        void DisableControls()
        {
            _validator.ClearValidateState();
            patronymic_txbx.Enabled =
                passport_txbx.Enabled =
                        issue_txbx.Enabled =
                            phone_txbx.Enabled =
                                address_txbx.Enabled =
                    fname_txbx.Enabled =
            save_btn.Enabled = lname_txbx.Enabled = false;
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

        //при загрузке формы загружаем все данные
        private void ParentsFormLoad(object sender, EventArgs e)
        {
            LoadData(null);
        }
        //Нажатие на кнопку добавить
        private void AddBtnClick(object sender, EventArgs e)
        {
            //вкл. контролы и очищаем содержимое
            EnableControls();

            lname_txbx.Text = string.Empty;
            fname_txbx.Text = string.Empty;
            patronymic_txbx.Text = string.Empty;
            passport_txbx.Text = string.Empty;
            issue_txbx.Text = string.Empty;
            phone_txbx.Text = string.Empty;
            address_txbx.Text = string.Empty;

            _isEdit = false;
            edit_btn.Enabled = false;
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
                    if (dgv.SelectedRows[0].DataBoundItem is Parent item) // получаем выбранные элемент
                    {
                        item.LastName = lname_txbx.Text; // изменяем его содержимое
                        item.FirstName = fname_txbx.Text;
                        item.Patronymic = patronymic_txbx.Text;
                        item.PassportIssue = issue_txbx.Text;
                        item.PassportNum = passport_txbx.Text;
                        item.Address = address_txbx.Text;
                        item.PhoneNumber = phone_txbx.Text;

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
                    var item = new Parent() // создаем обьект и заполняем данными
                    {
                        LastName = lname_txbx.Text,
                        FirstName = fname_txbx.Text,
                        Patronymic = patronymic_txbx.Text,
                        PassportIssue = issue_txbx.Text,
                        PassportNum = passport_txbx.Text,
                        Address = address_txbx.Text,
                        PhoneNumber = phone_txbx.Text
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
            if (dgv.SelectedRows[0].DataBoundItem is Parent item)
            {
                lname_txbx.Text = item.LastName; // Заполняем контролы данными из обьекта
                fname_txbx.Text = item.FirstName;
                patronymic_txbx.Text = item.Patronymic;
                issue_txbx.Text = item.PassportIssue;
                passport_txbx.Text = item.PassportNum;
                address_txbx.Text = item.Address;
                phone_txbx.Text = item.PhoneNumber;
            }
            DisableControls();
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
            if (dgv.SelectedRows[0].DataBoundItem is Parent item) //получем обьект из выбранной строки
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

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.SelectedRows.Count <= 0) return; //если ни одна строка не выбрана - выходим
            if (dgv.SelectedRows[0].DataBoundItem is Parent item) //получем обьект из выбранной строки
            {
                Visible = false;
                var form = UnityContainerIoC.Container.Resolve<ParentsPropertiesForm>
                    (new ParameterOverride(typeof(Parent), item));
                form.ShowDialog();
                Visible = true;
            }
            DisableControls();
        }
    }
}
