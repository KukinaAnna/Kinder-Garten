namespace KinderGarten.Views
{
    partial class GroupsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupsForm));
            this.save_btn = new KinderGarten.Views.ResizebleMaterialRaisedButton();
            this.edit_btn = new KinderGarten.Views.ResizebleMaterialRaisedButton();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewContextItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editContextItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteContextItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshDataContextItem = new System.Windows.Forms.ToolStripMenuItem();
            this.search_txbx = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.delete_btn = new KinderGarten.Views.ResizebleMaterialRaisedButton();
            this.add_btn = new KinderGarten.Views.ResizebleMaterialRaisedButton();
            this.exit_btn = new KinderGarten.Views.ResizebleMaterialRaisedButton();
            this.errorsLbl = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.text_txbx = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.year_txbx = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.resizebleMaterialRaisedButton1 = new KinderGarten.Views.ResizebleMaterialRaisedButton();
            this.contextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // save_btn
            // 
            this.save_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.save_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.save_btn.Depth = 0;
            this.save_btn.Icon = null;
            this.save_btn.Location = new System.Drawing.Point(935, 392);
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
            this.edit_btn.Location = new System.Drawing.Point(936, 308);
            this.edit_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Primary = true;
            this.edit_btn.Size = new System.Drawing.Size(297, 36);
            this.edit_btn.TabIndex = 4;
            this.edit_btn.Text = "Редактировать";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.EditBtnClick);
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
            this.search_txbx.Hint = "Для поиска введите название и нажмите enter";
            this.search_txbx.Location = new System.Drawing.Point(12, 73);
            this.search_txbx.MaxLength = 32767;
            this.search_txbx.MouseState = MaterialSkin.MouseState.HOVER;
            this.search_txbx.Name = "search_txbx";
            this.search_txbx.PasswordChar = '\0';
            this.search_txbx.SelectedText = "";
            this.search_txbx.SelectionLength = 0;
            this.search_txbx.SelectionStart = 0;
            this.search_txbx.Size = new System.Drawing.Size(416, 23);
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
            this.delete_btn.Location = new System.Drawing.Point(936, 350);
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
            this.add_btn.Location = new System.Drawing.Point(936, 266);
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
            this.exit_btn.Location = new System.Drawing.Point(934, 623);
            this.exit_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Primary = true;
            this.exit_btn.Size = new System.Drawing.Size(299, 36);
            this.exit_btn.TabIndex = 7;
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
            this.errorsLbl.Location = new System.Drawing.Point(935, 189);
            this.errorsLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.errorsLbl.Name = "errorsLbl";
            this.errorsLbl.Size = new System.Drawing.Size(298, 74);
            this.errorsLbl.TabIndex = 33;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(935, 73);
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
            this.text_txbx.Location = new System.Drawing.Point(935, 102);
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
            // dgv
            // 
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.ContextMenuStrip = this.contextMenu;
            this.dgv.Location = new System.Drawing.Point(12, 102);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(416, 557);
            this.dgv.TabIndex = 25;
            // 
            // year_txbx
            // 
            this.year_txbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.year_txbx.Depth = 0;
            this.year_txbx.Hint = "";
            this.year_txbx.Location = new System.Drawing.Point(935, 163);
            this.year_txbx.MaxLength = 32767;
            this.year_txbx.MouseState = MaterialSkin.MouseState.HOVER;
            this.year_txbx.Name = "year_txbx";
            this.year_txbx.PasswordChar = '\0';
            this.year_txbx.SelectedText = "";
            this.year_txbx.SelectionLength = 0;
            this.year_txbx.SelectionStart = 0;
            this.year_txbx.Size = new System.Drawing.Size(298, 23);
            this.year_txbx.TabIndex = 2;
            this.year_txbx.TabStop = false;
            this.year_txbx.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(935, 134);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(110, 19);
            this.materialLabel2.TabIndex = 34;
            this.materialLabel2.Text = "Год рождения";
            this.materialLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(434, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(494, 557);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(434, 73);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(171, 19);
            this.materialLabel3.TabIndex = 35;
            this.materialLabel3.Text = "Воспитанники группы:";
            // 
            // resizebleMaterialRaisedButton1
            // 
            this.resizebleMaterialRaisedButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.resizebleMaterialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.resizebleMaterialRaisedButton1.Depth = 0;
            this.resizebleMaterialRaisedButton1.Icon = null;
            this.resizebleMaterialRaisedButton1.Location = new System.Drawing.Point(934, 581);
            this.resizebleMaterialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.resizebleMaterialRaisedButton1.Name = "resizebleMaterialRaisedButton1";
            this.resizebleMaterialRaisedButton1.Primary = true;
            this.resizebleMaterialRaisedButton1.Size = new System.Drawing.Size(298, 36);
            this.resizebleMaterialRaisedButton1.TabIndex = 6;
            this.resizebleMaterialRaisedButton1.Text = "Печать";
            this.resizebleMaterialRaisedButton1.UseVisualStyleBackColor = true;
            this.resizebleMaterialRaisedButton1.Click += new System.EventHandler(this.resizebleMaterialRaisedButton1_Click);
            // 
            // GroupsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 671);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.resizebleMaterialRaisedButton1);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.search_txbx);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.errorsLbl);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.year_txbx);
            this.Controls.Add(this.text_txbx);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dgv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(715, 481);
            this.Name = "GroupsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Группы";
            this.Load += new System.EventHandler(this.GroupsFormLoad);
            this.contextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem addNewContextItem;
        private System.Windows.Forms.ToolStripMenuItem editContextItem;
        private System.Windows.Forms.ToolStripMenuItem deleteContextItem;
        private System.Windows.Forms.ToolStripMenuItem refreshDataContextItem;
        private MaterialSkin.Controls.MaterialSingleLineTextField search_txbx;
        private MaterialSkin.Controls.MaterialLabel errorsLbl;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField text_txbx;
        private System.Windows.Forms.DataGridView dgv;
        private MaterialSkin.Controls.MaterialSingleLineTextField year_txbx;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private ResizebleMaterialRaisedButton save_btn;
        private ResizebleMaterialRaisedButton edit_btn;
        private ResizebleMaterialRaisedButton delete_btn;
        private ResizebleMaterialRaisedButton add_btn;
        private ResizebleMaterialRaisedButton exit_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private ResizebleMaterialRaisedButton resizebleMaterialRaisedButton1;
    }
}