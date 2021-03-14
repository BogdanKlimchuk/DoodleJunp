using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

//Тут у нас хранится размер и позиция

namespace DoodleJump.Classes
{
    public class Object
    {
        public PointF position; 
        public Size size;

        public Object(PointF position, Size size)
        {
            this.position = position;
            this.size = size;
        }

    }
}
