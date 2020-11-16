using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAtackAircraft
{
    class AtackAircraft
    {

        /// <summary>
        /// Стартовая координата X
        /// </summary>
        private float _startPosX;

        /// <summary>
        /// Стартовая координата Y
        /// </summary>
        private float _startPosY;

        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private int _pictureWidth;

        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private int _pictureHeight;

        /// <summary>
        /// Ширина отрисовки штурмовика
        /// </summary>
        private readonly int atackAircraftWidth = 200;

        /// <summary>
        /// Высота отрисовки штурмовика
        /// </summary>
        private readonly int atackAircraftHeight = 100;

        /// <summary>
        /// Максимальная скорость
        /// </summary>
        public int MaxSpeed { private set; get; }

        /// <summary>
        /// Вес штурмовика
        /// </summary>
        public float Weight { private set; get; }

        /// <summary>
        /// Основной цвет штурмовика
        /// </summary>
        public Color MainColor { private set; get; }

        /// <summary>
        /// Дополнительные цвета штурмовика
        /// </summary>
        public Color DopColor { private set; get; }


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
        /// Признак наличия камуфляжа
        /// </summary>
        public bool Сamouflage { private set; get; }

        /// <summary>
        /// Признак наличия ракет
        /// </summary>
        public bool Rockets { private set; get; }

        /// <summary>
        /// Признак наличия бомб
        /// </summary>
        public bool Bombs { private set; get; }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес штурмовика</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        /// <param name="dopColor">Дополнительный цвет</param>
        /// <param name="dopColor2">Дополнительный цвет</param>
        /// <param name="dopColor3">Дополнительный цвет</param>
        /// <param name="propeller">Признак наличия переднего спойлера</param>
        /// <param name="chassis">Признак наличия боковых спойлеров</param>
        /// <param name="antenna">Признак наличия заднего спойлера</param>
        /// <param name="camouflage">Признак наличия гоночной полосы</param>
        /// <param name="rockets">Признак наличия заднего спойлера</param>
        /// <param name="bombs">Признак наличия гоночной полосы</param>
        public AtackAircraft(int maxSpeed, float weight, Color mainColor, Color dopColor, bool propeller, bool chassis, bool antenna, bool rockets, bool bombs)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            Propeller = propeller;
            Сhassis = chassis;
            Antenna = antenna;
            Rockets = rockets;
            Bombs = bombs;
            Сamouflage = rockets || bombs;
        }

        /// <summary>
        /// Установка позиции штурмовика
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <param name="width">Ширина картинки</param>
        /// <param name="height">Высота картинки</param>
        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }

        /// <summary>
        /// Изменение направления пермещения
        /// </summary>
        /// <param name="direction">Направление</param>
        public void MoveTransport(Direction direction)
        {
            int leftbody = 0;//выступ левой части
            int topbudy = 100;//выступ основной части корабля
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - atackAircraftWidth)
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
                    if (_startPosY - step > topbudy)
                    {
                        _startPosY -= step;
                    }
                    break;
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - atackAircraftHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }

        /// <summary>
        /// Отрисовка штурмовика
        /// </summary>
        /// <param name="g">Графика</param>
        public void DrawTransport(Graphics g)
        {
            
            Color ColorPropellerChassisAntena = Color.Green;
            Color ColorCamuflage = Color.Yellow;

            Pen pen = new Pen(MainColor);
            Brush brush;
            if (Сamouflage)
            {
                brush = new SolidBrush(MainColor);
            }
            else
            {
                brush = new SolidBrush(ColorCamuflage);
            }

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
                pen = new Pen(ColorPropellerChassisAntena);
                pen.Width = 3;
                g.DrawLine(pen, _startPosX + 85, _startPosY - 95, _startPosX + 115, _startPosY - 95);
                
            }
            if (Сhassis)
            {
                pen = new Pen(ColorPropellerChassisAntena);
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
                pen = new Pen(ColorPropellerChassisAntena);
                pen.Width = 3;
                g.DrawLine(pen, _startPosX + 100, _startPosY + 95, _startPosX + 100, _startPosY + 120);
            }
            if (Rockets)
            {
                pen = new Pen(DopColor);
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
                brush = new SolidBrush(DopColor);
                g.FillEllipse(brush, _startPosX + 93, _startPosY - 25, 14, 28);
                g.FillEllipse(brush, _startPosX + 93, _startPosY + 25, 14, 28);
            }
        }
    }
}
