using System;
using System.Linq;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace KinderGarten.Views
{
    class MaterialSkinInitializer
    {
        public static void Init(MaterialForm form)
        {
            MaterialSkinManager.Instance.AddFormToManage(form);
            MaterialSkinManager.Instance.Theme = MaterialSkinManager.Themes.LIGHT;
            MaterialSkinManager.Instance.ColorScheme 
                = new ColorScheme(Primary.Indigo300, 
                    Primary.Indigo600, 
                    Primary.Indigo600, 
                    Accent.Indigo200,
                    TextShade.WHITE);
        }

        /// <summary>
        /// Оформление DataGridView, установка шрифтов, цветов и тд
        /// </summary>
        /// <param name="dataGridView"></param>
        /// <param name="designColumns"></param>
        public static void DataGridViewDesign(DataGridView dataGridView, bool designColumns = true)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.BackgroundColor
                = materialSkinManager.GetApplicationBackgroundColor();

            dataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor
                = materialSkinManager.ColorScheme.PrimaryColor;
            dataGridView.RowTemplate.DefaultCellStyle.Font
                = materialSkinManager.ROBOTO_MEDIUM_12;
            dataGridView.AllowUserToAddRows = dataGridView.AllowUserToDeleteRows
                = dataGridView.AllowUserToResizeRows = false;

            dataGridView.AutoSizeColumnsMode
                = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridView.RowHeadersVisible = false;
            dataGridView.ReadOnly = true;
            dataGridView.ColumnHeadersHeight = 30;
            dataGridView.ColumnHeadersHeightSizeMode
                = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            dataGridView.ColumnHeadersDefaultCellStyle.SelectionBackColor
                = materialSkinManager.ColorScheme.LightPrimaryColor;
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor
                = materialSkinManager.ColorScheme.PrimaryColor;

            dataGridView.BorderStyle = BorderStyle.None;

            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor =
                materialSkinManager.ACTION_BAR_TEXT;
            dataGridView.RowTemplate.Height = 30;
            if (designColumns)
            {
                dataGridView.DataBindingComplete += DataGridViewDataBindingComplete;
            }
          
        }
        /// <summary>
        /// Метод, кототрый скрывает / показывает колонки и дизайнит заголовки DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void DataGridViewDataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            if (!(sender is DataGridView dgv)) return;
            if (dgv.DataSource == null) return;
            var bingObjType = dgv.DataSource.GetType();
            if (bingObjType.IsArray)
            {
                var bindObjectType = bingObjType.GetElementType();
                foreach (DataGridViewColumn column in dgv.Columns)
                {
                    column.Visible = GetVisible(bindObjectType, column.DataPropertyName);
                    column.HeaderText = column.HeaderText.ToUpper();
                    column.HeaderCell.Style.Font = materialSkinManager.ROBOTO_MEDIUM_10;
                }

            }
            if (dgv.DataSource is BindingSource bs) 
            {
                if (bs.DataSource == null) return;
                bingObjType = bs.DataSource.GetType();
                var genericTypes = bingObjType.GenericTypeArguments;
                if (genericTypes.Length != 1) return;
                var genericType = genericTypes.First();
                foreach (DataGridViewColumn column in dgv.Columns)
                {
                    column.Visible = GetVisible(genericType, column.DataPropertyName);
                    column.HeaderText = column.HeaderText.ToUpper();
                    column.HeaderCell.Style.Font = materialSkinManager.ROBOTO_MEDIUM_12;
                }
            }
            if (!bingObjType.IsGenericType) return;
            {
                var genericTypes = bingObjType.GenericTypeArguments;
                if (genericTypes.Length != 1) return;
                var genericType = genericTypes.First();
                foreach (DataGridViewColumn column in dgv.Columns)
                {
                    column.Visible = GetVisible(genericType, column.DataPropertyName);
                    column.HeaderText = column.HeaderText.ToUpper();
                    column.HeaderCell.Style.Font = materialSkinManager.ROBOTO_MEDIUM_12;
                }
            }
            
        }
        /// <summary>
        /// Оформление ContextMenu
        /// </summary>
        /// <param name="menu"></param>
        public static void ContextMenuDesign(ContextMenuStrip menu)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            menu.BackColor = materialSkinManager.ColorScheme.AccentColor;
        }

        /// <summary>
        /// Вспомогательный метод для получения атрибута Visible который говорит показать или скрыть колонку
        /// </summary>
        /// <param name="bindingObjectType"></param>
        /// <param name="dataPropertyName"></param>
        /// <returns></returns>
        private static bool GetVisible(Type bindingObjectType, string dataPropertyName)
        {
            var props = bindingObjectType.GetProperties();
            var bindingProperty = props.FirstOrDefault(x => x.Name == dataPropertyName);
            var attributesProperty = bindingProperty?.GetCustomAttributes(false);
            if (attributesProperty?
                .FirstOrDefault(x => x.GetType().Name == nameof(VisibleAttribute)) is VisibleAttribute visibleAttribute)
                return visibleAttribute.IsVisible;
            return true;
        }
    }
}
