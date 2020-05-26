namespace KinderGarten.Views
{
    partial class TeachersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeachersForm));
            this.search_txbx = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.refreshDataContextItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteContextItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewContextItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editContextItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorsLbl = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.fname_txbx = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lname_txbx = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.patronymic_txbx = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.scpecialization_cmbx = new System.Windows.Forms.ComboBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.save_btn = new KinderGarten.Views.ResizebleMaterialRaisedButton();
            this.edit_btn = new KinderGarten.Views.ResizebleMaterialRaisedButton();
            this.delete_btn = new KinderGarten.Views.ResizebleMaterialRaisedButton();
            this.add_btn = new KinderGarten.Views.ResizebleMaterialRaisedButton();
            this.exit_btn = new KinderGarten.Views.ResizebleMaterialRaisedButton();
            this.contextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // search_txbx
            // 
            this.search_txbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.search_txbx.Depth = 0;
            this.search_txbx.Hint = "Для поиска введите ФИО и нажмите enter";
            this.search_txbx.Location = new System.Drawing.Point(12, 68);
            this.search_txbx.MaxLength = 32767;
            this.search_txbx.MouseState = MaterialSkin.MouseState.HOVER;
            this.search_txbx.Name = "search_txbx";
            this.search_txbx.PasswordChar = '\0';
            this.search_txbx.SelectedText = "";
            this.search_txbx.SelectionLength = 0;
            this.search_txbx.SelectionStart = 0;
            this.search_txbx.Size = new System.Drawing.Size(795, 23);
            this.search_txbx.TabIndex = 42;
            this.search_txbx.TabStop = false;
            this.search_txbx.UseSystemPasswordChar = false;
            this.search_txbx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchKeyDown);
            // 
            // refreshDataContextItem
            // 
            this.refreshDataContextItem.Image = global::KinderGarten.Properties.Resources.refresh;
            this.refreshDataContextItem.Name = "refreshDataContextItem";
            this.refreshDataContextItem.Size = new System.Drawing.Size(193, 26);
            this.refreshDataContextItem.Text = "ОБНОВИТЬ ДАННЫЕ";
            this.refreshDataContextItem.Click += new System.EventHandler(this.RefreshItemClick);
            // 
            // deleteContextItem
            // 
            this.deleteContextItem.Image = global::KinderGarten.Properties.Resources.delete_alert;
            this.deleteContextItem.Name = "deleteContextItem";
            this.deleteContextItem.Size = new System.Drawing.Size(193, 26);
            this.deleteContextItem.Text = "УДАЛИТЬ";
            this.deleteContextItem.Click += new System.EventHandler(this.DeleteBtnClick);
            // 
            // addNewContextItem
            // 
            this.addNewContextItem.Image = global::KinderGarten.Properties.Resources.plus_thick;
            this.addNewContextItem.Name = "addNewContextItem";
            this.addNewContextItem.Size = new System.Drawing.Size(193, 26);
            this.addNewContextItem.Text = "ДОБАВИТЬ";
            this.addNewContextItem.Click += new System.EventHandler(this.AddBtnClick);
            // 
            // contextMenu
            // 
            this.contextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewContextItem,
            this.editContextItem,
            this.deleteContextItem,
            this.refreshDataContextItem});
            this.contextMenu.Name = "contextMenuStrip1";
            this.contextMenu.Size = new System.Drawing.Size(194, 108);
            // 
            // editContextItem
            // 
            this.editContextItem.Image = global::KinderGarten.Properties.Resources.pencil;
            this.editContextItem.Name = "editContextItem";
            this.editContextItem.Size = new System.Drawing.Size(193, 26);
            this.editContextItem.Text = "РЕДАКТИРОВАТЬ";
            this.editContextItem.Click += new System.EventHandler(this.EditBtnClick);
            // 
            // errorsLbl
            // 
            this.errorsLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.errorsLbl.BackColor = System.Drawing.Color.Transparent;
            this.errorsLbl.Depth = 0;
            this.errorsLbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.errorsLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.errorsLbl.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.errorsLbl.Location = new System.Drawing.Point(820, 299);
            this.errorsLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.errorsLbl.Name = "errorsLbl";
            this.errorsLbl.Size = new System.Drawing.Size(294, 100);
            this.errorsLbl.TabIndex = 44;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(816, 68);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(75, 19);
            this.materialLabel1.TabIndex = 45;
            this.materialLabel1.Text = "Фамилия";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fname_txbx
            // 
            this.fname_txbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fname_txbx.Depth = 0;
            this.fname_txbx.Hint = "";
            this.fname_txbx.Location = new System.Drawing.Point(816, 151);
            this.fname_txbx.MaxLength = 32767;
            this.fname_txbx.MouseState = MaterialSkin.MouseState.HOVER;
            this.fname_txbx.Name = "fname_txbx";
            this.fname_txbx.PasswordChar = '\0';
            this.fname_txbx.SelectedText = "";
            this.fname_txbx.SelectionLength = 0;
            this.fname_txbx.SelectionStart = 0;
            this.fname_txbx.Size = new System.Drawing.Size(298, 23);
            this.fname_txbx.TabIndex = 2;
            this.fname_txbx.TabStop = false;
            this.fname_txbx.UseSystemPasswordChar = false;
            // 
            // lname_txbx
            // 
            this.lname_txbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lname_txbx.Depth = 0;
            this.lname_txbx.Hint = "";
            this.lname_txbx.Location = new System.Drawing.Point(816, 97);
            this.lname_txbx.MaxLength = 32767;
            this.lname_txbx.MouseState = MaterialSkin.MouseState.HOVER;
            this.lname_txbx.Name = "lname_txbx";
            this.lname_txbx.PasswordChar = '\0';
            this.lname_txbx.SelectedText = "";
            this.lname_txbx.SelectionLength = 0;
            this.lname_txbx.SelectionStart = 0;
            this.lname_txbx.Size = new System.Drawing.Size(298, 23);
            this.lname_txbx.TabIndex = 1;
            this.lname_txbx.TabStop = false;
            this.lname_txbx.UseSystemPasswordChar = false;
            // 
            // dgv
            // 
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.ContextMenuStrip = this.contextMenu;
            this.dgv.Location = new System.Drawing.Point(12, 97);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(795, 578);
            this.dgv.TabIndex = 43;
            this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
            this.dgv.SelectionChanged += new System.EventHandler(this.DataGridSelectionChanged);
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(816, 129);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(39, 19);
            this.materialLabel2.TabIndex = 46;
            this.materialLabel2.Text = "Имя";
            this.materialLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(816, 186);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(75, 19);
            this.materialLabel3.TabIndex = 46;
            this.materialLabel3.Text = "Отчество";
            this.materialLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // patronymic_txbx
            // 
            this.patronymic_txbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.patronymic_txbx.Depth = 0;
            this.patronymic_txbx.Hint = "";
            this.patronymic_txbx.Location = new System.Drawing.Point(816, 208);
            this.patronymic_txbx.MaxLength = 32767;
            this.patronymic_txbx.MouseState = MaterialSkin.MouseState.HOVER;
            this.patronymic_txbx.Name = "patronymic_txbx";
            this.patronymic_txbx.PasswordChar = '\0';
            this.patronymic_txbx.SelectedText = "";
            this.patronymic_txbx.SelectionLength = 0;
            this.patronymic_txbx.SelectionStart = 0;
            this.patronymic_txbx.Size = new System.Drawing.Size(298, 23);
            this.patronymic_txbx.TabIndex = 3;
            this.patronymic_txbx.TabStop = false;
            this.patronymic_txbx.UseSystemPasswordChar = false;
            // 
            // scpecialization_cmbx
            // 
            this.scpecialization_cmbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.scpecialization_cmbx.BackColor = System.Drawing.SystemColors.Control;
            this.scpecialization_cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.scpecialization_cmbx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scpecialization_cmbx.FormattingEnabled = true;
            this.scpecialization_cmbx.ItemHeight = 13;
            this.scpecialization_cmbx.Location = new System.Drawing.Point(816, 265);
            this.scpecialization_cmbx.Name = "scpecialization_cmbx";
            this.scpecialization_cmbx.Size = new System.Drawing.Size(298, 21);
            this.scpecialization_cmbx.TabIndex = 4;
            // 
            // materialLabel4
            // 
            this.materialLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(816, 243);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(122, 19);
            this.materialLabel4.TabIndex = 46;
            this.materialLabel4.Text = "Специализация";
            this.materialLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // save_btn
            // 
            this.save_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.save_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.save_btn.Depth = 0;
            this.save_btn.Icon = null;
            this.save_btn.Location = new System.Drawing.Point(817, 528);
            this.save_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.save_btn.Name = "save_btn";
            this.save_btn.Primary = true;
            this.save_btn.Size = new System.Drawing.Size(298, 36);
            this.save_btn.TabIndex = 40;
            this.save_btn.Text = "Сохранить";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.SaveBtnClick);
            // 
            // edit_btn
            // 
            this.edit_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.edit_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.edit_btn.Depth = 0;
            this.edit_btn.Icon = null;
            this.edit_btn.Location = new System.Drawing.Point(818, 444);
            this.edit_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Primary = true;
            this.edit_btn.Size = new System.Drawing.Size(297, 36);
            this.edit_btn.TabIndex = 38;
            this.edit_btn.Text = "Редактировать";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.EditBtnClick);
            // 
            // delete_btn
            // 
            this.delete_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delete_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.delete_btn.Depth = 0;
            this.delete_btn.Icon = null;
            this.delete_btn.Location = new System.Drawing.Point(818, 486);
            this.delete_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Primary = true;
            this.delete_btn.Size = new System.Drawing.Size(297, 36);
            this.delete_btn.TabIndex = 39;
            this.delete_btn.Text = "Удалить";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.DeleteBtnClick);
            // 
            // add_btn
            // 
            this.add_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.add_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.add_btn.Depth = 0;
            this.add_btn.Icon = null;
            this.add_btn.Location = new System.Drawing.Point(818, 402);
            this.add_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.add_btn.Name = "add_btn";
            this.add_btn.Primary = true;
            this.add_btn.Size = new System.Drawing.Size(297, 36);
            this.add_btn.TabIndex = 37;
            this.add_btn.Text = "Добавить";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.AddBtnClick);
            // 
            // exit_btn
            // 
            this.exit_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exit_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.exit_btn.Depth = 0;
            this.exit_btn.Icon = null;
            this.exit_btn.Location = new System.Drawing.Point(817, 639);
            this.exit_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Primary = true;
            this.exit_btn.Size = new System.Drawing.Size(299, 36);
            this.exit_btn.TabIndex = 41;
            this.exit_btn.Text = "Выход";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.ExitBtnClick);
            // 
            // TeachersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 687);
            this.Controls.Add(this.scpecialization_cmbx);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.search_txbx);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.errorsLbl);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.patronymic_txbx);
            this.Controls.Add(this.fname_txbx);
            this.Controls.Add(this.lname_txbx);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.materialLabel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TeachersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Педагоги";
            this.Load += new System.EventHandler(this.TeachersFormLoad);
            this.contextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ResizebleMaterialRaisedButton save_btn;
        private ResizebleMaterialRaisedButton edit_btn;
        private MaterialSkin.Controls.MaterialSingleLineTextField search_txbx;
        private System.Windows.Forms.ToolStripMenuItem refreshDataContextItem;
        private System.Windows.Forms.ToolStripMenuItem deleteContextItem;
        private ResizebleMaterialRaisedButton delete_btn;
        private System.Windows.Forms.ToolStripMenuItem addNewContextItem;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem editContextItem;
        private ResizebleMaterialRaisedButton add_btn;
        private ResizebleMaterialRaisedButton exit_btn;
        private MaterialSkin.Controls.MaterialLabel errorsLbl;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField fname_txbx;
        private MaterialSkin.Controls.MaterialSingleLineTextField lname_txbx;
        private System.Windows.Forms.DataGridView dgv;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField patronymic_txbx;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.ComboBox scpecialization_cmbx;
    }
}