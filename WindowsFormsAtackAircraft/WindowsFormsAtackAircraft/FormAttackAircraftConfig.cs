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
    public partial class FormAttackAircraftConfig : Form
    {
        /// <summary>
        /// Переменная - выбранный самолет
        /// </summary>
        FlyingTransport plane = null;

        public Action<FlyingTransport> eventAddPlane;

        public FormAttackAircraftConfig()
        {
            InitializeComponent();

            panelRed.MouseDown += panelColor_MouseDown;
            panelYellow.MouseDown += panelColor_MouseDown;
            panelBlack.MouseDown += panelColor_MouseDown;
            panelWhite.MouseDown += panelColor_MouseDown;
            panelGrey.MouseDown += panelColor_MouseDown;
            panelOrange.MouseDown += panelColor_MouseDown;
            panelGreen.MouseDown += panelColor_MouseDown;
            panelBlue.MouseDown += panelColor_MouseDown;

            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }


        /// <summary>
        /// Перенос цвета
        /// </summary>
        private void panelColor_MouseDown(object Sender, MouseEventArgs e)
        {
            Control panelColor = (Control)Sender;
            panelColor.DoDragDrop(panelColor.BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }

        /// <summary>
        /// Отрисовать самолет
        /// </summary>
        private void DrawPlane()
        {
            if (plane != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxPlane.Width, pictureBoxPlane.Height);
                Graphics gr = Graphics.FromImage(bmp);
                plane.SetPosition(30, 105, pictureBoxPlane.Width, pictureBoxPlane.Height);
                plane.DrawTransport(gr);
                pictureBoxPlane.Image = bmp;
            }
        }

        /// <summary>
        /// Передаем информацию при нажатии на Label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelPlane_MouseDown(object sender, MouseEventArgs e)
        {
            labelPlane.DoDragDrop(labelPlane.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }


        /// <summary>
        /// Проверка получаемой информации (ее типа на соответствие требуемому)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void PanelPlane_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        /// <summary>
        /// Действия при приеме перетаскиваемой информации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PanelPlane_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Военный самолет":
                    plane = new Plane((int)numericUpDownMaxSpeed.Value, (int)numericUpDownWeight.Value, Color.Black, Color.Green, checkBoxPropeller.Checked, checkBoxChassis.Checked, checkBoxAntenna.Checked);
                    break;
                case "Штурмовик":
                    plane = new AttackAircraft((int)numericUpDownMaxSpeed.Value, (int)numericUpDownWeight.Value, Color.Gray, Color.Red, checkBoxPropeller.Checked, checkBoxChassis.Checked, checkBoxAntenna.Checked, checkBoxRockets.Checked, checkBoxBombs.Checked);
                    break;
            }
            DrawPlane();
        }

        /// <summary>
        /// 
        /// </summary>
        private void LabelMainColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void LabelMainColor_DragDrop(object sender, DragEventArgs e)
        {
            if (plane != null)
            {
                plane.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawPlane();
            }
        }


        /// <summary>
        /// 
        /// </summary>
        private void LabelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (plane is AttackAircraft)
            {
                AttackAircraft attackAircraft = (AttackAircraft)plane;
                attackAircraft.SetDopColor((Color)e.Data.GetData(typeof(Color)));
                DrawPlane();
            }
        }

        /// <summary>
        /// Выбираем итоговый вариант самолета
        /// </summary>
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            eventAddPlane?.Invoke(plane);
            Close();
        }


        public void PrintMessage(object sender, EventArgs e)
        {
            MessageBox.Show("Хотим припарковать самолет!");
        }


        /// <summary>
        /// Добавление события
        /// </summary>
        /// <param name="ev"></param>
        public void AddEvent(Action<FlyingTransport> ev)
        {
            if (eventAddPlane == null)
            {
                eventAddPlane = new Action<FlyingTransport>(ev);
            }
            else
            {
                eventAddPlane += ev;
            }
        }

        private void labelAttackAircraft_MouseDown(object sender, MouseEventArgs e)
        {
            labelAttackAircraft.DoDragDrop(labelAttackAircraft.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }
    }
}
