using System;
using System.Windows.Forms;

namespace KinderGarten.Views
{
    //кастомный контрол для выбора даты с претензией на дизайн
    public partial class MaterialDateTimePicker : UserControl
    {
        public MaterialDateTimePicker()
        {
            InitializeComponent();
            Format = "dd/MM/yyyy";
            datePicker.ValueChanged += DatePicker_ValueChanged;
        }

        private void DatePicker_ValueChanged(object sender, EventArgs e)
        {
            ValueChanged?.Invoke(datePicker, EventArgs.Empty);
        }

        private string hint;
        public string Hint
        {
            get => hint;
            set
            {
                hint = value;
                date_txbx.Hint = value;
            }
        }

        private string format;
        public string Format
        {
            get => format;
            set
            {
                format = value;
            }
        }

        public override string Text
        {
            get => date_txbx.Text;
            set => date_txbx.Text = value;
        }

        public event EventHandler ValueChanged;
        private void DateTimePickerValueChanged(object sender, EventArgs e)
        {
            date_txbx.Text = datePicker.Value.ToString(Format);
        }

        private void MaterialDateTimePickerBackColorChanged(object sender, EventArgs e)
        {
            date_txbx.BackColor = this.BackColor;
        }

        private void MaterialDateTimePickerEnabledChanged(object sender, EventArgs e)
        {
            date_txbx.Enabled = datePicker.Enabled = Enabled;
            date_txbx.Invalidate();
        }
    }
}
