using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sneha_S_301096645.Models
{
    public class PlayerResponse
    {
        [Required(ErrorMessage = "Please enter name of player")]
        public string PlayerName { get; set; }
        [Required(ErrorMessage = "Please enter name of club")]
        public string ClubName { get; set; }
        [Required(ErrorMessage = "Please enter ID of club")]
        public int ClubID { get; set; }
        [Key]
        [Required(ErrorMessage = "Please enter ID of player")]
        public int PlayerID { get; set; }
        [Required(ErrorMessage = "Please enter  email")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Please provide valid email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please choose an option")]
        public bool? Deregister { get; set; }
    }
}
