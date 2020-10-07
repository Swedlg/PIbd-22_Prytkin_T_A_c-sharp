using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAtackAircraft
{
	public partial class FormParking : Form
	{
		/// <summary>
		/// Объект от класса-парковки
		/// </summary>
		private readonly Parking<FlyingTransport> parking;

		public FormParking()
		{
			InitializeComponent();

			parking = new Parking<FlyingTransport>(pictureBoxParking.Width, pictureBoxParking.Height);
			Draw();
		}

		/// <summary>
		/// Метод отрисовки парковки
		/// </summary>
		private void Draw()
		{
			Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
			Graphics gr = Graphics.FromImage(bmp);
			parking.Draw(gr);
			pictureBoxParking.Image = bmp;
		}

		/// <summary>
		/// Обработка нажатия кнопки "Припарковать самолет"
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button_parkThePlane_Click(object sender, EventArgs e)
		{
			ColorDialog dialog = new ColorDialog();
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				var plane = new Plane(100, 1000, dialog.Color, Color.Green, true, true, true);
		    if (parking + plane)
				{
					Draw();
				}
				else
				{
					MessageBox.Show("Парковка переполнена");
				}
			}
		}


		/// <summary>
		/// Обработка нажатия кнопки "Припарковать штурмовик"
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button_parkAttackAircraft_Click(object sender, EventArgs e)
		{
			ColorDialog dialog = new ColorDialog();
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				ColorDialog dialogDop = new ColorDialog();
				if (dialogDop.ShowDialog() == DialogResult.OK)
				{
					var car = new AttackAircraft(100, 1000, dialog.Color, dialogDop.Color, true, true);
					if (parking + car)
					{
						Draw();
					}
					else
					{
						MessageBox.Show("Парковка переполнена");
					}
				}
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (maskedTextBox2.Text != "")
			{
				var plane = parking - (Convert.ToInt32(maskedTextBox2.Text) - 1);
				if (plane != null)
				{
					FormAtackAircraft form = new FormAtackAircraft();
					form.SetPlane(plane);
					form.ShowDialog();
				}
				Draw();
			}
		}

		private void groupBox2_Enter(object sender, EventArgs e)
		{

		}
	}
}
