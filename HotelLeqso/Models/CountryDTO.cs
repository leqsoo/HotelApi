using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelApi.Models
{
    public class CountryDTO : CreateCountryDTO
    {
        public int Id { get; set; }
    }
    public class CreateCountryDTO
    {
        [Required]
        public string Name { get; set; }
        
        [Required]
        public string ShortName { get; set; }
    }
}