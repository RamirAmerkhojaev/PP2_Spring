using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Food : GameObject
    {
        public Food(char sign) : base(sign)
        {
            
        }

        private bool GoodPoint(Point p, List<Point> usedPoints)
        {
            bool res = true;

            foreach (Point t in usedPoints)
            {
                if (t.X == p.X && t.Y == p.Y)
                {
                    res = false;
                    break;
                }
                if (res == false)
                    break;
            }

            return res;
        }

        public void Generate(List<Point> usedPoints1, List<Point> usedPoints2)
        {
            body.Clear();
            Random random = new Random(DateTime.Now.Second);
            Point p = new Point
            {
                X = random.Next(1, 39),
                Y = random.Next(1, 29)
            };
            while (!GoodPoint(p, usedPoints1) || !GoodPoint(p, usedPoints2))
            {
                p = new Point
                {
                    X = random.Next(1, 39),
                    Y = random.Next(1, 29)
                };
            }
            body.Add(p);
        }
        public bool Empty(List<Point> walls)
        {
            bool result = false;
            for (int i = body.Count - 1; i > 0; --i)
            {
                foreach (Point pnt in walls)
                {               
                    if (pnt.X == body[i].X && pnt.Y == body[i].Y)
                    {
                        result = true;
                        break;
                    }
                    if (result == true) break;
                }
                return result;
            }
            return result;
        }
        public bool Empty2(List<Point> checkwalls)
        {
            bool result2 = false;
            foreach (Point point2 in checkwalls)
            {
                if (point2.X == body[0].X && point2.Y == body[0].Y)
                {
                    result2 = true;
                    break;
                }

                if (result2 == true) break;
            }
            return result2;
        }
    }
}