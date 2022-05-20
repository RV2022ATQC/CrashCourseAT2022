using _321;
using NUnit.Framework;
using System;

namespace _321Test
{
    [TestFixture]
    public class ResidentialBuildingTest
    {
        [Test]
        public void GetCreateDate_Returs0()
        {
            ResidentialBuilding building = new ResidentialBuilding("Nester Street, 1", "01.01.2005", 40.1, 40, 10);

            Assert.That(building.NumberOfFlors, Is.EqualTo(10));
        }

        [Test]
        public void GetSape_Rerutnd_string_SrartWith_Name()
        {
            ResidentialBuilding building = new ResidentialBuilding("Nester Street, 1", "01.01.2005", 40.1, 40, 10);

            Assert.That(building, Does.Contain("Hero"));
        }
    }
}
