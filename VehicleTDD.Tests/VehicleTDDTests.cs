using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTDD.Tests
{
    //MALLORY BUSH TDD HOMEWORK 
    [TestFixture]

    class VehicleTDDTests
    {
        [Test]
        public void VehicleTDD_Property_Color()

        {
            var veh = new Vehicle("", "", "", "", 0, 0);

            var result = veh.color = "red";

            Assert.That(result, Is.EqualTo("red"));
        }

        [Test]
        public void VehicleTDD_Property_Make()
        {
            var veh = new Vehicle("", "", "", "", 0, 0);

            var result = veh.make = "Ford";

            Assert.That(result, Is.EqualTo("Ford"));
        }

        [Test]
        public void VehicleTDD_Property_Model()
        {
            var veh = new Vehicle("", "", "", "", 0, 0);

            var result = veh.model = "Bronco";

            Assert.That(result, Is.EqualTo("Bronco"));
        }

        [Test]
        public void VehicleTDD_Property_Year()
        {
            var veh = new Vehicle("", "", "", "", 0, 0);

            var result = veh.year = "1965";

            Assert.That(result, Is.EqualTo("1965"));
        }

        [Test]
        public void VehicleTDD_Property_EngSize()
        {
            var veh = new Vehicle("", "", "", "", 0, 0);

            var result = veh.engSize = 5.0;

            Assert.That(result, Is.EqualTo(5.0));
        }

        [Test]
        public void VehicleTDD_Property_Rim_Size()
        {
            var veh = new Vehicle("", "", "", "", 0, 0);

            var result = veh.rimSize = 16;

            Assert.That(result, Is.EqualTo(16));
        }

        [TestCase(0, 0, 0)]
        [TestCase (1, 1, 1)]
        [TestCase(1, 2, 0.5)]


        public void GetMPH_Return_0_For_0(double distance, double time, double expected)
        {
            var veh = new Vehicle("", "", "", "", 0, 0);

            var result = veh.GetMph(distance, time);

            Assert.That(result, Is.EqualTo(expected));
        }

        //[Test]
        //public void GetMPH_Return_Half_MPH()
        //{
        //    var veh = new Vehicle("", "", "", "", 0, 0);
        //    var distance = 1;
        //    var time = 2;

        //    var result = veh.GetMph(distance, time);

        //    Assert.That(result, Is.EqualTo(0.5));
        //}

        [Test]
        public void GetMPH_From_TimeSpan()
        {
            var veh = new Vehicle("", "", "", "", 0, 0);
            var distance = 1;
            TimeSpan time = TimeSpan.FromMinutes(2);

            var result = veh.GetMph(distance, time);

            Assert.That(result, Is.EqualTo(30));
        }

        [Test]
        public void GetMPH_From_TimeSpan_Hours()
        {
            var veh = new Vehicle("", "", "", "", 0, 0);
            var distance = 1;
            TimeSpan time = TimeSpan.FromHours(2);

            var result = veh.GetMph(distance, time);

            Assert.That(result, Is.EqualTo(0.5));
        }



        //        [Test]
        //        public void VehicleTDD_Method_Get_MPG()
        //        {
        //            var veh = new Vehicle("", "", "", "", 0, 0);

        //            var result = veh.GetMpg(3579, 3117, 9251);

        //            Assert.That(result, Is.EqualTo(49.94));
        //        }
        //    }
    }
}
