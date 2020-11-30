using System;

namespace WindowsFormsAtackAircraft
{
	partial class FormParking
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
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            this.button_ParkThePlane = new System.Windows.Forms.Button();
            this.groupBoxGoToSky = new System.Windows.Forms.GroupBox();
            this.buttonGoToSky = new System.Windows.Forms.Button();
            this.maskedTextBoxPlaceOnParking = new System.Windows.Forms.MaskedTextBox();
            this.labelPlace = new System.Windows.Forms.Label();
            this.textBoxNewLevelName = new System.Windows.Forms.MaskedTextBox();
            this.buttonAddParking = new System.Windows.Forms.Button();
            this.listBoxParkings = new System.Windows.Forms.ListBox();
            this.buttonDeleteParking = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.groupBoxGoToSky.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(649, 531);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;







            // 
            // button_ParkThePlane
            // 
            this.button_ParkThePlane.Location = new System.Drawing.Point(676, 12);
            this.button_ParkThePlane.Name = "buttonParkPlane";
            this.button_ParkThePlane.Size = new System.Drawing.Size(268, 120);
            this.button_ParkThePlane.TabIndex = 3;
            this.button_ParkThePlane.Text = "Припарковать самолет";
            this.button_ParkThePlane.UseVisualStyleBackColor = true;
            this.button_ParkThePlane.Click += new System.EventHandler(this.buttonParkPlane_Click);
            //this.buttonParkPlane.Click += new System.EventHandler(this.PrintMessage);






            // 
            // groupBoxGoToSky
            // 
            this.groupBoxGoToSky.Controls.Add(this.buttonGoToSky);
            this.groupBoxGoToSky.Controls.Add(this.maskedTextBoxPlaceOnParking);
            this.groupBoxGoToSky.Controls.Add(this.labelPlace);
            this.groupBoxGoToSky.Location = new System.Drawing.Point(676, 138);
            this.groupBoxGoToSky.Name = "groupBoxGoToSky";
            this.groupBoxGoToSky.Size = new System.Drawing.Size(275, 122);
            this.groupBoxGoToSky.TabIndex = 3;
            this.groupBoxGoToSky.TabStop = false;
            this.groupBoxGoToSky.Text = "Забрать самолет";
            // 
            // buttonGoToSky
            // 
            this.buttonGoToSky.Location = new System.Drawing.Point(9, 55);
            this.buttonGoToSky.Name = "buttonGoToSky";
            this.buttonGoToSky.Size = new System.Drawing.Size(260, 55);
            this.buttonGoToSky.TabIndex = 2;
            this.buttonGoToSky.Text = "Отправить самолет а в небо";
            this.buttonGoToSky.UseVisualStyleBackColor = true;
            this.buttonGoToSky.Click += new System.EventHandler(this.buttonGoToSkyAttackAirctaft_Click);
            // 
            // maskedTextBoxPlaceOnParking
            // 
            this.maskedTextBoxPlaceOnParking.Location = new System.Drawing.Point(57, 29);
            this.maskedTextBoxPlaceOnParking.Name = "maskedTextBoxPlaceOnParking";
            this.maskedTextBoxPlaceOnParking.Size = new System.Drawing.Size(212, 20);
            this.maskedTextBoxPlaceOnParking.TabIndex = 1;
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Location = new System.Drawing.Point(6, 32);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(45, 13);
            this.labelPlace.TabIndex = 0;
            this.labelPlace.Text = "Место: ";
            // 
            // textBoxNewLevelName
            // 
            this.textBoxNewLevelName.Location = new System.Drawing.Point(676, 287);
            this.textBoxNewLevelName.Name = "textBoxNewLevelName";
            this.textBoxNewLevelName.Size = new System.Drawing.Size(268, 20);
            this.textBoxNewLevelName.TabIndex = 4;
            // 
            // buttonAddParking
            // 
            this.buttonAddParking.Location = new System.Drawing.Point(676, 322);
            this.buttonAddParking.Name = "buttonAddParking";
            this.buttonAddParking.Size = new System.Drawing.Size(269, 55);
            this.buttonAddParking.TabIndex = 5;
            this.buttonAddParking.Text = "Добавить парковку";
            this.buttonAddParking.UseVisualStyleBackColor = true;
            this.buttonAddParking.Click += new System.EventHandler(this.buttonAddParking_Click);
            // 
            // listBoxParkings
            // 
            this.listBoxParkings.FormattingEnabled = true;
            this.listBoxParkings.Location = new System.Drawing.Point(678, 392);
            this.listBoxParkings.Name = "listBoxParkings";
            this.listBoxParkings.Size = new System.Drawing.Size(266, 95);
            this.listBoxParkings.TabIndex = 6;
            this.listBoxParkings.SelectedIndexChanged += new System.EventHandler(this.listBoxParkings_SelectedIndexChanged);
            // 
            // buttonDeleteParking
            // 
            this.buttonDeleteParking.Location = new System.Drawing.Point(678, 493);
            this.buttonDeleteParking.Name = "buttonDeleteParking";
            this.buttonDeleteParking.Size = new System.Drawing.Size(269, 55);
            this.buttonDeleteParking.TabIndex = 7;
            this.buttonDeleteParking.Text = "Удалить парковку";
            this.buttonDeleteParking.UseVisualStyleBackColor = true;
            this.buttonDeleteParking.Click += new System.EventHandler(this.buttonDeleteParking_Click);
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 555);
            this.Controls.Add(this.buttonDeleteParking);
            this.Controls.Add(this.listBoxParkings);
            this.Controls.Add(this.buttonAddParking);
            this.Controls.Add(this.textBoxNewLevelName);
            this.Controls.Add(this.groupBoxGoToSky);
            this.Controls.Add(this.button_ParkThePlane);
            this.Controls.Add(this.pictureBoxParking);
            this.Name = "FormParking";
            this.Text = "FormParking";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.groupBoxGoToSky.ResumeLayout(false);
            this.groupBoxGoToSky.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBoxParking;
		private System.Windows.Forms.Button button_ParkThePlane;
		private System.Windows.Forms.GroupBox groupBoxGoToSky;
		private System.Windows.Forms.Button buttonGoToSky;
		private System.Windows.Forms.MaskedTextBox maskedTextBoxPlaceOnParking;
		private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.MaskedTextBox textBoxNewLevelName;
        private System.Windows.Forms.Button buttonAddParking;
        private System.Windows.Forms.ListBox listBoxParkings;
        private System.Windows.Forms.Button buttonDeleteParking;














    }
}