namespace KinderGarten.Views
{
    partial class ChildForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChildForm));
            this.dgv = new System.Windows.Forms.DataGridView();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewContextItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editContextItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteContextItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshDataContextItem = new System.Windows.Forms.ToolStripMenuItem();
            this.search_txbx = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.group_cmbx = new System.Windows.Forms.ComboBox();
            this.status_cmbx = new System.Windows.Forms.ComboBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.group_chbx = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.resizebleMaterialRaisedButton4 = new KinderGarten.Views.ResizebleMaterialRaisedButton();
            this.filter_btn = new KinderGarten.Views.ResizebleMaterialRaisedButton();
            this.status_chbx = new MaterialSkin.Controls.MaterialCheckBox();
            this.req_chbx = new MaterialSkin.Controls.MaterialCheckBox();
            this.enter_chbx = new MaterialSkin.Controls.MaterialCheckBox();
            this.reqStart_txbx = new KinderGarten.Views.MaterialDateTimePicker();
            this.enterStart_txbx = new KinderGarten.Views.MaterialDateTimePicker();
            this.reqEnd_txbx = new KinderGarten.Views.MaterialDateTimePicker();
            this.enterEnd_txbx = new KinderGarten.Views.MaterialDateTimePicker();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.dob_chbx = new MaterialSkin.Controls.MaterialCheckBox();
            this.dobStart_txbx = new KinderGarten.Views.MaterialDateTimePicker();
            this.dobEnd_txbx = new KinderGarten.Views.MaterialDateTimePicker();
            this.exit_btn = new KinderGarten.Views.ResizebleMaterialRaisedButton();
            this.delete_btn = new KinderGarten.Views.ResizebleMaterialRaisedButton();
            this.resizebleMaterialRaisedButton3 = new KinderGarten.Views.ResizebleMaterialRaisedButton();
            this.resizebleMaterialRaisedButton2 = new KinderGarten.Views.ResizebleMaterialRaisedButton();
            this.resizebleMaterialRaisedButton1 = new KinderGarten.Views.ResizebleMaterialRaisedButton();
            this.agreement_btn = new KinderGarten.Views.ResizebleMaterialRaisedButton();
            this.add_btn = new KinderGarten.Views.ResizebleMaterialRaisedButton();
            this.edit_btn = new KinderGarten.Views.ResizebleMaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.contextMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.ContextMenuStrip = this.contextMenu;
            this.dgv.Location = new System.Drawing.Point(12, 105);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(1228, 491);
            this.dgv.TabIndex = 16;
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
            // search_txbx
            // 
            this.search_txbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.search_txbx.Depth = 0;
            this.search_txbx.Hint = "Для поиска введите фамилию, имя или отчетсво, свидетельство о рождении и нажмите " +
    "Enter";
            this.search_txbx.Location = new System.Drawing.Point(12, 76);
            this.search_txbx.MaxLength = 32767;
            this.search_txbx.MouseState = MaterialSkin.MouseState.HOVER;
            this.search_txbx.Name = "search_txbx";
            this.search_txbx.PasswordChar = '\0';
            this.search_txbx.SelectedText = "";
            this.search_txbx.SelectionLength = 0;
            this.search_txbx.SelectionStart = 0;
            this.search_txbx.Size = new System.Drawing.Size(1228, 23);
            this.search_txbx.TabIndex = 24;
            this.search_txbx.TabStop = false;
            this.search_txbx.UseSystemPasswordChar = false;
            this.search_txbx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.search_txbx_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.group_cmbx);
            this.groupBox1.Controls.Add(this.status_cmbx);
            this.groupBox1.Controls.Add(this.materialLabel3);
            this.groupBox1.Controls.Add(this.group_chbx);
            this.groupBox1.Controls.Add(this.materialLabel2);
            this.groupBox1.Controls.Add(this.resizebleMaterialRaisedButton4);
            this.groupBox1.Controls.Add(this.filter_btn);
            this.groupBox1.Controls.Add(this.status_chbx);
            this.groupBox1.Controls.Add(this.req_chbx);
            this.groupBox1.Controls.Add(this.enter_chbx);
            this.groupBox1.Controls.Add(this.reqStart_txbx);
            this.groupBox1.Controls.Add(this.enterStart_txbx);
            this.groupBox1.Controls.Add(this.reqEnd_txbx);
            this.groupBox1.Controls.Add(this.enterEnd_txbx);
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Controls.Add(this.dob_chbx);
            this.groupBox1.Controls.Add(this.dobStart_txbx);
            this.groupBox1.Controls.Add(this.dobEnd_txbx);
            this.groupBox1.Location = new System.Drawing.Point(12, 602);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(644, 175);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фильтр";
            // 
            // group_cmbx
            // 
            this.group_cmbx.BackColor = System.Drawing.SystemColors.Control;
            this.group_cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.group_cmbx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.group_cmbx.FormattingEnabled = true;
            this.group_cmbx.ItemHeight = 13;
            this.group_cmbx.Location = new System.Drawing.Point(234, 139);
            this.group_cmbx.Name = "group_cmbx";
            this.group_cmbx.Size = new System.Drawing.Size(314, 21);
            this.group_cmbx.TabIndex = 51;
            // 
            // status_cmbx
            // 
            this.status_cmbx.BackColor = System.Drawing.SystemColors.Control;
            this.status_cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.status_cmbx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.status_cmbx.FormattingEnabled = true;
            this.status_cmbx.ItemHeight = 13;
            this.status_cmbx.Location = new System.Drawing.Point(234, 109);
            this.status_cmbx.Name = "status_cmbx";
            this.status_cmbx.Size = new System.Drawing.Size(314, 21);
            this.status_cmbx.TabIndex = 51;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(380, 78);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(27, 19);
            this.materialLabel3.TabIndex = 15;
            this.materialLabel3.Text = "по";
            // 
            // group_chbx
            // 
            this.group_chbx.AutoSize = true;
            this.group_chbx.Depth = 0;
            this.group_chbx.Font = new System.Drawing.Font("Roboto", 10F);
            this.group_chbx.Location = new System.Drawing.Point(59, 134);
            this.group_chbx.Margin = new System.Windows.Forms.Padding(0);
            this.group_chbx.MouseLocation = new System.Drawing.Point(-1, -1);
            this.group_chbx.MouseState = MaterialSkin.MouseState.HOVER;
            this.group_chbx.Name = "group_chbx";
            this.group_chbx.Ripple = true;
            this.group_chbx.Size = new System.Drawing.Size(75, 30);
            this.group_chbx.TabIndex = 14;
            this.group_chbx.Text = "Группа";
            this.group_chbx.UseVisualStyleBackColor = true;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(380, 49);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(27, 19);
            this.materialLabel2.TabIndex = 15;
            this.materialLabel2.Text = "по";
            // 
            // resizebleMaterialRaisedButton4
            // 
            this.resizebleMaterialRaisedButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.resizebleMaterialRaisedButton4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.resizebleMaterialRaisedButton4.Depth = 0;
            this.resizebleMaterialRaisedButton4.Icon = null;
            this.resizebleMaterialRaisedButton4.Location = new System.Drawing.Point(554, 49);
            this.resizebleMaterialRaisedButton4.MouseState = MaterialSkin.MouseState.HOVER;
            this.resizebleMaterialRaisedButton4.Name = "resizebleMaterialRaisedButton4";
            this.resizebleMaterialRaisedButton4.Primary = true;
            this.resizebleMaterialRaisedButton4.Size = new System.Drawing.Size(77, 55);
            this.resizebleMaterialRaisedButton4.TabIndex = 20;
            this.resizebleMaterialRaisedButton4.Text = "Печать";
            this.resizebleMaterialRaisedButton4.UseVisualStyleBackColor = true;
            this.resizebleMaterialRaisedButton4.Click += new System.EventHandler(this.resizebleMaterialRaisedButton4_Click);
            // 
            // filter_btn
            // 
            this.filter_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.filter_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.filter_btn.Depth = 0;
            this.filter_btn.Icon = null;
            this.filter_btn.Location = new System.Drawing.Point(554, 109);
            this.filter_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.filter_btn.Name = "filter_btn";
            this.filter_btn.Primary = true;
            this.filter_btn.Size = new System.Drawing.Size(77, 55);
            this.filter_btn.TabIndex = 20;
            this.filter_btn.Text = "Фильтр";
            this.filter_btn.UseVisualStyleBackColor = true;
            this.filter_btn.Click += new System.EventHandler(this.filter_btn_Click);
            // 
            // status_chbx
            // 
            this.status_chbx.AutoSize = true;
            this.status_chbx.Depth = 0;
            this.status_chbx.Font = new System.Drawing.Font("Roboto", 10F);
            this.status_chbx.Location = new System.Drawing.Point(59, 104);
            this.status_chbx.Margin = new System.Windows.Forms.Padding(0);
            this.status_chbx.MouseLocation = new System.Drawing.Point(-1, -1);
            this.status_chbx.MouseState = MaterialSkin.MouseState.HOVER;
            this.status_chbx.Name = "status_chbx";
            this.status_chbx.Ripple = true;
            this.status_chbx.Size = new System.Drawing.Size(74, 30);
            this.status_chbx.TabIndex = 14;
            this.status_chbx.Text = "Статус";
            this.status_chbx.UseVisualStyleBackColor = true;
            // 
            // req_chbx
            // 
            this.req_chbx.AutoSize = true;
            this.req_chbx.Depth = 0;
            this.req_chbx.Font = new System.Drawing.Font("Roboto", 10F);
            this.req_chbx.Location = new System.Drawing.Point(59, 74);
            this.req_chbx.Margin = new System.Windows.Forms.Padding(0);
            this.req_chbx.MouseLocation = new System.Drawing.Point(-1, -1);
            this.req_chbx.MouseState = MaterialSkin.MouseState.HOVER;
            this.req_chbx.Name = "req_chbx";
            this.req_chbx.Ripple = true;
            this.req_chbx.Size = new System.Drawing.Size(121, 30);
            this.req_chbx.TabIndex = 14;
            this.req_chbx.Text = "Дата заявки с";
            this.req_chbx.UseVisualStyleBackColor = true;
            // 
            // enter_chbx
            // 
            this.enter_chbx.AutoSize = true;
            this.enter_chbx.Depth = 0;
            this.enter_chbx.Font = new System.Drawing.Font("Roboto", 10F);
            this.enter_chbx.Location = new System.Drawing.Point(59, 44);
            this.enter_chbx.Margin = new System.Windows.Forms.Padding(0);
            this.enter_chbx.MouseLocation = new System.Drawing.Point(-1, -1);
            this.enter_chbx.MouseState = MaterialSkin.MouseState.HOVER;
            this.enter_chbx.Name = "enter_chbx";
            this.enter_chbx.Ripple = true;
            this.enter_chbx.Size = new System.Drawing.Size(159, 30);
            this.enter_chbx.TabIndex = 14;
            this.enter_chbx.Text = "Дата поступления с";
            this.enter_chbx.UseVisualStyleBackColor = true;
            // 
            // reqStart_txbx
            // 
            this.reqStart_txbx.Format = "dd/MM/yyyy";
            this.reqStart_txbx.Hint = null;
            this.reqStart_txbx.Location = new System.Drawing.Point(234, 78);
            this.reqStart_txbx.Name = "reqStart_txbx";
            this.reqStart_txbx.Size = new System.Drawing.Size(125, 23);
            this.reqStart_txbx.TabIndex = 12;
            // 
            // enterStart_txbx
            // 
            this.enterStart_txbx.Format = "dd/MM/yyyy";
            this.enterStart_txbx.Hint = null;
            this.enterStart_txbx.Location = new System.Drawing.Point(234, 49);
            this.enterStart_txbx.Name = "enterStart_txbx";
            this.enterStart_txbx.Size = new System.Drawing.Size(125, 23);
            this.enterStart_txbx.TabIndex = 12;
            // 
            // reqEnd_txbx
            // 
            this.reqEnd_txbx.Format = "dd/MM/yyyy";
            this.reqEnd_txbx.Hint = null;
            this.reqEnd_txbx.Location = new System.Drawing.Point(413, 78);
            this.reqEnd_txbx.Name = "reqEnd_txbx";
            this.reqEnd_txbx.Size = new System.Drawing.Size(135, 23);
            this.reqEnd_txbx.TabIndex = 13;
            // 
            // enterEnd_txbx
            // 
            this.enterEnd_txbx.Format = "dd/MM/yyyy";
            this.enterEnd_txbx.Hint = null;
            this.enterEnd_txbx.Location = new System.Drawing.Point(413, 49);
            this.enterEnd_txbx.Name = "enterEnd_txbx";
            this.enterEnd_txbx.Size = new System.Drawing.Size(135, 23);
            this.enterEnd_txbx.TabIndex = 13;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(380, 19);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(27, 19);
            this.materialLabel1.TabIndex = 11;
            this.materialLabel1.Text = "по";
            // 
            // dob_chbx
            // 
            this.dob_chbx.AutoSize = true;
            this.dob_chbx.Depth = 0;
            this.dob_chbx.Font = new System.Drawing.Font("Roboto", 10F);
            this.dob_chbx.Location = new System.Drawing.Point(59, 14);
            this.dob_chbx.Margin = new System.Windows.Forms.Padding(0);
            this.dob_chbx.MouseLocation = new System.Drawing.Point(-1, -1);
            this.dob_chbx.MouseState = MaterialSkin.MouseState.HOVER;
            this.dob_chbx.Name = "dob_chbx";
            this.dob_chbx.Ripple = true;
            this.dob_chbx.Size = new System.Drawing.Size(142, 30);
            this.dob_chbx.TabIndex = 10;
            this.dob_chbx.Text = "Дата рождения с";
            this.dob_chbx.UseVisualStyleBackColor = true;
            // 
            // dobStart_txbx
            // 
            this.dobStart_txbx.Format = "dd/MM/yyyy";
            this.dobStart_txbx.Hint = null;
            this.dobStart_txbx.Location = new System.Drawing.Point(234, 19);
            this.dobStart_txbx.Name = "dobStart_txbx";
            this.dobStart_txbx.Size = new System.Drawing.Size(125, 23);
            this.dobStart_txbx.TabIndex = 9;
            // 
            // dobEnd_txbx
            // 
            this.dobEnd_txbx.Format = "dd/MM/yyyy";
            this.dobEnd_txbx.Hint = null;
            this.dobEnd_txbx.Location = new System.Drawing.Point(413, 19);
            this.dobEnd_txbx.Name = "dobEnd_txbx";
            this.dobEnd_txbx.Size = new System.Drawing.Size(135, 23);
            this.dobEnd_txbx.TabIndex = 9;
            // 
            // exit_btn
            // 
            this.exit_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exit_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.exit_btn.Depth = 0;
            this.exit_btn.Icon = null;
            this.exit_btn.Location = new System.Drawing.Point(941, 746);
            this.exit_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Primary = true;
            this.exit_btn.Size = new System.Drawing.Size(299, 36);
            this.exit_btn.TabIndex = 23;
            this.exit_btn.Text = "Выход";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.ExitBtnClick);
            // 
            // delete_btn
            // 
            this.delete_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.delete_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.delete_btn.Depth = 0;
            this.delete_btn.Icon = null;
            this.delete_btn.Location = new System.Drawing.Point(941, 698);
            this.delete_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Primary = true;
            this.delete_btn.Size = new System.Drawing.Size(299, 36);
            this.delete_btn.TabIndex = 22;
            this.delete_btn.Text = "Удалить";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.DeleteBtnClick);
            // 
            // resizebleMaterialRaisedButton3
            // 
            this.resizebleMaterialRaisedButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.resizebleMaterialRaisedButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.resizebleMaterialRaisedButton3.Depth = 0;
            this.resizebleMaterialRaisedButton3.Icon = null;
            this.resizebleMaterialRaisedButton3.Location = new System.Drawing.Point(662, 746);
            this.resizebleMaterialRaisedButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.resizebleMaterialRaisedButton3.Name = "resizebleMaterialRaisedButton3";
            this.resizebleMaterialRaisedButton3.Primary = true;
            this.resizebleMaterialRaisedButton3.Size = new System.Drawing.Size(273, 36);
            this.resizebleMaterialRaisedButton3.TabIndex = 20;
            this.resizebleMaterialRaisedButton3.Text = "Приказ об отчислении";
            this.resizebleMaterialRaisedButton3.UseVisualStyleBackColor = true;
            this.resizebleMaterialRaisedButton3.Click += new System.EventHandler(this.resizebleMaterialRaisedButton3_Click);
            // 
            // resizebleMaterialRaisedButton2
            // 
            this.resizebleMaterialRaisedButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.resizebleMaterialRaisedButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.resizebleMaterialRaisedButton2.Depth = 0;
            this.resizebleMaterialRaisedButton2.Icon = null;
            this.resizebleMaterialRaisedButton2.Location = new System.Drawing.Point(662, 698);
            this.resizebleMaterialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.resizebleMaterialRaisedButton2.Name = "resizebleMaterialRaisedButton2";
            this.resizebleMaterialRaisedButton2.Primary = true;
            this.resizebleMaterialRaisedButton2.Size = new System.Drawing.Size(273, 36);
            this.resizebleMaterialRaisedButton2.TabIndex = 20;
            this.resizebleMaterialRaisedButton2.Text = "Приказ о переводе";
            this.resizebleMaterialRaisedButton2.UseVisualStyleBackColor = true;
            this.resizebleMaterialRaisedButton2.Click += new System.EventHandler(this.resizebleMaterialRaisedButton2_Click);
            // 
            // resizebleMaterialRaisedButton1
            // 
            this.resizebleMaterialRaisedButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.resizebleMaterialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.resizebleMaterialRaisedButton1.Depth = 0;
            this.resizebleMaterialRaisedButton1.Icon = null;
            this.resizebleMaterialRaisedButton1.Location = new System.Drawing.Point(662, 650);
            this.resizebleMaterialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.resizebleMaterialRaisedButton1.Name = "resizebleMaterialRaisedButton1";
            this.resizebleMaterialRaisedButton1.Primary = true;
            this.resizebleMaterialRaisedButton1.Size = new System.Drawing.Size(273, 36);
            this.resizebleMaterialRaisedButton1.TabIndex = 20;
            this.resizebleMaterialRaisedButton1.Text = "Приказ о зачислении";
            this.resizebleMaterialRaisedButton1.UseVisualStyleBackColor = true;
            this.resizebleMaterialRaisedButton1.Click += new System.EventHandler(this.resizebleMaterialRaisedButton1_Click);
            // 
            // agreement_btn
            // 
            this.agreement_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.agreement_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.agreement_btn.Depth = 0;
            this.agreement_btn.Icon = null;
            this.agreement_btn.Location = new System.Drawing.Point(662, 602);
            this.agreement_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.agreement_btn.Name = "agreement_btn";
            this.agreement_btn.Primary = true;
            this.agreement_btn.Size = new System.Drawing.Size(273, 36);
            this.agreement_btn.TabIndex = 20;
            this.agreement_btn.Text = "Договор";
            this.agreement_btn.UseVisualStyleBackColor = true;
            this.agreement_btn.Click += new System.EventHandler(this.agreement_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.add_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.add_btn.Depth = 0;
            this.add_btn.Icon = null;
            this.add_btn.Location = new System.Drawing.Point(941, 602);
            this.add_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.add_btn.Name = "add_btn";
            this.add_btn.Primary = true;
            this.add_btn.Size = new System.Drawing.Size(299, 36);
            this.add_btn.TabIndex = 20;
            this.add_btn.Text = "Добавить";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.AddBtnClick);
            // 
            // edit_btn
            // 
            this.edit_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.edit_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.edit_btn.Depth = 0;
            this.edit_btn.Icon = null;
            this.edit_btn.Location = new System.Drawing.Point(941, 650);
            this.edit_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Primary = true;
            this.edit_btn.Size = new System.Drawing.Size(299, 36);
            this.edit_btn.TabIndex = 21;
            this.edit_btn.Text = "Редактировать";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.EditBtnClick);
            // 
            // ChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 789);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.search_txbx);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.resizebleMaterialRaisedButton3);
            this.Controls.Add(this.resizebleMaterialRaisedButton2);
            this.Controls.Add(this.resizebleMaterialRaisedButton1);
            this.Controls.Add(this.agreement_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.dgv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChildForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Воспитанники";
            this.Load += new System.EventHandler(this.ChildFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.contextMenu.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem addNewContextItem;
        private System.Windows.Forms.ToolStripMenuItem editContextItem;
        private System.Windows.Forms.ToolStripMenuItem deleteContextItem;
        private System.Windows.Forms.ToolStripMenuItem refreshDataContextItem;
        private ResizebleMaterialRaisedButton delete_btn;
        private ResizebleMaterialRaisedButton add_btn;
        private ResizebleMaterialRaisedButton edit_btn;
        private ResizebleMaterialRaisedButton exit_btn;
        private MaterialSkin.Controls.MaterialSingleLineTextField search_txbx;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialCheckBox req_chbx;
        private MaterialSkin.Controls.MaterialCheckBox enter_chbx;
        private MaterialDateTimePicker reqStart_txbx;
        private MaterialDateTimePicker enterStart_txbx;
        private MaterialDateTimePicker reqEnd_txbx;
        private MaterialDateTimePicker enterEnd_txbx;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialCheckBox dob_chbx;
        private MaterialDateTimePicker dobStart_txbx;
        private MaterialDateTimePicker dobEnd_txbx;
        private System.Windows.Forms.ComboBox group_cmbx;
        private System.Windows.Forms.ComboBox status_cmbx;
        private MaterialSkin.Controls.MaterialCheckBox group_chbx;
        private ResizebleMaterialRaisedButton filter_btn;
        private MaterialSkin.Controls.MaterialCheckBox status_chbx;
        private ResizebleMaterialRaisedButton agreement_btn;
        private ResizebleMaterialRaisedButton resizebleMaterialRaisedButton1;
        private ResizebleMaterialRaisedButton resizebleMaterialRaisedButton2;
        private ResizebleMaterialRaisedButton resizebleMaterialRaisedButton3;
        private ResizebleMaterialRaisedButton resizebleMaterialRaisedButton4;
    }
}