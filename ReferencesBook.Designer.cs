namespace KinderGarten.Views
{
    partial class ReferencesBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReferencesBookForm));
            this.roomsBtn = new KinderGarten.Views.ResizebleMaterialRaisedButton();
            this.groups_btn = new KinderGarten.Views.ResizebleMaterialRaisedButton();
            this.specializationBtn = new KinderGarten.Views.ResizebleMaterialRaisedButton();
            this.propertyBtn = new KinderGarten.Views.ResizebleMaterialRaisedButton();
            this.lessonsBtn = new KinderGarten.Views.ResizebleMaterialRaisedButton();
            this.nationalityBtn = new KinderGarten.Views.ResizebleMaterialRaisedButton();
            this.exitBtn = new KinderGarten.Views.ResizebleMaterialRaisedButton();
            this.SuspendLayout();
            // 
            // roomsBtn
            // 
            this.roomsBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.roomsBtn.Depth = 0;
            this.roomsBtn.Icon = null;
            this.roomsBtn.Location = new System.Drawing.Point(12, 70);
            this.roomsBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.roomsBtn.Name = "roomsBtn";
            this.roomsBtn.Primary = true;
            this.roomsBtn.Size = new System.Drawing.Size(503, 36);
            this.roomsBtn.TabIndex = 0;
            this.roomsBtn.Text = "Комнаты";
            this.roomsBtn.UseVisualStyleBackColor = true;
            this.roomsBtn.Click += new System.EventHandler(this.RoomsBtnClick);
            // 
            // groups_btn
            // 
            this.groups_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groups_btn.Depth = 0;
            this.groups_btn.Icon = null;
            this.groups_btn.Location = new System.Drawing.Point(12, 112);
            this.groups_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.groups_btn.Name = "groups_btn";
            this.groups_btn.Primary = true;
            this.groups_btn.Size = new System.Drawing.Size(503, 36);
            this.groups_btn.TabIndex = 0;
            this.groups_btn.Text = "Группы";
            this.groups_btn.UseVisualStyleBackColor = true;
            this.groups_btn.Click += new System.EventHandler(this.GroupsBtnClick);
            // 
            // specializationBtn
            // 
            this.specializationBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.specializationBtn.Depth = 0;
            this.specializationBtn.Icon = null;
            this.specializationBtn.Location = new System.Drawing.Point(12, 154);
            this.specializationBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.specializationBtn.Name = "specializationBtn";
            this.specializationBtn.Primary = true;
            this.specializationBtn.Size = new System.Drawing.Size(503, 36);
            this.specializationBtn.TabIndex = 0;
            this.specializationBtn.Text = "Специализации воспитателей";
            this.specializationBtn.UseVisualStyleBackColor = true;
            this.specializationBtn.Click += new System.EventHandler(this.SpecializationBtnClick);
            // 
            // propertyBtn
            // 
            this.propertyBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.propertyBtn.Depth = 0;
            this.propertyBtn.Icon = null;
            this.propertyBtn.Location = new System.Drawing.Point(12, 196);
            this.propertyBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.propertyBtn.Name = "propertyBtn";
            this.propertyBtn.Primary = true;
            this.propertyBtn.Size = new System.Drawing.Size(503, 36);
            this.propertyBtn.TabIndex = 0;
            this.propertyBtn.Text = "Характеристики воспитателей и родителей";
            this.propertyBtn.UseVisualStyleBackColor = true;
            this.propertyBtn.Click += new System.EventHandler(this.PropertyBtnClick);
            // 
            // lessonsBtn
            // 
            this.lessonsBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.lessonsBtn.Depth = 0;
            this.lessonsBtn.Icon = null;
            this.lessonsBtn.Location = new System.Drawing.Point(12, 238);
            this.lessonsBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.lessonsBtn.Name = "lessonsBtn";
            this.lessonsBtn.Primary = true;
            this.lessonsBtn.Size = new System.Drawing.Size(503, 36);
            this.lessonsBtn.TabIndex = 0;
            this.lessonsBtn.Text = "Занятия";
            this.lessonsBtn.UseVisualStyleBackColor = true;
            this.lessonsBtn.Click += new System.EventHandler(this.LessonsBtnClick);
            // 
            // nationalityBtn
            // 
            this.nationalityBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nationalityBtn.Depth = 0;
            this.nationalityBtn.Icon = null;
            this.nationalityBtn.Location = new System.Drawing.Point(12, 280);
            this.nationalityBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.nationalityBtn.Name = "nationalityBtn";
            this.nationalityBtn.Primary = true;
            this.nationalityBtn.Size = new System.Drawing.Size(503, 36);
            this.nationalityBtn.TabIndex = 0;
            this.nationalityBtn.Text = "Национальности";
            this.nationalityBtn.UseVisualStyleBackColor = true;
            this.nationalityBtn.Click += new System.EventHandler(this.NationalityBtnClick);
            // 
            // exitBtn
            // 
            this.exitBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.exitBtn.Depth = 0;
            this.exitBtn.Icon = null;
            this.exitBtn.Location = new System.Drawing.Point(12, 427);
            this.exitBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Primary = true;
            this.exitBtn.Size = new System.Drawing.Size(503, 36);
            this.exitBtn.TabIndex = 0;
            this.exitBtn.Text = "Выход";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // ReferencesBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 475);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.nationalityBtn);
            this.Controls.Add(this.lessonsBtn);
            this.Controls.Add(this.propertyBtn);
            this.Controls.Add(this.specializationBtn);
            this.Controls.Add(this.groups_btn);
            this.Controls.Add(this.roomsBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(527, 475);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(527, 475);
            this.Name = "ReferencesBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справочники";
            this.ResumeLayout(false);

        }

        #endregion

        private ResizebleMaterialRaisedButton roomsBtn;
        private ResizebleMaterialRaisedButton groups_btn;
        private ResizebleMaterialRaisedButton specializationBtn;
        private ResizebleMaterialRaisedButton propertyBtn;
        private ResizebleMaterialRaisedButton lessonsBtn;
        private ResizebleMaterialRaisedButton nationalityBtn;
        private ResizebleMaterialRaisedButton exitBtn;
    }
}