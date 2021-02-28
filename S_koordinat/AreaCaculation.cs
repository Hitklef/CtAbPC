using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_koordinat
{
    public static class AreaCaculation
    {
        public static double[] GetArea(Point[] points) 
        {
            double s1 = 0;
            double s2 = 0;
            for(int i = 1; i < points.Length - 1; i++) 
            {
                s1 += (points[i - 1].X - points[i + 1].X) * points[i].Y;
                s2 += (points[i + 1].Y - points[i - 1].Y) * points[i].X;
            }
            s1 += (points[points.Length - 1].X - points[1].X) * points[0].Y + (points[points.Length - 2].X - points[0].X) * points[points.Length - 1].Y;
            s2 += (points[1].Y - points[points.Length - 1].Y) * points[0].X + (points[0].Y - points[points.Length - 2].Y) * points[points.Length - 1].X;
            double Sx = s1 / 2.0;
            double Sy = s2 / 2.0;

            return new double[] { Sx, Sy};
        }
    }
}
