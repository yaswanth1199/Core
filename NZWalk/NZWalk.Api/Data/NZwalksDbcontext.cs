﻿using Microsoft.EntityFrameworkCore;
using NZWalk.Api.Models.Domain;

namespace NZWalk.Api.Data
{
    public class NZwalksDbcontext : DbContext
    {
       public NZwalksDbcontext(DbContextOptions<NZwalksDbcontext> options) : base(options)
        { 
        }

        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
        public DbSet<WalkDifficulty> WalkDifficulty { get; set; }
    }
}
