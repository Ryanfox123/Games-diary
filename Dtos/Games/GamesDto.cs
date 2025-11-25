using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace games_diary.Dtos.Games
{
    public class GamesDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Rating { get; set; }
        public bool isCompleted { get; set; }
    }
}