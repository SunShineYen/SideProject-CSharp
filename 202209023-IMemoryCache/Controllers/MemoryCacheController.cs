using Microsoft.AspNetCore.Mvc;

namespace _202209023_IMemoryCache.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MemoryCacheController : ControllerBase
    {
        [HttpGet(Name = "TestMemoryCache")]
        public string Get()
        {
            return "Test";
        }
    }
}