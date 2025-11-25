using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using games_diary.Data;
using games_diary.Interfaces;
using games_diary.Models;
using Microsoft.EntityFrameworkCore;

namespace games_diary.Repository
{
    public class GamesRepository : IGamesRepository
    {
        private readonly ApplicationDBContext _context;
        public GamesRepository(ApplicationDBContext context)
        {
            _context = context;
        }
        public async Task<List<Game>> GetAllAsync()
        {
            return await _context.Games.ToListAsync();
        }
    }
}