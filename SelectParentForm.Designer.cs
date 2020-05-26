namespace KinderGarten.Views
{
    partial class SelectParentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectParentForm));
            this.dgv = new System.Windows.Forms.DataGridView();
            this.search_txbx = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.resizebleMaterialRaisedButton1 = new KinderGarten.Views.ResizebleMaterialRaisedButton();
            this.add_btn = new KinderGarten.Views.ResizebleMaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 115);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(771, 318);
            this.dgv.TabIndex = 16;
            // 
            // search_txbx
            // 
            this.search_txbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.search_txbx.Depth = 0;
            this.search_txbx.Hint = "Для поиска введите ФИО или тел. номер или паспорт и нажмите enter";
            this.search_txbx.Location = new System.Drawing.Point(12, 86);
            this.search_txbx.MaxLength = 32767;
            this.search_txbx.MouseState = MaterialSkin.MouseState.HOVER;
            this.search_txbx.Name = "search_txbx";
            this.search_txbx.PasswordChar = '\0';
            this.search_txbx.SelectedText = "";
            this.search_txbx.SelectionLength = 0;
            this.search_txbx.SelectionStart = 0;
            this.search_txbx.Size = new System.Drawing.Size(771, 23);
            this.search_txbx.TabIndex = 15;
            this.search_txbx.TabStop = false;
            this.search_txbx.UseSystemPasswordChar = false;
            this.search_txbx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchKeyDown);
            // 
            // resizebleMaterialRaisedButton1
            // 
            this.resizebleMaterialRaisedButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.resizebleMaterialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.resizebleMaterialRaisedButton1.Depth = 0;
            this.resizebleMaterialRaisedButton1.Icon = null;
            this.resizebleMaterialRaisedButton1.Location = new System.Drawing.Point(635, 439);
            this.resizebleMaterialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.resizebleMaterialRaisedButton1.Name = "resizebleMaterialRaisedButton1";
            this.resizebleMaterialRaisedButton1.Primary = true;
            this.resizebleMaterialRaisedButton1.Size = new System.Drawing.Size(148, 36);
            this.resizebleMaterialRaisedButton1.TabIndex = 28;
            this.resizebleMaterialRaisedButton1.Text = "Отмена";
            this.resizebleMaterialRaisedButton1.UseVisualStyleBackColor = true;
            this.resizebleMaterialRaisedButton1.Click += new System.EventHandler(this.ExitBtnClick);
            // 
            // add_btn
            // 
            this.add_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.add_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.add_btn.Depth = 0;
            this.add_btn.Icon = null;
            this.add_btn.Location = new System.Drawing.Point(485, 439);
            this.add_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.add_btn.Name = "add_btn";
            this.add_btn.Primary = true;
            this.add_btn.Size = new System.Drawing.Size(144, 36);
            this.add_btn.TabIndex = 29;
            this.add_btn.Text = "Добавить";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // SelectParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 496);
            this.Controls.Add(this.resizebleMaterialRaisedButton1);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.search_txbx);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectParentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбрать родителя";
            this.Load += new System.EventHandler(this.SelectParentFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private MaterialSkin.Controls.MaterialSingleLineTextField search_txbx;
        private ResizebleMaterialRaisedButton resizebleMaterialRaisedButton1;
        private ResizebleMaterialRaisedButton add_btn;
    }
}