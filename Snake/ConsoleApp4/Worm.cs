using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Worm : GameObject
    {
            
        public int Dx
        {
            get;
            set;
        }
        public int Dy
        {
            get;
            set;
        }

        public Worm(char sign) : base(sign)
        {
            body.Add(new Point { X = 10, Y = 10 });
            Dx = Dy = 0;
        }
        public void Move()
        {
            for (int i = body.Count - 1; i > 0; --i)
            {
                body[i].X = body[i-1].X;
                body[i].Y = body[i-1].Y;
               
            }

            body[0].X += Dx;
            body[0].Y += Dy;
        }

        public bool CheckIntersection(List<Point> otherBody)
        {            
            bool res = false;            

            foreach (Point point in otherBody)
            {
                if (point.X == body[0].X &&
                    point.Y == body[0].Y)
                    
                {                   
                    res = true;
                    break;
                }

                if (res == true)
                    break;
            }

            return res;
        }

        public bool CheckColision(List<Point> wormbody)
        {
            bool res2 = false;

            for (int i = body.Count - 1; i > 0; --i)
            {
                if (wormbody[i].X == body[0].X && wormbody[i].Y == body[0].Y)
                {                 
                    res2 = true;
                    break;
                }

                if (res2 == true)
                {
                    break;
                }
            }
            return res2;
        }
        public bool CheckColision2(List<Point> wallbody)
        {
            bool res3 = false;
            foreach (Point point2 in wallbody)
            {
                if (point2.X == body[0].X && point2.Y == body[0].Y)
                {
                    res3 = true;
                    break;
                }

                if (res3 == true) break;
            }

            return res3;
        }

        public void Eat(List<Point> foodBody)
        {
            body.Add(new Point { X = foodBody[0].X, Y = foodBody[0].Y });
        }
    }
}