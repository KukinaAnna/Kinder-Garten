namespace KinderGarten.Views
{
    partial class RangeDatePickerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RangeDatePickerForm));
            this.errorsLbl = new MaterialSkin.Controls.MaterialLabel();
            this.save_btn = new KinderGarten.Views.ResizebleMaterialRaisedButton();
            this.exit_btn = new KinderGarten.Views.ResizebleMaterialRaisedButton();
            this.end_txbx = new KinderGarten.Views.MaterialDateTimePicker();
            this.start_txbx = new KinderGarten.Views.MaterialDateTimePicker();
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
            this.errorsLbl.Location = new System.Drawing.Point(16, 102);
            this.errorsLbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.errorsLbl.Name = "errorsLbl";
            this.errorsLbl.Size = new System.Drawing.Size(343, 62);
            this.errorsLbl.TabIndex = 34;
            // 
            // save_btn
            // 
            this.save_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.save_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.save_btn.Depth = 0;
            this.save_btn.Icon = null;
            this.save_btn.Location = new System.Drawing.Point(12, 203);
            this.save_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.save_btn.Name = "save_btn";
            this.save_btn.Primary = true;
            this.save_btn.Size = new System.Drawing.Size(168, 36);
            this.save_btn.TabIndex = 25;
            this.save_btn.Text = "Выбрать";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exit_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.exit_btn.Depth = 0;
            this.exit_btn.Icon = null;
            this.exit_btn.Location = new System.Drawing.Point(186, 203);
            this.exit_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Primary = true;
            this.exit_btn.Size = new System.Drawing.Size(173, 36);
            this.exit_btn.TabIndex = 24;
            this.exit_btn.Text = "Выход";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // end_txbx
            // 
            this.end_txbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.end_txbx.Format = "dd/MM/yyyy";
            this.end_txbx.Hint = null;
            this.end_txbx.Location = new System.Drawing.Point(213, 76);
            this.end_txbx.Name = "end_txbx";
            this.end_txbx.Size = new System.Drawing.Size(146, 23);
            this.end_txbx.TabIndex = 2;
            // 
            // start_txbx
            // 
            this.start_txbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.start_txbx.Format = "dd/MM/yyyy";
            this.start_txbx.Hint = null;
            this.start_txbx.Location = new System.Drawing.Point(20, 76);
            this.start_txbx.Name = "start_txbx";
            this.start_txbx.Size = new System.Drawing.Size(146, 23);
            this.start_txbx.TabIndex = 1;
            // 
            // RangeDatePickerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 251);
            this.Controls.Add(this.errorsLbl);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.end_txbx);
            this.Controls.Add(this.start_txbx);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RangeDatePickerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбрать диапазон дат";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialDateTimePicker start_txbx;
        private MaterialDateTimePicker end_txbx;
        private ResizebleMaterialRaisedButton exit_btn;
        private ResizebleMaterialRaisedButton save_btn;
        private MaterialSkin.Controls.MaterialLabel errorsLbl;
    }
}