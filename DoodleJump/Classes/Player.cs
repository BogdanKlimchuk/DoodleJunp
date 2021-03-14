using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Тут хранится инфа о модельке игрока и также пара функций для отрисовки и установки картинки

namespace DoodleJump.Classes
{
    public class Player
    {
        public Physic physic;
        public static Image pict;
        public Player()
        {           
            physic = new Physic(new PointF(100, 350), new Size(50, 50));
        }
        public static void AddPlayer(Image img)
        {
            pict = img;
        }
        public void DrawPict(Graphics graf)
        {         
            graf.DrawImage(pict, physic.obj.position.X, physic.obj.position.Y, physic.obj.size.Width, physic.obj.size.Height);
            if (physic.obj.position.X < -15)
                physic.obj.position.X += 330;

            if (physic.obj.position.X >= 335)
                physic.obj.position.X = -5;
        }


    }
}
