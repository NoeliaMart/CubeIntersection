using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeIntersection.src.Domain
{
    public class Vector
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Vector(double X, double Y, double Z) {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }
    }
}
