using NLog;
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

        /// <summary>
        /// Логгер
        /// </summary>
        private readonly Logger logger;

        public FormParking()
		{
			InitializeComponent();
            parkingCollection = new ParkingCollection(pictureBoxParking.Width, pictureBoxParking.Height);
            logger = LogManager.GetCurrentClassLogger();
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
            if (listBoxParkings.SelectedIndex > -1 && maskedTextBoxPlaceOnParking.Text != "")
            {
                try
                {
                    var plane = parkingCollection[listBoxParkings.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBoxPlaceOnParking.Text);
                    if (plane != null)
                    {
                        FormAtackAircraft form = new FormAtackAircraft();
                        form.SetPlane(plane);
                        form.ShowDialog();
                        logger.Info($"Изъят самолет {plane} с места {maskedTextBoxPlaceOnParking.Text}");
                        Draw();
                    }
                }
                catch (ParkingNotFoundException ex)
                {
                    MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn("Ошибка: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn("Неизвестная ошибка: " + ex.Message);
                }
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

            logger.Info($"Добавили парковку {textBoxNewLevelName.Text}");
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
                    logger.Info($"Удалили парковку {listBoxParkings.SelectedItem.ToString()}");
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
            logger.Info($"Перешли на парковку {listBoxParkings.SelectedItem.ToString()}");
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

                formSAttackAircraftConfig.ShowDialog();
            }
            else
            {
                MessageBox.Show("Гараж не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
		/// Метод добавления самолета
		/// </summary>
		/// <param name="plane"></param>
		private void AddPlane(FlyingTransport plane)
        {
            if (plane != null && listBoxParkings.SelectedIndex > -1)
            {
                try
                {
                    if ((parkingCollection[listBoxParkings.SelectedItem.ToString()]) + plane)
                    {
                        Draw();
                        logger.Info($"Добавлен самолет {plane}");
                    }
                    else
                    {
                        MessageBox.Show("Самолет не удалось поставить");
                    }
                    Draw();
                }
                catch (ParkingOverflowException ex)
                {
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn("Ошибка: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn("Неизвестная ошибка: " + ex.Message);
                }
            }
        }

        /// <summary>
        /// Обработка нажатия пункта меню "Сохранить"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    parkingCollection.SaveData(saveFileDialog.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn("Неизвестная ошибка при сохранении: " + ex.Message);
                }
            }
        }

        /// <summary>
        /// Обработка нажатия пункта меню "Загрузить"
        /// </summary>
        ///<param name="sender"></param>
        /// <param name="e"></param>
        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    parkingCollection.LoadData(openFileDialog.FileName);
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Загружено из файла " + openFileDialog.FileName);
                    ReloadLevels();
                    Draw();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при загрузку", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
