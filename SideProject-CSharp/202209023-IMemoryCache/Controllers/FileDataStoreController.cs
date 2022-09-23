using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Primitives;
using Newtonsoft.Json;

namespace _202209023_IMemoryCache.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FileDataStoreController : ControllerBase
    {
        private readonly ILogger<FileDataStoreController> _logger;
        private readonly IMemoryCache _cache;
        private readonly IWebHostEnvironment _env;

        public FileDataStoreController(IMemoryCache cache, IWebHostEnvironment env, ILogger<FileDataStoreController> logger)
        {
            _cache = cache;
            _env = env;
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public void Get()
        {

        }
    }
}