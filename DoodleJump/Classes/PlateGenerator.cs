using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Тут генерируются пратвормы и тут надо дописать

namespace DoodleJump.Classes
{
    public static class PlateGenerator
    {
        public static List<Plate> plates;
        public static int startPlatePosY = 400;

        public static void AddPlate(PointF position)    //Магия не трогать!!!!!
        {
            Plate plate = new Plate(position);
            plates.Add(plate);
        }
        public static void GenerateStartPlatform()
        {
            Random rnd = new Random();

            for (int i = 0; i < 15; i++)
            {
                ClearPlatforms();
                int x = rnd.Next(0, 250);
                PointF position = new PointF(x, startPlatePosY -= rnd.Next(40, 50));
                Plate plate = new Plate(position);
                plates.Add(plate);
            }
        }
        public static void GenerateRandomPlatform()
        {
            Random rnd = new Random();

            ClearPlatforms();
            int x = rnd.Next(0, 250);
            PointF position = new PointF(x, startPlatePosY);
            Plate plate = new Plate(position);
            plates.Add(plate);
        }
        public static void ClearPlatforms()
        {
            for (int i = 0; i < plates.Count; i++)
            {
                if (plates[i].obj.position.Y >= 500)
                    plates.RemoveAt(i);
            }
        }

    }
}
