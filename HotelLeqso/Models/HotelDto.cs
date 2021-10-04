using HotelApi.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HotelApi.Models
{
    public class HotelDto : CreateHotelDto
    {
        public int Id { get; set; }
        public Country Country { get; set; }
    }
    public class CreateHotelDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }
        public double Rating { get; set; }

        [Required]
        public int CountryId { get; set; }
    }
}
