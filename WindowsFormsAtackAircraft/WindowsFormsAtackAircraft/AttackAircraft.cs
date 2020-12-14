using System;
using System.Drawing;

namespace WindowsFormsAtackAircraft
{
    public class AttackAircraft : Plane, IEquatable<AttackAircraft>
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
        /// Конструктор для загрузки с файла
        /// </summary>
        /// <param name="info"></param>
        public AttackAircraft(string info) : base(info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 9)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromArgb(Convert.ToInt32(strs[2]));
                DopColorOfPropellerShassisAntenna = Color.Green;
                DopColor = Color.FromArgb(Convert.ToInt32(strs[3]));
                Propeller = Convert.ToBoolean(strs[4]);
                Сhassis = Convert.ToBoolean(strs[5]);
                Antenna = Convert.ToBoolean(strs[6]);
                Rockets = Convert.ToBoolean(strs[7]);
                Bombs = Convert.ToBoolean(strs[8]);
            }
        }

        /// <summary>
        /// Вернуть как строку
        /// </summary>
        public override string ToString()
        {
            return $"{MaxSpeed}{separator}{Weight}{separator}{MainColor.ToArgb()}{separator}{DopColor.ToArgb()}{separator}{Propeller}{separator}{Сhassis}{separator}{Antenna}{separator}{Rockets}{separator}{Bombs}";
        }

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





        /// <summary>
        /// Метод интерфейса IEquatable для класса AttackAircraft
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(AttackAircraft other)
        {
            // Реализовать метод сравнения для дочернего класса

            if (other == null)
            {
                return false;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return false;
            }
            if (Weight != other.Weight)
            {
                return false;
            }
            if (MainColor != other.MainColor)
            {
                return false;
            }
            if (Propeller != other.Propeller)
            {
                return false;
            }
            if (Сhassis != other.Сhassis)
            {
                return false;
            }
            if (Antenna != other.Antenna)
            {
                return false;
            }
            if (Rockets != other.Rockets)
            {
                return false;
            }
            if (Bombs != other.Bombs)
            {
                return false;
            }
            if (DopColor != other.DopColor)
            {
                return false;
            }
            return true;
        }





        /// <summary>
        /// Перегрузка метода от object
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is AttackAircraft attackAircraftObj))
            {
                return false;
            }
            else
            {
                return Equals(attackAircraftObj);
            }
        }




    }
}
