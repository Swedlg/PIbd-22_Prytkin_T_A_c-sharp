namespace WindowsFormsAtackAircraft
{
    partial class FormAtackAircraft
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAtackAircraft));
            //this.btnCreate = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.pictureBoxAtackAircraft = new System.Windows.Forms.PictureBox();
            //this.btnCreateAtackAircraft = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAtackAircraft)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRight
            // 
            this.btnRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRight.Image = global::WindowsFormsAtackAircraft.Properties.Resources.bRight;
            this.btnRight.Location = new System.Drawing.Point(1018, 629);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(60, 60);
            this.btnRight.TabIndex = 4;
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // btnDown
            // 
            this.btnDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDown.Image = global::WindowsFormsAtackAircraft.Properties.Resources.bDown;
            this.btnDown.Location = new System.Drawing.Point(952, 629);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(60, 60);
            this.btnDown.TabIndex = 3;
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLeft.Image = global::WindowsFormsAtackAircraft.Properties.Resources.bLeft;
            this.btnLeft.Location = new System.Drawing.Point(886, 629);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(60, 60);
            this.btnLeft.TabIndex = 2;
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // btnUp
            // 
            this.btnUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUp.Image = global::WindowsFormsAtackAircraft.Properties.Resources.bUP;
            this.btnUp.Location = new System.Drawing.Point(952, 563);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(60, 60);
            this.btnUp.TabIndex = 1;
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // pictureBoxAtackAircraft
            // 
            this.pictureBoxAtackAircraft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxAtackAircraft.BackColor = System.Drawing.Color.PowderBlue;
            this.pictureBoxAtackAircraft.BackgroundImage = global::WindowsFormsAtackAircraft.Properties.Resources.sky_2868089_1920;
            this.pictureBoxAtackAircraft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxAtackAircraft.Image = global::WindowsFormsAtackAircraft.Properties.Resources.sky_2868089_1920;
            this.pictureBoxAtackAircraft.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxAtackAircraft.Name = "pictureBoxAtackAircraft";
            this.pictureBoxAtackAircraft.Size = new System.Drawing.Size(749, 631);
            this.pictureBoxAtackAircraft.TabIndex = 0;
            this.pictureBoxAtackAircraft.TabStop = false;
            // 
            // FormAtackAircraft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1090, 701);
            //this.Controls.Add(this.btnCreateAtackAircraft);
            //this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.pictureBoxAtackAircraft);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAtackAircraft";
            this.Text = "Лаба 1 Штурмовик";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAtackAircraft)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAtackAircraft;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnRight;
        //private System.Windows.Forms.Button btnCreate;
        //private System.Windows.Forms.Button btnCreateAtackAircraft;
    }
}

