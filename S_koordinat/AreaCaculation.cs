using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_koordinat
{
    static class AreaCaculation
    {
        static double GetArea(Point[] points) 
        {
            double s1 = 0;
            double s2 = 0;
            for(int i=1; i<points.Length; i++) 
            {
                s1 = s1 + (points[i - 1].X - points[i + 1].X) * points[i].Y;
                s2 = s2 + (points[i + 1].Y - points[i - 1].Y) * points[i].X;
            }
            s1 = s1 + (points[points.Length].X - points[1].X) * points[0].Y + (points[points.Length-1].X - points[0].X) * points[points.Length].Y;
            s2 = s2 + (points[1].Y - points[points.Length].Y) * points[0].X + (points[0].Y - points[points.Length - 1].Y) * points[points.Length].X;
            s1 = s1 / 2.0;
            s2 = s2 / 2.0;
            return 0;
        }
    }
}
