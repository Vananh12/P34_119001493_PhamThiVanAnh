#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PhamThiVanAnh.Models;

    public class CategoryContext : DbContext
    {
        public CategoryContext (DbContextOptions<CategoryContext> options)
            : base(options)
        {
        }

        public DbSet<PhamThiVanAnh.Models.Category> Category { get; set; }

        public DbSet<PhamThiVanAnh.Models.News> News { get; set; }

        public DbSet<PhamThiVanAnh.Models.Comment> Comment { get; set; }
    }
