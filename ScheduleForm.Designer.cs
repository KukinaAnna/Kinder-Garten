namespace KinderGarten.Views
{
    partial class ScheduleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScheduleForm));
            this.room_cmbx = new System.Windows.Forms.ComboBox();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewContextItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editContextItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteContextItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshDataContextItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.errorsLbl = new MaterialSkin.Controls.MaterialLabel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lesson_cmbx = new System.Windows.Forms.ComboBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.teacher_cmbx = new System.Windows.Forms.ComboBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.group_cmbx = new System.Windows.Forms.ComboBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.search_txbx = new KinderGarten.Views.MaterialDateTimePicker();
            this.dob_txbx = new KinderGarten.Views.MaterialDateTimePicker();
            this.resizebleMaterialRaisedButton2 = new KinderGarten.Views.ResizebleMaterialRaisedButton();
            this.save_btn = new KinderGarten.Views.ResizebleMaterialRaisedButton();
            this.edit_btn = new KinderGarten.Views.ResizebleMaterialRaisedButton();
            this.delete_btn = new KinderGarten.Views.ResizebleMaterialRaisedButton();
            this.resizebleMaterialRaisedButton1 = new KinderGarten.Views.ResizebleMaterialRaisedButton();
            this.add_btn = new KinderGarten.Views.ResizebleMaterialRaisedButton();
            this.exit_btn = new KinderGarten.Views.ResizebleMaterialRaisedButton();
            this.searchlesson_cmbx = new System.Windows.Forms.ComboBox();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.contextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // room_cmbx
            // 
            this.room_cmbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.room_cmbx.BackColor = System.Drawing.SystemColors.Control;
            this.room_cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.room_cmbx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.room_cmbx.FormattingEnabled = true;
            this.room_cmbx.ItemHeight = 13;
            this.room_cmbx.Location = new System.Drawing.Point(817, 275);
            this.room_cmbx.Name = "room_cmbx";
            this.room_cmbx.Size = new System.Drawing.Size(298, 21);
            this.room_cmbx.TabIndex = 50;
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
            // addNewContextItem
            // 
            this.addNewContextItem.Image = global::KinderGarten.Properties.Resources.plus_thick;
            this.addNewContextItem.Name = "addNewContextItem";
            this.addNewContextItem.Size = new System.Drawing.Size(193, 26);
            this.addNewContextItem.Text = "ДОБАВИТЬ";
            this.addNewContextItem.Click += new System.EventHandler(this.AddBtnClick);
            // 
            // editContextItem
            // 
            this.editContextItem.Image = global::KinderGarten.Properties.Resources.pencil;
            this.editContextItem.Name = "editContextItem";
            this.editContextItem.Size = new System.Drawing.Size(193, 26);
            this.editContextItem.Text = "РЕДАКТИРОВАТЬ";
            this.editContextItem.Click += new System.EventHandler(this.EditBtnClick);
            // 
            // deleteContextItem
            // 
            this.deleteContextItem.Image = global::KinderGarten.Properties.Resources.delete_alert;
            this.deleteContextItem.Name = "deleteContextItem";
            this.deleteContextItem.Size = new System.Drawing.Size(193, 26);
            this.deleteContextItem.Text = "УДАЛИТЬ";
            this.deleteContextItem.Click += new System.EventHandler(this.DeleteBtnClick);
            // 
            // refreshDataContextItem
            // 
            this.refreshDataContextItem.Image = global::KinderGarten.Properties.Resources.refresh;
            this.refreshDataContextItem.Name = "refreshDataContextItem";
            this.refreshDataContextItem.Size = new System.Drawing.Size(193, 26);
            this.refreshDataContextItem.Text = "ОБНОВИТЬ ДАННЫЕ";
            this.refreshDataContextItem.Click += new System.EventHandler(this.RefreshItemClick);
            // 
            // materialLabel4
            // 
            this.materialLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(817, 253);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(71, 19);
            this.materialLabel4.TabIndex = 62;
            this.materialLabel4.Text = "Комната";
            this.materialLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // errorsLbl
            // 
            this.errorsLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.errorsLbl.BackColor = System.Drawing.Color.Transparent;
            this.errorsLbl.Depth = 0;
            this.errorsLbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.errorsLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.errorsLbl.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.errorsLbl.Location = new System.Drawing.Point(817, 367);
            this.errorsLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.errorsLbl.Name = "errorsLbl";
            this.errorsLbl.Size = new System.Drawing.Size(294, 100);
            this.errorsLbl.TabIndex = 58;
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
            this.dgv.Size = new System.Drawing.Size(795, 617);
            this.dgv.TabIndex = 57;
            this.dgv.SelectionChanged += new System.EventHandler(this.DataGridSelectionChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(813, 90);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(145, 19);
            this.materialLabel1.TabIndex = 62;
            this.materialLabel1.Text = "Мероприятие/Урок";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lesson_cmbx
            // 
            this.lesson_cmbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lesson_cmbx.BackColor = System.Drawing.SystemColors.Control;
            this.lesson_cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lesson_cmbx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lesson_cmbx.FormattingEnabled = true;
            this.lesson_cmbx.ItemHeight = 13;
            this.lesson_cmbx.Location = new System.Drawing.Point(813, 112);
            this.lesson_cmbx.Name = "lesson_cmbx";
            this.lesson_cmbx.Size = new System.Drawing.Size(298, 21);
            this.lesson_cmbx.TabIndex = 50;
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(813, 140);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(66, 19);
            this.materialLabel2.TabIndex = 62;
            this.materialLabel2.Text = "Педагог";
            this.materialLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // teacher_cmbx
            // 
            this.teacher_cmbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.teacher_cmbx.BackColor = System.Drawing.SystemColors.Control;
            this.teacher_cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.teacher_cmbx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.teacher_cmbx.FormattingEnabled = true;
            this.teacher_cmbx.ItemHeight = 13;
            this.teacher_cmbx.Location = new System.Drawing.Point(813, 162);
            this.teacher_cmbx.Name = "teacher_cmbx";
            this.teacher_cmbx.Size = new System.Drawing.Size(298, 21);
            this.teacher_cmbx.TabIndex = 50;
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(813, 197);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(58, 19);
            this.materialLabel3.TabIndex = 62;
            this.materialLabel3.Text = "Группа";
            this.materialLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // group_cmbx
            // 
            this.group_cmbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.group_cmbx.BackColor = System.Drawing.SystemColors.Control;
            this.group_cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.group_cmbx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.group_cmbx.FormattingEnabled = true;
            this.group_cmbx.ItemHeight = 13;
            this.group_cmbx.Location = new System.Drawing.Point(813, 219);
            this.group_cmbx.Name = "group_cmbx";
            this.group_cmbx.Size = new System.Drawing.Size(298, 21);
            this.group_cmbx.TabIndex = 50;
            // 
            // materialLabel5
            // 
            this.materialLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(817, 304);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(43, 19);
            this.materialLabel5.TabIndex = 62;
            this.materialLabel5.Text = "Дата";
            this.materialLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // search_txbx
            // 
            this.search_txbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.search_txbx.Format = "dd/MM/yyyy";
            this.search_txbx.Hint = null;
            this.search_txbx.Location = new System.Drawing.Point(12, 68);
            this.search_txbx.Name = "search_txbx";
            this.search_txbx.Size = new System.Drawing.Size(140, 23);
            this.search_txbx.TabIndex = 64;
            // 
            // dob_txbx
            // 
            this.dob_txbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dob_txbx.Format = "dd/MM/yyyy";
            this.dob_txbx.Hint = null;
            this.dob_txbx.Location = new System.Drawing.Point(818, 326);
            this.dob_txbx.Name = "dob_txbx";
            this.dob_txbx.Size = new System.Drawing.Size(294, 23);
            this.dob_txbx.TabIndex = 63;
            // 
            // resizebleMaterialRaisedButton2
            // 
            this.resizebleMaterialRaisedButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.resizebleMaterialRaisedButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.resizebleMaterialRaisedButton2.Depth = 0;
            this.resizebleMaterialRaisedButton2.Icon = null;
            this.resizebleMaterialRaisedButton2.Location = new System.Drawing.Point(818, 636);
            this.resizebleMaterialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.resizebleMaterialRaisedButton2.Name = "resizebleMaterialRaisedButton2";
            this.resizebleMaterialRaisedButton2.Primary = true;
            this.resizebleMaterialRaisedButton2.Size = new System.Drawing.Size(298, 36);
            this.resizebleMaterialRaisedButton2.TabIndex = 54;
            this.resizebleMaterialRaisedButton2.Text = "Печать";
            this.resizebleMaterialRaisedButton2.UseVisualStyleBackColor = true;
            this.resizebleMaterialRaisedButton2.Click += new System.EventHandler(this.resizebleMaterialRaisedButton2_Click);
            // 
            // save_btn
            // 
            this.save_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.save_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.save_btn.Depth = 0;
            this.save_btn.Icon = null;
            this.save_btn.Location = new System.Drawing.Point(818, 596);
            this.save_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.save_btn.Name = "save_btn";
            this.save_btn.Primary = true;
            this.save_btn.Size = new System.Drawing.Size(298, 36);
            this.save_btn.TabIndex = 54;
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
            this.edit_btn.Location = new System.Drawing.Point(818, 512);
            this.edit_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Primary = true;
            this.edit_btn.Size = new System.Drawing.Size(297, 36);
            this.edit_btn.TabIndex = 52;
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
            this.delete_btn.Location = new System.Drawing.Point(818, 554);
            this.delete_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Primary = true;
            this.delete_btn.Size = new System.Drawing.Size(297, 36);
            this.delete_btn.TabIndex = 53;
            this.delete_btn.Text = "Удалить";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.DeleteBtnClick);
            // 
            // resizebleMaterialRaisedButton1
            // 
            this.resizebleMaterialRaisedButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.resizebleMaterialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.resizebleMaterialRaisedButton1.Depth = 0;
            this.resizebleMaterialRaisedButton1.Icon = null;
            this.resizebleMaterialRaisedButton1.Location = new System.Drawing.Point(656, 68);
            this.resizebleMaterialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.resizebleMaterialRaisedButton1.Name = "resizebleMaterialRaisedButton1";
            this.resizebleMaterialRaisedButton1.Primary = true;
            this.resizebleMaterialRaisedButton1.Size = new System.Drawing.Size(151, 23);
            this.resizebleMaterialRaisedButton1.TabIndex = 51;
            this.resizebleMaterialRaisedButton1.Text = "Показать";
            this.resizebleMaterialRaisedButton1.UseVisualStyleBackColor = true;
            this.resizebleMaterialRaisedButton1.Click += new System.EventHandler(this.resizebleMaterialRaisedButton1_Click);
            // 
            // add_btn
            // 
            this.add_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.add_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.add_btn.Depth = 0;
            this.add_btn.Icon = null;
            this.add_btn.Location = new System.Drawing.Point(818, 470);
            this.add_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.add_btn.Name = "add_btn";
            this.add_btn.Primary = true;
            this.add_btn.Size = new System.Drawing.Size(297, 36);
            this.add_btn.TabIndex = 51;
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
            this.exit_btn.Location = new System.Drawing.Point(818, 678);
            this.exit_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Primary = true;
            this.exit_btn.Size = new System.Drawing.Size(299, 36);
            this.exit_btn.TabIndex = 55;
            this.exit_btn.Text = "Выход";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.ExitBtnClick);
            // 
            // searchlesson_cmbx
            // 
            this.searchlesson_cmbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchlesson_cmbx.BackColor = System.Drawing.SystemColors.Control;
            this.searchlesson_cmbx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchlesson_cmbx.FormattingEnabled = true;
            this.searchlesson_cmbx.ItemHeight = 13;
            this.searchlesson_cmbx.Location = new System.Drawing.Point(352, 68);
            this.searchlesson_cmbx.Name = "searchlesson_cmbx";
            this.searchlesson_cmbx.Size = new System.Drawing.Size(298, 21);
            this.searchlesson_cmbx.TabIndex = 50;
            // 
            // materialLabel6
            // 
            this.materialLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(184, 69);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(145, 19);
            this.materialLabel6.TabIndex = 62;
            this.materialLabel6.Text = "Мероприятие/Урок";
            this.materialLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 726);
            this.Controls.Add(this.search_txbx);
            this.Controls.Add(this.dob_txbx);
            this.Controls.Add(this.group_cmbx);
            this.Controls.Add(this.teacher_cmbx);
            this.Controls.Add(this.searchlesson_cmbx);
            this.Controls.Add(this.lesson_cmbx);
            this.Controls.Add(this.room_cmbx);
            this.Controls.Add(this.resizebleMaterialRaisedButton2);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.resizebleMaterialRaisedButton1);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.errorsLbl);
            this.Controls.Add(this.dgv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ScheduleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Расписание меропреятий";
            this.Load += new System.EventHandler(this.SchedulesFormLoad);
            this.contextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox room_cmbx;
        private ResizebleMaterialRaisedButton save_btn;
        private ResizebleMaterialRaisedButton edit_btn;
        private ResizebleMaterialRaisedButton delete_btn;
        private ResizebleMaterialRaisedButton add_btn;
        private ResizebleMaterialRaisedButton exit_btn;
        private System.Windows.Forms.ToolStripMenuItem editContextItem;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem addNewContextItem;
        private System.Windows.Forms.ToolStripMenuItem deleteContextItem;
        private System.Windows.Forms.ToolStripMenuItem refreshDataContextItem;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel errorsLbl;
        private System.Windows.Forms.DataGridView dgv;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.ComboBox lesson_cmbx;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.ComboBox teacher_cmbx;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.ComboBox group_cmbx;
        private MaterialDateTimePicker dob_txbx;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialDateTimePicker search_txbx;
        private ResizebleMaterialRaisedButton resizebleMaterialRaisedButton1;
        private ResizebleMaterialRaisedButton resizebleMaterialRaisedButton2;
        private System.Windows.Forms.ComboBox searchlesson_cmbx;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
    }
}