namespace KinderGarten.Views
{
    partial class ParentsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParentsForm));
            this.save_btn = new KinderGarten.Views.ResizebleMaterialRaisedButton();
            this.edit_btn = new KinderGarten.Views.ResizebleMaterialRaisedButton();
            this.delete_btn = new KinderGarten.Views.ResizebleMaterialRaisedButton();
            this.add_btn = new KinderGarten.Views.ResizebleMaterialRaisedButton();
            this.exit_btn = new KinderGarten.Views.ResizebleMaterialRaisedButton();
            this.errorsLbl = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.patronymic_txbx = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lname_txbx = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewContextItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editContextItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteContextItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshDataContextItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.search_txbx = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.fname_txbx = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.passport_txbx = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.issue_txbx = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.phone_txbx = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.address_txbx = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // save_btn
            // 
            this.save_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.save_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.save_btn.Depth = 0;
            this.save_btn.Icon = null;
            this.save_btn.Location = new System.Drawing.Point(818, 671);
            this.save_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.save_btn.Name = "save_btn";
            this.save_btn.Primary = true;
            this.save_btn.Size = new System.Drawing.Size(298, 36);
            this.save_btn.TabIndex = 11;
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
            this.edit_btn.Location = new System.Drawing.Point(819, 587);
            this.edit_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Primary = true;
            this.edit_btn.Size = new System.Drawing.Size(297, 36);
            this.edit_btn.TabIndex = 9;
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
            this.delete_btn.Location = new System.Drawing.Point(819, 629);
            this.delete_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Primary = true;
            this.delete_btn.Size = new System.Drawing.Size(297, 36);
            this.delete_btn.TabIndex = 10;
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
            this.add_btn.Location = new System.Drawing.Point(819, 545);
            this.add_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.add_btn.Name = "add_btn";
            this.add_btn.Primary = true;
            this.add_btn.Size = new System.Drawing.Size(297, 36);
            this.add_btn.TabIndex = 8;
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
            this.exit_btn.Location = new System.Drawing.Point(818, 713);
            this.exit_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Primary = true;
            this.exit_btn.Size = new System.Drawing.Size(299, 36);
            this.exit_btn.TabIndex = 12;
            this.exit_btn.Text = "Выход";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.ExitBtnClick);
            // 
            // errorsLbl
            // 
            this.errorsLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.errorsLbl.BackColor = System.Drawing.Color.Transparent;
            this.errorsLbl.Depth = 0;
            this.errorsLbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.errorsLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.errorsLbl.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.errorsLbl.Location = new System.Drawing.Point(820, 416);
            this.errorsLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.errorsLbl.Name = "errorsLbl";
            this.errorsLbl.Size = new System.Drawing.Size(294, 126);
            this.errorsLbl.TabIndex = 58;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(816, 72);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(75, 19);
            this.materialLabel1.TabIndex = 59;
            this.materialLabel1.Text = "Фамилия";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // patronymic_txbx
            // 
            this.patronymic_txbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.patronymic_txbx.Depth = 0;
            this.patronymic_txbx.Hint = "";
            this.patronymic_txbx.Location = new System.Drawing.Point(816, 193);
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
            // materialLabel3
            // 
            this.materialLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(816, 174);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(75, 19);
            this.materialLabel3.TabIndex = 61;
            this.materialLabel3.Text = "Отчество";
            this.materialLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.dgv.Size = new System.Drawing.Size(795, 652);
            this.dgv.TabIndex = 14;
            this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
            this.dgv.SelectionChanged += new System.EventHandler(this.DataGridSelectionChanged);
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
            // materialLabel2
            // 
            this.materialLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(816, 124);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(39, 19);
            this.materialLabel2.TabIndex = 62;
            this.materialLabel2.Text = "Имя";
            this.materialLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // search_txbx
            // 
            this.search_txbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.search_txbx.Depth = 0;
            this.search_txbx.Hint = "Для поиска введите ФИО или тел. номер или паспорт и нажмите enter";
            this.search_txbx.Location = new System.Drawing.Point(12, 68);
            this.search_txbx.MaxLength = 32767;
            this.search_txbx.MouseState = MaterialSkin.MouseState.HOVER;
            this.search_txbx.Name = "search_txbx";
            this.search_txbx.PasswordChar = '\0';
            this.search_txbx.SelectedText = "";
            this.search_txbx.SelectionLength = 0;
            this.search_txbx.SelectionStart = 0;
            this.search_txbx.Size = new System.Drawing.Size(795, 23);
            this.search_txbx.TabIndex = 13;
            this.search_txbx.TabStop = false;
            this.search_txbx.UseSystemPasswordChar = false;
            this.search_txbx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchKeyDown);
            // 
            // fname_txbx
            // 
            this.fname_txbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fname_txbx.Depth = 0;
            this.fname_txbx.Hint = "";
            this.fname_txbx.Location = new System.Drawing.Point(816, 145);
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
            // materialLabel4
            // 
            this.materialLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(816, 223);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(69, 19);
            this.materialLabel4.TabIndex = 61;
            this.materialLabel4.Text = "Паспорт";
            this.materialLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // passport_txbx
            // 
            this.passport_txbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.passport_txbx.Depth = 0;
            this.passport_txbx.Hint = "";
            this.passport_txbx.Location = new System.Drawing.Point(816, 241);
            this.passport_txbx.MaxLength = 32767;
            this.passport_txbx.MouseState = MaterialSkin.MouseState.HOVER;
            this.passport_txbx.Name = "passport_txbx";
            this.passport_txbx.PasswordChar = '\0';
            this.passport_txbx.SelectedText = "";
            this.passport_txbx.SelectionLength = 0;
            this.passport_txbx.SelectionStart = 0;
            this.passport_txbx.Size = new System.Drawing.Size(298, 23);
            this.passport_txbx.TabIndex = 4;
            this.passport_txbx.TabStop = false;
            this.passport_txbx.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(816, 272);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(56, 19);
            this.materialLabel5.TabIndex = 61;
            this.materialLabel5.Text = "Выдан";
            this.materialLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // issue_txbx
            // 
            this.issue_txbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.issue_txbx.Depth = 0;
            this.issue_txbx.Hint = "";
            this.issue_txbx.Location = new System.Drawing.Point(816, 289);
            this.issue_txbx.MaxLength = 32767;
            this.issue_txbx.MouseState = MaterialSkin.MouseState.HOVER;
            this.issue_txbx.Name = "issue_txbx";
            this.issue_txbx.PasswordChar = '\0';
            this.issue_txbx.SelectedText = "";
            this.issue_txbx.SelectionLength = 0;
            this.issue_txbx.SelectionStart = 0;
            this.issue_txbx.Size = new System.Drawing.Size(298, 23);
            this.issue_txbx.TabIndex = 5;
            this.issue_txbx.TabStop = false;
            this.issue_txbx.UseSystemPasswordChar = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(816, 320);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(72, 19);
            this.materialLabel6.TabIndex = 61;
            this.materialLabel6.Text = "Телефон";
            this.materialLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // phone_txbx
            // 
            this.phone_txbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.phone_txbx.Depth = 0;
            this.phone_txbx.Hint = "";
            this.phone_txbx.Location = new System.Drawing.Point(816, 337);
            this.phone_txbx.MaxLength = 32767;
            this.phone_txbx.MouseState = MaterialSkin.MouseState.HOVER;
            this.phone_txbx.Name = "phone_txbx";
            this.phone_txbx.PasswordChar = '\0';
            this.phone_txbx.SelectedText = "";
            this.phone_txbx.SelectionLength = 0;
            this.phone_txbx.SelectionStart = 0;
            this.phone_txbx.Size = new System.Drawing.Size(298, 23);
            this.phone_txbx.TabIndex = 6;
            this.phone_txbx.TabStop = false;
            this.phone_txbx.UseSystemPasswordChar = false;
            // 
            // materialLabel7
            // 
            this.materialLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(813, 368);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(52, 19);
            this.materialLabel7.TabIndex = 61;
            this.materialLabel7.Text = "Адрес";
            this.materialLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // address_txbx
            // 
            this.address_txbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.address_txbx.Depth = 0;
            this.address_txbx.Hint = "";
            this.address_txbx.Location = new System.Drawing.Point(816, 385);
            this.address_txbx.MaxLength = 32767;
            this.address_txbx.MouseState = MaterialSkin.MouseState.HOVER;
            this.address_txbx.Name = "address_txbx";
            this.address_txbx.PasswordChar = '\0';
            this.address_txbx.SelectedText = "";
            this.address_txbx.SelectionLength = 0;
            this.address_txbx.SelectionStart = 0;
            this.address_txbx.Size = new System.Drawing.Size(298, 23);
            this.address_txbx.TabIndex = 7;
            this.address_txbx.TabStop = false;
            this.address_txbx.UseSystemPasswordChar = false;
            // 
            // ParentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 761);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.errorsLbl);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.address_txbx);
            this.Controls.Add(this.phone_txbx);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.issue_txbx);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.passport_txbx);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.patronymic_txbx);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.lname_txbx);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.search_txbx);
            this.Controls.Add(this.fname_txbx);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ParentsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Родители";
            this.Load += new System.EventHandler(this.ParentsFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem refreshDataContextItem;
        private System.Windows.Forms.ToolStripMenuItem editContextItem;
        private System.Windows.Forms.ToolStripMenuItem addNewContextItem;
        private System.Windows.Forms.ToolStripMenuItem deleteContextItem;
        private ResizebleMaterialRaisedButton save_btn;
        private ResizebleMaterialRaisedButton edit_btn;
        private ResizebleMaterialRaisedButton delete_btn;
        private ResizebleMaterialRaisedButton add_btn;
        private ResizebleMaterialRaisedButton exit_btn;
        private MaterialSkin.Controls.MaterialLabel errorsLbl;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField patronymic_txbx;
        private MaterialSkin.Controls.MaterialSingleLineTextField lname_txbx;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField search_txbx;
        private MaterialSkin.Controls.MaterialSingleLineTextField fname_txbx;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField passport_txbx;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialSingleLineTextField issue_txbx;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialSingleLineTextField phone_txbx;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialSingleLineTextField address_txbx;
    }
}