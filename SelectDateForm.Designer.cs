namespace KinderGarten.Views
{
    partial class SelectDateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectDateForm));
            this.date_txbx = new KinderGarten.Views.MaterialDateTimePicker();
            this.add_btn = new KinderGarten.Views.ResizebleMaterialRaisedButton();
            this.resizebleMaterialRaisedButton1 = new KinderGarten.Views.ResizebleMaterialRaisedButton();
            this.SuspendLayout();
            // 
            // date_txbx
            // 
            this.date_txbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.date_txbx.Format = "dd/MM/yyyy";
            this.date_txbx.Hint = null;
            this.date_txbx.Location = new System.Drawing.Point(17, 79);
            this.date_txbx.Name = "date_txbx";
            this.date_txbx.Size = new System.Drawing.Size(298, 23);
            this.date_txbx.TabIndex = 26;
            this.date_txbx.ValueChanged += new System.EventHandler(this.date_txbx_ValueChanged);
            // 
            // add_btn
            // 
            this.add_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.add_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.add_btn.Depth = 0;
            this.add_btn.Icon = null;
            this.add_btn.Location = new System.Drawing.Point(17, 140);
            this.add_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.add_btn.Name = "add_btn";
            this.add_btn.Primary = true;
            this.add_btn.Size = new System.Drawing.Size(144, 36);
            this.add_btn.TabIndex = 27;
            this.add_btn.Text = "Добавить";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // resizebleMaterialRaisedButton1
            // 
            this.resizebleMaterialRaisedButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.resizebleMaterialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.resizebleMaterialRaisedButton1.Depth = 0;
            this.resizebleMaterialRaisedButton1.Icon = null;
            this.resizebleMaterialRaisedButton1.Location = new System.Drawing.Point(167, 140);
            this.resizebleMaterialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.resizebleMaterialRaisedButton1.Name = "resizebleMaterialRaisedButton1";
            this.resizebleMaterialRaisedButton1.Primary = true;
            this.resizebleMaterialRaisedButton1.Size = new System.Drawing.Size(148, 36);
            this.resizebleMaterialRaisedButton1.TabIndex = 27;
            this.resizebleMaterialRaisedButton1.Text = "Отмена";
            this.resizebleMaterialRaisedButton1.UseVisualStyleBackColor = true;
            this.resizebleMaterialRaisedButton1.Click += new System.EventHandler(this.resizebleMaterialRaisedButton1_Click);
            // 
            // SelectDateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 203);
            this.Controls.Add(this.resizebleMaterialRaisedButton1);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.date_txbx);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(327, 203);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(327, 203);
            this.Name = "SelectDateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбрать дату";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialDateTimePicker date_txbx;
        private ResizebleMaterialRaisedButton add_btn;
        private ResizebleMaterialRaisedButton resizebleMaterialRaisedButton1;
    }
}