using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace games_diary.Interfaces
{
    public interface IGamesRepository
    {
        Task GetAllAsync();
    }
}