using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;


namespace Online_Game_store.Models
{
    public class Publisher
    {
        public int PublisherId { get; set; }

        [MinLength(2, ErrorMessage = "Name cannot be less than 2")]
        public string Name { get; set; }
        // many-to-one relationship
        public virtual ICollection<Game> Games { get; set; }

        // one-to-one relationship
        public virtual Contact Contact { get; set; }
    }
}