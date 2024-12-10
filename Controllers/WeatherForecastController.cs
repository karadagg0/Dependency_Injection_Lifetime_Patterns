using Microsoft.AspNetCore.Mvc;

namespace Dependency_Injection_Lifetime_Patterns.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IUserLoginDate _userLoginDate; 

        public WeatherForecastController(IUserLoginDate userLoginDate)
        {
            _userLoginDate = userLoginDate;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public string Get()
        {
            return _userLoginDate.GetUserDetails();
        }
    }
}