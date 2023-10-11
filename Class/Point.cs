using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class Point
    {
    }

    public class PointTT
    {
        public int X { get; }
        public int Y { get; }

        public PointTT(int x, int y) => (X, Y) = (x, y);
    }

    public class PointFactory
    {
        private readonly int numberOfPoints;

        public PointFactory()
        {
            this.numberOfPoints = numberOfPoints;
        }

        public IEnumerable<PointTT> CreatePoints()
        {
            var generator = new Random();
            for (int i = 0; i < numberOfPoints; i++)
            {
                yield return new PointTT(generator.Next(), generator.Next());
            }
        }
    }
}
