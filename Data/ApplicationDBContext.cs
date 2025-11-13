using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using games_diary.Models;
using Microsoft.EntityFrameworkCore;

namespace games_diary.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions dbContextOptions)
        : base(dbContextOptions)
        {

        }
        public DbSet<Game> Games { get; set; }
    }
}