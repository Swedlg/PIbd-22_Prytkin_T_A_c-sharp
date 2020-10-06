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

        private void BtnCreate_Click(object sender, EventArgs e)
        {       
            atackAircraft = new AtackAircraft(rnd.Next(1000, 1500), rnd.Next(2000, 3000), Color.Blue, Color.Red, Color.Green, Color.Yellow, RandomBoolean(), RandomBoolean(), RandomBoolean(), RandomBoolean(), RandomBoolean());
            atackAircraft.SetPosition(rnd.Next(150, 200), rnd.Next(150, 200), pictureBoxAtackAircraft.Width, pictureBoxAtackAircraft.Height);
            Draw();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            atackAircraft = new AtackAircraft(rnd.Next(1000, 1500), rnd.Next(2000, 3000), Color.Blue, Color.Red, Color.Green, Color.Yellow, true, true, true, true, true);
            atackAircraft.SetPosition(rnd.Next(150, 200), rnd.Next(150, 200), pictureBoxAtackAircraft.Width, pictureBoxAtackAircraft.Height);
            Draw();
        }
    }
}
