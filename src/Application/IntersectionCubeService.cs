using CubeIntersection.src.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeIntersection.src.Application
{
    public class IntersectionCubeService
    {
        private Cube cube1;
        private Cube cube2;

        public IntersectionCubeService(double size1, double x1, double y1, double z1, double size2, double x2, double y2, double z2)
        {
            this.cube1 = new Cube(size1, x1, y1, z1);
            this.cube2 = new Cube(size2, x2, y2, z2);
        }
        public double VolumenIntersection()
        {
            double xMinIntersect = Math.Max(cube1.getXMin(), cube2.getXMin());
            double yMinIntersect = Math.Max(cube1.getYMin(), cube2.getYMin());
            double zMinIntersect = Math.Max(cube1.getZMin(), cube2.getZMin());
            double xMaxIntersect = Math.Min(cube1.getXMax(), cube2.getXMax());
            double yMaxIntersect = Math.Min(cube1.getYMax(), cube2.getYMax());
            double zMaxIntersect = Math.Min(cube1.getZMax(), cube2.getZMax());

            double intersectSideLength = Math.Min(xMaxIntersect - xMinIntersect, Math.Min(yMaxIntersect - yMinIntersect, zMaxIntersect - zMinIntersect));

            return Math.Pow(intersectSideLength, 3);
        }
    }
}
