using System;
using Unity;
using MaterialSkin.Controls;

namespace KinderGarten.Views
{
    public partial class CanteenForm : MaterialForm
    {
        public CanteenForm()
        {
            InitializeComponent();
        }

        private void DishesBtnClick(object sender, EventArgs e)
        {
            Visible = false;
            var form = UnityContainerIoC.Container.Resolve<DishForm>();
            form.ShowDialog();
            Visible = true;
        }

        private void MeasurementBtnClick(object sender, EventArgs e)
        {
            Visible = false;
            var form = UnityContainerIoC.Container.Resolve<MeasurementForm>();
            form.ShowDialog();
            Visible = true;
        }

        private void MealTimeBtnClick(object sender, EventArgs e)
        {
            Visible = false;
            var form = UnityContainerIoC.Container.Resolve<MealTimeForm>();
            form.ShowDialog();
            Visible = true;
        }

        private void resizebleMaterialRaisedButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MenuBtnClick(object sender, EventArgs e)
        {
            Visible = false;
            var form = UnityContainerIoC.Container.Resolve<MenuForm>();
            form.ShowDialog();
            Visible = true;
        }
    }
}
