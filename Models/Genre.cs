using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Online_Game_store.Models
{
    public class Genre
    {
        public int GenreId { get; set; }

        [MinLength(2, ErrorMessage = "Name cannot be less than 5"), Required]
        public string Name { get; set; }
        // many-to-many relationship
        public virtual ICollection<Game> games { get; set; }
    }
}