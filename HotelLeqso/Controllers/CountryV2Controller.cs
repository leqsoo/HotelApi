using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelApi.Controllers
{
    [ApiVersion("2021-10-25.2.0-jk2")]
    [Route("api/[controller]")]
    [ApiController]
    public class CountryV2Controller : ControllerBase
    {
        //private readonly IUnitOfWork _unitOfWork;
        //private readonly ILogger<CountryController> _logger;
        //private readonly IMapper _mapper;
        //public CountryV2Controller(IUnitOfWork unitOfWork, ILogger<CountryController> logger, IMapper mapper)
        //{
        //    _unitOfWork = unitOfWork;
        //    _logger = logger;
        //    _mapper = mapper;
        //}

        //[HttpGet]
        //[ProducesResponseType(StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status500InternalServerError)]
        //public async Task<IActionResult> GetCountries([FromQuery] RequestedParams requestedParams)
        //{
        //    var countries = await _unitOfWork.Countries.GetAll(requestedParams);
        //    var results = _mapper.Map<List<CountryDTO>>(countries);
        //    return Ok(results);
        //}

        //[HttpGet("{id:int}", Name = "GetCountry")]
        //[ProducesResponseType(StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status500InternalServerError)]
        //public async Task<IActionResult> GetCountry(int id)
        //{
        //    throw new Exception();
        //    var country = await _unitOfWork.Countries.Get(c => c.Id == id, new List<string> { "Hotels" });
        //    var result = _mapper.Map<CountryDTO>(country);
        //    return Ok(result);
        //}
    }
}
