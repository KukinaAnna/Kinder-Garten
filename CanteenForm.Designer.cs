namespace KinderGarten.Views
{
    partial class CanteenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CanteenForm));
            this.dishesBtn = new KinderGarten.Views.ResizebleMaterialRaisedButton();
            this.measurement_btn = new KinderGarten.Views.ResizebleMaterialRaisedButton();
            this.mealTime_btn = new KinderGarten.Views.ResizebleMaterialRaisedButton();
            this.menuBtn = new KinderGarten.Views.ResizebleMaterialRaisedButton();
            this.resizebleMaterialRaisedButton2 = new KinderGarten.Views.ResizebleMaterialRaisedButton();
            this.SuspendLayout();
            // 
            // dishesBtn
            // 
            this.dishesBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dishesBtn.Depth = 0;
            this.dishesBtn.Icon = null;
            this.dishesBtn.Location = new System.Drawing.Point(12, 166);
            this.dishesBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.dishesBtn.Name = "dishesBtn";
            this.dishesBtn.Primary = true;
            this.dishesBtn.Size = new System.Drawing.Size(503, 36);
            this.dishesBtn.TabIndex = 1;
            this.dishesBtn.Text = "Блюда";
            this.dishesBtn.UseVisualStyleBackColor = true;
            this.dishesBtn.Click += new System.EventHandler(this.DishesBtnClick);
            // 
            // measurement_btn
            // 
            this.measurement_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.measurement_btn.Depth = 0;
            this.measurement_btn.Icon = null;
            this.measurement_btn.Location = new System.Drawing.Point(12, 82);
            this.measurement_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.measurement_btn.Name = "measurement_btn";
            this.measurement_btn.Primary = true;
            this.measurement_btn.Size = new System.Drawing.Size(503, 36);
            this.measurement_btn.TabIndex = 1;
            this.measurement_btn.Text = "Единицы измерения";
            this.measurement_btn.UseVisualStyleBackColor = true;
            this.measurement_btn.Click += new System.EventHandler(this.MeasurementBtnClick);
            // 
            // mealTime_btn
            // 
            this.mealTime_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mealTime_btn.Depth = 0;
            this.mealTime_btn.Icon = null;
            this.mealTime_btn.Location = new System.Drawing.Point(12, 124);
            this.mealTime_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.mealTime_btn.Name = "mealTime_btn";
            this.mealTime_btn.Primary = true;
            this.mealTime_btn.Size = new System.Drawing.Size(503, 36);
            this.mealTime_btn.TabIndex = 1;
            this.mealTime_btn.Text = "Время приемов пищи";
            this.mealTime_btn.UseVisualStyleBackColor = true;
            this.mealTime_btn.Click += new System.EventHandler(this.MealTimeBtnClick);
            // 
            // menuBtn
            // 
            this.menuBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.menuBtn.Depth = 0;
            this.menuBtn.Icon = null;
            this.menuBtn.Location = new System.Drawing.Point(12, 208);
            this.menuBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Primary = true;
            this.menuBtn.Size = new System.Drawing.Size(503, 36);
            this.menuBtn.TabIndex = 1;
            this.menuBtn.Text = "Меню";
            this.menuBtn.UseVisualStyleBackColor = true;
            this.menuBtn.Click += new System.EventHandler(this.MenuBtnClick);
            // 
            // resizebleMaterialRaisedButton2
            // 
            this.resizebleMaterialRaisedButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.resizebleMaterialRaisedButton2.Depth = 0;
            this.resizebleMaterialRaisedButton2.Icon = null;
            this.resizebleMaterialRaisedButton2.Location = new System.Drawing.Point(12, 427);
            this.resizebleMaterialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.resizebleMaterialRaisedButton2.Name = "resizebleMaterialRaisedButton2";
            this.resizebleMaterialRaisedButton2.Primary = true;
            this.resizebleMaterialRaisedButton2.Size = new System.Drawing.Size(503, 36);
            this.resizebleMaterialRaisedButton2.TabIndex = 1;
            this.resizebleMaterialRaisedButton2.Text = "Выход";
            this.resizebleMaterialRaisedButton2.UseVisualStyleBackColor = true;
            this.resizebleMaterialRaisedButton2.Click += new System.EventHandler(this.resizebleMaterialRaisedButton2_Click);
            // 
            // CanteenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 475);
            this.Controls.Add(this.mealTime_btn);
            this.Controls.Add(this.measurement_btn);
            this.Controls.Add(this.resizebleMaterialRaisedButton2);
            this.Controls.Add(this.menuBtn);
            this.Controls.Add(this.dishesBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CanteenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Столовая";
            this.ResumeLayout(false);

        }

        #endregion

        private ResizebleMaterialRaisedButton dishesBtn;
        private ResizebleMaterialRaisedButton measurement_btn;
        private ResizebleMaterialRaisedButton mealTime_btn;
        private ResizebleMaterialRaisedButton menuBtn;
        private ResizebleMaterialRaisedButton resizebleMaterialRaisedButton2;
    }
}