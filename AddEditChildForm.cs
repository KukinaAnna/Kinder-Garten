using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using KinderGarten.Data.Entities;
using KinderGarten.Data.Services;
using MaterialSkin.Controls;
using Unity;

namespace KinderGarten.Views
{
    public partial class AddEditChildForm : MaterialForm
    {
        private readonly IDataService _dataService;
        private Children _children;
        private readonly Validator _validator;
        private readonly Validator _validatorSearch;
        private List<ParentChildren> parentData;
        private BindingSource _parendBs;
        private CultureInfo cultureInfo = new CultureInfo("ru-ru");
        public AddEditChildForm(IDataService dataService, Children children)
        {
            _dataService = dataService;
            _children = children;
            InitializeComponent();

            status_cmbx.Font = group_cmbx.Font = nationalty_cmbx.Font =
                SkinManager.ROBOTO_MEDIUM_11;

            MaterialSkinInitializer.DataGridViewDesign(parentsDgv);
            MaterialSkinInitializer.DataGridViewDesign(propertiesDgv);
            MaterialSkinInitializer.DataGridViewDesign(visitsDgv);
            _validator = new Validator();
            _validator.AddValue(fname_txbx, _validator.RequiredValidation, "Имя обязательно");
            _validator.AddValue(dob_txbx, _validator.IsDateValidation, "Дата рождения обязательна");
            _validator.AddValue(lname_txbx, _validator.RequiredValidation, "Фамилия обязательно");
            _validator.AddValue(nationalty_cmbx, _validator.RequiredValidation, "Национальность обязательна");
            _validator.AddValue(documentOfBirth_txbx, _validator.RequiredValidation, "Свидетельство о рождении обязательно");
            _validator.AddValue(dateOfRequest_txbx, _validator.RequiredValidation, "Дата заявки обязательна");
            _validator.AddValue(status_cmbx, _validator.RequiredValidation, "Статус обязателен");
            _validator.AddValue(enteredDate_txbx, ValidationDate, "Дата имеет не верный формат");
            _validator.AddValue(graduatedDate_txbx, ValidationDate, "Дата имеет не верный формат");

            _validatorSearch = new Validator();
            _validatorSearch.AddValue(search_txbx, ValidateSearch, "Формат даты для поиска не верный");
        }

        private bool ValidateSearch(object obj)
        {
            return DateTime.TryParseExact(search_txbx.Text,
                "MM/yyyy", 
                cultureInfo, 
                DateTimeStyles.None,
                out _);
        }

        private bool ValidationDate(object obj)
        {

            if (!string.IsNullOrWhiteSpace(obj.ToString()))
            {
                return DateTime.TryParse(obj.ToString(), cultureInfo
                    , DateTimeStyles.None
                    , out _);
            }
            else return true;

        }

        private async void AddEditChildFormLoad(object sender, EventArgs e)
        {
            search_txbx.Text = DateTime.Now.ToString("MM/yyyy");
            var firstdate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            var lasedate = firstdate.AddMonths(1).Subtract(new TimeSpan(0, 0, 1));

            visitsDgv.DataSource = await _dataService.GetEntitiesAsync<Visit>
                (x=>x.ChildrenId == _children.ChildrenId && (x.Date<= lasedate && x.Date>= firstdate));

            group_cmbx.DataSource = await _dataService.GetEntitiesAsync<Group>();
            nationalty_cmbx.DataSource = await _dataService.GetEntitiesAsync<Nationality>();
            status_cmbx.DataSource = await _dataService.GetEntitiesAsync<Status>();

            if (_children == null)
            {
                group_cmbx.SelectedItem =
                    nationalty_cmbx.SelectedItem =
                        status_cmbx.SelectedItem = null;

                parentData = new List<ParentChildren>();
                _parendBs = new BindingSource();
                _parendBs.DataSource = parentData;
                parentsDgv.DataSource = _parendBs;
                _children = new Children();

                show_btn.Visible = false;
                search_txbx.Visible = false;
                search_lbl.Visible = false;
            }
            else
            {
                group_cmbx.SelectedItem = _children.Group;
                nationalty_cmbx.SelectedItem = _children.Nationality;
                status_cmbx.SelectedItem = _children.Status;

                fname_txbx.Text = _children.FirstName;
                lname_txbx.Text = _children.LastName;
                mname_txbx.Text = _children.Patronymic;
                dob_txbx.Text = _children.DateOfBirth.ToString("dd/MM/yyyy");
                dateOfRequest_txbx.Text = _children.DateOfRequest.ToString("dd/MM/yyyy");
                documentOfBirth_txbx.Text = _children.DocumentOfBirth;
                referral_txbx.Text = _children.Referral;

                enteredDate_txbx.Text = _children.EnteredDate?.ToString("dd/MM/yyyy");
                graduatedDate_txbx.Text = _children.GraduatedDate?.ToString("dd/MM/yyyy");
                referralDate_txbx.Text = _children.ReferralDate?.ToString("dd/MM/yyyy");

                parentsDgv.DataSource = _children.Parents.ToArray();
            }
        }

        private void ExitBtnClick(object sender, EventArgs e)
        {
            Close();
        }

        private async void SaveBtnClick(object sender, EventArgs e)
        {
            if (_validator.CheckAll()
                && nationalty_cmbx.SelectedItem is Nationality nationality
                && status_cmbx.SelectedItem is Status status)
            {
                if (_children.ChildrenId == default) // новый детенок
                {
                    var child = new Children()
                    {
                        FirstName = fname_txbx.Text,
                        LastName = lname_txbx.Text,
                        Patronymic = mname_txbx.Text,
                        DateOfBirth = DateTime.Parse(dob_txbx.Text, cultureInfo),
                        DateOfRequest = DateTime.Parse(dateOfRequest_txbx.Text, cultureInfo),
                        DocumentOfBirth = documentOfBirth_txbx.Text,
                        GroupId = (group_cmbx.SelectedItem as Group)?.GroupId,
                        NationalityId = nationality.NationalityId,
                        Referral = referral_txbx.Text,
                        StatusId = status.StatusId
                    };
                    if (enteredDate_txbx.Text.Length > 0)
                        child.EnteredDate = DateTime.Parse(enteredDate_txbx.Text, cultureInfo);
                    if (graduatedDate_txbx.Text.Length > 0)
                        child.GraduatedDate = DateTime.Parse(graduatedDate_txbx.Text, cultureInfo);
                    if (referralDate_txbx.Text.Length > 0)
                        child.ReferralDate = DateTime.Parse(referralDate_txbx.Text, cultureInfo);

                    child.Parents = parentData.Select(x => new ParentChildren()
                    {
                        ParentId = x.Parent.ParentId
                    }).ToList();
                    await _dataService.AddEntityAsync(child);
                    MessageBox.Show(@"Воспитанник добавлен в базу данных",
                        @"Успех",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                    Close();
                }
                else
                {
                    _children.Nationality = null;
                    _children.Group = null;
                    _children.Status = null;
                    _children.Parents = null;

                    _children.FirstName = fname_txbx.Text;
                    _children.LastName = lname_txbx.Text;
                    _children.Patronymic = mname_txbx.Text;
                    _children.DateOfBirth = DateTime.Parse(dob_txbx.Text, cultureInfo);
                    _children.DateOfRequest = DateTime.Parse(dateOfRequest_txbx.Text, cultureInfo);
                    _children.DocumentOfBirth = documentOfBirth_txbx.Text;
                    _children.GroupId = (group_cmbx.SelectedItem as Group)?.GroupId;
                    _children.NationalityId = nationality.NationalityId;
                    _children.Referral = referral_txbx.Text;
                    _children.StatusId = status.StatusId;

                    if (enteredDate_txbx.Text.Length > 0)
                        _children.EnteredDate = DateTime.Parse(enteredDate_txbx.Text, cultureInfo);
                    if (graduatedDate_txbx.Text.Length > 0)
                        _children.GraduatedDate = DateTime.Parse(graduatedDate_txbx.Text, cultureInfo);
                    if (referralDate_txbx.Text.Length > 0)
                        _children.ReferralDate = DateTime.Parse(referralDate_txbx.Text, cultureInfo);

                    await _dataService.UpdateEntityAsync(_children);
                    MessageBox.Show(@"Данные воспитанника обновлены",
                        @"Успех",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                    Close();
                }
            }
        }

        private void AddNewContextItemClick(object sender, EventArgs e)
        {
            var f = UnityContainerIoC.Container.Resolve<SelectParentForm>();
            f.FormClosing += FFormClosing;
            f.ShowDialog();
        }

        private async void FFormClosing(object sender, FormClosingEventArgs e)
        {
            if (!(sender is SelectParentForm parentForm))
                return;

            if (_children.ChildrenId == default)
            {
                if (parentData.Any(x => x.Parent?.ParentId == parentForm.SelectedParent.ParentId))
                    return;

                _parendBs.DataSource = null;
                parentData.Add(new ParentChildren()
                {
                    Parent = parentForm.SelectedParent
                });
                _parendBs.DataSource = parentData;

            }
            else
            {
                if (_children.Parents.Any(x => x.Parent?.ParentId == parentForm.SelectedParent.ParentId))
                    return;

                await _dataService.AddEntityAsync(new ParentChildren()
                {
                    ChildId = _children.ChildrenId,
                    ParentId = parentForm.SelectedParent.ParentId
                });
                var ch = await _dataService.GetEntitiesAsync<Children>(
                    x => x.ChildrenId == _children.ChildrenId);
                _children.Parents = ch.FirstOrDefault()?.Parents;
                parentsDgv.DataSource = null;
                parentsDgv.DataSource = _children?.Parents?.ToArray();

            }
        }

        private async void ParentsDgvSelectionChanged(object sender, EventArgs e)
        {
            if (parentsDgv.SelectedRows.Count != 0
                && parentsDgv.SelectedRows[0].DataBoundItem is ParentChildren parent)
            {
                if (parent.Parent != null)
                {
                    propertiesDgv.DataSource =
                        await _dataService.GetEntitiesAsync<ParentProperty>
                            (x => x.ParentId == parent.Parent.ParentId);
                }

            }
            else propertiesDgv.DataSource = null;
        }

        private async void DeleteContextItemClick(object sender, EventArgs e)
        {
            if (parentsDgv.SelectedRows.Count != 0
                && parentsDgv.SelectedRows[0].DataBoundItem is ParentChildren parent)
            {
                if (_children.ChildrenId != default)
                {
                    await _dataService.DeleteEntityAsync(parent);
                    var ch = await _dataService.GetEntitiesAsync<Children>(
                        x => x.ChildrenId == _children.ChildrenId);
                    _children.Parents = ch.FirstOrDefault()?.Parents;
                    parentsDgv.DataSource = null;
                    parentsDgv.DataSource = _children?.Parents?.ToArray();
                }
            }
        }

        private async void show_btn_Click(object sender, EventArgs e)
        {
            if (_validatorSearch.CheckAll() 
                && DateTime.TryParseExact(search_txbx.Text, "MM/yyyy", cultureInfo, DateTimeStyles.None,
                out var firstdate))
            {
              var second = firstdate.AddMonths(1).Subtract(new TimeSpan(0, 0, 1));
              var data = await _dataService.GetEntitiesAsync<Visit>(x =>
                  x.ChildrenId == _children.ChildrenId &&
                  x.Date >= firstdate && x.Date <= second);
              visitsDgv.DataSource = data.OrderBy(x => x.Date).ToArray();
              
            }
        }

        private void visitsDgv_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (visitsDgv.Columns["Date"]!=null)
            {
                visitsDgv.Columns["Date"].DefaultCellStyle.Format = "dd/MMMM/yyyy";
            }
        }
    }
}
