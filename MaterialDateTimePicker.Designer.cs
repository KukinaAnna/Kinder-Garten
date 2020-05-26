namespace KinderGarten.Views
{
    partial class MaterialDateTimePicker
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.date_txbx = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SuspendLayout();
            // 
            // datePicker
            // 
            this.datePicker.Dock = System.Windows.Forms.DockStyle.Right;
            this.datePicker.Location = new System.Drawing.Point(163, 0);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(19, 20);
            this.datePicker.TabIndex = 28;
            this.datePicker.ValueChanged += new System.EventHandler(this.DateTimePickerValueChanged);
            // 
            // date_txbx
            // 
            this.date_txbx.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.date_txbx.Depth = 0;
            this.date_txbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.date_txbx.Hint = "dd/mm/yyyy";
            this.date_txbx.Location = new System.Drawing.Point(0, 0);
            this.date_txbx.MaxLength = 32767;
            this.date_txbx.MouseState = MaterialSkin.MouseState.HOVER;
            this.date_txbx.Name = "date_txbx";
            this.date_txbx.PasswordChar = '\0';
            this.date_txbx.SelectedText = "";
            this.date_txbx.SelectionLength = 0;
            this.date_txbx.SelectionStart = 0;
            this.date_txbx.Size = new System.Drawing.Size(182, 23);
            this.date_txbx.TabIndex = 0;
            this.date_txbx.TabStop = false;
            this.date_txbx.UseSystemPasswordChar = false;
            // 
            // MaterialDateTimePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.date_txbx);
            this.Name = "MaterialDateTimePicker";
            this.Size = new System.Drawing.Size(182, 23);
            this.BackColorChanged += new System.EventHandler(this.MaterialDateTimePickerBackColorChanged);
            this.EnabledChanged += new System.EventHandler(this.MaterialDateTimePickerEnabledChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker datePicker;
        private MaterialSkin.Controls.MaterialSingleLineTextField date_txbx;
    }
}
