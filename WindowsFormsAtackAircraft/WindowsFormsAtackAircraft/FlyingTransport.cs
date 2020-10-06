using System.Drawing;

namespace WindowsFormsAtackAircraft
{
    public abstract class FlyingTransport : ITransport
    {


        /// <summary>
        /// Левая координата отрисовки воздушного транспорта
        /// </summary>
        protected float _startPosX;

        /// <summary>
        /// Правая кооридната отрисовки воздушного транспорта
        /// </summary>
        protected float _startPosY;

        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        protected int _pictureWidth;

        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        protected int _pictureHeight;

        /// <summary>
        /// Максимальная скорость воздушного транспорта
        /// </summary>
        public int MaxSpeed { protected set; get; }

        /// <summary>
        /// Вес воздушного транспорта
        /// </summary>
        public float Weight { protected set; get; }

        /// <summary>
        /// Основной и дополнительный цвета
        /// </summary>
        public Color MainColor { protected set; get; }
        public Color DopColor { protected set; get; }

        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
        }

        public abstract void DrawTransport(Graphics g);

        public abstract void MoveTransport(Direction direction);

    }
}
