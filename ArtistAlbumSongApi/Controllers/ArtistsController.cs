using ArtistAlbumSongApi.Data;
using ArtistAlbumSongApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace ArtistAlbumSongApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtistsController : ControllerBase
    {
        private ApiDbContext _dbContext;
        public ArtistsController(ApiDbContext dbCXontext)
        {
            _dbContext = dbCXontext;
         }

        [HttpPost]
        public async Task<IActionResult> Post([FromForm] Artist artist)
        {
            string connectionString = @"DefaultEndpointsProtocol=https;AccountName=musicstorage;AccountK";                                                                                                                                                                                                                                                                                                                                                                                                                                     
            
            
            await _dbContext.Artists.AddAsync(artist);
            await _dbContext.SaveChangesAsync();
            return StatusCode(StatusCodes.Status201Created);

        }
    
    
    
    
    
    
    
    
    }
}

