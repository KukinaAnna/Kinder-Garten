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
    public partial class TeachersForm : MaterialForm
    {
        //сервис для доступа к данным в БД
        private readonly IDataService _dataService;
        //Валидатор для проверки значений в контролах
        private Validator _validator;
        //Флаг - идет ли редактирование
        private bool _isEdit;
        //Данные для формы
        private IEnumerable<Teacher> _data;

        //Конструктор, который принимает абстракцию сервиса к доступу к данным
        public TeachersForm(IDataService dataService)
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
            _validator.AddValue(lname_txbx, _validator.RequiredValidation, "Фамилия обязательно");
            _validator.AddValue(fname_txbx, _validator.RequiredValidation, "Имя обязателен");
            _validator.AddValue(scpecialization_cmbx, _validator.RequiredValidation, "Специализация обязательна");

            scpecialization_cmbx.Font = SkinManager.ROBOTO_MEDIUM_11;
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
            scpecialization_cmbx.Enabled =
            fname_txbx.Enabled =
            save_btn.Enabled = lname_txbx.Enabled = true;
        }
        //выкл. контролы
        void DisableControls()
        {
            _validator.ClearValidateState();
            patronymic_txbx.Enabled =
                scpecialization_cmbx.Enabled =
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
                    scpecialization_cmbx.DataSource =
                        await _dataService.GetEntitiesAsync<Specialization>();
                    _data = await _dataService.GetEntitiesAsync<Teacher>();
                    dgv.DataSource = _data;
                }
                else
                {
                    scpecialization_cmbx.DataSource =
                        await _dataService.GetEntitiesAsync<Specialization>();
                    //иначе только то что удв. условиям
                    _data = await _dataService.GetEntitiesAsync<Teacher>(x =>
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
        private void TeachersFormLoad(object sender, EventArgs e)
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
            scpecialization_cmbx.SelectedItem = null;

            _isEdit = false;
            edit_btn.Enabled = false;
            lname_txbx.Text = string.Empty;
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
            if (_validator.CheckAll() && scpecialization_cmbx.SelectedItem is Specialization specialization)
            {
                if (_isEdit) // если вкл. редактирование
                {
                    if (dgv.SelectedRows.Count <= 0) return;
                    if (dgv.SelectedRows[0].DataBoundItem is Teacher item) // получаем выбранные элемент
                    {
                        item.LastName = lname_txbx.Text; // изменяем его содержимое
                        item.FirstName = fname_txbx.Text;
                        item.Patronymic = patronymic_txbx.Text;
                        item.SpecializationId = specialization.SpecializationId;
                        item.Specialization = null;

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
                    var item = new Teacher() // создаем обьект и заполняем данными
                    {
                        LastName = lname_txbx.Text,
                        FirstName = fname_txbx.Text,
                        Patronymic = patronymic_txbx.Text,
                        SpecializationId = specialization.SpecializationId
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
            if (dgv.SelectedRows[0].DataBoundItem is Teacher item)
            {
                lname_txbx.Text = item.LastName; // Заполняем контролы данными из обьекта
                fname_txbx.Text = item.FirstName;
                patronymic_txbx.Text = item.Patronymic;
                scpecialization_cmbx.SelectedItem = item.Specialization;
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
            if (dgv.SelectedRows[0].DataBoundItem is Teacher item) //получем обьект из выбранной строки
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
            if (dgv.SelectedRows[0].DataBoundItem is Teacher item) //получем обьект из выбранной строки
            {
                Visible = false;
                var form = UnityContainerIoC.Container.Resolve<TeachersPropertiesForm>
                    (new ParameterOverride(typeof(Teacher), item));
                form.ShowDialog();
                Visible = true;
            }
            DisableControls();
        }
    }
}
