﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsAtackAircraft
{
    public partial class FormAtackAircraft : Form
    {

        Random rnd = new Random();

        private ITransport plane;

        public FormAtackAircraft()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод отрисовки самолета
        /// </summary>
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxAtackAircraft.Width, pictureBoxAtackAircraft.Height);
            Graphics gr = Graphics.FromImage(bmp);
            plane.DrawTransport(gr);
            pictureBoxAtackAircraft.Image = bmp;
        }

        /// <summary>
        /// В зависимости от нажатой кнопки выбираем напрвавление передвижения
        /// </summary>
        private void buttonMove_Click(object sender, EventArgs e)
        {
            try
            {
                string name = (sender as Button).Name;
                switch (name)
                {
                    case "btnUp":
                        plane.MoveTransport(Direction.Up);
                        break;
                    case "btnDown":
                        plane.MoveTransport(Direction.Down);
                        break;
                    case "btnLeft":
                        plane.MoveTransport(Direction.Left);
                        break;
                    case "btnRight":
                        plane.MoveTransport(Direction.Right);
                        break;
                }
                Draw();
            }
            catch { }
        }

        /// <summary>
        /// Получение рандомного булего значения (true/false)
        /// </summary>
        private bool RandomBoolean()
        {
            int temp = rnd.Next(0, 2);
            if (temp == 1) { return false; }
            else { return true; }
        }

        /// <summary>
        /// Обработчик для кнопки создать обычный самолет
        /// </summary>
        private void BtnCreate_Click(object sender, EventArgs e)
        {

            plane = new Plane(rnd.Next(1000, 1500), rnd.Next(2000, 3000), Color.Blue, Color.Green, true, true, true);
            plane.SetPosition(rnd.Next(150, 200), rnd.Next(150, 200), pictureBoxAtackAircraft.Width, pictureBoxAtackAircraft.Height);
            Draw();
        }

        /// <summary>
        /// Обработчик для кнопки создать штурмовик
        /// </summary>
        private void Button1_Click(object sender, EventArgs e)
        {
            plane = new AttackAircraft(rnd.Next(1000, 1500), rnd.Next(2000, 3000), Color.Blue, Color.Red, true, true);
            plane.SetPosition(rnd.Next(150, 200), rnd.Next(150, 200), pictureBoxAtackAircraft.Width, pictureBoxAtackAircraft.Height);
            Draw();
        }
    }
}
