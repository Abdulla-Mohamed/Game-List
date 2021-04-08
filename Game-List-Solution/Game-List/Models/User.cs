using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Game_List.Models
{
    [Serializable]
    public class User
    {
        [Required(ErrorMessage = "Login required")]
        [EmailAddress]
        public string login { get; set; }

        [Required(ErrorMessage = "Password required")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Username required")]
        public string Username { get; set; }
        public string Bio { get; set; }
    }
}
