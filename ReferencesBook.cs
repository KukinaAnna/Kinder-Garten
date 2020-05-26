using MaterialSkin.Controls;
using Unity;

namespace KinderGarten.Views
{
    public partial class ReferencesBookForm : MaterialForm
    {
        public ReferencesBookForm()
        {
            InitializeComponent();
        }

        private void RoomsBtnClick(object sender, System.EventArgs e)
        {
            Visible = false;
            var form = UnityContainerIoC.Container.Resolve<RoomsForm>();
            form.ShowDialog();
            Visible = true;
        }

        private void GroupsBtnClick(object sender, System.EventArgs e)
        {
            Visible = false;
            var form = UnityContainerIoC.Container.Resolve<GroupsForm>();
            form.ShowDialog();
            Visible = true;
        }

        private void SpecializationBtnClick(object sender, System.EventArgs e)
        {
            Visible = false;
            var form = UnityContainerIoC.Container.Resolve<SpecializationsForm>();
            form.ShowDialog();
            Visible = true;
        }

        private void PropertyBtnClick(object sender, System.EventArgs e)
        {
            Visible = false;
            var form = UnityContainerIoC.Container.Resolve<PropertyForm>();
            form.ShowDialog();
            Visible = true;
        }

        private void LessonsBtnClick(object sender, System.EventArgs e)
        {
            Visible = false;
            var form = UnityContainerIoC.Container.Resolve<LessonsForm>();
            form.ShowDialog();
            Visible = true;
        }

        private void NationalityBtnClick(object sender, System.EventArgs e)
        {
            Visible = false;
            var form = UnityContainerIoC.Container.Resolve<NationalityForm>();
            form.ShowDialog();
            Visible = true;
        }

        private void exitBtn_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
