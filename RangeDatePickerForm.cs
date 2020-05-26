using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace KinderGarten.Views
{
    public partial class RangeDatePickerForm : MaterialForm
    {
        public DateTime Start { get; private set; }
        public DateTime End { get; private set; }

        private Validator _validator;

        public RangeDatePickerForm()
        {
            InitializeComponent();
            _validator = new Validator();
            _validator.AddValue(start_txbx, _validator.IsDateValidation, "Дата начала не задана или имеет не верный формат (дд/мм/гггг");
            _validator.AddValue(end_txbx, _validator.IsDateValidation, "Дата окончания не задана или имеет не верный формат (дд/мм/гггг");
            _validator.AddValue(start_txbx, ValidateFunc, "Дата окончания должна быть больше даты начала");
            _validator.ValidationStateChanged += _validator_ValidationStateChanged;
        }

        private void _validator_ValidationStateChanged(System.Collections.Generic.IEnumerable<string> errors)
        {
            var enumerable = errors as string[] ?? errors.ToArray();
            if (enumerable.Count() != 0)
            {
                errorsLbl.ForeColor = Color.Crimson;
                errorsLbl.Text = @" • " + string.Join($"{Environment.NewLine} • ", enumerable);
            }

            else errorsLbl.Text = string.Empty;
        }

        private bool ValidateFunc(object obj)
        {
            if (DateTime.TryParse(start_txbx.Text, new CultureInfo("ru-ru"), DateTimeStyles.None, out var start) 
            && DateTime.TryParse(end_txbx.Text, new CultureInfo("ru-ru"), DateTimeStyles.None, out var end))
            {
                return start < end;
            }

            return false;
        }

        private void exit_btn_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (_validator.CheckAll())
            {
                if (DateTime.TryParse(start_txbx.Text, new CultureInfo("ru-ru"), DateTimeStyles.None, out var start)
                    && DateTime.TryParse(end_txbx.Text, new CultureInfo("ru-ru"), DateTimeStyles.None, out var end))
                {
                    Start = start;
                    End = end;
                    DialogResult = DialogResult.OK;
                }
            }
        }
    }
}
