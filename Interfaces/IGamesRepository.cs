using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using games_diary.Models;

namespace games_diary.Interfaces
{
    public interface IGamesRepository
    {
        Task<List<Game>> GetAllAsync();
    }
}