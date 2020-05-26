namespace KinderGarten.Views
{
    partial class ParentsPropertiesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParentsPropertiesForm));
            this.dgv = new System.Windows.Forms.DataGridView();
            this.search_txbx = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.propdgv = new System.Windows.Forms.DataGridView();
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prop_cmbx = new System.Windows.Forms.ComboBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.text_txbx = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.add_btn = new KinderGarten.Views.ResizebleMaterialRaisedButton();
            this.exit_btn = new KinderGarten.Views.ResizebleMaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propdgv)).BeginInit();
            this.materialContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 97);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(776, 195);
            this.dgv.TabIndex = 15;
            this.dgv.SelectionChanged += new System.EventHandler(this.DgvSelectionChanged);
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
            this.search_txbx.Size = new System.Drawing.Size(776, 23);
            this.search_txbx.TabIndex = 16;
            this.search_txbx.TabStop = false;
            this.search_txbx.UseSystemPasswordChar = false;
            this.search_txbx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchKeyDown);
            // 
            // propdgv
            // 
            this.propdgv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.propdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.propdgv.ContextMenuStrip = this.materialContextMenuStrip1;
            this.propdgv.Location = new System.Drawing.Point(12, 374);
            this.propdgv.Name = "propdgv";
            this.propdgv.Size = new System.Drawing.Size(776, 153);
            this.propdgv.TabIndex = 15;
            // 
            // materialContextMenuStrip1
            // 
            this.materialContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip1.Depth = 0;
            this.materialContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.materialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            this.materialContextMenuStrip1.Size = new System.Drawing.Size(119, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::KinderGarten.Properties.Resources.delete_alert;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.deleteToolStripMenuItem.Text = "Удалить";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItemClick);
            // 
            // prop_cmbx
            // 
            this.prop_cmbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.prop_cmbx.BackColor = System.Drawing.SystemColors.Control;
            this.prop_cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.prop_cmbx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prop_cmbx.FormattingEnabled = true;
            this.prop_cmbx.ItemHeight = 13;
            this.prop_cmbx.Location = new System.Drawing.Point(12, 336);
            this.prop_cmbx.Name = "prop_cmbx";
            this.prop_cmbx.Size = new System.Drawing.Size(298, 21);
            this.prop_cmbx.TabIndex = 17;
            // 
            // materialLabel4
            // 
            this.materialLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(12, 317);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(79, 19);
            this.materialLabel4.TabIndex = 47;
            this.materialLabel4.Text = "Свойство";
            this.materialLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // text_txbx
            // 
            this.text_txbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.text_txbx.Depth = 0;
            this.text_txbx.Hint = "";
            this.text_txbx.Location = new System.Drawing.Point(316, 337);
            this.text_txbx.MaxLength = 32767;
            this.text_txbx.MouseState = MaterialSkin.MouseState.HOVER;
            this.text_txbx.Name = "text_txbx";
            this.text_txbx.PasswordChar = '\0';
            this.text_txbx.SelectedText = "";
            this.text_txbx.SelectionLength = 0;
            this.text_txbx.SelectionStart = 0;
            this.text_txbx.Size = new System.Drawing.Size(298, 23);
            this.text_txbx.TabIndex = 48;
            this.text_txbx.TabStop = false;
            this.text_txbx.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(316, 315);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(77, 19);
            this.materialLabel2.TabIndex = 49;
            this.materialLabel2.Text = "Значение";
            this.materialLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // add_btn
            // 
            this.add_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.add_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.add_btn.Depth = 0;
            this.add_btn.Icon = null;
            this.add_btn.Location = new System.Drawing.Point(620, 336);
            this.add_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.add_btn.Name = "add_btn";
            this.add_btn.Primary = true;
            this.add_btn.Size = new System.Drawing.Size(168, 24);
            this.add_btn.TabIndex = 51;
            this.add_btn.Text = "Добавить";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.AddBtnClick);
            // 
            // exit_btn
            // 
            this.exit_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exit_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.exit_btn.Depth = 0;
            this.exit_btn.Icon = null;
            this.exit_btn.Location = new System.Drawing.Point(12, 533);
            this.exit_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Primary = true;
            this.exit_btn.Size = new System.Drawing.Size(776, 36);
            this.exit_btn.TabIndex = 50;
            this.exit_btn.Text = "Выход";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.ExitBtnClick);
            // 
            // ParentsPropertiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 580);
            this.Controls.Add(this.text_txbx);
            this.Controls.Add(this.prop_cmbx);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.search_txbx);
            this.Controls.Add(this.propdgv);
            this.Controls.Add(this.dgv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ParentsPropertiesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Данные о родителях";
            this.Load += new System.EventHandler(this.ParentsPropertiesFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propdgv)).EndInit();
            this.materialContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private MaterialSkin.Controls.MaterialSingleLineTextField search_txbx;
        private System.Windows.Forms.DataGridView propdgv;
        private System.Windows.Forms.ComboBox prop_cmbx;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField text_txbx;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private ResizebleMaterialRaisedButton exit_btn;
        private ResizebleMaterialRaisedButton add_btn;
        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}