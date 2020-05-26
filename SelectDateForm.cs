using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace KinderGarten.Views
{
    public partial class SelectDateForm : MaterialForm
    {
        public SelectDateForm()
        {
            InitializeComponent();
        }
        public DateTime SelectedDate { get; private set; }
        private void resizebleMaterialRaisedButton1_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void add_btn_Click(object sender, System.EventArgs e)
        {
            if (DateTime.TryParse(date_txbx.Text, new CultureInfo("ru-ru"),
                DateTimeStyles.None,
                out var date))
            {
                SelectedDate = date;
                DialogResult = DialogResult.Yes;
            }
            else date_txbx.BackColor = Color.Salmon;
        }

        private void date_txbx_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.TryParse(date_txbx.Text, new CultureInfo("ru-ru"), 
                DateTimeStyles.None, 
                out var  date))
            {
                SelectedDate = date;
            }
        }
    }
}
