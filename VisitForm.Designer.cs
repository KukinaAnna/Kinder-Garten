namespace KinderGarten.Views
{
    partial class VisitForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisitForm));
            this.refreshDataContextItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editContextItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewContextItem = new System.Windows.Forms.ToolStripMenuItem();
            this.status_cmbx = new System.Windows.Forms.ComboBox();
            this.child_cmbx = new System.Windows.Forms.ComboBox();
            this.deleteContextItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.errorsLbl = new MaterialSkin.Controls.MaterialLabel();
            this.start_chbx = new MaterialSkin.Controls.MaterialCheckBox();
            this.end_chbx = new MaterialSkin.Controls.MaterialCheckBox();
            this.child_chbx = new MaterialSkin.Controls.MaterialCheckBox();
            this.status_chbx = new MaterialSkin.Controls.MaterialCheckBox();
            this.end_txbx = new KinderGarten.Views.MaterialDateTimePicker();
            this.start_txbx = new KinderGarten.Views.MaterialDateTimePicker();
            this.exit_btn = new KinderGarten.Views.ResizebleMaterialRaisedButton();
            this.printBtn = new KinderGarten.Views.ResizebleMaterialRaisedButton();
            this.save_btn = new KinderGarten.Views.ResizebleMaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // refreshDataContextItem
            // 
            this.refreshDataContextItem.Image = global::KinderGarten.Properties.Resources.refresh;
            this.refreshDataContextItem.Name = "refreshDataContextItem";
            this.refreshDataContextItem.Size = new System.Drawing.Size(193, 26);
            this.refreshDataContextItem.Text = "ОБНОВИТЬ ДАННЫЕ";
            // 
            // editContextItem
            // 
            this.editContextItem.Image = global::KinderGarten.Properties.Resources.pencil;
            this.editContextItem.Name = "editContextItem";
            this.editContextItem.Size = new System.Drawing.Size(193, 26);
            this.editContextItem.Text = "РЕДАКТИРОВАТЬ";
            // 
            // addNewContextItem
            // 
            this.addNewContextItem.Image = global::KinderGarten.Properties.Resources.plus_thick;
            this.addNewContextItem.Name = "addNewContextItem";
            this.addNewContextItem.Size = new System.Drawing.Size(193, 26);
            this.addNewContextItem.Text = "ДОБАВИТЬ";
            // 
            // status_cmbx
            // 
            this.status_cmbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.status_cmbx.BackColor = System.Drawing.SystemColors.Control;
            this.status_cmbx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.status_cmbx.FormattingEnabled = true;
            this.status_cmbx.ItemHeight = 13;
            this.status_cmbx.Location = new System.Drawing.Point(611, 217);
            this.status_cmbx.Name = "status_cmbx";
            this.status_cmbx.Size = new System.Drawing.Size(298, 21);
            this.status_cmbx.TabIndex = 66;
            // 
            // child_cmbx
            // 
            this.child_cmbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.child_cmbx.BackColor = System.Drawing.SystemColors.Control;
            this.child_cmbx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.child_cmbx.FormattingEnabled = true;
            this.child_cmbx.ItemHeight = 13;
            this.child_cmbx.Location = new System.Drawing.Point(611, 160);
            this.child_cmbx.Name = "child_cmbx";
            this.child_cmbx.Size = new System.Drawing.Size(298, 21);
            this.child_cmbx.TabIndex = 65;
            // 
            // deleteContextItem
            // 
            this.deleteContextItem.Image = global::KinderGarten.Properties.Resources.delete_alert;
            this.deleteContextItem.Name = "deleteContextItem";
            this.deleteContextItem.Size = new System.Drawing.Size(193, 26);
            this.deleteContextItem.Text = "УДАЛИТЬ";
            // 
            // dgv
            // 
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.ContextMenuStrip = this.contextMenu;
            this.dgv.Location = new System.Drawing.Point(12, 68);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(578, 639);
            this.dgv.TabIndex = 49;
            this.dgv.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgv_DataBindingComplete);
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
            // errorsLbl
            // 
            this.errorsLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.errorsLbl.BackColor = System.Drawing.Color.Transparent;
            this.errorsLbl.Depth = 0;
            this.errorsLbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.errorsLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.errorsLbl.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.errorsLbl.Location = new System.Drawing.Point(612, 241);
            this.errorsLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.errorsLbl.Name = "errorsLbl";
            this.errorsLbl.Size = new System.Drawing.Size(298, 133);
            this.errorsLbl.TabIndex = 58;
            // 
            // start_chbx
            // 
            this.start_chbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.start_chbx.AutoSize = true;
            this.start_chbx.Depth = 0;
            this.start_chbx.Font = new System.Drawing.Font("Roboto", 10F);
            this.start_chbx.Location = new System.Drawing.Point(611, 68);
            this.start_chbx.Margin = new System.Windows.Forms.Padding(0);
            this.start_chbx.MouseLocation = new System.Drawing.Point(-1, -1);
            this.start_chbx.MouseState = MaterialSkin.MouseState.HOVER;
            this.start_chbx.Name = "start_chbx";
            this.start_chbx.Ripple = true;
            this.start_chbx.Size = new System.Drawing.Size(73, 30);
            this.start_chbx.TabIndex = 70;
            this.start_chbx.Text = "Дата с";
            this.start_chbx.UseVisualStyleBackColor = true;
            this.start_chbx.CheckedChanged += new System.EventHandler(this.start_chbx_CheckedChanged);
            // 
            // end_chbx
            // 
            this.end_chbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.end_chbx.AutoSize = true;
            this.end_chbx.Depth = 0;
            this.end_chbx.Font = new System.Drawing.Font("Roboto", 10F);
            this.end_chbx.Location = new System.Drawing.Point(755, 68);
            this.end_chbx.Margin = new System.Windows.Forms.Padding(0);
            this.end_chbx.MouseLocation = new System.Drawing.Point(-1, -1);
            this.end_chbx.MouseState = MaterialSkin.MouseState.HOVER;
            this.end_chbx.Name = "end_chbx";
            this.end_chbx.Ripple = true;
            this.end_chbx.Size = new System.Drawing.Size(81, 30);
            this.end_chbx.TabIndex = 70;
            this.end_chbx.Text = "Дата по";
            this.end_chbx.UseVisualStyleBackColor = true;
            this.end_chbx.CheckedChanged += new System.EventHandler(this.end_chbx_CheckedChanged);
            // 
            // child_chbx
            // 
            this.child_chbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.child_chbx.AutoSize = true;
            this.child_chbx.Depth = 0;
            this.child_chbx.Font = new System.Drawing.Font("Roboto", 10F);
            this.child_chbx.Location = new System.Drawing.Point(611, 127);
            this.child_chbx.Margin = new System.Windows.Forms.Padding(0);
            this.child_chbx.MouseLocation = new System.Drawing.Point(-1, -1);
            this.child_chbx.MouseState = MaterialSkin.MouseState.HOVER;
            this.child_chbx.Name = "child_chbx";
            this.child_chbx.Ripple = true;
            this.child_chbx.Size = new System.Drawing.Size(115, 30);
            this.child_chbx.TabIndex = 70;
            this.child_chbx.Text = "Воспитанник";
            this.child_chbx.UseVisualStyleBackColor = true;
            this.child_chbx.CheckedChanged += new System.EventHandler(this.child_chbx_CheckedChanged);
            // 
            // status_chbx
            // 
            this.status_chbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.status_chbx.AutoSize = true;
            this.status_chbx.Depth = 0;
            this.status_chbx.Font = new System.Drawing.Font("Roboto", 10F);
            this.status_chbx.Location = new System.Drawing.Point(611, 184);
            this.status_chbx.Margin = new System.Windows.Forms.Padding(0);
            this.status_chbx.MouseLocation = new System.Drawing.Point(-1, -1);
            this.status_chbx.MouseState = MaterialSkin.MouseState.HOVER;
            this.status_chbx.Name = "status_chbx";
            this.status_chbx.Ripple = true;
            this.status_chbx.Size = new System.Drawing.Size(74, 30);
            this.status_chbx.TabIndex = 70;
            this.status_chbx.Text = "Статус";
            this.status_chbx.UseVisualStyleBackColor = true;
            this.status_chbx.CheckedChanged += new System.EventHandler(this.status_chbx_CheckedChanged);
            // 
            // end_txbx
            // 
            this.end_txbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.end_txbx.Format = "dd/MM/yyyy";
            this.end_txbx.Hint = null;
            this.end_txbx.Location = new System.Drawing.Point(755, 101);
            this.end_txbx.Name = "end_txbx";
            this.end_txbx.Size = new System.Drawing.Size(155, 23);
            this.end_txbx.TabIndex = 62;
            // 
            // start_txbx
            // 
            this.start_txbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.start_txbx.Format = "dd/MM/yyyy";
            this.start_txbx.Hint = null;
            this.start_txbx.Location = new System.Drawing.Point(611, 101);
            this.start_txbx.Name = "start_txbx";
            this.start_txbx.Size = new System.Drawing.Size(138, 23);
            this.start_txbx.TabIndex = 62;
            // 
            // exit_btn
            // 
            this.exit_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exit_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.exit_btn.Depth = 0;
            this.exit_btn.Icon = null;
            this.exit_btn.Location = new System.Drawing.Point(612, 671);
            this.exit_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Primary = true;
            this.exit_btn.Size = new System.Drawing.Size(299, 36);
            this.exit_btn.TabIndex = 57;
            this.exit_btn.Text = "Выход";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.ExitBtnClick);
            // 
            // printBtn
            // 
            this.printBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.printBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.printBtn.Depth = 0;
            this.printBtn.Icon = null;
            this.printBtn.Location = new System.Drawing.Point(610, 419);
            this.printBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.printBtn.Name = "printBtn";
            this.printBtn.Primary = true;
            this.printBtn.Size = new System.Drawing.Size(298, 36);
            this.printBtn.TabIndex = 55;
            this.printBtn.Text = "Печать";
            this.printBtn.UseVisualStyleBackColor = true;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // save_btn
            // 
            this.save_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.save_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.save_btn.Depth = 0;
            this.save_btn.Icon = null;
            this.save_btn.Location = new System.Drawing.Point(611, 377);
            this.save_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.save_btn.Name = "save_btn";
            this.save_btn.Primary = true;
            this.save_btn.Size = new System.Drawing.Size(298, 36);
            this.save_btn.TabIndex = 54;
            this.save_btn.Text = "Поиск";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // VisitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 727);
            this.Controls.Add(this.end_chbx);
            this.Controls.Add(this.status_chbx);
            this.Controls.Add(this.child_chbx);
            this.Controls.Add(this.start_chbx);
            this.Controls.Add(this.status_cmbx);
            this.Controls.Add(this.child_cmbx);
            this.Controls.Add(this.end_txbx);
            this.Controls.Add(this.start_txbx);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.errorsLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VisitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Посещения";
            this.Load += new System.EventHandler(this.VisitFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem refreshDataContextItem;
        private System.Windows.Forms.ToolStripMenuItem editContextItem;
        private System.Windows.Forms.ToolStripMenuItem addNewContextItem;
        private System.Windows.Forms.ComboBox status_cmbx;
        private System.Windows.Forms.ComboBox child_cmbx;
        private MaterialDateTimePicker start_txbx;
        private System.Windows.Forms.ToolStripMenuItem deleteContextItem;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private ResizebleMaterialRaisedButton exit_btn;
        private ResizebleMaterialRaisedButton printBtn;
        private ResizebleMaterialRaisedButton save_btn;
        private MaterialSkin.Controls.MaterialLabel errorsLbl;
        private MaterialDateTimePicker end_txbx;
        private MaterialSkin.Controls.MaterialCheckBox start_chbx;
        private MaterialSkin.Controls.MaterialCheckBox end_chbx;
        private MaterialSkin.Controls.MaterialCheckBox child_chbx;
        private MaterialSkin.Controls.MaterialCheckBox status_chbx;
    }
}