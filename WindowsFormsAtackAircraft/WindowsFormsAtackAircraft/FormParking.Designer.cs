﻿using System;

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
            this.button_parkThePlane = new System.Windows.Forms.Button();
            this.button_parkAttackAircraft = new System.Windows.Forms.Button();
            this.groupBoxGoToSky = new System.Windows.Forms.GroupBox();
            this.buttonGoToSky = new System.Windows.Forms.Button();
            this.maskedTextBoxPlaceOnParking = new System.Windows.Forms.MaskedTextBox();
            this.labelPlace = new System.Windows.Forms.Label();
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
            // button_parkThePlane
            // 
            this.button_parkThePlane.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_parkThePlane.Location = new System.Drawing.Point(676, 12);
            this.button_parkThePlane.Name = "button_parkThePlane";
            this.button_parkThePlane.Size = new System.Drawing.Size(276, 57);
            this.button_parkThePlane.TabIndex = 1;
            this.button_parkThePlane.Text = "Припарковать самолет";
            this.button_parkThePlane.UseVisualStyleBackColor = true;
            this.button_parkThePlane.Click += new System.EventHandler(this.button_parkThePlane_Click);
            // 
            // button_parkAttackAircraft
            // 
            this.button_parkAttackAircraft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_parkAttackAircraft.Location = new System.Drawing.Point(676, 75);
            this.button_parkAttackAircraft.Name = "button_parkAttackAircraft";
            this.button_parkAttackAircraft.Size = new System.Drawing.Size(276, 57);
            this.button_parkAttackAircraft.TabIndex = 2;
            this.button_parkAttackAircraft.Text = "Припарковать штурмовик";
            this.button_parkAttackAircraft.UseVisualStyleBackColor = true;
            this.button_parkAttackAircraft.Click += new System.EventHandler(this.button_parkAttackAircraft_Click);
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
            this.buttonGoToSky.Click += new System.EventHandler(this.buttonCreateAttackAirctaft_Click);
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
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 555);
            this.Controls.Add(this.groupBoxGoToSky);
            this.Controls.Add(this.button_parkAttackAircraft);
            this.Controls.Add(this.button_parkThePlane);
            this.Controls.Add(this.pictureBoxParking);
            this.Name = "FormParking";
            this.Text = "FormParking";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.groupBoxGoToSky.ResumeLayout(false);
            this.groupBoxGoToSky.PerformLayout();
            this.ResumeLayout(false);

		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{
			throw new NotImplementedException();
		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBoxParking;
		private System.Windows.Forms.Button button_parkThePlane;
		private System.Windows.Forms.Button button_parkAttackAircraft;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button_pickUp;
		private System.Windows.Forms.MaskedTextBox maskedTextBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBoxGoToSky;
		private System.Windows.Forms.Button buttonGoToSky;
		private System.Windows.Forms.MaskedTextBox maskedTextBoxPlaceOnParking;
		private System.Windows.Forms.Label labelPlace;
	}
}