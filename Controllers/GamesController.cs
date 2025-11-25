using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using games_diary.Dtos.Games;
using games_diary.Interfaces;
using games_diary.Mappers;
using Microsoft.AspNetCore.Mvc;

namespace games_diary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        private readonly IGamesRepository _gamesRepo;

        public GamesController (IGamesRepository gamesRepository)
        {
            _gamesRepo = gamesRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<GamesDto>>> GetAll()
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            
            var games = await _gamesRepo.GetAllAsync();

            var gamesDto = games.Select(g => GamesMappers.ToGamesDto(g)).ToList();

            return Ok(gamesDto);
        }
    }
}