using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsAtackAircraft
{
    public partial class FormAtackAircraft : Form
    {

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
        /// Передача самолета на форму
        /// </summary>
        /// <param name="plane"></param>
        public void SetPlane(ITransport plane)
        {
            this.plane = plane;
            Draw();
        }

        /// <summary>
        /// Обработчие переджвижения самолета
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
    }
}
