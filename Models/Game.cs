using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace Online_Game_store.Models
{
    public class Game
    {
        [Key]
        public int GameId { get; set; }

        [MinLength(5, ErrorMessage = "Title cannot be less than 5"), Required]
        public string Title { get; set; }

        [MinLength(2, ErrorMessage = "Name cannot be less than 2")]
        public string Creator { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateCreation { get; set; }

        //// one to many
        //[Column("Publisher_id")]
        //public int PublisherId { get; set; }

        //public virtual Publisher Publisher { get; set; }
        //// many to many
        //public virtual ICollection<Genre> Genres { get; set; }
    }
}