using Microsoft.AspNetCore.Mvc;

namespace _20220923_IMemoryCache.Controllers
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