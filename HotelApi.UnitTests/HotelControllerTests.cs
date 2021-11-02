using AutoMapper;
using HotelApi.Controllers;
using HotelApi.Data;
using HotelApi.IRepository;
using HotelApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HotelApi.UnitTests
{
    [TestFixture]
    public class HotelControllerTests
    {
        private HotelController _hotelController;
        private Mock<IUnitOfWork> _unitOfWorkMoq = new();
        private Mock<ILogger<HotelController>> _loggerMoq = new();
        private Mock<IMapper> _mapperMoq = new();

        public HotelControllerTests()
        {
            _hotelController = new HotelController(_unitOfWorkMoq.Object, _loggerMoq.Object, _mapperMoq.Object);
        }

        [Test]
        public async Task GetHotel_WhenHotelExists_ShouldReturnHotelById()
        {
            var id = new int();
            var hotelFromDb = new Hotel
            {
                Id = id,
                Address = "d",
                Country = new Country(),
                CountryId = 1,
                Name = "bl",
                Rating = 1,
            };
            var hotelDto= new HotelDto
            {
                Id = id,
                Address = "d",
                Country = new CountryDTO(),
                CountryId = 1,
                Name = "bl",
                Rating = 1,
            };
            _unitOfWorkMoq.Setup(u => u.Hotels.Get(u => u.Id == id, new List<string> { "Country" })).ReturnsAsync(hotelFromDb);
            _mapperMoq.Setup(x => x.Map<Hotel, HotelDto>(It.IsAny<Hotel>())).Returns(hotelDto);

            var hotel = await _hotelController.GetHotel(id) as ObjectResult;

            Assert.That(hotelFromDb, Is.EqualTo(hotel.Value));
        }

        [Test]
        public async Task DeleteHotel_WhenCalled_ShouldReturnHotelById()
        {
            await _hotelController.DeleteHotel(1);
            _unitOfWorkMoq.Verify(u => u.Hotels.Delete(1));
        }
    }
}