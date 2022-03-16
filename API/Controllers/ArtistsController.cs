using Application.Artists;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class ArtistsController : BaseControllers
    {
        [HttpGet]
        public async Task<ActionResult<List<Artist>>> GetArtist(CancellationToken ct)
        {
            return await Mediator.Send(new List.Query(), ct);
        }
    }

}