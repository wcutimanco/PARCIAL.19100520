using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PARCIAL._19100520.DOMAIN.Core.Interfaces;
using PARCIAL._19100520.DOMAIN.Infrastructure.Data;

namespace PARCIAL._19100520.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutoPartsController : ControllerBase
    {
        private readonly IAutoPartsRepository _autoPartsRepository;

        public AutoPartsController(IAutoPartsRepository autoPartsRepository)
        {
            _autoPartsRepository = autoPartsRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAutoParts()
        {
            var autoparts = await _autoPartsRepository.GetAutoParts();
            return Ok(autoparts);
        }
        [HttpPost] 
        public async Task<IActionResult> Create([FromBody]AutoParts autoParts)
        {
            int id = await _autoPartsRepository.Insert(autoParts);
            return Ok(id);
        }
        [HttpPut]
        
        
    }
}
