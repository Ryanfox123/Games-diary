using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using games_diary.Dtos.Games;
using games_diary.Models;

namespace games_diary.Mappers
{
    public static class GamesMappers
    {
        public static GamesDto ToGamesDto (this Game gameModel)
        {
            return new GamesDto
            {
                Id = gameModel.Id,
                Name = gameModel.Name,
                Rating = gameModel.Rating,
                isCompleted = gameModel.isCompleted
            };
        }
    }
}