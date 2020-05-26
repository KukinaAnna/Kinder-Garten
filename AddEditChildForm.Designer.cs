namespace KinderGarten.Views
{
    partial class AddEditChildForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditChildForm));
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lname_txbx = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.fname_txbx = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.mname_txbx = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.nationalty_cmbx = new System.Windows.Forms.ComboBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.search_txbx = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.documentOfBirth_txbx = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.group_cmbx = new System.Windows.Forms.ComboBox();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.status_cmbx = new System.Windows.Forms.ComboBox();
            this.referral_txbx = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.parentsDgv = new System.Windows.Forms.DataGridView();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewContextItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteContextItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertiesDgv = new System.Windows.Forms.DataGridView();
            this.visitsDgv = new System.Windows.Forms.DataGridView();
            this.search_lbl = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.referralDate_txbx = new KinderGarten.Views.MaterialDateTimePicker();
            this.graduatedDate_txbx = new KinderGarten.Views.MaterialDateTimePicker();
            this.enteredDate_txbx = new KinderGarten.Views.MaterialDateTimePicker();
            this.dateOfRequest_txbx = new KinderGarten.Views.MaterialDateTimePicker();
            this.dob_txbx = new KinderGarten.Views.MaterialDateTimePicker();
            this.exit_btn = new KinderGarten.Views.ResizebleMaterialRaisedButton();
            this.save_btn = new KinderGarten.Views.ResizebleMaterialRaisedButton();
            this.show_btn = new KinderGarten.Views.ResizebleMaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.parentsDgv)).BeginInit();
            this.contextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitsDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(17, 76);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(75, 19);
            this.materialLabel1.TabIndex = 26;
            this.materialLabel1.Text = "Фамилия";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lname_txbx
            // 
            this.lname_txbx.Depth = 0;
            this.lname_txbx.Hint = "";
            this.lname_txbx.Location = new System.Drawing.Point(17, 105);
            this.lname_txbx.MaxLength = 32767;
            this.lname_txbx.MouseState = MaterialSkin.MouseState.HOVER;
            this.lname_txbx.Name = "lname_txbx";
            this.lname_txbx.PasswordChar = '\0';
            this.lname_txbx.SelectedText = "";
            this.lname_txbx.SelectionLength = 0;
            this.lname_txbx.SelectionStart = 0;
            this.lname_txbx.Size = new System.Drawing.Size(92, 23);
            this.lname_txbx.TabIndex = 1;
            this.lname_txbx.TabStop = false;
            this.lname_txbx.UseSystemPasswordChar = false;
            // 
            // fname_txbx
            // 
            this.fname_txbx.Depth = 0;
            this.fname_txbx.Hint = "";
            this.fname_txbx.Location = new System.Drawing.Point(115, 105);
            this.fname_txbx.MaxLength = 32767;
            this.fname_txbx.MouseState = MaterialSkin.MouseState.HOVER;
            this.fname_txbx.Name = "fname_txbx";
            this.fname_txbx.PasswordChar = '\0';
            this.fname_txbx.SelectedText = "";
            this.fname_txbx.SelectionLength = 0;
            this.fname_txbx.SelectionStart = 0;
            this.fname_txbx.Size = new System.Drawing.Size(92, 23);
            this.fname_txbx.TabIndex = 2;
            this.fname_txbx.TabStop = false;
            this.fname_txbx.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(111, 76);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(39, 19);
            this.materialLabel2.TabIndex = 26;
            this.materialLabel2.Text = "Имя";
            this.materialLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mname_txbx
            // 
            this.mname_txbx.Depth = 0;
            this.mname_txbx.Hint = "";
            this.mname_txbx.Location = new System.Drawing.Point(213, 105);
            this.mname_txbx.MaxLength = 32767;
            this.mname_txbx.MouseState = MaterialSkin.MouseState.HOVER;
            this.mname_txbx.Name = "mname_txbx";
            this.mname_txbx.PasswordChar = '\0';
            this.mname_txbx.SelectedText = "";
            this.mname_txbx.SelectionLength = 0;
            this.mname_txbx.SelectionStart = 0;
            this.mname_txbx.Size = new System.Drawing.Size(102, 23);
            this.mname_txbx.TabIndex = 3;
            this.mname_txbx.TabStop = false;
            this.mname_txbx.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(209, 76);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(75, 19);
            this.materialLabel3.TabIndex = 26;
            this.materialLabel3.Text = "Отчество";
            this.materialLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nationalty_cmbx
            // 
            this.nationalty_cmbx.BackColor = System.Drawing.SystemColors.Control;
            this.nationalty_cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nationalty_cmbx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nationalty_cmbx.FormattingEnabled = true;
            this.nationalty_cmbx.ItemHeight = 13;
            this.nationalty_cmbx.Location = new System.Drawing.Point(169, 139);
            this.nationalty_cmbx.Name = "nationalty_cmbx";
            this.nationalty_cmbx.Size = new System.Drawing.Size(146, 21);
            this.nationalty_cmbx.TabIndex = 4;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(17, 139);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(130, 19);
            this.materialLabel4.TabIndex = 50;
            this.materialLabel4.Text = "Национальность";
            this.materialLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // search_txbx
            // 
            this.search_txbx.Depth = 0;
            this.search_txbx.Hint = "мм/гггг";
            this.search_txbx.Location = new System.Drawing.Point(415, 76);
            this.search_txbx.MaxLength = 32767;
            this.search_txbx.MouseState = MaterialSkin.MouseState.HOVER;
            this.search_txbx.Name = "search_txbx";
            this.search_txbx.PasswordChar = '\0';
            this.search_txbx.SelectedText = "";
            this.search_txbx.SelectionLength = 0;
            this.search_txbx.SelectionStart = 0;
            this.search_txbx.Size = new System.Drawing.Size(146, 23);
            this.search_txbx.TabIndex = 16;
            this.search_txbx.TabStop = false;
            this.search_txbx.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(17, 180);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(118, 19);
            this.materialLabel5.TabIndex = 26;
            this.materialLabel5.Text = "Дата рождения";
            this.materialLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // documentOfBirth_txbx
            // 
            this.documentOfBirth_txbx.Depth = 0;
            this.documentOfBirth_txbx.Hint = "";
            this.documentOfBirth_txbx.Location = new System.Drawing.Point(17, 240);
            this.documentOfBirth_txbx.MaxLength = 32767;
            this.documentOfBirth_txbx.MouseState = MaterialSkin.MouseState.HOVER;
            this.documentOfBirth_txbx.Name = "documentOfBirth_txbx";
            this.documentOfBirth_txbx.PasswordChar = '\0';
            this.documentOfBirth_txbx.SelectedText = "";
            this.documentOfBirth_txbx.SelectionLength = 0;
            this.documentOfBirth_txbx.SelectionStart = 0;
            this.documentOfBirth_txbx.Size = new System.Drawing.Size(298, 23);
            this.documentOfBirth_txbx.TabIndex = 6;
            this.documentOfBirth_txbx.TabStop = false;
            this.documentOfBirth_txbx.UseSystemPasswordChar = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(17, 218);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(208, 19);
            this.materialLabel6.TabIndex = 26;
            this.materialLabel6.Text = "Свидетельство о рождении";
            this.materialLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(17, 278);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(58, 19);
            this.materialLabel7.TabIndex = 50;
            this.materialLabel7.Text = "Группа";
            this.materialLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // group_cmbx
            // 
            this.group_cmbx.BackColor = System.Drawing.SystemColors.Control;
            this.group_cmbx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.group_cmbx.FormattingEnabled = true;
            this.group_cmbx.ItemHeight = 13;
            this.group_cmbx.Location = new System.Drawing.Point(128, 278);
            this.group_cmbx.Name = "group_cmbx";
            this.group_cmbx.Size = new System.Drawing.Size(187, 21);
            this.group_cmbx.TabIndex = 7;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(17, 319);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(97, 19);
            this.materialLabel8.TabIndex = 26;
            this.materialLabel8.Text = "Дата заявки";
            this.materialLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(17, 348);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(139, 19);
            this.materialLabel9.TabIndex = 26;
            this.materialLabel9.Text = "Дата поступления";
            this.materialLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(17, 377);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(112, 19);
            this.materialLabel10.TabIndex = 26;
            this.materialLabel10.Text = "Дата выбытия";
            this.materialLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Location = new System.Drawing.Point(17, 411);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(56, 19);
            this.materialLabel11.TabIndex = 50;
            this.materialLabel11.Text = "Статус";
            this.materialLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // status_cmbx
            // 
            this.status_cmbx.BackColor = System.Drawing.SystemColors.Control;
            this.status_cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.status_cmbx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.status_cmbx.FormattingEnabled = true;
            this.status_cmbx.ItemHeight = 13;
            this.status_cmbx.Location = new System.Drawing.Point(128, 411);
            this.status_cmbx.Name = "status_cmbx";
            this.status_cmbx.Size = new System.Drawing.Size(187, 21);
            this.status_cmbx.TabIndex = 11;
            // 
            // referral_txbx
            // 
            this.referral_txbx.Depth = 0;
            this.referral_txbx.Hint = "";
            this.referral_txbx.Location = new System.Drawing.Point(128, 442);
            this.referral_txbx.MaxLength = 32767;
            this.referral_txbx.MouseState = MaterialSkin.MouseState.HOVER;
            this.referral_txbx.Name = "referral_txbx";
            this.referral_txbx.PasswordChar = '\0';
            this.referral_txbx.SelectedText = "";
            this.referral_txbx.SelectionLength = 0;
            this.referral_txbx.SelectionStart = 0;
            this.referral_txbx.Size = new System.Drawing.Size(48, 23);
            this.referral_txbx.TabIndex = 12;
            this.referral_txbx.TabStop = false;
            this.referral_txbx.UseSystemPasswordChar = false;
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel12.Location = new System.Drawing.Point(17, 442);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(105, 19);
            this.materialLabel12.TabIndex = 26;
            this.materialLabel12.Text = "Направление";
            this.materialLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // parentsDgv
            // 
            this.parentsDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.parentsDgv.ContextMenuStrip = this.contextMenu;
            this.parentsDgv.Location = new System.Drawing.Point(12, 491);
            this.parentsDgv.Name = "parentsDgv";
            this.parentsDgv.Size = new System.Drawing.Size(710, 113);
            this.parentsDgv.TabIndex = 51;
            this.parentsDgv.SelectionChanged += new System.EventHandler(this.ParentsDgvSelectionChanged);
            // 
            // contextMenu
            // 
            this.contextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewContextItem,
            this.deleteContextItem});
            this.contextMenu.Name = "contextMenuStrip1";
            this.contextMenu.Size = new System.Drawing.Size(140, 56);
            // 
            // addNewContextItem
            // 
            this.addNewContextItem.Image = global::KinderGarten.Properties.Resources.plus_thick;
            this.addNewContextItem.Name = "addNewContextItem";
            this.addNewContextItem.Size = new System.Drawing.Size(139, 26);
            this.addNewContextItem.Text = "ДОБАВИТЬ";
            this.addNewContextItem.Click += new System.EventHandler(this.AddNewContextItemClick);
            // 
            // deleteContextItem
            // 
            this.deleteContextItem.Image = global::KinderGarten.Properties.Resources.delete_alert;
            this.deleteContextItem.Name = "deleteContextItem";
            this.deleteContextItem.Size = new System.Drawing.Size(139, 26);
            this.deleteContextItem.Text = "УДАЛИТЬ";
            this.deleteContextItem.Click += new System.EventHandler(this.DeleteContextItemClick);
            // 
            // propertiesDgv
            // 
            this.propertiesDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.propertiesDgv.Location = new System.Drawing.Point(12, 610);
            this.propertiesDgv.Name = "propertiesDgv";
            this.propertiesDgv.Size = new System.Drawing.Size(710, 96);
            this.propertiesDgv.TabIndex = 51;
            // 
            // visitsDgv
            // 
            this.visitsDgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.visitsDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.visitsDgv.Location = new System.Drawing.Point(340, 105);
            this.visitsDgv.Name = "visitsDgv";
            this.visitsDgv.Size = new System.Drawing.Size(382, 380);
            this.visitsDgv.TabIndex = 51;
            this.visitsDgv.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.visitsDgv_DataBindingComplete);
            // 
            // search_lbl
            // 
            this.search_lbl.AutoSize = true;
            this.search_lbl.BackColor = System.Drawing.Color.Transparent;
            this.search_lbl.Depth = 0;
            this.search_lbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.search_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.search_lbl.Location = new System.Drawing.Point(336, 76);
            this.search_lbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.search_lbl.Name = "search_lbl";
            this.search_lbl.Size = new System.Drawing.Size(63, 19);
            this.search_lbl.TabIndex = 26;
            this.search_lbl.Text = "Период";
            this.search_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // materialLabel14
            // 
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel14.Location = new System.Drawing.Point(17, 469);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(82, 19);
            this.materialLabel14.TabIndex = 26;
            this.materialLabel14.Text = "Родители:";
            this.materialLabel14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // referralDate_txbx
            // 
            this.referralDate_txbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.referralDate_txbx.Format = "dd/MM/yyyy";
            this.referralDate_txbx.Hint = null;
            this.referralDate_txbx.Location = new System.Drawing.Point(182, 442);
            this.referralDate_txbx.Name = "referralDate_txbx";
            this.referralDate_txbx.Size = new System.Drawing.Size(133, 23);
            this.referralDate_txbx.TabIndex = 13;
            // 
            // graduatedDate_txbx
            // 
            this.graduatedDate_txbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.graduatedDate_txbx.Format = "dd/MM/yyyy";
            this.graduatedDate_txbx.Hint = null;
            this.graduatedDate_txbx.Location = new System.Drawing.Point(169, 373);
            this.graduatedDate_txbx.Name = "graduatedDate_txbx";
            this.graduatedDate_txbx.Size = new System.Drawing.Size(146, 23);
            this.graduatedDate_txbx.TabIndex = 10;
            // 
            // enteredDate_txbx
            // 
            this.enteredDate_txbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.enteredDate_txbx.Format = "dd/MM/yyyy";
            this.enteredDate_txbx.Hint = null;
            this.enteredDate_txbx.Location = new System.Drawing.Point(169, 344);
            this.enteredDate_txbx.Name = "enteredDate_txbx";
            this.enteredDate_txbx.Size = new System.Drawing.Size(146, 23);
            this.enteredDate_txbx.TabIndex = 9;
            // 
            // dateOfRequest_txbx
            // 
            this.dateOfRequest_txbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateOfRequest_txbx.Format = "dd/MM/yyyy";
            this.dateOfRequest_txbx.Hint = null;
            this.dateOfRequest_txbx.Location = new System.Drawing.Point(169, 315);
            this.dateOfRequest_txbx.Name = "dateOfRequest_txbx";
            this.dateOfRequest_txbx.Size = new System.Drawing.Size(146, 23);
            this.dateOfRequest_txbx.TabIndex = 8;
            // 
            // dob_txbx
            // 
            this.dob_txbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dob_txbx.Format = "dd/MM/yyyy";
            this.dob_txbx.Hint = null;
            this.dob_txbx.Location = new System.Drawing.Point(169, 180);
            this.dob_txbx.Name = "dob_txbx";
            this.dob_txbx.Size = new System.Drawing.Size(146, 23);
            this.dob_txbx.TabIndex = 5;
            // 
            // exit_btn
            // 
            this.exit_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exit_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.exit_btn.Depth = 0;
            this.exit_btn.Icon = null;
            this.exit_btn.Location = new System.Drawing.Point(12, 750);
            this.exit_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Primary = true;
            this.exit_btn.Size = new System.Drawing.Size(710, 32);
            this.exit_btn.TabIndex = 15;
            this.exit_btn.Text = "Выход";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.ExitBtnClick);
            // 
            // save_btn
            // 
            this.save_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.save_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.save_btn.Depth = 0;
            this.save_btn.Icon = null;
            this.save_btn.Location = new System.Drawing.Point(12, 712);
            this.save_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.save_btn.Name = "save_btn";
            this.save_btn.Primary = true;
            this.save_btn.Size = new System.Drawing.Size(710, 32);
            this.save_btn.TabIndex = 14;
            this.save_btn.Text = "Сохранить";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.SaveBtnClick);
            // 
            // show_btn
            // 
            this.show_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.show_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.show_btn.Depth = 0;
            this.show_btn.Icon = null;
            this.show_btn.Location = new System.Drawing.Point(567, 70);
            this.show_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.show_btn.Name = "show_btn";
            this.show_btn.Primary = true;
            this.show_btn.Size = new System.Drawing.Size(155, 32);
            this.show_btn.TabIndex = 17;
            this.show_btn.Text = "Показать";
            this.show_btn.UseVisualStyleBackColor = true;
            this.show_btn.Click += new System.EventHandler(this.show_btn_Click);
            // 
            // AddEditChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 792);
            this.Controls.Add(this.referralDate_txbx);
            this.Controls.Add(this.graduatedDate_txbx);
            this.Controls.Add(this.enteredDate_txbx);
            this.Controls.Add(this.dateOfRequest_txbx);
            this.Controls.Add(this.dob_txbx);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.show_btn);
            this.Controls.Add(this.propertiesDgv);
            this.Controls.Add(this.visitsDgv);
            this.Controls.Add(this.parentsDgv);
            this.Controls.Add(this.status_cmbx);
            this.Controls.Add(this.materialLabel11);
            this.Controls.Add(this.group_cmbx);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.nationalty_cmbx);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.search_lbl);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel10);
            this.Controls.Add(this.materialLabel9);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel14);
            this.Controls.Add(this.materialLabel12);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.mname_txbx);
            this.Controls.Add(this.fname_txbx);
            this.Controls.Add(this.documentOfBirth_txbx);
            this.Controls.Add(this.search_txbx);
            this.Controls.Add(this.referral_txbx);
            this.Controls.Add(this.lname_txbx);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(734, 792);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(734, 792);
            this.Name = "AddEditChildForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Личная карточка учащегося";
            this.Load += new System.EventHandler(this.AddEditChildFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.parentsDgv)).EndInit();
            this.contextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.propertiesDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitsDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField lname_txbx;
        private MaterialSkin.Controls.MaterialSingleLineTextField fname_txbx;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField mname_txbx;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.ComboBox nationalty_cmbx;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField search_txbx;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialSingleLineTextField documentOfBirth_txbx;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private System.Windows.Forms.ComboBox group_cmbx;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private System.Windows.Forms.ComboBox status_cmbx;
        private MaterialSkin.Controls.MaterialSingleLineTextField referral_txbx;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private System.Windows.Forms.DataGridView parentsDgv;
        private System.Windows.Forms.DataGridView propertiesDgv;
        private System.Windows.Forms.DataGridView visitsDgv;
        private MaterialSkin.Controls.MaterialLabel search_lbl;
        private ResizebleMaterialRaisedButton show_btn;
        private ResizebleMaterialRaisedButton save_btn;
        private ResizebleMaterialRaisedButton exit_btn;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private MaterialDateTimePicker dob_txbx;
        private MaterialDateTimePicker dateOfRequest_txbx;
        private MaterialDateTimePicker enteredDate_txbx;
        private MaterialDateTimePicker graduatedDate_txbx;
        private MaterialDateTimePicker referralDate_txbx;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem addNewContextItem;
        private System.Windows.Forms.ToolStripMenuItem deleteContextItem;
    }
}