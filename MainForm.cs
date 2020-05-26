using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using KinderGarten.Data.Entities;
using KinderGarten.Data.Services;
using MaterialSkin;
using MaterialSkin.Controls;
using Unity;
using Unity.Resolution;

namespace KinderGarten.Views
{
    public partial class MainForm : MaterialForm
    {
        private readonly IDataService _service;
        private Validator _validator;
        private VisitStatus[] statuses;

        public MainForm(IDataService service)
        {
            _service = service;
            InitializeComponent();

            _validator = new Validator();
            _validator.AddValue(dep_cmbx, _validator.NullValidator, "");
           
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            verticalMenu_panel.BackColor
                = MaterialSkinManager.Instance.ColorScheme.PrimaryColor;
            statuses = await _service.GetEntitiesAsync<VisitStatus>();
            dep_cmbx.DataSource = await _service.GetEntitiesAsync<Group>();

            menuStrip1.BackColor = SkinManager.ColorScheme.PrimaryColor;
            menuStrip1.Font = SkinManager.ROBOTO_MEDIUM_10;
            materialLabel3.ForeColor = Color.White;
        }

        private void ReferencesBtnClick(object sender, EventArgs e)
        {
            Visible = false;
            var form = UnityContainerIoC.Container.Resolve<ReferencesBookForm>();
            form.ShowDialog();
            Visible = true;
        }

        private void TeachersBtnClick(object sender, System.EventArgs e)
        {
            Visible = false;
            var form = UnityContainerIoC.Container.Resolve<TeachersForm>();
            form.ShowDialog();
            Visible = true;
        }

        private void ParentBtnClick(object sender, System.EventArgs e)
        {
            Visible = false;
            var form = UnityContainerIoC.Container.Resolve<ParentsForm>();
            form.ShowDialog();
            Visible = true;
        }

        private void ParentInfoBtnClick(object sender, EventArgs e)
        {
            Visible = false;
            var form = UnityContainerIoC.Container.Resolve<ParentsPropertiesForm>();
            form.ShowDialog();
            Visible = true;
        }

        private void TeacherPropBtnClick(object sender, EventArgs e)
        {
            Visible = false;
            var form = UnityContainerIoC.Container.Resolve<TeachersPropertiesForm>();
            form.ShowDialog();
            Visible = true;
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            Visible = false;
            var form = UnityContainerIoC.Container.Resolve<CanteenForm>();
            form.ShowDialog();
            Visible = true;
        }

        private void Children_btn_Click(object sender, EventArgs e)
        {
            Visible = false;
            var form = UnityContainerIoC.Container.Resolve<ChildForm>();
            form.ShowDialog();
            Visible = true;
        }

        private void DetailsBtnClick(object sender, EventArgs e)
        {
            Visible = false;
            var form = UnityContainerIoC.Container.Resolve<DetailsForm>();
            form.ShowDialog();
            Visible = true;
        }


        private async void LoadData()
        {
            if (_validator.CheckAll())
            {
                var gr = dep_cmbx.SelectedItem as Group;
                var start = new DateTime(date_dtpc.Value.Year, date_dtpc.Value.Month, 1);
                var end = start.AddMonths(1).Subtract(new TimeSpan(0, 0, 1));
                var countDays = Math.Round((end - start).TotalDays);
                try
                {
                    Visit[] items;

                    //Получим учеников у кого нет посещений за выбранный период
                    //получим кол-во дней 
                    var children = await _service.GetEntitiesAsync<Children>(x => x.GroupId == gr.GroupId);
                    var childVisits = children.Select(x => new
                    {
                        x.ChildrenId,
                        _service.GetEntitiesAsync<Visit>(c => c.ChildrenId == x.ChildrenId
                                                              && c.Date >= start && c.Date <= end).Result
                    }).ToArray();

                    //Получаем детей у кого кол-во посещений меньше кол-ва дней в месяце
                    var missChildren = childVisits.Where(x => x.Result.Length < countDays).ToArray();
                    if (missChildren.Length > 0)
                    {
                        MessageBox.Show("Обнаружены воспитанники у которых не сформирован журнал посещений. " +
                                        "Журнал будет создан, пожалуйста, подождите." +
                        "Это может занять до 1 минуты", "Пожалуйста подождите",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        toolStripProgressBar1.Maximum = missChildren.Length;
                        toolStripProgressBar1.Value = 0;
                    }
                    foreach (var miss in missChildren)
                    {
                        var startdate = start;
                        for (int i = 0; i < countDays; i++)
                        {
                            if (miss.Result.Any(x => x.Date.Date == startdate.AddDays(i).Date))
                            {
                                continue;
                            }
                            else
                                await _service.AddEntityAsync(new Visit()
                                {
                                    ChildrenId = miss.ChildrenId,
                                    Date = start.Date.AddDays(i),
                                    StatusId = 6
                                });
                        }

                        toolStripProgressBar1.Value++;
                    }

                    toolStripProgressBar1.Value = 0;

                    items = await _service.GetEntitiesAsync<Visit>(x => x.Children.GroupId == gr.GroupId
                                                                        && x.Date >= start && x.Date <= end);
                    if (items.Length > 0)
                    {
                        try
                        {
                            var table = await VisitJournal.GetVisitGournal(items, start);
                            visit_dgv.DataSource = table;
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show($"Ошибка при формировании таблицы посещений. " +
                                            $"На дату {start.ToString("dd/MM/yyyy")} "
                                            + e.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        var childrens = await _service.GetEntitiesAsync<Children>();

                        childrens = childrens.Where(x => x.Group != null
                                                         && x.GroupId == gr.GroupId)
                            .ToArray();
                        if (childrens.Length == 0)
                        {
                            MessageBox.Show("Нет воспитанников в выбранной группе"
                                , "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            visit_dgv.DataSource = null;
                            return;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else visit_dgv.DataSource = null;
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void visit_dgv_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            visit_dgv.EnableHeadersVisualStyles = false;
            var dtfi = new CultureInfo("ru-ru");
            foreach (DataGridViewColumn column in visit_dgv.Columns)
            {
                if (column.HeaderText != "Воспитанник")
                {
                    if (DateTime.TryParse(column.HeaderText, dtfi, DateTimeStyles.None, out var date))
                    {
                        column.HeaderText = date.Day.ToString();
                        if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                        {
                            column.HeaderCell.Style.ForeColor = Color.Crimson;
                        }
                    }

                }
                else column.Width = 150;
            }
        }

        private void ToolStripMenuItemClick(object sender, EventArgs e)
        {
            foreach (DataGridViewCell cell in visit_dgv.SelectedCells)
            {
                var s = sender.ToString();
                if (cell.Value is Visit visit)
                {
                    switch (s)
                    {
                        case "Болел":
                            {
                                var vs = statuses.FirstOrDefault(x => x.Long == "Болезнь");
                                visit.Status = vs;
                                visit.StatusId = vs.VisitStatusId;
                                break;
                            }
                        case "Отсутствует":
                            {
                                var vs = statuses.FirstOrDefault(x => x.Long == "Отсутствует");
                                visit.Status = vs;
                                visit.StatusId = vs.VisitStatusId;
                                break;
                            }
                        case "Присутствует":
                            {
                                var vs = statuses.FirstOrDefault(x => x.Long == "Присутствует");
                                visit.Status = vs;
                                visit.StatusId = vs.VisitStatusId;
                                break;
                            }
                        case "Отпросились":
                            {
                                var vs = statuses.FirstOrDefault(x => x.Long == "Отпросились");
                                visit.Status = vs;
                                visit.StatusId = vs.VisitStatusId;
                                break;
                            }
                        case "Не определено":
                            {
                                var vs = statuses.FirstOrDefault(x => x.Long == "Не определено");
                                visit.Status = vs;
                                visit.StatusId = vs.VisitStatusId;
                                break;
                            }
                        case "Выходной":
                            {
                                var vs = statuses.FirstOrDefault(x => x.Long == "Выходной");
                                visit.Status = vs;
                                visit.StatusId = vs.VisitStatusId;
                                break;
                            }
                    }
                    visit.isChanged = true;
                    cell.Selected = false;
                    cell.Selected = true;
                }
            }
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            SaveJournal(visit_dgv.DataSource as DataTable);
        }

        internal async void SaveJournal(DataTable table)
        {
            if (table != null)
            {
                List<Visit> updList = new List<Visit>();
                foreach (DataRow row in table.Rows)
                {
                    updList.AddRange(row.ItemArray.OfType<Visit>().Where(x => x.isChanged));
                }

                foreach (var visit in updList)
                {
                    visit.Children = null;
                    visit.Status = null;
                }

                if (updList.Count <= 0) return;

                toolStripProgressBar1.Maximum = updList.Count;
                toolStripProgressBar1.Value = 0;
                foreach (var visit in updList)
                {
                    await _service.UpdateEntityAsync(visit);
                    toolStripProgressBar1.Value++;
                }
                toolStripProgressBar1.Value = 0;
                MessageBox.Show("Данные сохранены!");
                LoadData();
            }
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            Visible = false;
            var form = UnityContainerIoC.Container.Resolve<ScheduleForm>();
            form.ShowDialog();
            Visible = true;
        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            RangeDatePickerForm dpf = new RangeDatePickerForm();
            dpf.FormClosing += Dpf_FormClosing;
            dpf.ShowDialog();
        }

        private async void Dpf_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sender is RangeDatePickerForm dpf && dpf.DialogResult == DialogResult.OK)
            {
                var reportSource = await _service.GetEntitiesAsync<Visit>(x => x.Date >= dpf.Start
                                                                               && x.Date <= dpf.End &&
                                                                               x.StatusId != 5);
                if (reportSource.Length == 0)
                {
                    MessageBox.Show("Не найдено данных для отображения, попробуйте изменить период выборки",
                        "Ошибка", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error);
                    return;
                }

                var gr = reportSource.GroupBy(x => new {x.Date.Date, x.Status.Long}).Select(x => new VisitReport()
                {
                    Date = x.Key.Date,
                    Title = x.Key.Long,
                    Count = x.Count()
                }).ToArray();

                Visible = false;
                ReportForm rf = UnityContainerIoC.Container.Resolve<ReportForm>(new ParameterOverride(typeof(string),
                    "VisitReport"), new ParameterOverride(typeof(object), gr));
                rf.ShowDialog();
                Visible = true;
            }
        }

        private void materialFlatButton4_Click(object sender, EventArgs e)
        {
            RangeDatePickerForm dpf = new RangeDatePickerForm();
            dpf.FormClosing += Dpf_FormClosing1;
            dpf.ShowDialog();
        }

        private async void Dpf_FormClosing1(object sender, FormClosingEventArgs e)
        {
            if (sender is RangeDatePickerForm dpf && dpf.DialogResult == DialogResult.OK)
            {
                var reportSource = await _service.GetEntitiesAsync<Children>(x => x.EnteredDate!=null 
                                                                                  && x.EnteredDate >= dpf.Start
                                                                               && x.EnteredDate <= dpf.End);
                if (reportSource.Length == 0)
                {
                    MessageBox.Show("Не найдено данных для отображения, попробуйте изменить период выборки",
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                var gr = reportSource.GroupBy(x =>  new DateTime(x.EnteredDate.Value.Year, x.EnteredDate.Value.Month, 1))
                    .Select(x => new CountReport()
                {
                    DateTime = x.Key.Date,
                    Count = x.Count()
                }).ToArray();

                Visible = false;
                ReportForm rf = UnityContainerIoC.Container.Resolve<ReportForm>(new ParameterOverride(typeof(string),
                    "EnteredGraphReport"), new ParameterOverride(typeof(object), gr));
                rf.ShowDialog();
                Visible = true;
            }
        }

        private void materialFlatButton5_Click(object sender, EventArgs e)
        {
            RangeDatePickerForm dpf = new RangeDatePickerForm();
            dpf.FormClosing += Dpf_FormClosing2; ;
            dpf.ShowDialog();
        }

        private async void Dpf_FormClosing2(object sender, FormClosingEventArgs e)
        {
            if (sender is RangeDatePickerForm dpf && dpf.DialogResult == DialogResult.OK)
            {
                var reportSource = await _service.GetEntitiesAsync<Children>(x => x.DateOfRequest >= dpf.Start
                                                                                  && x.DateOfRequest <= dpf.End);
                if (reportSource.Length == 0)
                {
                    MessageBox.Show("Не найдено данных для отображения, попробуйте изменить период выборки",
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                var gr = reportSource.GroupBy(x => new DateTime(x.EnteredDate.Value.Year, x.EnteredDate.Value.Month, 1))
                    .Select(x => new CountReport()
                    {
                        DateTime = x.Key.Date,
                        Count = x.Count()
                    }).ToArray();

                Visible = false;
                ReportForm rf = UnityContainerIoC.Container.Resolve<ReportForm>(new ParameterOverride(typeof(string),
                    "ReqGraphReport"), new ParameterOverride(typeof(object), gr));
                rf.ShowDialog();
                Visible = true;
            }
        }

        private void materialFlatButton6_Click(object sender, EventArgs e)
        {
            RangeDatePickerForm dpf = new RangeDatePickerForm();
            dpf.FormClosing += Dpf_FormClosing3; 
            dpf.ShowDialog();
        }

        private async void Dpf_FormClosing3(object sender, FormClosingEventArgs e)
        {
            if (sender is RangeDatePickerForm dpf && dpf.DialogResult == DialogResult.OK)
            {
                var reportSource = await _service.GetEntitiesAsync<Children>(x => x.EnteredDate != null
                                                                                  && x.EnteredDate >= dpf.Start
                                                                                  && x.EnteredDate <= dpf.End);
                var total = new List<CountReport>();

                var countMonth = Math.Ceiling((dpf.End - dpf.Start).TotalDays / 29);
                var start = new DateTime(dpf.Start.Year, dpf.Start.Month, 1);
                for (int i = 0; i < countMonth; i++)
                {
                    var end = start.AddMonths(i+1);

                    total.Add(new CountReport()
                    {
                        DateTime = start.AddMonths(i), 
                        Count = reportSource.Count(x => x.EnteredDate.Value <= end 
                                                        && (x.GraduatedDate == null
                                                            || x.GraduatedDate.Value >= end))
                    });
                }
                if (reportSource.Length == 0)
                {
                    MessageBox.Show("Не найдено данных для отображения, попробуйте изменить период выборки",
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                Visible = false;
                ReportForm rf = UnityContainerIoC.Container.Resolve<ReportForm>(new ParameterOverride(typeof(string),
                    "CountGraphReport"), new ParameterOverride(typeof(object), total.ToArray()));
                rf.ShowDialog();
                Visible = true;
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void комнатыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visible = false;
            var form = UnityContainerIoC.Container.Resolve<RoomsForm>();
            form.ShowDialog();
            Visible = true;
        }

        private void группыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visible = false;
            var form = UnityContainerIoC.Container.Resolve<GroupsForm>();
            form.ShowDialog();
            Visible = true;
        }

        private void специализацииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visible = false;
            var form = UnityContainerIoC.Container.Resolve<SpecializationsForm>();
            form.ShowDialog();
            Visible = true;
        }

        private void характеристикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visible = false;
            var form = UnityContainerIoC.Container.Resolve<PropertyForm>();
            form.ShowDialog();
            Visible = true;
        }

        private void занятияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visible = false;
            var form = UnityContainerIoC.Container.Resolve<LessonsForm>();
            form.ShowDialog();
            Visible = true;
        }

        private void национальностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visible = false;
            var form = UnityContainerIoC.Container.Resolve<NationalityForm>();
            form.ShowDialog();
            Visible = true;
        }

        private async void materialRaisedButton3_Click(object sender, EventArgs e)
        {
          

            if (_validator.CheckAll())
            {
                MessageBox.Show("Формирование отчета может занять некоторое время, пожалуйста, подождите", "Подождите",
                    MessageBoxButtons.OK);

                var gr = dep_cmbx.SelectedItem as Group;
                var start = new DateTime(date_dtpc.Value.Year, date_dtpc.Value.Month, 1);
                var end = start.AddMonths(1).Subtract(new TimeSpan(0, 0, 1));
                var countDays = Math.Round((end - start).TotalDays);
                try
                {
                    Visit[] items;

                    //Получим учеников у кого нет посещений за выбранный период
                    //получим кол-во дней 
                    var children = await _service.GetEntitiesAsync<Children>(x => x.GroupId == gr.GroupId);
                    var childVisits = children.Select(x => new
                    {
                        x.ChildrenId,
                        _service.GetEntitiesAsync<Visit>(c => c.ChildrenId == x.ChildrenId
                                                              && c.Date >= start && c.Date <= end).Result
                    }).ToArray();

                    //Получаем детей у кого кол-во посещений меньше кол-ва дней в месяце
                    var missChildren = childVisits.Where(x => x.Result.Length < countDays).ToArray();
                    if (missChildren.Length > 0)
                    {
                        MessageBox.Show("Обнаружены воспитанники у которых не сформирован журнал посещений. " +
                                        "Журнал будет создан, пожалуйста, подождите." +
                        "Это может занять до 1 минуты", "Пожалуйста подождите",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        toolStripProgressBar1.Maximum = missChildren.Length;
                        toolStripProgressBar1.Value = 0;
                    }
                    foreach (var miss in missChildren)
                    {
                        var startdate = start;
                        for (int i = 0; i < countDays; i++)
                        {
                            if (miss.Result.Any(x => x.Date.Date == startdate.AddDays(i).Date))
                            {
                                continue;
                            }
                            else
                                await _service.AddEntityAsync(new Visit()
                                {
                                    ChildrenId = miss.ChildrenId,
                                    Date = start.Date.AddDays(i),
                                    StatusId = 6
                                });
                        }

                        toolStripProgressBar1.Value++;
                    }

                    toolStripProgressBar1.Value = 0;

                    items = await _service.GetEntitiesAsync<Visit>(x => x.Children.GroupId == gr.GroupId
                                                                        && x.Date >= start && x.Date <= end);
                    if (items.Length > 0)
                    {
                        try
                        {
                            var table = await VisitJournal.GetVisitGournal(items, start);
                            Visible = false;
                            ReportForm rf = UnityContainerIoC.Container.Resolve<ReportForm>(new ParameterOverride(typeof(string),
                                "ScheduleTableReport"), new ParameterOverride(typeof(object), (table, gr.Title, start.ToString("MMMM yyyy"))));
                            rf.ShowDialog();
                            Visible = true;

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Ошибка при формировании таблицы посещений. " +
                                            $"На дату {start.ToString("dd/MM/yyyy")} "
                                            + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        var childrens = await _service.GetEntitiesAsync<Children>();

                        childrens = childrens.Where(x => x.Group != null
                                                         && x.GroupId == gr.GroupId)
                            .ToArray();
                        if (childrens.Length == 0)
                        {
                            MessageBox.Show("Нет воспитанников в выбранной группе"
                                , "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void посещаемостьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visible = false;
            var form = UnityContainerIoC.Container.Resolve<VisitForm>();
            form.ShowDialog();
            Visible = true;
        }

        private void педагогиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Visible = false;
            var form = UnityContainerIoC.Container.Resolve<TeachersForm>();
            form.ShowDialog();
            Visible = true;
        }

        private void инфоПедагоговToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visible = false;
            var form = UnityContainerIoC.Container.Resolve<TeachersPropertiesForm>();
            form.ShowDialog();
            Visible = true;
        }

        private void инфоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visible = false;
            var form = UnityContainerIoC.Container.Resolve<ParentsPropertiesForm>();
            form.ShowDialog();
            Visible = true;
        }

        private void родителиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Visible = false;
            var form = UnityContainerIoC.Container.Resolve<ParentsForm>();
            form.ShowDialog();
            Visible = true;
        }

        private void едИзмToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visible = false;
            var form = UnityContainerIoC.Container.Resolve<MeasurementForm>();
            form.ShowDialog();
            Visible = true;
        }

        private void блюдаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visible = false;
            var form = UnityContainerIoC.Container.Resolve<DishForm>();
            form.ShowDialog();
            Visible = true;
        }

        private void менюToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Visible = false;
            var form = UnityContainerIoC.Container.Resolve<MenuForm>();
            form.ShowDialog();
            Visible = true;
        }

        private void времяПриемаПищиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visible = false;
            var form = UnityContainerIoC.Container.Resolve<MealTimeForm>();
            form.ShowDialog();
            Visible = true;
        }

        private void воспитанникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visible = false;
            var form = UnityContainerIoC.Container.Resolve<ChildForm>();
            form.ShowDialog();
            Visible = true;
        }

        private void посещенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            materialFlatButton3_Click(null, null);
        }

        private void поступившиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            materialFlatButton4_Click(null, null);
        }

        private void заявкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            materialFlatButton5_Click(null, null);
        }

        private void воспитанникиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            materialFlatButton6_Click(null, null);
        }

        private void занятияToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Visible = false;
            var form = UnityContainerIoC.Container.Resolve<ScheduleForm>();
            form.ShowDialog();
            Visible = true;
        }

        private void реквизитыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visible = false;
            var form = UnityContainerIoC.Container.Resolve<DetailsForm>();
            form.ShowDialog();
            Visible = true;
        }
    }
}
