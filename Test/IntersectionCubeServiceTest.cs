using CubeIntersection.src.Application;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeIntersection.Test
{
    class IntersectionCubeServiceTest
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CubesNotCollide()
        {
            IntersectionCubeService cubeService = new IntersectionCubeService(5, 10, 10, 10, 2, 1, 1, 1);

            double volIntersection = cubeService.VolumenIntersection();

            Assert.IsNotNull(volIntersection);
            Assert.True(volIntersection < 0);
        }

        [Test]
        public void CubesCollide()
        {
            IntersectionCubeService cubeService = new IntersectionCubeService(10, 10, 10, 10, 2, 1, 1, 1);

            double volIntersection = cubeService.VolumenIntersection();

            Assert.IsNotNull(volIntersection);
            Assert.AreEqual(volIntersection, 3.375);
        }

    }
}
