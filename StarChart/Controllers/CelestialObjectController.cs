using Microsoft.AspNetCore.Mvc;
using StarChart.Data;

namespace StarChart.Controllers
{
    [Route("")]
    [ApiController]
    public class CelestialObjectController : ControllerBase
    {
        readonly private ApplicationDbContext _context;
        
        public CelestialObjectController(ApplicationDbContext _context)
        {
            this._context = _context;
        }
    }
}
