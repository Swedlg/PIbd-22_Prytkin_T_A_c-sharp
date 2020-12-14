using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAtackAircraft
{
    /// <summary>
	/// Класс-коллекция парковок
	/// </summary>
	public class ParkingCollection
    {
        /// <summary>
        /// Словарь (хранилище) с парковками
        /// </summary>
        readonly Dictionary<string, Parking<FlyingTransport>> parkingStages;

        /// <summary>
        /// Возвращение списка названий праковок
        /// </summary>
        public List<string> Keys => parkingStages.Keys.ToList();

        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private readonly int pictureWidth;

        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private readonly int pictureHeight;

        /// <summary>
        /// Разделитель для записи информации в файл
        /// </summary>
        private readonly char separator = ':';

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="pictureWidth"></param>
        /// <param name="pictureHeight"></param>
        public ParkingCollection(int pictureWidth, int pictureHeight)
        {
            parkingStages = new Dictionary<string, Parking<FlyingTransport>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        }

        /// <summary>
        /// Добавление парковки
        /// </summary>
        /// <param name="name">Название парковки</param>
        public void AddParking(string name)
        {
            if (parkingStages.ContainsKey(name))
            {
                MessageBox.Show("Уже существует такая парковка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                parkingStages.Add(name, new Parking<FlyingTransport>(pictureWidth, pictureHeight));
            }
        }

        /// <summary>
        /// Удаление парковки
        /// </summary>
        /// <param name="name">Название парковки</param>
        public void DelParking(string name)
        {
            if (parkingStages.ContainsKey(name))
            {
                parkingStages.Remove(name);
            }
            else
            {
                MessageBox.Show("Нет такой парковки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Доступ к парковке
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Parking<FlyingTransport> this[string index]
        {
            get
            {
                if (parkingStages.ContainsKey(index))
                {
                    return parkingStages[index];
                }
                return null;
            }
        }

        /// <summary>
        /// Сохранение информации по автомобилям на парковках в файл
        /// </summary>
        /// <param name="filename">Путь и имя файла</param>
        /// <returns></returns>
        public void SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }

            using (StreamWriter streamWriter = new StreamWriter(filename, true, Encoding.UTF8))
            {
                streamWriter.WriteLine("ParkingCollection");

                foreach (var level in parkingStages)
                {
                    //Начинаем парковку
                    streamWriter.WriteLine($"Parking{separator}{level.Key}");
                    ITransport plane = null;
                    for (int i = 0; (plane = level.Value.GetNext(i)) != null; i++)
                    {
                        if (plane != null)
                        {
                            //если место не пустое
                            //Записываем тип самолета
                            if (plane.GetType().Name == "Plane")
                            {
                                streamWriter.Write($"Plane{separator}");
                            }
                            if (plane.GetType().Name == "AttackAircraft")
                            {
                                streamWriter.Write($"AttackAircraft{separator}");
                            }

                            //Записываемые параметры
                            streamWriter.WriteLine(plane);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Загрузка нформации по автомобилям на парковках из файла
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public void LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }

            using (StreamReader streamReader = new StreamReader(filename, Encoding.UTF8))
            {

                String strs = streamReader.ReadLine();

                if (strs.Contains("ParkingCollection"))
                {
                    //очищаем записи
                    parkingStages.Clear();
                }

                else
                {
                    //если нет такой записи, то это не те данные
                    throw new Exception("Неверный формат файла");
                }
                FlyingTransport plane = null;
                string key = string.Empty;

                while ((strs = streamReader.ReadLine()) != null)
                {
                    //идем по считанным записям
                    if (strs.Contains("Parking"))
                    {
                        //начинаем новую парковку
                        key = strs.Split(separator)[1];
                        parkingStages.Add(key, new Parking<FlyingTransport>(pictureWidth, pictureHeight));
                        continue;
                    }
                    if (string.IsNullOrEmpty(strs))
                    {
                        continue;
                    }
                    if (strs.Split(separator)[0] == "Plane")
                    {
                        plane = new Plane(strs.Split(separator)[1]);
                    }
                    else if (strs.Split(separator)[0] == "AttackAircraft")
                    {
                        plane = new AttackAircraft(strs.Split(separator)[1]);
                    }


                    if (!(parkingStages[key] + plane))
                    {
                        throw new Exception("Не удалось загрузить cамолет на парковку");
                    }
                }
            }
        }
    }
}
