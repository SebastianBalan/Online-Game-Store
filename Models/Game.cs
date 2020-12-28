using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;


namespace Online_Game_store.Models
{
    public class Game
    {
        public int GameId { get; set; }

        [MinLength(5, ErrorMessage = "Title cannot be less than 5"), Required]
        public string Title { get; set; }

        [MinLength(2, ErrorMessage = "Name cannot be less than 2")]
        public string Creator { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateCreation { get; set; }

        // one to many
        public int PublisherId { get; set; }
        // one-to-many relationship
        public virtual Publisher Publisher { get; set; }
        // many to many
        //public virtual ICollection<Genre> Genres { get; set; }
    }
}