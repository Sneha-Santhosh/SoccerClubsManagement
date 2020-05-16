using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sneha_S_301096645.Models
{
    public class ClubResponse
    {
        [Required(ErrorMessage = "Please enter name of club")]
        public string ClubName { get; set; }

        [Required(ErrorMessage = "Please enter ID of club")]
        [Key]
        public int ClubID { get; set; }
        [Required(ErrorMessage = "Please enter location of club")]
        public string Location { get; set; }
        [Required(ErrorMessage = "Please enter name of manager of club")]
        public string ManagerName{get; set;}

    }
}
