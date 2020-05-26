namespace KinderGarten.Views
{
    partial class MealTimeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MealTimeForm));
            this.errorsLbl = new MaterialSkin.Controls.MaterialLabel();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewContextItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editContextItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteContextItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshDataContextItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.search_txbx = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.delete_btn = new KinderGarten.Views.ResizebleMaterialRaisedButton();
            this.add_btn = new KinderGarten.Views.ResizebleMaterialRaisedButton();
            this.exit_btn = new KinderGarten.Views.ResizebleMaterialRaisedButton();
            this.save_btn = new KinderGarten.Views.ResizebleMaterialRaisedButton();
            this.edit_btn = new KinderGarten.Views.ResizebleMaterialRaisedButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.text_txbx = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.time_txbx = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.contextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // errorsLbl
            // 
            this.errorsLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.errorsLbl.BackColor = System.Drawing.Color.Transparent;
            this.errorsLbl.Depth = 0;
            this.errorsLbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.errorsLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.errorsLbl.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.errorsLbl.Location = new System.Drawing.Point(411, 199);
            this.errorsLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.errorsLbl.Name = "errorsLbl";
            this.errorsLbl.Size = new System.Drawing.Size(298, 88);
            this.errorsLbl.TabIndex = 33;
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
            // dgv
            // 
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.ContextMenuStrip = this.contextMenu;
            this.dgv.Location = new System.Drawing.Point(12, 105);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(376, 452);
            this.dgv.TabIndex = 9;
            this.dgv.SelectionChanged += new System.EventHandler(this.DataGridSelectionChanged);
            // 
            // search_txbx
            // 
            this.search_txbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.search_txbx.Depth = 0;
            this.search_txbx.Hint = "Для поиска введите название и нажмите enter";
            this.search_txbx.Location = new System.Drawing.Point(12, 76);
            this.search_txbx.MaxLength = 32767;
            this.search_txbx.MouseState = MaterialSkin.MouseState.HOVER;
            this.search_txbx.Name = "search_txbx";
            this.search_txbx.PasswordChar = '\0';
            this.search_txbx.SelectedText = "";
            this.search_txbx.SelectionLength = 0;
            this.search_txbx.SelectionStart = 0;
            this.search_txbx.Size = new System.Drawing.Size(376, 23);
            this.search_txbx.TabIndex = 8;
            this.search_txbx.TabStop = false;
            this.search_txbx.UseSystemPasswordChar = false;
            this.search_txbx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchKeyDown);
            // 
            // delete_btn
            // 
            this.delete_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delete_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.delete_btn.Depth = 0;
            this.delete_btn.Icon = null;
            this.delete_btn.Location = new System.Drawing.Point(412, 374);
            this.delete_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Primary = true;
            this.delete_btn.Size = new System.Drawing.Size(297, 36);
            this.delete_btn.TabIndex = 5;
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
            this.add_btn.Location = new System.Drawing.Point(412, 290);
            this.add_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.add_btn.Name = "add_btn";
            this.add_btn.Primary = true;
            this.add_btn.Size = new System.Drawing.Size(297, 36);
            this.add_btn.TabIndex = 3;
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
            this.exit_btn.Location = new System.Drawing.Point(410, 521);
            this.exit_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Primary = true;
            this.exit_btn.Size = new System.Drawing.Size(299, 36);
            this.exit_btn.TabIndex = 7;
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
            this.save_btn.Location = new System.Drawing.Point(411, 416);
            this.save_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.save_btn.Name = "save_btn";
            this.save_btn.Primary = true;
            this.save_btn.Size = new System.Drawing.Size(298, 36);
            this.save_btn.TabIndex = 6;
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
            this.edit_btn.Location = new System.Drawing.Point(412, 332);
            this.edit_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Primary = true;
            this.edit_btn.Size = new System.Drawing.Size(297, 36);
            this.edit_btn.TabIndex = 4;
            this.edit_btn.Text = "Редактировать";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.EditBtnClick);
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(411, 76);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(79, 19);
            this.materialLabel1.TabIndex = 34;
            this.materialLabel1.Text = "Название";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // text_txbx
            // 
            this.text_txbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.text_txbx.Depth = 0;
            this.text_txbx.Hint = "";
            this.text_txbx.Location = new System.Drawing.Point(411, 105);
            this.text_txbx.MaxLength = 32767;
            this.text_txbx.MouseState = MaterialSkin.MouseState.HOVER;
            this.text_txbx.Name = "text_txbx";
            this.text_txbx.PasswordChar = '\0';
            this.text_txbx.SelectedText = "";
            this.text_txbx.SelectionLength = 0;
            this.text_txbx.SelectionStart = 0;
            this.text_txbx.Size = new System.Drawing.Size(298, 23);
            this.text_txbx.TabIndex = 1;
            this.text_txbx.TabStop = false;
            this.text_txbx.UseSystemPasswordChar = false;
            // 
            // time_txbx
            // 
            this.time_txbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.time_txbx.Depth = 0;
            this.time_txbx.Hint = "чч:мм";
            this.time_txbx.Location = new System.Drawing.Point(412, 163);
            this.time_txbx.MaxLength = 32767;
            this.time_txbx.MouseState = MaterialSkin.MouseState.HOVER;
            this.time_txbx.Name = "time_txbx";
            this.time_txbx.PasswordChar = '\0';
            this.time_txbx.SelectedText = "";
            this.time_txbx.SelectionLength = 0;
            this.time_txbx.SelectionStart = 0;
            this.time_txbx.Size = new System.Drawing.Size(298, 23);
            this.time_txbx.TabIndex = 2;
            this.time_txbx.TabStop = false;
            this.time_txbx.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(412, 134);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(53, 19);
            this.materialLabel2.TabIndex = 34;
            this.materialLabel2.Text = "Время";
            this.materialLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MealTimeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 578);
            this.Controls.Add(this.errorsLbl);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.search_txbx);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.time_txbx);
            this.Controls.Add(this.text_txbx);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MealTimeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Время приемов пищи";
            this.Load += new System.EventHandler(this.MealTimesFormLoad);
            this.contextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel errorsLbl;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem addNewContextItem;
        private System.Windows.Forms.ToolStripMenuItem editContextItem;
        private System.Windows.Forms.ToolStripMenuItem deleteContextItem;
        private System.Windows.Forms.ToolStripMenuItem refreshDataContextItem;
        private System.Windows.Forms.DataGridView dgv;
        private MaterialSkin.Controls.MaterialSingleLineTextField search_txbx;
        private ResizebleMaterialRaisedButton delete_btn;
        private ResizebleMaterialRaisedButton add_btn;
        private ResizebleMaterialRaisedButton exit_btn;
        private ResizebleMaterialRaisedButton save_btn;
        private ResizebleMaterialRaisedButton edit_btn;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField text_txbx;
        private MaterialSkin.Controls.MaterialSingleLineTextField time_txbx;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}