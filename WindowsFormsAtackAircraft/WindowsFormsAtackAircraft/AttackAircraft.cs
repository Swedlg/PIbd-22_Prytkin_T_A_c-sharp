using System.Drawing;

namespace WindowsFormsAtackAircraft
{
    public class AttackAircraft : Plane
    {

        /// <summary>
        /// Дополнительный цвет
        /// </summary>
        public Color DopColor2 { private set; get; }//Красный

        /// <summary>
        /// Признак наличия ракет
        /// </summary>
        public bool Rockets { private set; get; }

        /// <summary>
        /// Признак наличия заднего бомб
        /// </summary>
        public bool Bombs { private set; get; }


        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес автомобиля</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        /// <param name="dopColor">Дополнительный цвет</param>
        /// public SportCar(int maxSpeed, float weight, Color mainColor, Color dopColor, bool frontSpoiler, bool sideSpoiler, bool backSpoiler, bool sportLine) :


        public AttackAircraft(int maxSpeed, float weight, Color mainColor, Color dopColor2, bool rockets, bool bombs) :
        base(maxSpeed, weight, mainColor, Color.Green, true, true, true, 100, 60)
        {
            DopColor2 = dopColor2;
            Rockets = rockets;
            Bombs = bombs;

        }

        public override void DrawTransport(Graphics g)
        {

            base.DrawTransport(g);

            Pen pen = new Pen(DopColor2);
            Brush brush;

            if (Rockets)
            {
                pen.Width = 5;

                g.DrawLine(pen, _startPosX + 25, _startPosY + 10, _startPosX + 25, _startPosY + 35);
                g.DrawLine(pen, _startPosX + 50, _startPosY, _startPosX + 50, _startPosY + 25);
                g.DrawLine(pen, _startPosX + 75, _startPosY - 10, _startPosX + 75, _startPosY + 15);

                g.DrawLine(pen, _startPosX + 125, _startPosY - 10, _startPosX + 125, _startPosY + 15);
                g.DrawLine(pen, _startPosX + 150, _startPosY, _startPosX + 150, _startPosY + 25);
                g.DrawLine(pen, _startPosX + 175, _startPosY + 10, _startPosX + 175, _startPosY + 35);

            }
            if (Bombs)
            {
                brush = new SolidBrush(DopColor2);
                g.FillEllipse(brush, _startPosX + 93, _startPosY - 25, 14, 28);
                g.FillEllipse(brush, _startPosX + 93, _startPosY + 25, 14, 28);
            }
        }
    }
}
