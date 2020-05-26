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
using Menu = KinderGarten.Data.Entities.Menu;

namespace KinderGarten.Views
{
    public partial class MenuForm : MaterialForm
    {
        //сервис для доступа к данным в БД
        private readonly IDataService _dataService;
        //Валидатор для проверки значений в контролах
        private Validator _validator;
        //Флаг - идет ли редактирование
        private bool _isEdit;
        //Данные для формы
        private IEnumerable<Menu> _data;
        private CultureInfo CultureInfo = new CultureInfo("ru-ru");

        private Validator _validatorSearching;

        //Конструктор, который принимает абстракцию сервиса к доступу к данным
        public MenuForm(IDataService dataService)
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
            _validator.AddValue(date_txbx, _validator.IsDateValidation, "Дата обязательна и должна иметь формат дд/мм/гггг");
            _validator.AddValue(mealtime_cmbx, _validator.RequiredValidation, "Необходимо указать прием пищи");
            _validator.AddValue(dish_cmbx, _validator.RequiredValidation, "Блюдо обязательно");
            _validator.AddValue(count_txbx, _validator.PositiveValidation, "Количество обязательно");
            dish_cmbx.Font =
                mealtime_cmbx.Font = SkinManager.ROBOTO_MEDIUM_11;
            searchdate_txbx.ValueChanged += Searchdate_txbx_ValueChanged;

            _validatorSearching = new Validator();
            _validatorSearching.AddValue(searchdate_txbx, _validatorSearching.IsDateValidation, "Дата обязательна");
            DisableControls();

            dgv.ColumnHeadersHeight = 40;
        }

        private void Searchdate_txbx_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.TryParse(searchdate_txbx.Text, CultureInfo, DateTimeStyles.None, out var date))
            {
                LoadData(searchdate_txbx.Text);
            }
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
            count_txbx.Enabled =
            mealtime_cmbx.Enabled =
            dish_cmbx.Enabled =
          
            save_btn.Enabled = date_txbx.Enabled = true;
        }
        //выкл. контролы
        void DisableControls()
        {
            _validator.ClearValidateState();
            count_txbx.Enabled =
            mealtime_cmbx.Enabled =
                dish_cmbx.Enabled =
                    save_btn.Enabled = date_txbx.Enabled = false;
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
                FillComboBoxes();

                if (_validatorSearching.CheckAll())
                    if (DateTime.TryParse(searchdate_txbx.Text, CultureInfo, DateTimeStyles.None, out var date))
                    {
                        _data = await _dataService.GetEntitiesAsync<Menu>(x => x.Date == date.Date);
                        dgv.DataSource = _data;
                    }
                    else dgv.DataSource = null;
                else dgv.DataSource = null;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, @"Ошибка"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
            }
        }

        private async void FillComboBoxes()
        {
            mealtime_cmbx.DataSource =
                await _dataService.GetEntitiesAsync<MealTime>();
           
            var dishes = await _dataService.GetEntitiesAsync<Dish>();
            dish_cmbx.DataSource = dishes;

            dish_cmbx.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            dish_cmbx.AutoCompleteCustomSource = new AutoCompleteStringCollection();
            foreach (var dish in dishes)
            {
                dish_cmbx.AutoCompleteCustomSource.Add(dish.Title);
            }
            dish_cmbx.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        //при загрузке формы загружаем все данные
        private void MenusFormLoad(object sender, EventArgs e)
        {
            searchdate_txbx.Text = DateTime.Now.Date.ToString("dd/MM/yyyy");
            LoadData(DateTime.Now.Date.ToString("dd/MM/yyyy"));
        }
        //Нажатие на кнопку добавить
        private void AddBtnClick(object sender, EventArgs e)
        {
            //вкл. контролы и очищаем содержимое
            EnableControls();

            date_txbx.Text = searchdate_txbx.Text;
            count_txbx.Text = string.Empty;
            mealtime_cmbx.SelectedItem = null;
            dish_cmbx.SelectedItem = null;

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
            if (_validator.CheckAll()
                && mealtime_cmbx.SelectedItem is MealTime mealTime
                && dish_cmbx.SelectedItem is Dish dish)
            {
                if (_isEdit) // если вкл. редактирование
                {
                    if (dgv.SelectedRows.Count <= 0) return;
                    if (dgv.SelectedRows[0].DataBoundItem is Menu item) // получаем выбранные элемент
                    {
                        item.Date = DateTime.Parse(date_txbx.Text, CultureInfo); // изменяем его содержимое
                        item.Count = decimal.Parse(count_txbx.Text);
                        item.MealTimeId = mealTime.MealTimeId;
                        item.DishId = dish.DishId;
                        
                        item.Dish = null;
                        item.MealTime = null;

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
                    var item = new Menu() // создаем обьект и заполняем данными
                    {
                        Date = DateTime.Parse(date_txbx.Text, CultureInfo), // изменяем его содержимое
                        Count = decimal.Parse(count_txbx.Text),
                        MealTimeId = mealTime.MealTimeId,
                        DishId = dish.DishId
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
                        LoadData(searchdate_txbx.Text);
                    }
                }
                //Если все было ок, перезагружаем данные из БД
                if (result)
                {
                    _validator.ClearValidateState();
                    LoadData(searchdate_txbx.Text);
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
            if (dgv.SelectedRows[0].DataBoundItem is Menu item)
            {
                date_txbx.Text = item.Date.ToString("dd/MM/yyyy");
                count_txbx.Text = item.Count.ToString("F2");
                mealtime_cmbx.SelectedItem = item.MealTime;
                dish_cmbx.SelectedItem = item.Dish;
            }
            DisableControls();
        }



        //удаление 
        private async void DeleteBtnClick(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count <= 0) return; //если ни одна строка не выбрана - выходим
            if (dgv.SelectedRows[0].DataBoundItem is Menu item) //получем обьект из выбранной строки
            {
                await _dataService.DeleteEntityAsync(item); // удаляем из БД
                LoadData(searchdate_txbx.Text); // загружаем актуальные данные из БД
            }
            DisableControls();
        }

        //Перезагружаем данные в БД
        private void RefreshItemClick(object sender, EventArgs e)
        {
            LoadData(searchdate_txbx.Text);
        }

        private void resizebleMaterialRaisedButton1_Click(object sender, EventArgs e)
        {
            SelectDateForm sf = new SelectDateForm();
            sf.FormClosing += Sf_FormClosing;
            sf.ShowDialog();
        }

        private async void Sf_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((!(sender is SelectDateForm selectDate))) return;
            if (_data.Any())
            {
                var data = await _dataService
                    .GetEntitiesAsync<Menu>(x => x.Date.Date == selectDate.SelectedDate.Date);
                if (data.Any())
                {
                    var res = MessageBox.Show("В меню на указанную дату уже есть позиции. " +
                                              "Хотите перезаписать? Если нажмете Нет, " +
                                              "текущее меню будет добавлено к меню на заданную дату.",
                        "Перезаписать?"
                        , MessageBoxButtons.YesNoCancel
                        , MessageBoxIcon.Question);

                    switch (res)
                    {
                        case DialogResult.Cancel:
                            return;
                        case DialogResult.Yes:
                            {
                                foreach (var item in data)
                                {
                                    await _dataService.DeleteEntityAsync(item);
                                }
                                break;
                            }
                    }
                }

                foreach (var item in _data)
                {
                    await _dataService.AddEntityAsync(new Menu()
                    {
                        Count = item.Count,
                        Date = selectDate.SelectedDate.Date,
                        DishId = item.DishId,
                        MealTimeId = item.MealTimeId
                    });
                }

                searchdate_txbx.Text = selectDate.SelectedDate.ToString("dd/MM/yyyy");
                LoadData(searchdate_txbx.Text);
            }
            else MessageBox.Show("Текущее меню не содержит позиций для копирования!",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            if (_data.Any())
            {
                var reportSource = _data.OrderBy(x => x.MealTime.Time)
                    .Select(x => new MenuReport()
                    {
                        Date = x.Date,
                        MealTime = x.MealTime + " " + x.MealTime.Time,
                        Measurement = x.Dish.Measurement.ToString(),
                        Count = x.Count,
                        EnergyCost = x.EnergyCost,
                        Dish = x.Dish.ToString()
                    }).ToArray();
                ReportForm rf = UnityContainerIoC.Container.Resolve<ReportForm>(new ParameterOverride(typeof(string),
                    "MenuReport"), new ParameterOverride(typeof(object),
                    reportSource));
                rf.ShowDialog();
            }
        }
    }
}
