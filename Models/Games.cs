using System;
using System.ComponentModel.DataAnnotations;

namespace gaminglist.Pages.Games
{
    public class Game
    {
        public int ID { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Text)]
        public string Genre { get; set; }
        public string Rating { get; set; }

        public string Image { get; set; }
    }
}