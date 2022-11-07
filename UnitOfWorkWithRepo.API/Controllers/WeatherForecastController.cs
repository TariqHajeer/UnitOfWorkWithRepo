using Microsoft.AspNetCore.Mvc;
using RepositoryWithUOW.core.Interfaces;
using RepositoryWithUOW.core.Models;
using System.Runtime.InteropServices;

namespace UnitOfWorkWithRepo.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IRepository<Country> _countryRepository;
        private readonly IRepository<Language> _languageRepository;
        private readonly IUnitOfWOrk _unitOfWOrk;

        public WeatherForecastController(IRepository<Country> countryRepository, IRepository<Language> languageRepository, IUnitOfWOrk unitOfWOrk)
        {
            _countryRepository = countryRepository;
            _languageRepository = languageRepository;
            _unitOfWOrk = unitOfWOrk;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {

            var t1 = _languageRepository.GetAll();
            var t2 = _countryRepository.GetAll();
            ///any ther call for db 
            ///code ..... 
            ///
            await Task.WhenAll(t1, t2);
            var lang = await t1;
            var coun = await t2;
            return Ok(new { CC = coun.Count(), lC = lang.Count() });
        }
        [HttpPost]
        public async Task<IActionResult> Create()
        {
            var country = new Country()
            {
                Name = "new Country"
            };
            var lang = new Language()
            {
                Name = "new lang"
            };
            await _unitOfWOrk.Add(country);
            await _unitOfWOrk.Add(lang);
            await _unitOfWOrk.SaveChange();
            return Ok();
        }
    }
}