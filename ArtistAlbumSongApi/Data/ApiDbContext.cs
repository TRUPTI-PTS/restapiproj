using ArtistAlbumSongApi.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace ArtistAlbumSongApi.Data
{
    public class ApiDbContext : DbContext
    {
        // to pass an instance of DbContext option class is constructor
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)//passing options to the base class constructor
                                                                                   //options is the name given to parameter
        {


        }
        public DbSet<Song> Songs { get; set; }//entity framework will create a table inside the dtabase with the name Songs
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Album> Albums { get; set; }
         }
}
