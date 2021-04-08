using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Game_List.Models
{
    [Serializable]
    public class Game
    {
        public int IDGame { get; set; }
        [Required(ErrorMessage = "Game name required")]
        public string GameName { get; set; }

        public string GameDescription { get; set; }
        [Required(ErrorMessage = "Category name required")]
        public string GameCategory { get; set; }
        [Required(ErrorMessage = "Device name required")]
        public string Device  { get; set; }
    }
}
