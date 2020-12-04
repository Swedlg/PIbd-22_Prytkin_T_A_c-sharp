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
		/// Объект от коллекции парковок
		/// </summary>
		private readonly ParkingCollection parkingCollection;

		public FormParking()
		{
			InitializeComponent();
            parkingCollection = new ParkingCollection(pictureBoxParking.Width, pictureBoxParking.Height);
			Draw();
		}

		/// <summary>
		/// Метод отрисовки парковки
		/// </summary>
		private void Draw()
		{
			if (listBoxParkings.SelectedIndex > -1)
			{//если выбран один из пуктов в listBox (при старте программы ни один пункт не будет выбран и может возникнуть ошибка, если мы попытаемся обратиться к элементу listBox)
				Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
				Graphics g = Graphics.FromImage(bmp);
				parkingCollection[listBoxParkings.SelectedItem.ToString()].Draw(g);
				pictureBoxParking.Image = bmp;
			}
		}

        /// <summary>
		/// Обработка нажатия кнопки "Отправить самолет в воздух"
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonGoToSkyAttackAirctaft_Click(object sender, EventArgs e)
		{
			if (maskedTextBoxPlaceOnParking.Text != "")
			{
				var plane = parkingCollection[listBoxParkings.SelectedItem.ToString()] - (Convert.ToInt32(maskedTextBoxPlaceOnParking.Text) - 1);

				if (plane != null)
				{
					FormAtackAircraft form = new FormAtackAircraft();
					form.SetPlane(plane);
					form.ShowDialog();
				}
				Draw();
			}
		}

        /// <summary>
        /// Заполнение listBoxLevels
        /// </summary>
        private void ReloadLevels()
        {
            int index = listBoxParkings.SelectedIndex;
            listBoxParkings.Items.Clear();
            for (int i = 0; i < parkingCollection.Keys.Count; i++)
            {
                listBoxParkings.Items.Add(parkingCollection.Keys[i]);
            }
            if (listBoxParkings.Items.Count > 0 && (index == -1 || index >= listBoxParkings.Items.Count))
            {
                listBoxParkings.SelectedIndex = 0;
            }
            else if (listBoxParkings.Items.Count > 0 && index > -1 && index < listBoxParkings.Items.Count)
            {
                listBoxParkings.SelectedIndex = index;
            }
        }

        /// <summary>
        /// Добавить парковку
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddParking_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNewLevelName.Text))
            {
                MessageBox.Show("Введите название парковки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            parkingCollection.AddParking(textBoxNewLevelName.Text);
            ReloadLevels();
        }

        /// <summary>
        /// Удалить парковку
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteParking_Click(object sender, EventArgs e)
        {
            if (listBoxParkings.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить парковку {listBoxParkings.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    parkingCollection.DelParking(listBoxParkings.SelectedItem.ToString());
                    ReloadLevels();
                }
            }
        }
      
        /// <summary>
        /// Выбрать парковку (вызовется ее отрисовка)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxParkings_SelectedIndexChanged(object sender, EventArgs e)
        {
            Draw();
        }

        /// <summary>
		/// Обработчик кнопки припарковать самолет
		/// </summary>
		private void buttonParkPlane_Click(object sender, EventArgs e)
        {
            if (listBoxParkings.SelectedIndex > -1)
            {
                var formSAttackAircraftConfig = new FormAttackAircraftConfig();

                formSAttackAircraftConfig.AddEvent(AddPlane);

                formSAttackAircraftConfig.eventAddPlane += PrintMessage;

                formSAttackAircraftConfig.ShowDialog();
            }
            else
            {
                MessageBox.Show("Гараж не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
		/// Выводит диалоговое окно с надписью
		/// </summary>
        public void PrintMessage(FlyingTransport f)
        {
            MessageBox.Show("Самолет припаркован");
        }

        /// <summary>
		/// Метод добавления самолета
		/// </summary>
		/// <param name="plane"></param>
		private void AddPlane(FlyingTransport plane)
        {
            if (plane != null && listBoxParkings.SelectedIndex > -1)
            {
                if ((parkingCollection[listBoxParkings.SelectedItem.ToString()]) + plane)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Самолет не удалось поставить");
                }
            }
        }
    }
}
