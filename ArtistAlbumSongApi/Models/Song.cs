using System.ComponentModel.DataAnnotations.Schema;

namespace ArtistAlbumSongApi.Models
{
    public class Song
    {
        //[NotMapped] //this attribute means this wont be the part of our songs table
        //public IFormFile Image { get; set; }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Duration { get; set; }
        public DateTime UplaodDate { get; set; }
        public int IsFeatured { get; set; }

        [NotMapped]
        public IFormFile Image { get; set; }

        public string ImageURL { get; set; }

        [NotMapped]
        public IFormFile AudioFile { get; set; }

        public string AudioUrl { get; set; }
        public int ArtistId { get; set; }
        public int? AlbumId { get; set; }//? simply means this foreign key can have null value
    }
}

