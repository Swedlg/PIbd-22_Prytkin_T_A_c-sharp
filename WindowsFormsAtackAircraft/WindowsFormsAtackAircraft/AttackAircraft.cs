using System.Drawing;

namespace WindowsFormsAtackAircraft
{
    public class AttackAircraft : Plane
    {

        /// <summary>
        /// Дополнительный цвет
        /// </summary>
        public Color DopColor { private set; get; }//Красный

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
        public AttackAircraft(int maxSpeed, float weight, Color mainColor, Color dopColor, bool propeller, bool chassis, bool antenna, bool rockets, bool bombs) :
        base(maxSpeed, weight, mainColor, Color.Green, propeller, chassis, antenna, 100, -100)//высота -100 т.к. отчет от его цетнра
        {
            DopColor = dopColor;
            Rockets = rockets;
            Bombs = bombs;
        }

        /// <summary>
        /// Смена дополнительного цвета
        /// </summary>
        /// <param name="color"></param>
        public void SetDopColor(Color color)
        {
            DopColor = color;
        }

        /// <summary>
        /// Отрисовка транспорта
        /// </summary>
        /// <param name="g"></param>
        public override void DrawTransport(Graphics g)
        {

            base.DrawTransport(g);

            Pen pen = new Pen(DopColor);
            Brush brush = new SolidBrush(DopColor); ;

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
                g.FillEllipse(brush, _startPosX + 93, _startPosY - 25, 14, 28);
                g.FillEllipse(brush, _startPosX + 93, _startPosY + 25, 14, 28);
            }
        }
    }
}
