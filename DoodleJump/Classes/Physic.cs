using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DoodleJump.Classes
{
    public class Physic
    {
        public Object obj;
        public float gravity;
        float a;
        public static int score = 0;  // Вот эта хрень
        public float dx;

        public Physic(PointF position, Size size)
        {
            obj = new Object(position, size);
            gravity = 0;
            a = 0.35f;
            dx = 0;
        }

        public void ApplyPhysics()
        {
            CalculatePhysics();
        }

        public void AddForce()
        {
            gravity = -10;
        }
        public void CalculatePhysics()
        {
            if (dx != 0)
            {
                obj.position.X += dx;                
            }
            if (obj.position.Y < 500)
            {
                obj.position.Y += gravity;
                gravity += a;

                Collision();
            }
        }

        public void Collision()
        {
            for (int i = 0; i < PlateGenerator.plates.Count; i++)
            {
                var platform = PlateGenerator.plates[i];
                if (obj.position.X + obj.size.Width / 2 >= platform.obj.position.X && obj.position.X + obj.size.Width / 2 <= platform.obj.position.X + platform.obj.size.Width)
                {
                    if (obj.position.Y + obj.size.Height >= platform.obj.position.Y && obj.position.Y + obj.size.Height <= platform.obj.position.Y + platform.obj.size.Height)
                    {
                        if (gravity > 0)
                        {
                            AddForce();
                            if (!platform.isTouchedByPlayer)
                            {
                                PlateGenerator.GenerateRandomPlatform();
                                PlateGenerator.GenerateHelpPlatform();
                                score += 20;
                                platform.isTouchedByPlayer = true;
                            }
                        }
                    }
                }
            }
        }




    }
}
