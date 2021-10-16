using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelApi.Controllers;

namespace UnitTests
{
    [TestFixture]
    public class CountryControllerTests
    {
        [Test]
        public void DeleteCountry_WhenCalled_DeleteCountryFromDatabase()
        {
            var controller = new CountryController();
        }
    }
}
