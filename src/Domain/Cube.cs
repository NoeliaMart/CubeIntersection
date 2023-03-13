using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeIntersection.src.Domain
{
    class Cube
    {
        private double size;
        private Vector centerCoordinate;

        public Cube(double size, double X, double Y, double Z)
        {
            this.centerCoordinate = new Vector(X, Y, Z);
            this.size = size;
        }

        public double getLength() {
            return size;
        }

        public Vector getCenterCoordinate() 
        {
            return centerCoordinate;
        }

        public double getXMin()
        {
            return (this.getCenterCoordinate().X - size) / 2.0;
        }

        public double getYMin()
        {
            return (this.getCenterCoordinate().Y - size) / 2.0;
        }

        public double getZMin()
        {
            return (this.getCenterCoordinate().Z - size) / 2.0;
        }

        public double getXMax()
        {
            return (this.getCenterCoordinate().X + size) / 2.0;
        }

        public double getYMax()
        {
            return (this.getCenterCoordinate().Y + size) / 2.0;
        }

        public double getZMax()
        {
            return (this.getCenterCoordinate().Z + size) / 2.0;
        }

    }
}
