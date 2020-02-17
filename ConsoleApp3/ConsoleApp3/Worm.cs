using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Worm:GameObject
    {
        public int Score
        {
            get;
            set;
        }

        public Worm(char sign): base(sign)
        {
            body.Add(new Point { X = 20, Y = 20 });
        }
        
       
        public void Move(int dx, int dy)
        {
            Clear();

            for(int i = body.Count - 1; i > 0; --i)
            {
                body[i].X = body[i - 1].X;
                body[i].Y = body[i - 1].Y;
            }

            body[0].X += dx;
            body[0].Y += dy;       
        }
        public void Clear()
        {
            foreach(Point p in body)
            {
                Console.SetCursorPosition(p.X, p.Y);
                Console.Write(' ');
            }
        }

        public bool CheckIntersection(List<Point> otherbody)
        {

            bool res1 = false;
          
            Console.SetCursorPosition(2, 35);
            Console.WriteLine("Your score is: {0}", Score);

            foreach (Point point in otherbody)
            {             
                    if(point.X == body[0].X && point.Y == body[0].Y)
                    {                   
                      res1 = true;
                     
                      Score++;                     
                      break;
                    }

                if (res1 == true)
                    Score++;
                    break;
            }


            return res1;
        }
        
        public bool CheckColision(List<Point> body)
        {
            bool res2 = false;
            for(int i = body.Count - 1; i>0; --i)
            {
                if (body[i].X == body[0].X && body[i].Y == body[0].Y)
                {
                    res2 = true;
                    break;
                }

                if (res2 == true) break;
            }

            return res2;
        }
        public bool CheckColision2(List<Point> wallbody)
        {
            bool res3 = false;
            foreach(Point point2 in wallbody)
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

        public void Eat(List<Point> foodbody)
        {
            body.Add(new Point { X = foodbody[0].X, Y = foodbody[0].Y });           
        }
    }
}
