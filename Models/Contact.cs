using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace Online_Game_store.Models
{
    public class Contact
    {
        [Key]
        [ForeignKey("Publisher")]
        public int PublisherId { get; set; }
        [MinLength(8, ErrorMessage = "Phone number cannot be less than 8 digits"), Required]
        public string PhoneNumber { get; set; }
        // one-to one-relationship
        public virtual Publisher Publisher { get; set; }
    }
}