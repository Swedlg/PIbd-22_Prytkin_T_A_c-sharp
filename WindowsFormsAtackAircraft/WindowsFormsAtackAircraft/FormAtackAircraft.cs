using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsAtackAircraft
{
    public partial class FormAtackAircraft : Form
    {

        Random rnd = new Random();

        private AtackAircraft atackAircraft;

        public FormAtackAircraft()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Метод отрисовки штурмовика
        /// </summary>
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxAtackAircraft.Width, pictureBoxAtackAircraft.Height);
            Graphics gr = Graphics.FromImage(bmp);
            atackAircraft.DrawTransport(gr);
            pictureBoxAtackAircraft.Image = bmp;
        }

        /// <summary>
        /// Обработчик нажатия на кнопку переджвижения
        /// </summary>
        private void buttonMove_Click(object sender, EventArgs e)
        {
            try
            {
                string name = (sender as Button).Name;
                switch (name)
                {
                    case "btnUp":
                        atackAircraft.MoveTransport(Direction.Up);
                        break;
                    case "btnDown":
                        atackAircraft.MoveTransport(Direction.Down);
                        break;
                    case "btnLeft":
                        atackAircraft.MoveTransport(Direction.Left);
                        break;
                    case "btnRight":
                        atackAircraft.MoveTransport(Direction.Right);
                        break;
                }
                Draw();
            }
            catch { }        
        }

        private bool RandomBoolean()
        {
            int temp = rnd.Next(0, 2);
            if (temp == 1) { return false; }
            else { return true; }
        }

        /// <summary>
        /// Обработчик нажатия на кнопку создать самолет
        /// </summary>
        private void ButtonCreatePlane_Click(object sender, EventArgs e)
        {       
            atackAircraft = new AtackAircraft(rnd.Next(1000, 1500), rnd.Next(2000, 3000), Color.Blue, Color.Red, RandomBoolean(), RandomBoolean(), RandomBoolean(), RandomBoolean(), RandomBoolean());
            atackAircraft.SetPosition(rnd.Next(150, 200), rnd.Next(150, 200), pictureBoxAtackAircraft.Width, pictureBoxAtackAircraft.Height);
            Draw();
        }

        /// <summary>
        /// Обработчик нажатия на кнопку создать штурмовик
        /// </summary>
        private void ButtonCreateAttackAircraft_Click(object sender, EventArgs e)
        {
            atackAircraft = new AtackAircraft(rnd.Next(1000, 1500), rnd.Next(2000, 3000), Color.Blue, Color.Red, true, true, true, true, true);
            atackAircraft.SetPosition(rnd.Next(150, 200), rnd.Next(150, 200), pictureBoxAtackAircraft.Width, pictureBoxAtackAircraft.Height);
            Draw();
        }
    }
}
