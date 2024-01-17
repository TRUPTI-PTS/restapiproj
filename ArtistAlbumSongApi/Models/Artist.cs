using ArtistAlbumSongApi.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArtistAlbumSongApi.Models
{
    public class Artist
    {
        //private string _artistRepository;
        public int Id { get; set; }

        public string Name { get; set; }

        public string Gender { get; set; }

        public string ImageUrl { get; set; }

        [NotMapped]
        public IFormFile Image { get; set; }

        public ICollection<Album> Albums { get; set; }//convention use to indicate one to many relationship between artist and album entity
        public ICollection<Song> Songs { get; set; }
    }
}

