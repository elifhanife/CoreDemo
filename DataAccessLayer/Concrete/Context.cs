﻿using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {//connectionstring i tanımlayacağız.
            optionsBuilder.UseSqlServer("server=ELIFHANIFE\\SQLEXPRESS;database=CoreBlogDb;" +
                "integrated security=true;TrustServerCertificate=True");
        }

        public DbSet<About> Abouts { get; set; } //<class ismi> + property ismi 
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Writer> Writers { get; set; }
    }
}
