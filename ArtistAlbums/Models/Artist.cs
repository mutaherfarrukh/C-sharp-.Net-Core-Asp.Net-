using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ArtistAlbums.Models
{
    public class Artist
    {
        [Key]
        public int ArtistId {get;set;}
        public string ArtistName {get;set;}
        public List<Album> CreatedAlbums {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}
