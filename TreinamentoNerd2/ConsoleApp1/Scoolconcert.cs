﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCCoreTutorialsConsole
{
    public class Scoolconcert : DbContext
    {

        public DbSet<student> Students { get; set; }

        public DbSet<Grade> Grades { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           // base.OnConfiguring(optionsBuilder);
           optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb")
        }
    }
}
