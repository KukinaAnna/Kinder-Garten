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
    public partial class ScheduleForm : MaterialForm
    {
        //сервис для доступа к данным в БД
        private readonly IDataService _dataService;
        //Валидатор для проверки значений в контролах
        private Validator _validator;
        private Validator _validatorSearch;
        //Флаг - идет ли редактирование
        private bool _isEdit;
        //Данные для формы
        private IEnumerable<Schedule> _data;

        //Конструктор, который принимает абстракцию сервиса к доступу к данным
        public ScheduleForm(IDataService dataService)
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
            _validator.AddValue(group_cmbx, _validator.RequiredValidation, "Группа обязательна");
            _validator.AddValue(lesson_cmbx, _validator.RequiredValidation, "Урок/Мероприятие обязательно");
            _validator.AddValue(room_cmbx, _validator.RequiredValidation, "Комната обязальна");
            _validator.AddValue(teacher_cmbx, _validator.RequiredValidation, "Педагог обязателен");
            _validator.AddValue(dob_txbx, ValidateFunc, "Дата имеет не верный формат");

            _validatorSearch = new Validator();
            _validatorSearch.AddValue(search_txbx, ValidateFunc, "");

            room_cmbx.Font = SkinManager.ROBOTO_MEDIUM_11;
            group_cmbx.Font = SkinManager.ROBOTO_MEDIUM_11;
            teacher_cmbx.Font = SkinManager.ROBOTO_MEDIUM_11;
            lesson_cmbx.Font = SkinManager.ROBOTO_MEDIUM_11;
            dob_txbx.Hint = "дд/мм/гггг чч:мм";
            dob_txbx.Format = "dd/MM/yyyy hh:mm";
            DisableControls();

            searchlesson_cmbx.Font = SkinManager.ROBOTO_MEDIUM_10;
        }

        private bool ValidateFunc(object obj)
        {
            return DateTime.TryParse(obj.ToString(), new CultureInfo("ru-ru"), DateTimeStyles.None, out _);
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
            group_cmbx.Enabled =
            room_cmbx.Enabled =
            teacher_cmbx.Enabled =
                lesson_cmbx.Enabled =
            save_btn.Enabled = dob_txbx.Enabled = true;
        }
        //выкл. контролы
        void DisableControls()
        {
            _validator.ClearValidateState();
            group_cmbx.Enabled =
                room_cmbx.Enabled =
                    teacher_cmbx.Enabled =
                        lesson_cmbx.Enabled =
                            save_btn.Enabled = dob_txbx.Enabled = false;
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
                    var lessondata = await _dataService.GetEntitiesAsync<Lesson>();
                    room_cmbx.DataSource =
                        await _dataService.GetEntitiesAsync<Room>();

                    lesson_cmbx.DataSource = lessondata.ToArray();
                    searchlesson_cmbx.DataSource = lessondata.ToArray();

                    teacher_cmbx.DataSource =
                        await _dataService.GetEntitiesAsync<Teacher>();
                    group_cmbx.DataSource =
                        await _dataService.GetEntitiesAsync<Group>();

                    _data = await _dataService.GetEntitiesAsync<Schedule>();
                    dgv.DataSource = _data;
                }
                else
                {
                    var data = DateTime.Parse(search_txbx.Text, new CultureInfo("ru-ru"));
                    _data = await _dataService.GetEntitiesAsync<Schedule>(x => x.DateTime.Date == data.Date);
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
        private void SchedulesFormLoad(object sender, EventArgs e)
        {
            LoadData(null);
        }
        //Нажатие на кнопку добавить
        private void AddBtnClick(object sender, EventArgs e)
        {
            //вкл. контролы и очищаем содержимое
            EnableControls();

            group_cmbx.SelectedItem =
                room_cmbx.SelectedItem =
                    teacher_cmbx.SelectedItem =
                        lesson_cmbx.SelectedItem = null;
            dob_txbx.Text = string.Empty;

            room_cmbx.SelectedItem = null;

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
            if (_validator.CheckAll() && room_cmbx.SelectedItem is Room room && group_cmbx.SelectedItem is Group group
            && teacher_cmbx.SelectedItem is Teacher teacher && lesson_cmbx.SelectedItem is Lesson lesson)
            {
                if (_isEdit) // если вкл. редактирование
                {
                    if (dgv.SelectedRows.Count <= 0) return;
                    if (dgv.SelectedRows[0].DataBoundItem is Schedule item) // получаем выбранные элемент
                    {
                        item.Group = null;
                        item.Room = null;
                        item.Lesson = null;
                        item.Teacher = null;

                        item.GroupId = group.GroupId;
                        item.LessonId = lesson.LessonId;
                        item.TeacherId = teacher.TeacherId;
                        item.RoomId = room.RoomId;

                        item.DateTime = DateTime.Parse(dob_txbx.Text, new CultureInfo("ru-ru"), DateTimeStyles.None);

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
                    var item = new Schedule() // создаем обьект и заполняем данными
                    {
                        GroupId = group.GroupId,
                        LessonId = lesson.LessonId,
                        TeacherId = teacher.TeacherId,
                        RoomId = room.RoomId,
                        DateTime = DateTime.Parse(dob_txbx.Text, new CultureInfo("ru-ru"), DateTimeStyles.None)
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
            if (dgv.SelectedRows[0].DataBoundItem is Schedule item)
            {
                room_cmbx.SelectedItem = item.Room;
                group_cmbx.SelectedItem = item.Group;
                teacher_cmbx.SelectedItem = item.Teacher;
                lesson_cmbx.SelectedItem = item.Lesson;

                dob_txbx.Text = item.DateTime.ToString("dd/MM/yyyy hh:mm");
            }
            DisableControls();
        }



        //удаление 
        private async void DeleteBtnClick(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count <= 0) return; //если ни одна строка не выбрана - выходим
            if (dgv.SelectedRows[0].DataBoundItem is Schedule item) //получем обьект из выбранной строки
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

        private async void resizebleMaterialRaisedButton1_Click(object sender, EventArgs e)
        {
             
            var data  = (await _dataService.GetEntitiesAsync<Schedule>()).AsEnumerable();
       

            if (searchlesson_cmbx.SelectedItem is Lesson lesson)
            {
                data = data.Where(x => x.LessonId == lesson.LessonId);
            }

            if (DateTime.TryParse(search_txbx.Text, new CultureInfo("ru-ru"), DateTimeStyles.None, out var date))
            {
                data = data.Where(x => x.DateTime.Date == date.Date);
            }

            _data = data.ToArray();
            dgv.DataSource = _data;
        }

        private void resizebleMaterialRaisedButton2_Click(object sender, EventArgs e)
        {
            var reportSource = _data.OrderBy(x => x.DateTime).ToArray();
            Visible = false;
            ReportForm rf = UnityContainerIoC.Container.Resolve<ReportForm>(new ParameterOverride(typeof(string),
                "ScheduleReport"), new ParameterOverride(typeof(object),
                reportSource));
            rf.ShowDialog();
            Visible = true;
        }
    }
}
