namespace WindowsFormsAtackAircraft
{
    partial class FormAttackAircraftConfig
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelAttackAircraft = new System.Windows.Forms.Label();
            this.labelPlane = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDownMaxSpeed = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.checkBoxBombs = new System.Windows.Forms.CheckBox();
            this.checkBoxRockets = new System.Windows.Forms.CheckBox();
            this.checkBoxChassis = new System.Windows.Forms.CheckBox();
            this.checkBoxAntenna = new System.Windows.Forms.CheckBox();
            this.checkBoxPropeller = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxPlane = new System.Windows.Forms.PictureBox();
            this.panelPlane = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelOrange = new System.Windows.Forms.Panel();
            this.panelGrey = new System.Windows.Forms.Panel();
            this.panelWhite = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.labelMainColor = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlane)).BeginInit();
            this.panelPlane.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelAttackAircraft);
            this.groupBox1.Controls.Add(this.labelPlane);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 263);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип самолета";
            // 
            // labelAttackAircraft
            // 
            this.labelAttackAircraft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAttackAircraft.Location = new System.Drawing.Point(6, 103);
            this.labelAttackAircraft.Name = "labelAttackAircraft";
            this.labelAttackAircraft.Size = new System.Drawing.Size(240, 46);
            this.labelAttackAircraft.TabIndex = 1;
            this.labelAttackAircraft.Text = "Штурмовик";
            this.labelAttackAircraft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelAttackAircraft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelAttackAircraft_MouseDown);
            // 
            // labelPlane
            // 
            this.labelPlane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPlane.Location = new System.Drawing.Point(6, 26);
            this.labelPlane.Name = "labelPlane";
            this.labelPlane.Size = new System.Drawing.Size(240, 50);
            this.labelPlane.TabIndex = 0;
            this.labelPlane.Text = "Военный самолет";
            this.labelPlane.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPlane.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelPlane_MouseDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDownMaxSpeed);
            this.groupBox2.Controls.Add(this.numericUpDownWeight);
            this.groupBox2.Controls.Add(this.checkBoxBombs);
            this.groupBox2.Controls.Add(this.checkBoxRockets);
            this.groupBox2.Controls.Add(this.checkBoxChassis);
            this.groupBox2.Controls.Add(this.checkBoxAntenna);
            this.groupBox2.Controls.Add(this.checkBoxPropeller);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(11, 282);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(535, 153);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Параметры:";
            // 
            // numericUpDownMaxSpeed
            // 
            this.numericUpDownMaxSpeed.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDownMaxSpeed.Location = new System.Drawing.Point(15, 87);
            this.numericUpDownMaxSpeed.Maximum = new decimal(new int[] {
            1250,
            0,
            0,
            0});
            this.numericUpDownMaxSpeed.Minimum = new decimal(new int[] {
            750,
            0,
            0,
            0});
            this.numericUpDownMaxSpeed.Name = "numericUpDownMaxSpeed";
            this.numericUpDownMaxSpeed.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownMaxSpeed.TabIndex = 8;
            this.numericUpDownMaxSpeed.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDownWeight.Location = new System.Drawing.Point(15, 41);
            this.numericUpDownWeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownWeight.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownWeight.Name = "numericUpDownWeight";
            this.numericUpDownWeight.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownWeight.TabIndex = 7;
            this.numericUpDownWeight.Value = new decimal(new int[] {
            750,
            0,
            0,
            0});
            // 
            // checkBoxBombs
            // 
            this.checkBoxBombs.AutoSize = true;
            this.checkBoxBombs.Location = new System.Drawing.Point(307, 113);
            this.checkBoxBombs.Name = "checkBoxBombs";
            this.checkBoxBombs.Size = new System.Drawing.Size(61, 17);
            this.checkBoxBombs.TabIndex = 6;
            this.checkBoxBombs.Text = "Бомбы";
            this.checkBoxBombs.UseVisualStyleBackColor = true;
            // 
            // checkBoxRockets
            // 
            this.checkBoxRockets.AutoSize = true;
            this.checkBoxRockets.Location = new System.Drawing.Point(307, 90);
            this.checkBoxRockets.Name = "checkBoxRockets";
            this.checkBoxRockets.Size = new System.Drawing.Size(64, 17);
            this.checkBoxRockets.TabIndex = 5;
            this.checkBoxRockets.Text = "Ракеты";
            this.checkBoxRockets.UseVisualStyleBackColor = true;
            // 
            // checkBoxChassis
            // 
            this.checkBoxChassis.AutoSize = true;
            this.checkBoxChassis.Location = new System.Drawing.Point(307, 67);
            this.checkBoxChassis.Name = "checkBoxChassis";
            this.checkBoxChassis.Size = new System.Drawing.Size(59, 17);
            this.checkBoxChassis.TabIndex = 4;
            this.checkBoxChassis.Text = "Шасси";
            this.checkBoxChassis.UseVisualStyleBackColor = true;
            // 
            // checkBoxAntenna
            // 
            this.checkBoxAntenna.AutoSize = true;
            this.checkBoxAntenna.Location = new System.Drawing.Point(307, 44);
            this.checkBoxAntenna.Name = "checkBoxAntenna";
            this.checkBoxAntenna.Size = new System.Drawing.Size(68, 17);
            this.checkBoxAntenna.TabIndex = 3;
            this.checkBoxAntenna.Text = "Антенна";
            this.checkBoxAntenna.UseVisualStyleBackColor = true;
            // 
            // checkBoxPropeller
            // 
            this.checkBoxPropeller.AutoSize = true;
            this.checkBoxPropeller.Location = new System.Drawing.Point(307, 21);
            this.checkBoxPropeller.Name = "checkBoxPropeller";
            this.checkBoxPropeller.Size = new System.Drawing.Size(82, 17);
            this.checkBoxPropeller.TabIndex = 2;
            this.checkBoxPropeller.Text = "Пропеллер";
            this.checkBoxPropeller.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Вес самолета:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Макс. скорость:";
            // 
            // pictureBoxPlane
            // 
            this.pictureBoxPlane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPlane.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxPlane.Name = "pictureBoxPlane";
            this.pictureBoxPlane.Size = new System.Drawing.Size(266, 258);
            this.pictureBoxPlane.TabIndex = 2;
            this.pictureBoxPlane.TabStop = false;
            // 
            // panelPlane
            // 
            this.panelPlane.AllowDrop = true;
            this.panelPlane.Controls.Add(this.pictureBoxPlane);
            this.panelPlane.Location = new System.Drawing.Point(273, 12);
            this.panelPlane.Name = "panelPlane";
            this.panelPlane.Size = new System.Drawing.Size(273, 264);
            this.panelPlane.TabIndex = 3;
            this.panelPlane.DragDrop += new System.Windows.Forms.DragEventHandler(this.PanelPlane_DragDrop);
            this.panelPlane.DragEnter += new System.Windows.Forms.DragEventHandler(this.PanelPlane_DragEnter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonCancel);
            this.groupBox3.Controls.Add(this.buttonAdd);
            this.groupBox3.Controls.Add(this.panelBlue);
            this.groupBox3.Controls.Add(this.panelGreen);
            this.groupBox3.Controls.Add(this.panelOrange);
            this.groupBox3.Controls.Add(this.panelGrey);
            this.groupBox3.Controls.Add(this.panelWhite);
            this.groupBox3.Controls.Add(this.panelBlack);
            this.groupBox3.Controls.Add(this.panelYellow);
            this.groupBox3.Controls.Add(this.panelRed);
            this.groupBox3.Controls.Add(this.labelDopColor);
            this.groupBox3.Controls.Add(this.labelMainColor);
            this.groupBox3.Location = new System.Drawing.Point(552, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(320, 425);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Цвета";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(11, 272);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(290, 54);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(11, 212);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(290, 54);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Aqua;
            this.panelBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBlue.Location = new System.Drawing.Point(233, 146);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(68, 60);
            this.panelBlue.TabIndex = 4;
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.Lime;
            this.panelGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGreen.Location = new System.Drawing.Point(159, 146);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(68, 60);
            this.panelGreen.TabIndex = 4;
            // 
            // panelOrange
            // 
            this.panelOrange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelOrange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOrange.Location = new System.Drawing.Point(85, 146);
            this.panelOrange.Name = "panelOrange";
            this.panelOrange.Size = new System.Drawing.Size(68, 60);
            this.panelOrange.TabIndex = 4;
            // 
            // panelGrey
            // 
            this.panelGrey.BackColor = System.Drawing.Color.Gray;
            this.panelGrey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGrey.Location = new System.Drawing.Point(11, 146);
            this.panelGrey.Name = "panelGrey";
            this.panelGrey.Size = new System.Drawing.Size(68, 60);
            this.panelGrey.TabIndex = 4;
            // 
            // panelWhite
            // 
            this.panelWhite.BackColor = System.Drawing.Color.White;
            this.panelWhite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelWhite.Location = new System.Drawing.Point(233, 80);
            this.panelWhite.Name = "panelWhite";
            this.panelWhite.Size = new System.Drawing.Size(68, 60);
            this.panelWhite.TabIndex = 3;
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBlack.Location = new System.Drawing.Point(159, 80);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(68, 60);
            this.panelBlack.TabIndex = 3;
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelYellow.Location = new System.Drawing.Point(85, 80);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(68, 60);
            this.panelYellow.TabIndex = 3;
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRed.Location = new System.Drawing.Point(11, 80);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(68, 60);
            this.panelRed.TabIndex = 2;
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(166, 20);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(148, 42);
            this.labelDopColor.TabIndex = 1;
            this.labelDopColor.Text = "Дополнительный цвет";
            this.labelDopColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.LabelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.LabelMainColor_DragEnter);
            // 
            // labelMainColor
            // 
            this.labelMainColor.AllowDrop = true;
            this.labelMainColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMainColor.Location = new System.Drawing.Point(6, 20);
            this.labelMainColor.Name = "labelMainColor";
            this.labelMainColor.Size = new System.Drawing.Size(154, 42);
            this.labelMainColor.TabIndex = 0;
            this.labelMainColor.Text = "Основной цвет";
            this.labelMainColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMainColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.LabelMainColor_DragDrop);
            this.labelMainColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.LabelMainColor_DragEnter);
            // 
            // FormAttackAircraftConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 447);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panelPlane);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormAttackAircraftConfig";
            this.Text = "Выбор самолета";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlane)).EndInit();
            this.panelPlane.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxSpeed;
        private System.Windows.Forms.NumericUpDown numericUpDownWeight;
        private System.Windows.Forms.CheckBox checkBoxBombs;
        private System.Windows.Forms.CheckBox checkBoxRockets;
        private System.Windows.Forms.CheckBox checkBoxChassis;
        private System.Windows.Forms.CheckBox checkBoxAntenna;
        private System.Windows.Forms.CheckBox checkBoxPropeller;
        private System.Windows.Forms.Label labelAttackAircraft;
        private System.Windows.Forms.Label labelPlane;
        private System.Windows.Forms.PictureBox pictureBoxPlane;
        private System.Windows.Forms.Panel panelPlane;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelOrange;
        private System.Windows.Forms.Panel panelGrey;
        private System.Windows.Forms.Panel panelWhite;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.Label labelMainColor;
    }
}