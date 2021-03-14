using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

//Тут у нас платформы размер и позиция также пара функций для установки картинки и отрисовки

namespace DoodleJump.Classes
{
    public class Plate
    {
        static Image platform;

        public Object obj;
        public int sizeX;
        public int sizeY;
        public bool isTouchedByPlayer;

        public Plate(PointF position)
        {
            sizeX = 60;
            sizeY = 12;
            obj = new Object(position, new Size(sizeX, sizeY));
            isTouchedByPlayer = false;
        }
        public static void AdImage(Image img)
        {
            platform = img;
        }
        public void DrawPlate(Graphics graphics)
        {
            graphics.DrawImage(platform, obj.position.X, obj.position.Y, obj.size.Width, obj.size.Height);
        }



    }
}
