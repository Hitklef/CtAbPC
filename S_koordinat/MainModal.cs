using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_koordinat
{
    public class MainModal
    {       
        private List<Point> Points;
        private double[] Result;

        public MainModal() 
        {
            Points = new List<Point>();
        }

        public void SetPoints(Point point)
        {
            Points.Add(point);
        }

        public List<Point> GetPoints()
        {
            return Points;
        }

        public void SetResult(double[] result)
        {
            Result = result;
        }

        public double[] GetResult()
        {
            return Result;
        }
    }
}
