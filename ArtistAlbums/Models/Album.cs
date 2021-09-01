using System;
using System.ComponentModel.DataAnnotations;

namespace ArtistAlbums.Models
{
    public class Album
    {
        [Key]
        public int AlbumId {get;set;}
        public string AlbumName {get;set;}
        public int ReleaseYear {get;set;}
        public string CoverURL {get;set;}
        public int ArtistId{get;set;}
        public Artist Creator {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}
