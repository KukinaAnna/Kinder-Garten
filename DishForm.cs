using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using KinderGarten.Data.Entities;
using KinderGarten.Data.Services;
using MaterialSkin.Controls;

namespace KinderGarten.Views
{
    public partial class DishForm : MaterialForm
    {
        //сервис для доступа к данным в БД
        private readonly IDataService _dataService;
        //Валидатор для проверки значений в контролах
        private Validator _validator;
        //Флаг - идет ли редактирование
        private bool _isEdit;
        //Данные для формы
        private IEnumerable<Dish> _data;

        //Конструктор, который принимает абстракцию сервиса к доступу к данным
        public DishForm(IDataService dataService)
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
            _validator.AddValue(text_txbx, _validator.RequiredValidation, "Название обязательно");
            _validator.AddValue(ccal_txbx, _validator.MoreThanZeroValidation, "Необходимо указать кКал");
            _validator.AddValue(measurement_cmbx, _validator.RequiredValidation, "Ед. изм. обязательны");
            measurement_cmbx.Font = SkinManager.ROBOTO_MEDIUM_11;
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
                errorsLbl.Text = @"• " + string.Join($"• {Environment.NewLine}", enumerable);
            }

            else errorsLbl.Text = string.Empty;
        }
        //вкл. контролы
        void EnableControls()
        {
           ccal_txbx.Enabled = measurement_cmbx.Enabled = save_btn.Enabled = text_txbx.Enabled = true;
        }
        //выкл. контролы
        void DisableControls()
        {
            _validator.ClearValidateState();
            ccal_txbx.Enabled = measurement_cmbx.Enabled = save_btn.Enabled = text_txbx.Enabled = false;
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
                    _data = await _dataService.GetEntitiesAsync<Dish>();
                    dgv.DataSource = _data;
                }
                else
                {
                    //иначе только то что удв. условиям
                    _data = await _dataService.GetEntitiesAsync<Dish>(x => x.Title
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
        private async void DishsFormLoad(object sender, EventArgs e)
        {
            measurement_cmbx.DataSource =
                await _dataService.GetEntitiesAsync<Measurement>();

            LoadData(null);
        }
        //Нажатие на кнопку добавить
        private void AddBtnClick(object sender, EventArgs e)
        {
            //вкл. контролы и очищаем содержимое
            EnableControls();
            text_txbx.Text = string.Empty;
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
            if (_validator.CheckAll() && measurement_cmbx.SelectedItem is Measurement measurement)
            {
                if (_isEdit) // если вкл. редактирование
                {
                    if (dgv.SelectedRows.Count <= 0) return;
                    if (dgv.SelectedRows[0].DataBoundItem is Dish item) // получаем выбранные элемент
                    {
                        item.Title = text_txbx.Text; // изменяем его содержимое
                        item.MeasurementId = measurement.MeasurementId;
                        item.Ccal = decimal.Parse(ccal_txbx.Text);
                        item.Measurement = null;
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
                    var item = new Dish() // создаем обьект и заполняем данными
                    {
                        Title = text_txbx.Text,
                        MeasurementId = measurement.MeasurementId,
                        Ccal = decimal.Parse(ccal_txbx.Text)
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
            if (dgv.SelectedRows[0].DataBoundItem is Dish item)
            {
                text_txbx.Text = item.Title; // Заполняем контролы данными из обьекта
                measurement_cmbx.SelectedItem = item.Measurement;
                ccal_txbx.Text = item.Ccal.ToString();
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
            if (dgv.SelectedRows[0].DataBoundItem is Dish item) //получем обьект из выбранной строки
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
    }
}
