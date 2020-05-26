using System;
using System.Linq;
using System.Windows.Forms;
using KinderGarten.Data.Entities;
using KinderGarten.Data.Services;
using MaterialSkin.Controls;

namespace KinderGarten.Views
{
    public partial class DetailsForm : MaterialForm
    {
        private readonly IDataService _service;
        private Details _details;
        private Validator _validator;

        public DetailsForm(IDataService service)
        {
            _service = service;
            InitializeComponent();
            _validator = new Validator();

            _validator.AddValue(costHour_txbx, _validator.PositiveValidation, "");
            _validator.AddValue(name_txbx, _validator.RequiredValidation, "");
            _validator.AddValue(phone_txbx, _validator.PhoneValidator, "");
            _validator.AddValue(city_txbx, _validator.RequiredValidation, "");
            _validator.AddValue(address_txbx, _validator.RequiredValidation, "");
            _validator.AddValue(costMonth_txbx, _validator.PositiveValidation, "");
            _validator.AddValue(CEO_txbx, _validator.RequiredValidation, "");
        }

        private async void DetailsLoad(object sender, System.EventArgs e)
        {
            try
            {
                var details = await _service.GetEntitiesAsync<Details>();
                _details = details?.FirstOrDefault();

                if (_details == null)
                {
                    MessageBox.Show("Реквизиты не найдены"
                        , "Внимание"
                        , MessageBoxButtons.OK
                        , MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    name_txbx.Text = _details.Title;
                    costHour_txbx.Text = _details.HourPayment.ToString("F2");
                    phone_txbx.Text = _details.Phone;
                    city_txbx.Text = _details.City;
                    costMonth_txbx.Text = _details.MonthPayment.ToString("F2");
                    address_txbx.Text = _details.Address;
                    CEO_txbx.Text = _details.Director;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message
                    , "Error"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Error);
            }

        }

        private async void SaveBtnClick(object sender, EventArgs e)
        {
            if (_validator.CheckAll())
            {
                var result = false;
                try
                {
                    bool isNew = false;
                    if (_details == null)
                    {
                        _details = new Details();
                        isNew = true;
                    }

                    _details.Title = name_txbx.Text;
                    _details.HourPayment = decimal.Parse(costHour_txbx.Text);
                    _details.Phone = phone_txbx.Text;
                    _details.City = city_txbx.Text;
                    _details.MonthPayment = decimal.Parse(costMonth_txbx.Text);
                    _details.Address = address_txbx.Text;
                    _details.Director = CEO_txbx.Text;

                    if (isNew)
                    {
                        result = await _service.AddEntityAsync(_details);
                    }
                    else result = await _service.UpdateEntityAsync(_details);

                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message
                        , "Ошибка"
                        , MessageBoxButtons.OK
                        , MessageBoxIcon.Error);
                }

                if (result)
                {
                    MessageBox.Show("Операция успешна"
                        , "Успех"
                        , MessageBoxButtons.OK
                        , MessageBoxIcon.Information);
                    Close();
                }
            }


        }
        private void ExitBtnClick(object sender, EventArgs e)
        {
            Close();
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
