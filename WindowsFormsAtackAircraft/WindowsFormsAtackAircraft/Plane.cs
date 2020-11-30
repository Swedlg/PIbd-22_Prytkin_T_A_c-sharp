using System;
using System.Drawing;

namespace WindowsFormsAtackAircraft
{
    public class Plane : FlyingTransport
    {

        /// <summary>
        /// Ширина отрисовки самолета
        /// </summary>
        protected readonly int planeWidth = 200;

        /// <summary>
        /// Высота отрисовки самолета
        /// </summary>
        protected readonly int planeHeight = 200;

        /// <summary>
        /// Признак пропеллера
        /// </summary>
        public bool Propeller { private set; get; }

        /// <summary>
        /// Признак наличия шасси
        /// </summary>
        public bool Сhassis { private set; get; }

        /// <summary>
        /// Признак наличия антенна
        /// </summary>
        public bool Antenna { private set; get; }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес автомобиля</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        public Plane(int maxSpeed, float weight, Color mainColor, Color dopColor, bool propeller, bool chassis, bool antenna)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColorOfPropellerShassisAntenna = dopColor;
            Propeller = propeller;
            Сhassis = chassis;
            Antenna = antenna;
        }

        /// <summary>
        /// Конструктор с изменением размеров машины
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес автомобиля</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        /// <param name="planeWidth">Ширина отрисовки автомобиля</param>
        /// <param name="planeHeight">Высота отрисовки автомобиля</param>
        protected Plane(int maxSpeed, float weight, Color mainColor, Color dopColor, bool propeller, bool chassis, bool antenna, int planeWidth, int planeHeight)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColorOfPropellerShassisAntenna = dopColor;
            Propeller = propeller;
            Сhassis = chassis;
            Antenna = antenna;
            this.planeWidth = planeWidth;
            this.planeHeight = planeHeight;

        }

        /// <summary>
        /// Передвижение транпорта
        /// </summary>
        /// <param name="direction"></param>
        public override void MoveTransport(Direction direction)
        {
            int leftbody = 0;//выступ левой части
            int topbody = 100;//выступ основной части корабля
            float step = MaxSpeed * 100 / Weight;

            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - planeWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                case Direction.Left:
                    if (_startPosX - step > leftbody)
                    {
                        _startPosX -= step;
                    }
                    break;
                case Direction.Up:
                    if (_startPosY - step > topbody)
                    {
                        _startPosY -= step;
                    }
                    break;
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - planeHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }

        /// <summary>
        /// Отрисовка транспорта
        /// </summary>
        /// <param name="g"></param>
        public override void DrawTransport(Graphics g)
        {

            Pen pen = new Pen(DopColorOfPropellerShassisAntenna);
            Brush brush = new SolidBrush(MainColor); ;

            //pen.Width = 16;

            //самолет
            Point point1 = new Point((int)_startPosX + 100, (int)_startPosY - 100);
            Point point2 = new Point((int)_startPosX + 110, (int)_startPosY - 75);
            Point point3 = new Point((int)_startPosX + 110, (int)_startPosY - 10);
            Point point4 = new Point((int)_startPosX + 200, (int)_startPosY + 25);
            Point point5 = new Point((int)_startPosX + 200, (int)_startPosY + 50);
            Point point6 = new Point((int)_startPosX + 110, (int)_startPosY + 50);
            Point point7 = new Point((int)_startPosX + 110, (int)_startPosY + 75);
            Point point8 = new Point((int)_startPosX + 125, (int)_startPosY + 100);
            Point point9 = new Point((int)_startPosX + 110, (int)_startPosY + 100);
            Point point10 = new Point((int)_startPosX + 100, (int)_startPosY + 110);//
            Point point11 = new Point((int)_startPosX + 90, (int)_startPosY + 100);
            Point point12 = new Point((int)_startPosX + 75, (int)_startPosY + 100);
            Point point13 = new Point((int)_startPosX + 90, (int)_startPosY + 75);
            Point point14 = new Point((int)_startPosX + 90, (int)_startPosY + 50);
            Point point15 = new Point((int)_startPosX, (int)_startPosY + 50);
            Point point16 = new Point((int)_startPosX, (int)_startPosY + 25);
            Point point17 = new Point((int)_startPosX + 90, (int)_startPosY - 10);
            Point point18 = new Point((int)_startPosX + 90, (int)_startPosY - 75);

            Point[] curvePoints = { point1, point2, point3, point4, point5, point6, point7, point8, point9, point10, point11, point12, point13, point14, point15, point16, point17, point18 };
            g.FillPolygon(brush, curvePoints);

            if (Propeller)
            {
                pen = new Pen(DopColorOfPropellerShassisAntenna);
                pen.Width = 3;
                g.DrawLine(pen, _startPosX + 85, _startPosY - 95, _startPosX + 115, _startPosY - 95);

            }
            if (Сhassis)
            {
                pen = new Pen(DopColorOfPropellerShassisAntenna);
                pen.Width = 3;
                g.DrawLine(pen, _startPosX + 100, _startPosY - 75, _startPosX + 100, _startPosY - 50);
                g.DrawEllipse(pen, _startPosX + 97, _startPosY - 65, 6, 6);
                g.DrawLine(pen, _startPosX + 75, _startPosY + 35, _startPosX + 75, _startPosY + 60);
                g.DrawEllipse(pen, _startPosX + 72, _startPosY + 44, 6, 6);
                g.DrawLine(pen, _startPosX + 125, _startPosY + 35, _startPosX + 125, _startPosY + 60);
                g.DrawEllipse(pen, _startPosX + 122, _startPosY + 44, 6, 6);
            }
            if (Antenna)
            {
                pen = new Pen(DopColorOfPropellerShassisAntenna);
                pen.Width = 3;
                g.DrawLine(pen, _startPosX + 100, _startPosY + 95, _startPosX + 100, _startPosY + 120);
            }
        }
    }
}
