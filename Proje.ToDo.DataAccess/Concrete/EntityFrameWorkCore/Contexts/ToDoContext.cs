using Microsoft.EntityFrameworkCore;
using Proje.ToDo.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proje.ToDo.DataAccess.Concrete.EntityFrameWorkCore.Contexts
{
    public class ToDoContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-JIVBBIO\\SQLEXPRESS;database = KisiselWebSiteDb;integrated security=true;");
        }
        public DbSet<User>Users{get;set;}
        public DbSet<Work> Works { get; set; }

    }

}

            
        
